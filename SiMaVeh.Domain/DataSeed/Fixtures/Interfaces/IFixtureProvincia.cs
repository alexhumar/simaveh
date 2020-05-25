using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz de FixtureProvincia
    /// </summary>
    public interface IFixtureProvincia
    {
        /// <summary>
        /// Get Provincias
        /// </summary>
        /// <returns></returns>
        Dictionary<long, Dictionary<long, string>> GetProvincias();
    }
}
