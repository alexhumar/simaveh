using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers;
using SiMaVeh.Api.Model;
using SiMaVeh.Api.Utils;
using SiMaVeh.Api.Utils.Interfaces;
using SiMaVeh.Domain.BusinessLogic.Entities;
using System.Net;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Test
{
    public class VersionTests
    {
        private class VersionFija : IInformacionVersion
        {
            public string Aplicacion => "SiMaVeh";
            public string Version => "1.2.3";
            public string Build => "1.2.3+abc";
        }

        [Fact]
        public void InformacionVersion_TomaLaVersionDelEnsamblado()
        {
            var informacion = new InformacionVersion();
            var versionEnsamblado = typeof(InformacionVersion).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

            Assert.Equal("SiMaVeh", informacion.Aplicacion);
            Assert.Equal(versionEnsamblado, informacion.Build);
            Assert.Matches(new Regex(@"^\d+\.\d+\.\d+$"), informacion.Version);
            Assert.StartsWith(informacion.Version, informacion.Build);
            Assert.Equal($"SiMaVeh {informacion.Build}", informacion.ToString());
        }

        [Fact]
        public void InformacionVersion_CoincideConLaVersionDelEnsambladoDeLaApi()
        {
            var version = typeof(InformacionVersion).Assembly.GetName().Version;

            Assert.Equal(version.ToString(3), new InformacionVersion().Version);
        }

        [Fact]
        public void VersionController_Get_DevuelveLaInformacionDeVersion()
        {
            var resultado = Assert.IsType<OkObjectResult>(new VersionController(new VersionFija()).Get());

            using var json = JsonDocument.Parse(JsonSerializer.Serialize(resultado.Value));
            Assert.Equal("SiMaVeh", json.RootElement.GetProperty("aplicacion").GetString());
            Assert.Equal("1.2.3", json.RootElement.GetProperty("version").GetString());
            Assert.Equal("1.2.3+abc", json.RootElement.GetProperty("build").GetString());
        }

        /// <summary>
        /// Host en memoria con la misma configuracion de MVC/OData que Startup (sin base de datos),
        /// para verificar que /version convive con las rutas OData.
        /// </summary>
        private static async Task<IHost> CrearHostAsync()
        {
            var edmModel = new SiMaVehODataModelBuilder(new EntityTypeGetter()).GetEdmModel();

            return await new HostBuilder()
                .ConfigureWebHost(web => web
                    .UseTestServer()
                    .ConfigureServices(services =>
                    {
                        services.AddSingleton<IInformacionVersion, InformacionVersion>();
                        services.AddControllers(o => o.EnableEndpointRouting = false)
                            .AddApplicationPart(typeof(Startup).Assembly)
                            .AddApplicationPart(typeof(Microsoft.AspNetCore.OData.Routing.Controllers.MetadataController).Assembly)
                            .AddOData(o => o.AddRouteComponents(UriConstants.PrefijoRutaOData, edmModel));
                    })
                    .Configure(app => app
                        .UseRouting()
                        .UseEndpoints(e => e.MapControllers())))
                .StartAsync();
        }

        [Fact]
        public async Task GetVersion_PorHttp_DevuelveLaVersionEnJson()
        {
            using var host = await CrearHostAsync();
            var cliente = host.GetTestClient();

            var respuesta = await cliente.GetAsync("/version");

            Assert.Equal(HttpStatusCode.OK, respuesta.StatusCode);
            using var json = JsonDocument.Parse(await respuesta.Content.ReadAsStringAsync());
            var informacion = new InformacionVersion();
            Assert.Equal("SiMaVeh", json.RootElement.GetProperty("aplicacion").GetString());
            Assert.Equal(informacion.Version, json.RootElement.GetProperty("version").GetString());
            Assert.Equal(informacion.Build, json.RootElement.GetProperty("build").GetString());
        }

        [Fact]
        public async Task GetVersion_NoAfectaLasRutasOData()
        {
            using var host = await CrearHostAsync();
            var cliente = host.GetTestClient();

            var metadata = await cliente.GetAsync($"/{UriConstants.PrefijoRutaOData}/$metadata");

            Assert.Equal(HttpStatusCode.OK, metadata.StatusCode);
            Assert.Contains("EntitySet Name=\"Paises\"", await metadata.Content.ReadAsStringAsync());
        }
    }
}
