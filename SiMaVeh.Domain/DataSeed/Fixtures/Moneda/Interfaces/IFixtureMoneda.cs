using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Moneda.Interfaces
{
    /// <summary>
    /// Interfaz de FixtureMoneda
    /// </summary>
    public interface IFixtureMoneda
    {
        /// <summary>
        /// Get Monedas
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosMoneda> GetMonedas();
    }
}
