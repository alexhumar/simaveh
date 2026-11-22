using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Contrato.Interfaces;
using SiMaVeh.Api.Controllers;
using SiMaVeh.Api.Test.Helpers;
using SiMaVeh.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Test
{
    /// <summary>
    /// Host compartido por los tests del contrato: se levanta una vez y se lee el documento publicado.
    /// </summary>
    public sealed class ContratoFixture : IAsyncLifetime
    {
        public IHost Host { get; private set; }

        public HttpClient Cliente { get; private set; }

        public string Json { get; private set; }

        public OpenApiDocument Documento { get; private set; }

        public OpenApiDiagnostic Diagnostico { get; private set; }

        public async ValueTask InitializeAsync()
        {
            Host = await HostDePrueba.CrearAsync();
            Cliente = Host.GetTestClient();
            Json = await Cliente.GetStringAsync($"/{UriConstants.ContratoOpenApiJson}", TestContext.Current.CancellationToken);
            Documento = new OpenApiStringReader().Read(Json, out var diagnostico);
            Diagnostico = diagnostico;
        }

        public ValueTask DisposeAsync()
        {
            Cliente.Dispose();
            Host.Dispose();
            return ValueTask.CompletedTask;
        }
    }

    public class ContratoTests(ContratoFixture fixture) : IClassFixture<ContratoFixture>
    {
        private const string Prefijo = "/" + UriConstants.PrefijoRutaOData;

        private readonly ContratoFixture fixture = fixture;

        private OpenApiDocument Documento => fixture.Documento;

        private OpenApiOperation Operacion(string path, OperationType metodo)
        {
            Assert.True(Documento.Paths.TryGetValue(path, out var item), $"El contrato no tiene el path {path}");
            Assert.True(item.Operations.TryGetValue(metodo, out var operacion), $"El path {path} no tiene {metodo}");
            return operacion;
        }

        private static IEnumerable<string> NombresDeParametros(OpenApiOperation operacion) =>
            operacion.Parameters.Select(p => p.Reference?.Id ?? p.Name);

        private static IEnumerable<string> Enum(OpenApiOperation operacion, string parametro) =>
            operacion.Parameters.Single(p => p.Name == parametro).Schema.Enum.Cast<OpenApiString>().Select(s => s.Value);

        private static string Normalizar(string path) => Regex.Replace(path, @"\{[^}]*\}", "{}");

        #region Publicacion

        [Fact]
        public async Task GetOpenApiJson_PublicaUnDocumentoOpenApiValido()
        {
            var respuesta = await fixture.Cliente.GetAsync($"/{UriConstants.ContratoOpenApiJson}", TestContext.Current.CancellationToken);

            Assert.Equal(HttpStatusCode.OK, respuesta.StatusCode);
            Assert.Equal("application/json", respuesta.Content.Headers.ContentType.MediaType);
            Assert.Empty(fixture.Diagnostico.Errors);
            Assert.Equal(Microsoft.OpenApi.OpenApiSpecVersion.OpenApi3_0, fixture.Diagnostico.SpecificationVersion);
        }

        [Fact]
        public void Documento_UsaLaVersionDeLaAplicacion()
        {
            Assert.Equal("SiMaVeh API", Documento.Info.Title);
            Assert.Equal(new InformacionVersion().Version, Documento.Info.Version);
            Assert.Equal("/", Assert.Single(Documento.Servers).Url);
        }

        [Fact]
        public async Task GetOpenApiYaml_PublicaElMismoContrato()
        {
            var respuesta = await fixture.Cliente.GetAsync($"/{UriConstants.ContratoOpenApiYaml}", TestContext.Current.CancellationToken);
            var yaml = await respuesta.Content.ReadAsStringAsync(TestContext.Current.CancellationToken);

            var documentoYaml = new OpenApiStringReader().Read(yaml, out var diagnostico);

            Assert.Equal(HttpStatusCode.OK, respuesta.StatusCode);
            Assert.Empty(diagnostico.Errors);
            Assert.Equal(Documento.Paths.Keys.OrderBy(k => k), documentoYaml.Paths.Keys.OrderBy(k => k));
        }

        [Fact]
        public async Task SwaggerUI_EstaDisponibleYApuntaAlContrato()
        {
            var html = await fixture.Cliente.GetAsync($"/{UriConstants.PrefijoSwaggerUI}/index.html", TestContext.Current.CancellationToken);
            var configuracion = await fixture.Cliente.GetStringAsync($"/{UriConstants.PrefijoSwaggerUI}/index.js", TestContext.Current.CancellationToken);

            Assert.Equal(HttpStatusCode.OK, html.StatusCode);
            Assert.Equal("text/html", html.Content.Headers.ContentType.MediaType);
            Assert.Contains($"/{UriConstants.ContratoOpenApiJson}", configuracion);
        }

        [Fact]
        public void Generador_ConstruyeElDocumentoUnaSolaVez()
        {
            var generador = fixture.Host.Services.GetRequiredService<IGeneradorContratoOpenApi>();

            Assert.Same(generador.Documento, generador.Documento);
            Assert.Same(generador.ComoJson(), generador.ComoJson());
        }

        #endregion

        [Fact]
        public void ApiRegistry_RegistraElGeneradorComoSingleton()
        {
            //Mismo cableado que Startup: servicios de MVC/OData mas el ApiRegistry de Lamar.
            var servicios = new Lamar.ServiceRegistry();
            servicios.AddSingleton<Microsoft.OData.Edm.IEdmModel>(new Model.SiMaVehODataModelBuilder(new Domain.BusinessLogic.Entities.EntityTypeGetter()).GetEdmModel());
            servicios.AddLogging();
            servicios.AddControllers();
            servicios.IncludeRegistry<ApiRegistry>();
            using var contenedor = new Lamar.Container(servicios);

            var generador = contenedor.GetInstance<IGeneradorContratoOpenApi>();

            Assert.Same(generador, contenedor.GetInstance<IGeneradorContratoOpenApi>());
            Assert.NotNull(Microsoft.Extensions.DependencyInjection.ActivatorUtilities.CreateInstance<ContratoController>(contenedor));
        }

        #region Operaciones descriptas

        [Fact]
        public void Contrato_DescribeElCrudDeUnaColeccion()
        {
            Assert.Equal([OperationType.Get, OperationType.Post], Documento.Paths[$"{Prefijo}/Provincias"].Operations.Keys.OrderBy(k => k));
            Assert.Equal([OperationType.Get, OperationType.Put, OperationType.Delete, OperationType.Patch],
                Documento.Paths[$"{Prefijo}/Provincias({{Id}})"].Operations.Keys.OrderBy(k => k));
            Operacion($"{Prefijo}/Provincias/$count", OperationType.Get);
        }

        [Fact]
        public void Contrato_IncluyeOperacionesQueLaConversionDelModeloNoGenera()
        {
            var put = Operacion($"{Prefijo}/Provincias({{Id}})", OperationType.Put);
            var nombre = Operacion($"{Prefijo}/Provincias({{Id}})/Nombre", OperationType.Get);
            var valor = Operacion($"{Prefijo}/Provincias({{Id}})/Nombre/$value", OperationType.Get);

            Assert.Equal("SiMaVeh.Domain.Models.Provincia", put.RequestBody.Content["application/json"].Schema.Reference.Id);
            Assert.Contains("204", put.Responses.Keys);
            Assert.Equal("string", nombre.Responses["200"].Content["application/json"].Schema.Properties["value"].Type);
            Assert.Contains("text/plain", valor.Responses["200"].Content.Keys);
        }

        [Fact]
        public void Contrato_DescribeLasNavegaciones()
        {
            Assert.Equal("SiMaVeh.Domain.Models.Provincia", Operacion($"{Prefijo}/Partidos({{Id}})/Provincia", OperationType.Get).Responses["200"].Content["application/json"].Schema.Reference.Id);
            Operacion($"{Prefijo}/Provincias({{Id}})/Partidos", OperationType.Get);
            Operacion($"{Prefijo}/Provincias({{Id}})/Partidos/$count", OperationType.Get);
        }

        [Fact]
        public void Contrato_RefPostYPut_OfrecenSoloLasNavegacionesQueCorresponden()
        {
            var crear = Operacion($"{Prefijo}/Provincias({{Id}})/{{navigationProperty}}/$ref", OperationType.Post);
            var cambiar = Operacion($"{Prefijo}/Provincias({{Id}})/{{navigationProperty}}/$ref", OperationType.Put);

            Assert.Equal(["Partidos"], Enum(crear, "navigationProperty"));
            Assert.Equal(["Pais"], Enum(cambiar, "navigationProperty"));
            Assert.Equal("ReferenceCreate", crear.RequestBody.Content["application/json"].Schema.Reference.Id);
            Assert.Contains("501", crear.Responses.Keys);
            Assert.Contains("501", cambiar.Responses.Keys);
        }

        [Fact]
        public void Contrato_RefDelete_SoloDondeElControllerLoImplementa()
        {
            //AceitesController sobrescribe DeleteRef; ProvinciasController usa el de GenericController, que responde 501.
            var quitar = Operacion($"{Prefijo}/Aceites({{Id}})/{{navigationProperty}}({{IdRelacionado}})/$ref", OperationType.Delete);

            Assert.Equal(["RecomendacionesModeloVehiculo"], Enum(quitar, "navigationProperty"));
            Assert.DoesNotContain(Documento.Paths, p => p.Key.StartsWith($"{Prefijo}/Provincias(") && p.Key.EndsWith("/$ref") && p.Value.Operations.ContainsKey(OperationType.Delete));
            Assert.DoesNotContain(Documento.Paths, p => p.Key.EndsWith("/{navigationProperty}/$ref") && p.Value.Operations.ContainsKey(OperationType.Delete));
        }

        [Fact]
        public void Contrato_ExcluyeRutasQueNingunControllerAtiende()
        {
            //La conversion del modelo genera navegacion por clave (Partidos({Id1})), pero ningun controller la implementa.
            Assert.DoesNotContain(Documento.Paths.Keys, p => p.Contains("Id1"));
            Assert.DoesNotContain($"{Prefijo}/Provincias({{Id}})/Partidos({{Id1}})", Documento.Paths.Keys);
        }

        [Fact]
        public void Contrato_OpcionesDeConsulta_SoloDondeEstanHabilitadas()
        {
            var aceites = NombresDeParametros(Operacion($"{Prefijo}/Aceites", OperationType.Get)).ToList();
            var provincias = NombresDeParametros(Operacion($"{Prefijo}/Provincias", OperationType.Get)).ToList();
            var nombre = NombresDeParametros(Operacion($"{Prefijo}/Provincias({{Id}})/Nombre", OperationType.Get)).ToList();

            Assert.Contains("filter", provincias);
            Assert.Contains("$expand", provincias);
            Assert.Contains("$select", aceites);
            Assert.DoesNotContain("$expand", aceites);
            Assert.DoesNotContain(Documento.Paths.Values.SelectMany(p => p.Operations.Values).SelectMany(NombresDeParametros), n => n is "search" or "$search");
            Assert.DoesNotContain(nombre, n => n.StartsWith('$') || n is "filter" or "top" or "skip" or "count");
        }

        [Fact]
        public void Contrato_DocumentaErroresDeValidacionYEntidadesInexistentes()
        {
            var post = Operacion($"{Prefijo}/Provincias", OperationType.Post);
            var get = Operacion($"{Prefijo}/Provincias({{Id}})", OperationType.Get);

            Assert.Equal("ErroresValidacion", post.Responses["400"].Content["application/json"].Schema.Reference.Id);
            Assert.Contains("404", get.Responses.Keys);
            Assert.Equal("array", Documento.Components.Schemas["ErroresValidacion"].Type);
        }

        [Fact]
        public void Contrato_IncluyeMetadataYVersion()
        {
            Assert.Contains("application/xml", Operacion($"{Prefijo}/$metadata", OperationType.Get).Responses["200"].Content.Keys);
            Assert.Equal(["aplicacion", "build", "version"], Operacion("/version", OperationType.Get).Responses["200"].Content["application/json"].Schema.Properties.Keys.OrderBy(k => k));
        }

        [Fact]
        public void Contrato_ClavesDeTexto_UsanParametroString()
        {
            var clave = Operacion($"{Prefijo}/Monedas({{Id}})", OperationType.Get).Parameters.Single(p => p.In == ParameterLocation.Path);

            Assert.Equal("string", clave.Schema.Type);
        }

        [Fact]
        public void Contrato_OperationIdsUnicos()
        {
            var ids = Documento.Paths.Values.SelectMany(p => p.Operations.Values).Select(o => o.OperationId).ToList();

            Assert.All(ids, id => Assert.False(string.IsNullOrWhiteSpace(id)));
            Assert.Equal(ids.Count, ids.Distinct().Count());
        }

        #endregion

        #region Consistencia con el router

        private sealed record Ruta(string Plantilla, string Metodo, ControllerActionDescriptor Accion);

        private IEnumerable<Ruta> RutasODataRegistradas() =>
            fixture.Host.Services.GetRequiredService<IActionDescriptorCollectionProvider>().ActionDescriptors.Items
                .OfType<ControllerActionDescriptor>()
                .Where(a => a.AttributeRouteInfo?.Template is string t && (t == UriConstants.PrefijoRutaOData || t.StartsWith(UriConstants.PrefijoRutaOData + "/")))
                .SelectMany(a => a.EndpointMetadata.OfType<HttpMethodMetadata>().SelectMany(m => m.HttpMethods).Select(m => new Ruta("/" + a.AttributeRouteInfo.Template, m, a)));

        [Fact]
        public void CadaOperacionDelContrato_CorrespondeAUnaRutaRegistrada()
        {
            var rutas = RutasODataRegistradas().ToList();

            foreach (var (path, item) in Documento.Paths.Where(p => p.Key != "/version"))
            {
                foreach (var metodo in item.Operations.Keys)
                {
                    Assert.True(rutas.Any(r => r.Metodo.Equals(metodo.ToString(), StringComparison.OrdinalIgnoreCase) && Normalizar(r.Plantilla) == Normalizar(path)),
                        $"{metodo} {path} no corresponde a ninguna ruta registrada");
                }
            }
        }

        [Fact]
        public void CadaRutaRegistrada_EstaEnElContrato_SalvoLasExclusionesDocumentadas()
        {
            static bool ClaveComoSegmento(string plantilla) => plantilla.Split('/').Any(s => s is "{key}" or "{relatedKey}");
            static bool DeleteRefHeredado(ControllerActionDescriptor a) => a.MethodInfo.Name == "DeleteRef"
                && a.MethodInfo.DeclaringType.IsGenericType && a.MethodInfo.DeclaringType.GetGenericTypeDefinition() == typeof(GenericController<,>);

            var contrato = Documento.Paths
                .SelectMany(p => p.Value.Operations.Keys.Select(m => (Path: Normalizar(p.Key), Metodo: m.ToString().ToUpperInvariant())))
                .ToHashSet();

            var faltantes = RutasODataRegistradas()
                .Where(r => !ClaveComoSegmento(r.Plantilla) && !DeleteRefHeredado(r.Accion))
                .Where(r => !contrato.Contains((Normalizar(r.Plantilla), r.Metodo.ToUpperInvariant())))
                //Un $ref se omite solo si la entidad no tiene navegaciones del tipo que corresponde al verbo.
                .Where(r => !r.Plantilla.EndsWith("/$ref"))
                .Select(r => $"{r.Metodo} {r.Plantilla}")
                .ToList();

            Assert.True(faltantes.Count == 0, "Rutas registradas sin describir: " + string.Join(", ", faltantes));
        }

        #endregion
    }
}
