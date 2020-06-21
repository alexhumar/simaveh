using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags
{
    /// <summary>
    /// Fixture con informacion de equipamiento de airbags
    /// </summary>
    public class FixtureEquipamientoAirbags : IFixtureEquipamientoAirbags
    {
        private readonly IEquipamientoAirbagsFixtureGettersProvider equipamientoAirbagsFixtureGettersProvider;
        private IEnumerable<DatosEquipamientoAirbags> equipamientosAirbags;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="equipamientoAirbagsFixtureGettersProvider"></param>
        public FixtureEquipamientoAirbags(IEquipamientoAirbagsFixtureGettersProvider equipamientoAirbagsFixtureGettersProvider)
        {
            this.equipamientoAirbagsFixtureGettersProvider = equipamientoAirbagsFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Retorna los equipamientos de airbags default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosEquipamientoAirbags> GetEquipamientosAirbags()
        {
            return equipamientosAirbags;
        }

        private void Initialize()
        {
            equipamientosAirbags = equipamientoAirbagsFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
