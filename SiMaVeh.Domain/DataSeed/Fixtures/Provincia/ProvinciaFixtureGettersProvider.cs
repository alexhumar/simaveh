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
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="datosEntidadBuilder"></param>
    /// <param name="paisFixtureGetter"></param>
    public class ProvinciaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder,
        IPaisFixtureGetter paisFixtureGetter) : IProvinciaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder = datosEntidadBuilder;
        private readonly IPaisFixtureGetter paisFixtureGetter = paisFixtureGetter;

        /// <summary>
        /// Retorna los providers de fixture getters de provincias
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, DatosEntidad>> GetFixtureGetters()
        {
            return
            [
                new ProvinciaArgentinaFixtureGetter(datosEntidadBuilder, paisFixtureGetter),
                new ProvinciaUruguayFixtureGetter(datosEntidadBuilder, paisFixtureGetter),
            ];
        }
    }
}
