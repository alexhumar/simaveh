using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces
{
    /// <summary>
    /// Interfaz de FixtureFuenteEnergia
    /// </summary>
    public interface IFixtureFuenteEnergia
    {
        /// <summary>
        /// Get Fuentes Energia
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosFuenteEnergia> GetFuentesEnergia();
    }
}
