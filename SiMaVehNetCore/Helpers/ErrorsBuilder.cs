using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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

            foreach (var ms in modelState.Values) {
                foreach (var error in ms.Errors) {
                    result.Add(error.Exception.Message);
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