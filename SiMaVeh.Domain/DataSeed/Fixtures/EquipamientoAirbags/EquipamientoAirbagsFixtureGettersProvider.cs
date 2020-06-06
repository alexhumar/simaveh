using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags
{
    /// <summary>
    /// Provider de fixture getters de equipamientos de airbags
    /// </summary>
    public class EquipamientoAirbagsFixtureGettersProvider : IEquipamientoAirbagsFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public EquipamientoAirbagsFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
        }

        /// <summary>
        /// Retorna los providers de fixture getters de equipamientos de airbags
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosEquipamientoAirbags>> GetFixtureGetters()
        {
            return new List<IFixtureGetter<DatosEquipamientoAirbags>>
            {
                new EquipamientoAirbagsPiezaFixtureGetter(datosEntidadBuilder)
            };
        }
    }
}
