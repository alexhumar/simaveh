using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de equipamiento airbags
    /// </summary>
    public class EquipamientoAirbagsSeeder : ISeeder<EquipamientoAirbags, string>
    {
        private readonly IFixtureEquipamientoAirbags fixtureEquipamientoAirbags;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureEquipamientoAirbags"></param>
        public EquipamientoAirbagsSeeder(IFixtureEquipamientoAirbags fixtureEquipamientoAirbags)
        {
            this.fixtureEquipamientoAirbags = fixtureEquipamientoAirbags;
        }

        /// <summary>
        /// Genera los equipamientos de airbags default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var equipamientoAirbagsFixture in fixtureEquipamientoAirbags.GetEquipamientosAirbags())
            {
                result.Add(new
                {
                    equipamientoAirbagsFixture.Acompanante,
                    equipamientoAirbagsFixture.Conductor,
                    equipamientoAirbagsFixture.DelanteroDerecho,
                    equipamientoAirbagsFixture.DelanteroIzquierdo,
                    equipamientoAirbagsFixture.TraseroDerecho,
                    equipamientoAirbagsFixture.TraseroIzquierdo
                });
            }

            return result;
        }
    }
}
