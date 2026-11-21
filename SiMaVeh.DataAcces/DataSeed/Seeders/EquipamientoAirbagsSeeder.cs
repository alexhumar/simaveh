using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de equipamiento airbags
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureEquipamientoAirbags"></param>
    public class EquipamientoAirbagsSeeder(IFixtureEquipamientoAirbags fixtureEquipamientoAirbags) : SeederBase<EquipamientoAirbags>
    {
        private readonly IFixtureEquipamientoAirbags fixtureEquipamientoAirbags = fixtureEquipamientoAirbags;

        /// <summary>
        /// Genera los equipamientos de airbags default
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<object> GetSeeds()
        {
            return fixtureEquipamientoAirbags.GetEquipamientosAirbags().Select(equipamientoAirbagsFixture => new
            {
                equipamientoAirbagsFixture.Id,
                equipamientoAirbagsFixture.Acompanante,
                equipamientoAirbagsFixture.Conductor,
                equipamientoAirbagsFixture.DelanteroDerecho,
                equipamientoAirbagsFixture.DelanteroIzquierdo,
                equipamientoAirbagsFixture.TraseroDerecho,
                equipamientoAirbagsFixture.TraseroIzquierdo
            });
        }
    }
}
