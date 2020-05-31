using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Provider de Fixture Getters de Partido
    /// </summary>
    public class PartidoFixtureGettersProvider : IPartidoFixtureGettersProvider
    {
        private readonly IProvinciaFixtureGetter provinciaArgentinaFixtureGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        public PartidoFixtureGettersProvider()
        {
            provinciaArgentinaFixtureGetter = new ProvinciaArgentinaFixtureGetter(new PaisFixtureGetter(new DatosEntidadBuilder()));
        }

        /// <summary>
        /// Retorna los providers de fixture getters de partidos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureDetailGetter<long, DatosEntidad>>
            {
                new PartidoBuenosAiresFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoCatamarcaFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoChacoFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoChubutFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoCordobaFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoCorrientesFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoEntreRiosFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoFormosaFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoJujuyFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoLaPampaFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoLaRiojaFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoMendozaFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoMisionesFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoNeuquenFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoRioNegroFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoSaltaFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoSanJuanFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoSanLuisFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoSantaCruzFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoSantaFeFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoSantiagoDelEsteroFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoTierraDelFuegoFixtureGetter(provinciaArgentinaFixtureGetter),
                new PartidoTucumanFixtureGetter(provinciaArgentinaFixtureGetter)
            };
        }
    }
}
