using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Provider de Loaders de Partido
    /// </summary>
    public class PartidoLoadersProvider : IFixtureItemKeyValueLoaderProvider<long, long, string>
    {
        /// <summary>
        /// Retorna los providers de loaders de partidos
        /// </summary>
        /// <returns></returns>
        public List<IFixtureItemKeyValueLoader<long, long, string>> GetProviders()
        {
            return new List<IFixtureItemKeyValueLoader<long, long, string>>
            {
                new BuenosAiresLoader(),
                new CatamarcaLoader(),
                new ChacoLoader(),
                new ChubutLoader(),
                new CordobaLoader(),
                new CorrientesLoader(),
                new EntreRiosLoader(),
                new FormosaLoader(),
                new JujuyLoader(),
                new LaPampaLoader(),
                new LaRiojaLoader(),
                new MendozaLoader(),
                new MisionesLoader(),
                new NeuquenLoader(),
                new RioNegroLoader(),
                new SaltaLoader(),
                new SanJuanLoader(),
                new SanLuisLoader(),
                new SantaCruzLoader(),
                new SantaFeLoader(),
                new SantiagoDelEsteroLoader(),
                new TierraDelFuegoLoader(),
                new TucumanLoader()
            };
        }
    }
}
