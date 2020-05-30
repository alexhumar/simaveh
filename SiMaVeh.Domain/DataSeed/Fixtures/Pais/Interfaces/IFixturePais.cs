using SiMaVeh.Domain.DataSeed.Models;
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
        IEnumerable<DatosEntidad> GetPaises();

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        DatosEntidad FindByNombre(string nombre);
    }
}
