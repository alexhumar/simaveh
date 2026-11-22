using Microsoft.AspNetCore.Builder;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.ErrorManagement.Middlewares;

namespace SiMaVeh.Api.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ResponseExceptionMiddleware>();
        }

        /// <summary>
        /// Swagger UI (en /swagger) para explorar y probar el contrato OpenAPI que publica ContratoController.
        /// </summary>
        public static void ConfigurarSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwaggerUI(opciones =>
            {
                opciones.RoutePrefix = UriConstants.PrefijoSwaggerUI;
                opciones.DocumentTitle = "SiMaVeh API";
                opciones.SwaggerEndpoint($"/{UriConstants.ContratoOpenApiJson}", "SiMaVeh API");
            });
        }
    }
}
