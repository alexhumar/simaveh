using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces
{
    /// <summary>
    /// Fixture de tipo de fuente de energia
    /// </summary>
    public interface IFixtureTipoFuenteEnergia
    {
        /// <summary>
        /// Retorna los tipos de fuente de energia default
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosEntidad> GetTiposFuenteEnergia();
    }
}
