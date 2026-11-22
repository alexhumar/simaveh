using Microsoft.OpenApi.Models;

namespace SiMaVeh.Api.Contrato.Interfaces
{
    /// <summary>
    /// Genera el contrato OpenAPI de la API a partir del modelo EDM y de las rutas que el router realmente registra.
    /// </summary>
    public interface IGeneradorContratoOpenApi
    {
        /// <summary>
        /// Documento OpenAPI (se genera una sola vez).
        /// </summary>
        OpenApiDocument Documento { get; }

        /// <summary>
        /// Documento serializado en JSON (OpenAPI 3.0).
        /// </summary>
        string ComoJson();

        /// <summary>
        /// Documento serializado en YAML (OpenAPI 3.0).
        /// </summary>
        string ComoYaml();
    }
}
