using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SiMaVeh.Api.ErrorManagement.Interfaces;
using System;
using System.Net;

namespace SiMaVeh.Api.ErrorManagement.Filters
{
    public class ResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        private readonly IErrorsBuilder errorsBuilder;

        public int Order { get; set; }

        public ResponseExceptionFilter(IErrorsBuilder errorsBuilder)
        {
            this.errorsBuilder = errorsBuilder;

            //Esta cuenta permite que otros filters se ejecuten lo mas al final posible del pipeline
            Order = int.MaxValue - 10;
        }

        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is Exception exception)
            {
                context.Result = new ObjectResult(errorsBuilder.BuildError(exception))
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                };
                context.ExceptionHandled = true;
            }
        }
    }
}
