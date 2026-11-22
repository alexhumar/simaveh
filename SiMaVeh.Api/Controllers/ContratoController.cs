using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Contrato.Interfaces;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Publica el contrato OpenAPI de la API, fuera del prefijo OData.
    /// El contrato OData (CSDL) sigue disponible en /simaveh/$metadata.
    /// </summary>
    /// <param name="generadorContrato"></param>
    [ApiController]
    public class ContratoController(IGeneradorContratoOpenApi generadorContrato) : ControllerBase
    {
        private readonly IGeneradorContratoOpenApi generadorContrato = generadorContrato;

        /// <summary>
        /// Contrato OpenAPI 3.0 en JSON.
        /// </summary>
        [HttpGet(UriConstants.ContratoOpenApiJson)]
        public ContentResult GetJson() => Content(generadorContrato.ComoJson(), "application/json");

        /// <summary>
        /// Contrato OpenAPI 3.0 en YAML.
        /// </summary>
        [HttpGet(UriConstants.ContratoOpenApiYaml)]
        public ContentResult GetYaml() => Content(generadorContrato.ComoYaml(), "application/yaml");
    }
}
