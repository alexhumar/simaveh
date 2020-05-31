using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Uruguay;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia
{
    /// <summary>
    /// Provider de fixture getters de provincia
    /// </summary>
    public class ProvinciaFixtureGettersProvider : IProvinciaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly IPaisFixtureGetter paisFixtureGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        /// <param name="paisFixtureGetter"></param>
        public ProvinciaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder,
            IPaisFixtureGetter paisFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            this.paisFixtureGetter = paisFixtureGetter;
        }

        /// <summary>
        /// Retorna los providers de fixture getters de provincias
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureDetailGetter<long, DatosEntidad>>
            {
                new ProvinciaArgentinaFixtureGetter(datosEntidadBuilder, paisFixtureGetter),
                new ProvinciaUruguayFixtureGetter(datosEntidadBuilder, paisFixtureGetter),
            };
        }
    }
}
