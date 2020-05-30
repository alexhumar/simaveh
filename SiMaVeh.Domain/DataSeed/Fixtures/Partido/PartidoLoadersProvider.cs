using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Loaders;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Argentina;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Provider de Loaders de Partido
    /// </summary>
    public class PartidoLoadersProvider : IPartidoLoadersProvider
    {
        private readonly IProvinciasLoader provinciasArgentinaLoader;

        /// <summary>
        /// Constructor
        /// </summary>
        public PartidoLoadersProvider()
        {
            provinciasArgentinaLoader = new ProvinciasArgentinaLoader(new PaisFixtureGetter());
        }

        /// <summary>
        /// Retorna los providers de loaders de partidos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureItemKeyValueLoader<long, long, string>> GetLoaders()
        {
            return new List<IFixtureItemKeyValueLoader<long, long, string>>
            {
                new PartidosBuenosAiresLoader(provinciasArgentinaLoader),
                new PartidosCatamarcaLoader(provinciasArgentinaLoader),
                new PartidosChacoLoader(provinciasArgentinaLoader),
                new PartidosChubutLoader(provinciasArgentinaLoader),
                new PartidosCordobaLoader(provinciasArgentinaLoader),
                new PartidosCorrientesLoader(provinciasArgentinaLoader),
                new PartidosEntreRiosLoader(provinciasArgentinaLoader),
                new PartidosFormosaLoader(provinciasArgentinaLoader),
                new PartidosJujuyLoader(provinciasArgentinaLoader),
                new PartidosLaPampaLoader(provinciasArgentinaLoader),
                new PartidosLaRiojaLoader(provinciasArgentinaLoader),
                new PartidosMendozaLoader(provinciasArgentinaLoader),
                new PartidosMisionesLoader(provinciasArgentinaLoader),
                new PartidosNeuquenLoader(provinciasArgentinaLoader),
                new PartidosRioNegroLoader(provinciasArgentinaLoader),
                new PartidosSaltaLoader(provinciasArgentinaLoader),
                new PartidosSanJuanLoader(provinciasArgentinaLoader),
                new PartidosSanLuisLoader(provinciasArgentinaLoader),
                new PartidosSantaCruzLoader(provinciasArgentinaLoader),
                new PartidosSantaFeLoader(provinciasArgentinaLoader),
                new PartidosSantiagoDelEsteroLoader(provinciasArgentinaLoader),
                new PartidosTierraDelFuegoLoader(provinciasArgentinaLoader),
                new PartidosTucumanLoader(provinciasArgentinaLoader)
            };
        }
    }
}
