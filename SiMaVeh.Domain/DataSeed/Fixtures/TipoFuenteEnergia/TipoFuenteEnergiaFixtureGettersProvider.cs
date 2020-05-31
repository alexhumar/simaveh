using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia
{
    /// <summary>
    /// Provider de fixture getters de Tipos de Fuentes de Energia
    /// </summary>
    public class TipoFuenteEnergiaFixtureGettersProvider : ITipoFuenteEnergiaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public TipoFuenteEnergiaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
        }

        /// <summary>
        /// Retorna los providers de fixture getters de tipos de fuentes de energia
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureGetter<DatosEntidad>>
            {
                new TipoFuenteEnergiaFixtureGetter(datosEntidadBuilder)
            };
        }
    }
}
