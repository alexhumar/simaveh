using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz de FixtureLocalidad
    /// </summary>
    public interface IFixtureLocalidad
    {
        /// <summary>
        /// Get Localidades
        /// </summary>
        /// <returns></returns>
        Dictionary<long, Dictionary<long, string>> GetLocalidades();
    }
}
