using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces
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
        IDictionary<long, IEnumerable<DatosEntidad>> GetLocalidades();
    }
}
