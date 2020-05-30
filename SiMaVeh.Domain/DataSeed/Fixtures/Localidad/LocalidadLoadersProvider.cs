using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad
{
    /// <summary>
    /// Provider de Loaders de Localidad
    /// </summary>
    public class LocalidadLoadersProvider : ILocalidadLoadersProvider
    {
        private readonly IProvinciaFixtureGetter provinciasArgentinaLoader;

        /// <summary>
        /// Constructor
        /// </summary>
        public LocalidadLoadersProvider()
        {
            provinciasArgentinaLoader = new ProvinciaArgentinaFixtureGetter(new PaisFixtureGetter());
        }

        /// <summary>
        /// Retorna los providers de loaders de localidades
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, long, string>> GetFixtureGetters()
        {
            return new List<IFixtureDetailGetter<long, long, string>>
            {
                new LocalidadesBuenosAiresLoader(new PartidosBuenosAiresLoader(provinciasArgentinaLoader)),
                new LocalidadesCatamarcaLoader(new PartidosCatamarcaLoader(provinciasArgentinaLoader)),
                new LocalidadesChacoLoader(new PartidosChacoLoader(provinciasArgentinaLoader)),
                new LocalidadesChubutLoader(new PartidosChubutLoader(provinciasArgentinaLoader)),
                new LocalidadesCordobaLoader(new PartidosCordobaLoader(provinciasArgentinaLoader)),
                new LocalidadesCorrientesLoader(new PartidosCorrientesLoader(provinciasArgentinaLoader)),
                new LocalidadesEntreRiosLoader(new PartidosEntreRiosLoader(provinciasArgentinaLoader)),
                new LocalidadesFormosaLoader(new PartidosFormosaLoader(provinciasArgentinaLoader)),
                new LocalidadesJujuyLoader(new PartidosJujuyLoader(provinciasArgentinaLoader)),
                new LocalidadesLaPampaLoader(new PartidosLaPampaLoader(provinciasArgentinaLoader)),
                new LocalidadesLaRiojaLoader(new PartidosLaRiojaLoader(provinciasArgentinaLoader)),
                new LocalidadesMendozaLoader(new PartidosMendozaLoader(provinciasArgentinaLoader)),
                new LocalidadesMisionesLoader(new PartidosMisionesLoader(provinciasArgentinaLoader)),
                new LocalidadesNeuquenLoader(new PartidosNeuquenLoader(provinciasArgentinaLoader)),
                new LocalidadesRioNegroLoader(new PartidosRioNegroLoader(provinciasArgentinaLoader)),
                new LocalidadesSaltaLoader(new PartidosSaltaLoader(provinciasArgentinaLoader)),
                new LocalidadesSanJuanLoader(new PartidosSanJuanLoader(provinciasArgentinaLoader)),
                new LocalidadesSanLuisLoader(new PartidosSanLuisLoader(provinciasArgentinaLoader)),
                new LocalidadesSantaCruzLoader(new PartidosSantaCruzLoader(provinciasArgentinaLoader)),
                new LocalidadesSantaFeLoader(new PartidosSantaFeLoader(provinciasArgentinaLoader)),
                new LocalidadesSantiagoDelEsteroLoader(new PartidosSantiagoDelEsteroLoader(provinciasArgentinaLoader)),
                new LocalidadesTierraDelFuegoLoader(new PartidosTierraDelFuegoLoader(provinciasArgentinaLoader)),
                new LocalidadesTucumanLoader(new PartidosTucumanLoader(provinciasArgentinaLoader))
            };
        }
    }
}
