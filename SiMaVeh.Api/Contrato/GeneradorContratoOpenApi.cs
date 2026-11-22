using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.Routing;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.OData.ModelBuilder.Config;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.OData;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Contrato.Interfaces;
using SiMaVeh.Api.Controllers;
using SiMaVeh.Api.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SiMaVeh.Api.Contrato
{
    /// <summary>
    /// Genera el contrato OpenAPI 3.0 de la API.
    /// </summary>
    /// <remarks>
    /// Los paths salen de las rutas que el router de OData registra para los controllers existentes, de modo que
    /// el contrato describe lo que la API realmente atiende. Los esquemas, las respuestas de coleccion y los
    /// parametros de consulta se toman de la conversion del modelo EDM (Microsoft.OpenApi.OData); cuando esa
    /// conversion ya describe una ruta registrada se reutiliza su operacion, y si no (PUT, getters de propiedades,
    /// $ref, $metadata) la operacion se arma a partir del modelo EDM.
    /// Se excluyen las rutas que nunca funcionan: los DeleteRef heredados de GenericController (responden 501)
    /// y los $ref sobre entidades sin navegaciones del tipo que corresponde.
    /// </remarks>
    public class GeneradorContratoOpenApi : IGeneradorContratoOpenApi
    {
        private const string EsquemaErroresValidacion = "ErroresValidacion";
        private const string ParametroNavegacion = "navigationProperty";
        private const string ClaveRelacionada = "IdRelacionado";
        private const string TagMetadata = "Metadata";

        private static readonly string Prefijo = UriConstants.PrefijoRutaOData;
        private static readonly string[] OpcionesDeConsulta = ["top", "skip", "count", "filter", "search"];

        private readonly IEdmModel edmModel;
        private readonly IActionDescriptorCollectionProvider acciones;
        private readonly IInformacionVersion informacionVersion;
        private readonly Lazy<OpenApiDocument> documento;
        private readonly Lazy<string> json;
        private readonly Lazy<string> yaml;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="edmModel"></param>
        /// <param name="acciones"></param>
        /// <param name="informacionVersion"></param>
        public GeneradorContratoOpenApi(IEdmModel edmModel, IActionDescriptorCollectionProvider acciones, IInformacionVersion informacionVersion)
        {
            this.edmModel = edmModel;
            this.acciones = acciones;
            this.informacionVersion = informacionVersion;
            documento = new(Generar);
            json = new(() => Documento.SerializeAsJson(OpenApiSpecVersion.OpenApi3_0));
            yaml = new(() => Documento.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0));
        }

        /// <inheritdoc/>
        public OpenApiDocument Documento => documento.Value;

        /// <inheritdoc/>
        public string ComoJson() => json.Value;

        /// <inheritdoc/>
        public string ComoYaml() => yaml.Value;

        #region Generacion

        private sealed record RutaRegistrada(string Plantilla, OperationType Metodo, ControllerActionDescriptor Accion);

        private enum TipoRuta { Recurso, DocumentoDeServicio, Metadata }

        private sealed record RutaAnalizada(
            TipoRuta Tipo,
            string Path,
            IEdmEntitySet Conjunto = null,
            IEdmEntityType Entidad = null,
            bool ConClave = false,
            IEdmStructuralProperty Propiedad = null,
            IEdmNavigationProperty Navegacion = null,
            bool NavegacionParametrica = false,
            bool ConClaveRelacionada = false,
            string Sufijo = null);

        private OpenApiDocument Generar()
        {
            var convertido = edmModel.ConvertToOpenApi(new OpenApiConvertSettings
            {
                PathPrefix = Prefijo,
                ServiceRoot = new Uri("http://localhost"),
                EnableKeyAsSegment = false,
                SemVerVersion = informacionVersion.Version,
                ShowSchemaExamples = false
            });

            convertido.Components.Schemas[EsquemaErroresValidacion] = new OpenApiSchema
            {
                Type = "array",
                Items = new OpenApiSchema { Type = "string" },
                Description = "Mensajes de error de validacion de la entidad."
            };

            var pathsConvertidos = convertido.Paths.ToDictionary(p => Normalizar(p.Key), p => p.Value);

            var resultado = new OpenApiDocument
            {
                Info = new OpenApiInfo
                {
                    Title = "SiMaVeh API",
                    Version = informacionVersion.Version,
                    Description = Descripcion
                },
                Servers = [new OpenApiServer { Url = "/" }],
                Paths = [],
                Components = convertido.Components
            };

            foreach (var ruta in RutasRegistradas())
            {
                var analizada = Analizar(ruta.Plantilla);

                var operacion = pathsConvertidos.TryGetValue(Normalizar(analizada.Path), out var itemConvertido)
                    && itemConvertido.Operations.TryGetValue(ruta.Metodo, out var operacionConvertida)
                        ? operacionConvertida
                        : Sintetizar(analizada, ruta.Metodo, convertido);

                if (operacion == null)
                {
                    continue;
                }

                Ajustar(operacion, analizada, ruta);

                if (!resultado.Paths.TryGetValue(analizada.Path, out var item))
                {
                    resultado.Paths[analizada.Path] = item = new OpenApiPathItem();
                }

                item.Operations[ruta.Metodo] = operacion;
            }

            AgregarVersion(resultado);

            return resultado;
        }

        private const string Descripcion =
            "API REST OData de SiMaVeh para la administracion y el registro de mantenimientos vehiculares.\n\n" +
            "- El contrato OData completo (CSDL) esta en `GET /" + "simaveh/$metadata`.\n" +
            "- Las colecciones admiten las opciones de consulta de OData indicadas en cada operacion ($filter, $select, $orderby, $top, $skip, $count y, donde corresponde, $expand).\n" +
            "- Las claves de texto (por ejemplo Monedas) se escriben entre comillas simples: `Monedas('ARS')`.\n" +
            "- Las operaciones `$ref` reciben en el cuerpo `{\"@odata.id\": \"<url de la entidad relacionada>\"}` y responden 501 si la navegacion no admite referencias en ese recurso.\n" +
            "- Los errores de validacion se devuelven con 400 y una lista de mensajes.";

        /// <summary>
        /// Rutas OData registradas (forma con clave entre parentesis), sin las que siempre responden 501.
        /// </summary>
        private IEnumerable<RutaRegistrada> RutasRegistradas()
        {
            return acciones.ActionDescriptors.Items
                .OfType<ControllerActionDescriptor>()
                .Where(a => a.AttributeRouteInfo?.Template is string plantilla && (plantilla == Prefijo || plantilla.StartsWith(Prefijo + "/")))
                .Where(a => !EsFormaClaveComoSegmento(a.AttributeRouteInfo.Template))
                .Where(a => !EsDeleteRefNoImplementado(a))
                .SelectMany(a => Metodos(a).Select(m => new RutaRegistrada(a.AttributeRouteInfo.Template, m, a)))
                .GroupBy(r => (r.Plantilla, r.Metodo))
                .Select(g => g.First())
                .OrderBy(r => r.Plantilla, StringComparer.Ordinal)
                .ThenBy(r => r.Metodo);
        }

        //OData registra cada ruta con clave dos veces: Provincias({key}) y Provincias/{key}. Se documenta la primera.
        private static bool EsFormaClaveComoSegmento(string plantilla) =>
            plantilla.Split('/').Any(s => s is "{key}" or "{relatedKey}");

        private static bool EsDeleteRefNoImplementado(ControllerActionDescriptor accion) =>
            accion.MethodInfo.Name == nameof(GenericController<Domain.Models.Pais, long>.DeleteRef)
            && accion.MethodInfo.DeclaringType is { IsGenericType: true } tipo
            && tipo.GetGenericTypeDefinition() == typeof(GenericController<,>);

        private static IEnumerable<OperationType> Metodos(ControllerActionDescriptor accion) =>
            accion.EndpointMetadata.OfType<HttpMethodMetadata>()
                .SelectMany(m => m.HttpMethods)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .Select(m => Enum.Parse<OperationType>(m, ignoreCase: true));

        private static string Normalizar(string path) => Regex.Replace(path, @"\{[^}]*\}", "{}");

        private RutaAnalizada Analizar(string plantilla)
        {
            var resto = plantilla.Length == Prefijo.Length ? string.Empty : plantilla[(Prefijo.Length + 1)..];

            if (resto.Length == 0)
            {
                return new RutaAnalizada(TipoRuta.DocumentoDeServicio, $"/{Prefijo}");
            }

            if (resto == "$metadata")
            {
                return new RutaAnalizada(TipoRuta.Metadata, $"/{Prefijo}/$metadata");
            }

            var segmentos = resto.Split('/');
            var inicio = Regex.Match(segmentos[0], @"^(?<conjunto>\w+)(?<clave>\(\{key\}\))?$");
            var conjunto = (inicio.Success ? edmModel.EntityContainer.FindEntitySet(inicio.Groups["conjunto"].Value) : null) ??
                throw new NotSupportedException($"Ruta OData no reconocida para el contrato: {plantilla}");

            var entidad = conjunto.EntityType();
            var conClave = inicio.Groups["clave"].Success;
            var path = new StringBuilder($"/{Prefijo}/{conjunto.Name}");
            if (conClave)
            {
                path.Append($"({{{entidad.Key().Single().Name}}})");
            }

            var analizada = new RutaAnalizada(TipoRuta.Recurso, null, conjunto, entidad, conClave);

            foreach (var segmento in segmentos.Skip(1))
            {
                switch (segmento)
                {
                    case "$count" or "$value" or "$ref":
                        analizada = analizada with { Sufijo = segmento };
                        path.Append('/').Append(segmento);
                        break;
                    case "{navigationProperty}":
                        analizada = analizada with { NavegacionParametrica = true };
                        path.Append($"/{{{ParametroNavegacion}}}");
                        break;
                    case "{navigationProperty}({relatedKey})":
                        analizada = analizada with { NavegacionParametrica = true, ConClaveRelacionada = true };
                        path.Append($"/{{{ParametroNavegacion}}}({{{ClaveRelacionada}}})");
                        break;
                    default:
                        analizada = entidad.FindProperty(segmento) switch
                        {
                            IEdmNavigationProperty navegacion => analizada with { Navegacion = navegacion },
                            IEdmStructuralProperty propiedad => analizada with { Propiedad = propiedad },
                            _ => throw new NotSupportedException($"Segmento '{segmento}' no reconocido en la ruta {plantilla}")
                        };
                        path.Append('/').Append(segmento);
                        break;
                }
            }

            return analizada with { Path = path.ToString() };
        }

        #endregion

        #region Operaciones armadas a partir del modelo EDM

        private static OpenApiOperation Sintetizar(RutaAnalizada ruta, OperationType metodo, OpenApiDocument convertido)
        {
            if (ruta.Tipo == TipoRuta.Metadata && metodo == OperationType.Get)
            {
                return new OpenApiOperation
                {
                    Tags = [new OpenApiTag { Name = TagMetadata }],
                    OperationId = "Metadata.GetMetadata",
                    Summary = "Contrato OData completo (CSDL): entidades, propiedades, claves y relaciones.",
                    Responses = new OpenApiResponses
                    {
                        ["200"] = new OpenApiResponse
                        {
                            Description = "Documento CSDL. Con $format=json se obtiene en JSON.",
                            Content = new Dictionary<string, OpenApiMediaType> { ["application/xml"] = new() { Schema = new OpenApiSchema { Type = "string" } } }
                        }
                    }
                };
            }

            if (ruta.Tipo == TipoRuta.DocumentoDeServicio && metodo == OperationType.Get)
            {
                return new OpenApiOperation
                {
                    Tags = [new OpenApiTag { Name = TagMetadata }],
                    OperationId = "Metadata.GetDocumentoDeServicio",
                    Summary = "Documento de servicio OData: lista de colecciones (entity sets) disponibles.",
                    Responses = new OpenApiResponses { ["200"] = Json("Colecciones disponibles.", new OpenApiSchema { Type = "object" }) }
                };
            }

            if (ruta.Tipo != TipoRuta.Recurso)
            {
                throw new NotSupportedException($"No hay descripcion para {metodo} {ruta.Path}");
            }

            var nombre = ruta.Entidad.Name;
            var operacion = new OpenApiOperation
            {
                Tags = TagsDe(ruta.Conjunto, convertido),
                Parameters = [],
                Responses = []
            };

            if (ruta.ConClave)
            {
                operacion.Parameters.Add(ParametroClave(ruta, convertido));
            }

            var esEntidad = ruta.ConClave && ruta.Propiedad == null && ruta.Navegacion == null && !ruta.NavegacionParametrica && ruta.Sufijo == null;

            if (esEntidad && metodo == OperationType.Put)
            {
                operacion.OperationId = Id(ruta, $"Replace{nombre}");
                operacion.Summary = $"Reemplaza un/a {nombre} existente (todas sus propiedades).";
                operacion.RequestBody = Cuerpo($"{nombre} completo/a. El Id debe coincidir con el de la ruta.", RefEsquema(ruta.Entidad.FullName()));
                operacion.Responses["204"] = new OpenApiResponse { Description = "Entidad actualizada." };
                return operacion;
            }

            if (ruta.Propiedad != null && metodo == OperationType.Get)
            {
                var propiedad = ruta.Propiedad.Name;
                if (ruta.Sufijo == "$value")
                {
                    operacion.OperationId = Id(ruta, $"Get{propiedad}Valor");
                    operacion.Summary = $"Valor crudo de la propiedad {propiedad}.";
                    operacion.Responses["200"] = new OpenApiResponse
                    {
                        Description = "Valor de la propiedad en texto plano.",
                        Content = new Dictionary<string, OpenApiMediaType> { ["text/plain"] = new() { Schema = new OpenApiSchema { Type = "string" } } }
                    };
                    return operacion;
                }

                operacion.OperationId = Id(ruta, $"Get{propiedad}");
                operacion.Summary = $"Obtiene la propiedad {propiedad}.";
                operacion.Responses["200"] = Json("Valor de la propiedad.", new OpenApiSchema
                {
                    Type = "object",
                    Properties = new Dictionary<string, OpenApiSchema> { ["value"] = EsquemaDe(ruta.Propiedad.Type) }
                });
                return operacion;
            }

            if (ruta.Navegacion != null && metodo == OperationType.Get)
            {
                var navegacion = ruta.Navegacion.Name;
                var destino = ruta.Navegacion.ToEntityType().FullName();
                operacion.OperationId = Id(ruta, ruta.Sufijo == "$count" ? $"Count{navegacion}" : $"Get{navegacion}");
                operacion.Summary = ruta.Sufijo == "$count" ? $"Cantidad de elementos de {navegacion}." : $"Obtiene {navegacion}.";
                operacion.Responses["200"] = ruta.Sufijo == "$count"
                    ? RespuestaRef("ODataCountResponse")
                    : ruta.Navegacion.Type.IsCollection() ? RespuestaRef($"{destino}CollectionResponse") : Json($"{navegacion}.", RefEsquema(destino));
                return operacion;
            }

            if (ruta.NavegacionParametrica && ruta.Sufijo == "$ref")
            {
                //CreateRef: POST agrega a una coleccion, PUT cambia una navegacion simple. DeleteRef quita de una coleccion.
                var deColeccion = metodo != OperationType.Put;
                var navegaciones = ruta.Entidad.NavigationProperties().Where(n => n.Type.IsCollection() == deColeccion).Select(n => n.Name).OrderBy(n => n).ToList();
                if (navegaciones.Count == 0)
                {
                    return null;
                }

                operacion.Parameters.Add(new OpenApiParameter
                {
                    Name = ParametroNavegacion,
                    In = ParameterLocation.Path,
                    Required = true,
                    Description = deColeccion ? "Navegacion de coleccion." : "Navegacion simple.",
                    Schema = new OpenApiSchema { Type = "string", Enum = navegaciones.Select(n => (IOpenApiAny)new OpenApiString(n)).ToList() }
                });

                if (metodo == OperationType.Delete)
                {
                    operacion.OperationId = Id(ruta, "DeleteRef");
                    operacion.Summary = $"Quita una entidad relacionada de una coleccion de {nombre}.";
                    operacion.Parameters.Add(new OpenApiParameter
                    {
                        Name = ClaveRelacionada,
                        In = ParameterLocation.Path,
                        Required = true,
                        Description = "Clave de la entidad relacionada que se quita.",
                        Schema = new OpenApiSchema { Type = "string" }
                    });
                }
                else
                {
                    operacion.OperationId = Id(ruta, metodo == OperationType.Post ? "CreateRef" : "UpdateRef");
                    operacion.Summary = metodo == OperationType.Post
                        ? $"Agrega una entidad existente a una coleccion de {nombre}."
                        : $"Cambia la entidad relacionada de una navegacion simple de {nombre}.";
                    operacion.RequestBody = Cuerpo("Referencia a la entidad relacionada.", RefEsquema(metodo == OperationType.Post ? "ReferenceCreate" : "ReferenceUpdate"));
                    operacion.Responses["400"] = new OpenApiResponse { Description = "Falta la referencia o el verbo no corresponde a la navegacion." };
                }

                operacion.Responses["204"] = new OpenApiResponse { Description = "Referencia actualizada." };
                operacion.Responses["404"] = new OpenApiResponse { Description = "No existe la entidad o la entidad relacionada." };
                operacion.Responses["501"] = new OpenApiResponse { Description = "La navegacion no admite referencias en este recurso." };
                return operacion;
            }

            throw new NotSupportedException($"No hay descripcion para {metodo} {ruta.Path}");
        }

        /// <summary>
        /// Ajustes sobre cada operacion para que refleje el comportamiento real de la API.
        /// </summary>
        private void Ajustar(OpenApiOperation operacion, RutaAnalizada ruta, RutaRegistrada registrada)
        {
            operacion.Parameters ??= [];

            //$search no esta habilitado en ninguna entidad.
            QuitarParametros(operacion, n => n is "search" or "$search");

            //Sin [EnableQuery] la accion no aplica opciones de consulta.
            if (!TieneEnableQuery(registrada.Accion))
            {
                QuitarParametros(operacion, n => OpcionesDeConsulta.Contains(n) || n.StartsWith('$'));
            }

            var entidadResultado = ruta.Navegacion?.ToEntityType() ?? ruta.Entidad;
            if (entidadResultado != null && !PermiteExpand(entidadResultado))
            {
                QuitarParametros(operacion, n => n == "$expand");
            }

            var modificaEntidad = registrada.Metodo is OperationType.Post or OperationType.Put or OperationType.Patch
                && ruta.Tipo == TipoRuta.Recurso && ruta.Sufijo == null && !ruta.NavegacionParametrica;
            if (modificaEntidad)
            {
                operacion.Responses["400"] = Json("Errores de validacion.", RefEsquema(EsquemaErroresValidacion));
            }

            if (ruta.ConClave && !operacion.Responses.ContainsKey("404"))
            {
                operacion.Responses["404"] = new OpenApiResponse { Description = "No existe una entidad con esa clave." };
            }
        }

        private static void QuitarParametros(OpenApiOperation operacion, Func<string, bool> criterio)
        {
            foreach (var parametro in operacion.Parameters.Where(p => criterio(p.Reference?.Id ?? p.Name)).ToList())
            {
                operacion.Parameters.Remove(parametro);
            }
        }

        private static bool TieneEnableQuery(ControllerActionDescriptor accion) =>
            accion.MethodInfo.GetCustomAttributes(typeof(EnableQueryAttribute), inherit: true).Length > 0;

        private bool PermiteExpand(IEdmEntityType entidad) =>
            edmModel.GetAnnotationValue<ModelBoundQuerySettings>(entidad)?.DefaultExpandType == SelectExpandType.Allowed;

        private static void AgregarVersion(OpenApiDocument resultado)
        {
            resultado.Paths["/version"] = new OpenApiPathItem
            {
                Operations =
                {
                    [OperationType.Get] = new OpenApiOperation
                    {
                        Tags = [new OpenApiTag { Name = "Version" }],
                        OperationId = "Version.GetVersion",
                        Summary = "Version de la aplicacion.",
                        Responses = new OpenApiResponses
                        {
                            ["200"] = Json("Version de la aplicacion.", new OpenApiSchema
                            {
                                Type = "object",
                                Properties = new Dictionary<string, OpenApiSchema>
                                {
                                    ["aplicacion"] = new() { Type = "string" },
                                    ["version"] = new() { Type = "string", Description = "Version SemVer, por ejemplo 0.8.0." },
                                    ["build"] = new() { Type = "string", Description = "Version con el hash del commit." }
                                }
                            })
                        }
                    }
                }
            };
        }

        #endregion

        #region Helpers

        private static string Id(RutaAnalizada ruta, string accion) => $"{ruta.Conjunto.Name}.{ruta.Entidad.Name}.{accion}";

        private static IList<OpenApiTag> TagsDe(IEdmEntitySet conjunto, OpenApiDocument convertido) =>
            convertido.Paths.TryGetValue($"/{Prefijo}/{conjunto.Name}", out var item) && item.Operations.Count > 0
                ? item.Operations.Values.First().Tags
                : [new OpenApiTag { Name = conjunto.Name }];

        private static OpenApiParameter ParametroClave(RutaAnalizada ruta, OpenApiDocument convertido)
        {
            var clave = ruta.Entidad.Key().Single();
            var pathEntidad = $"/{Prefijo}/{ruta.Conjunto.Name}({{{clave.Name}}})";
            var parametroConvertido = convertido.Paths.TryGetValue(pathEntidad, out var item)
                ? item.Operations.Values.SelectMany(o => o.Parameters).FirstOrDefault(p => p.In == ParameterLocation.Path)
                : null;

            return parametroConvertido ?? new OpenApiParameter
            {
                Name = clave.Name,
                In = ParameterLocation.Path,
                Required = true,
                Schema = EsquemaDe(clave.Type)
            };
        }

        private static OpenApiSchema EsquemaDe(IEdmTypeReference tipo)
        {
            if (tipo.IsEnum())
            {
                return RefEsquema(tipo.FullName());
            }

            var esquema = tipo.PrimitiveKind() switch
            {
                EdmPrimitiveTypeKind.Int16 or EdmPrimitiveTypeKind.Int32 => new OpenApiSchema { Type = "integer", Format = "int32" },
                EdmPrimitiveTypeKind.Int64 => new OpenApiSchema { Type = "number", Format = "int64" },
                EdmPrimitiveTypeKind.Decimal => new OpenApiSchema { Type = "number", Format = "decimal" },
                EdmPrimitiveTypeKind.Double => new OpenApiSchema { Type = "number", Format = "double" },
                EdmPrimitiveTypeKind.Boolean => new OpenApiSchema { Type = "boolean" },
                EdmPrimitiveTypeKind.DateTimeOffset => new OpenApiSchema { Type = "string", Format = "date-time" },
                EdmPrimitiveTypeKind.Date => new OpenApiSchema { Type = "string", Format = "date" },
                _ => new OpenApiSchema { Type = "string" }
            };
            esquema.Nullable = tipo.IsNullable;

            return esquema;
        }

        private static OpenApiSchema RefEsquema(string id) => new() { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = id } };

        private static OpenApiResponse RespuestaRef(string id) => new() { Reference = new OpenApiReference { Type = ReferenceType.Response, Id = id } };

        private static OpenApiResponse Json(string descripcion, OpenApiSchema esquema) => new()
        {
            Description = descripcion,
            Content = new Dictionary<string, OpenApiMediaType> { ["application/json"] = new() { Schema = esquema } }
        };

        private static OpenApiRequestBody Cuerpo(string descripcion, OpenApiSchema esquema) => new()
        {
            Required = true,
            Description = descripcion,
            Content = new Dictionary<string, OpenApiMediaType> { ["application/json"] = new() { Schema = esquema } }
        };

        #endregion
    }
}
