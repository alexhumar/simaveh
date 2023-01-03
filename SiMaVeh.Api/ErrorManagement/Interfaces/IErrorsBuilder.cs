using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;

namespace SiMaVeh.Api.ErrorManagement.Interfaces
{
    /// <summary>
    /// Interfaz de Errors Builder
    /// </summary>
    public interface IErrorsBuilder
    {
        /// <summary>
        /// Genera una lista de errores a partir del modelstate
        /// </summary>
        /// <typeparam name="modelState"></typeparam>
        /// <returns></returns>
        IList<string> BuildErrors(ModelStateDictionary modelState);

        /// <summary>
        /// Genera una lista de errores a partir de una excepcion
        /// </summary>
        /// <typeparam name="e"></typeparam>
        /// <returns></returns>
        IList<string> BuildErrors(Exception e);

        /// <summary>
        /// Genera un mensaje de error a partir de una excepcion
        /// </summary>
        /// <typeparam name="e"></typeparam>
        /// <returns></returns>
        string BuildError(Exception e);
    }
}
