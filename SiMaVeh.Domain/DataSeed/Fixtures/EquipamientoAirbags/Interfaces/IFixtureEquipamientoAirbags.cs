using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.Interfaces
{
    /// <summary>
    /// Fixture de equipamiento airbags
    /// </summary>
    public interface IFixtureEquipamientoAirbags
    {
        /// <summary>
        /// Retorna los equipamientos de airbags default
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosEquipamientoAirbags> GetEquipamientosAirbags();
    }
}
