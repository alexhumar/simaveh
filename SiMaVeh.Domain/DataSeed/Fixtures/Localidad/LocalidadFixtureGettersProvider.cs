using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad
{
    /// <summary>
    /// Provider de Fixture Getters de Localidad
    /// </summary>
    public class LocalidadFixtureGettersProvider : ILocalidadFixtureGettersProvider
    {
        private readonly IProvinciaFixtureGetter provinciaArgentinaFixtureGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        public LocalidadFixtureGettersProvider()
        {
            provinciaArgentinaFixtureGetter = new ProvinciaArgentinaFixtureGetter(new PaisFixtureGetter());
        }

        /// <summary>
        /// Retorna los providers de fixture getters de localidades
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureDetailGetter<long, DatosEntidad>>
            {
                new LocalidadesBuenosAiresLoader(new PartidoBuenosAiresFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesCatamarcaLoader(new PartidoCatamarcaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesChacoLoader(new PartidoChacoFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesChubutLoader(new PartidoChubutFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesCordobaLoader(new PartidoCordobaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesCorrientesLoader(new PartidoCorrientesFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesEntreRiosLoader(new PartidoEntreRiosFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesFormosaLoader(new PartidoFormosaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesJujuyLoader(new PartidoJujuyFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesLaPampaLoader(new PartidoLaPampaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesLaRiojaLoader(new PartidoLaRiojaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesMendozaLoader(new PartidoMendozaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesMisionesLoader(new PartidoMisionesFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesNeuquenLoader(new PartidoNeuquenFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesRioNegroLoader(new PartidoRioNegroFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesSaltaLoader(new PartidoSaltaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesSanJuanLoader(new PartidoSanJuanFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesSanLuisLoader(new PartidoSanLuisFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesSantaCruzLoader(new PartidoSantaCruzFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesSantaFeLoader(new PartidoSantaFeFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesSantiagoDelEsteroLoader(new PartidoSantiagoDelEsteroFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesTierraDelFuegoLoader(new PartidoTierraDelFuegoFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadesTucumanLoader(new PartidoTucumanFixtureGetter(provinciaArgentinaFixtureGetter))
            };
        }
    }
}
