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
    }
}
