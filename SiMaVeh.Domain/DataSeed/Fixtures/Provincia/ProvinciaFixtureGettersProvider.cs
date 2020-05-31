using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Uruguay;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia
{
    /// <summary>
    /// Provider de Fixture Getters de Provincia
    /// </summary>
    public class ProvinciaFixtureGettersProvider : IProvinciaFixtureGettersProvider
    {
        private readonly IPaisFixtureGetter paisFixtureGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProvinciaFixtureGettersProvider()
        {
            paisFixtureGetter = new PaisFixtureGetter(new DatosEntidadBuilder());
        }

        /// <summary>
        /// Retorna los providers de fixture getters de provincias
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureDetailGetter<long, DatosEntidad>>
            {
                new ProvinciaArgentinaFixtureGetter(paisFixtureGetter),
                new ProvinciaUruguayFixtureGetter(paisFixtureGetter),
            };
        }
    }
}
