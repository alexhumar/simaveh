using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;

namespace SiMaVeh.Helpers
{
    /// <summary>
    /// Genera y procesa errores del sistema
    /// </summary>
    public class ErrorsBuilder
    {
        /// <summary>
        /// Genera una lista de errores a partir del modelstate
        /// </summary>
        /// <typeparam name="modelState"></typeparam>
        /// <returns></returns>
        public static IList<string> BuildErrors(ModelStateDictionary modelState)
        {
            var result = new List<string>();

            foreach (var ms in modelState.Values)
            {
                foreach (var error in ms.Errors)
                {
                    var message = ((error.Exception != null) ? error.Exception.Message : error.ErrorMessage).Trim();
                    if (!string.IsNullOrEmpty(message))
                        result.Add(message);
                }
            }

            return result;
        }

        /// <summary>
        /// Genera una lista de errores a partir de una excepcion
        /// </summary>
        /// <typeparam name="e"></typeparam>
        /// <returns></returns>
        public static IList<string> BuildErrors(Exception e)
        {
            return new List<string> { e.InnerException.Message };
        }
    }
}