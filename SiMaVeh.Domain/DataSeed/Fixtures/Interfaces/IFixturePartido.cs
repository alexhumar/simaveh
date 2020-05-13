using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
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
        Dictionary<long, Dictionary<long, string>> GetPartidos();
    }
}
