using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia
{
    /// <summary>
    /// Provider de fixture getters de fuentes de energia
    /// </summary>
    public class FuenteEnergiaFixtureGettersProvider : IFuenteEnergiaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public FuenteEnergiaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
        }

        /// <summary>
        /// Retorna los providers de fixture getters de fuentes de energia
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosFuenteEnergia>> GetFixtureGetters()
        {
            return new List<IFixtureGetter<DatosFuenteEnergia>>
            {
                new FuenteEnergiaFixtureGetter(datosEntidadBuilder)
            };
        }
    }
}
