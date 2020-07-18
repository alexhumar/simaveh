using Microsoft.AspNetCore.Mvc.ModelBinding;
using SiMaVeh.Api.ErrorManagement.Interfaces;
using System;
using System.Collections.Generic;

namespace SiMaVeh.Api.ErrorManagement
{
    /// <summary>
    /// Genera y procesa errores del sistema
    /// </summary>
    internal class ErrorsBuilder : IErrorsBuilder
    {
        /// <summary>
        /// Genera una lista de errores a partir del modelstate
        /// </summary>
        /// <typeparam name="modelState"></typeparam>
        /// <returns></returns>
        public IList<string> BuildErrors(ModelStateDictionary modelState)
        {
            var result = new List<string>();

            foreach (var modelStateEntry in modelState.Values)
            {
                foreach (var modelError in modelStateEntry.Errors)
                {
                    var message = (modelError.Exception != null ? modelError.Exception.Message : modelError.ErrorMessage).Trim();
                    if (!string.IsNullOrEmpty(message))
                    {
                        result.Add(message);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Genera una lista de errores a partir de una excepcion
        /// </summary>
        /// <typeparam name="e"></typeparam>
        /// <returns></returns>
        public IList<string> BuildErrors(Exception e)
        {
            return new List<string> { e.InnerException.Message };
        }
    }
}