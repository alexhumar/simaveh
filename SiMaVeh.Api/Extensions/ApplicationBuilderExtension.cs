using Microsoft.AspNetCore.Builder;
using SiMaVeh.Api.ErrorManagement.Middlewares;

namespace SiMaVeh.Api.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ResponseExceptionMiddleware>();
        }
    }
}
