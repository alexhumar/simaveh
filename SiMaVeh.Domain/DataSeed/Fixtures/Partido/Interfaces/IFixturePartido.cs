using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces
{
    /// <summary>
    /// Interfaz de FixturePartido
    /// </summary>
    public interface IFixturePartido
    {
        /// <summary>
        /// Get Partidos
        /// </summary>
        /// <returns></returns>
        IDictionary<long, List<DatosEntidad>> GetPartidos();
    }
}
