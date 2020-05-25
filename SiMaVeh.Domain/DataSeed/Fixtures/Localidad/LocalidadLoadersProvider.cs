using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Argentina;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Provider de Loaders de Localidad
    /// </summary>
    public class LocalidadLoadersProvider : ILocalidadLoadersProvider
    {
        private readonly IProvinciasLoader<long, long, string> provinciasArgentinaLoader;

        /// <summary>
        /// Constructor
        /// </summary>
        public LocalidadLoadersProvider()
        {
            provinciasArgentinaLoader = new ProvinciasArgentinaLoader(new PaisesLoader());
        }

        /// <summary>
        /// Retorna los providers de loaders de localidades
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureItemKeyValueLoader<long, long, string>> GetLoaders()
        {
            return new List<IFixtureItemKeyValueLoader<long, long, string>>
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
