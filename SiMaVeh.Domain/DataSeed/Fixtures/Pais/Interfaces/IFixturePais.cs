using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces
{
    /// <summary>
    /// Interfaz de FixturePais
    /// </summary>
    public interface IFixturePais
    {
        /// <summary>
        /// Get Paises
        /// </summary>
        /// <returns></returns>
        IDictionary<long, string> GetPaises();

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        KeyValuePair<long, string>? FindByNombre(string nombre);
    }
}
