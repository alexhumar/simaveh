using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.ErrorManagement.Middlewares
{
    public class ResponseExceptionMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger logger;

        public ResponseExceptionMiddleware(RequestDelegate next,
            ILogger<ResponseExceptionMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception exceptionObj)
            {
                await HandleExceptionAsync(context, exceptionObj);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            logger.LogError(exception, "Error SiMaVeh");

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            //TODO: hacer un objeto serializable para contener esta respuesta.
            return context.Response.WriteAsync("Se produjo un error inesperado. Consulte el log de SiMaVeh.");
        }
    }
}
