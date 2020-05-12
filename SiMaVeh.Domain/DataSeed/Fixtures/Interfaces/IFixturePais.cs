using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
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
        Dictionary<long, string> GetPaises();

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        KeyValuePair<long, string>? FindByNombre(string nombre);
    }
}
