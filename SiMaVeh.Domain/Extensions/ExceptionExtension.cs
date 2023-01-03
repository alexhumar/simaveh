using System;

namespace SiMaVeh.Domain.Extensions
{
    /// <summary>
    /// Metodos de extension de excepciones generales
    /// </summary>
    public static class ExceptionExtension
    {
        /// <summary>
        /// Obtiene el detalle de una excepcion
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string GetDetalle(this Exception e)
        {
            var result = e.Message;

            if (e.InnerException != null && !string.IsNullOrWhiteSpace(e.InnerException.Message))
            {
                result = $"{result}. Detalle: {e.InnerException.Message}";
            }

            return result;
        }
    }
}
