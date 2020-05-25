using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Provider de Loaders de Localidad
    /// </summary>
    public class LocalidadLoadersProvider : ILocalidadLoadersProvider
    {
        private readonly IFixturePartido fixturePartido;
        private readonly IProvinciasLoader<long, long, string> provinciasArgentinaLoader;

        /// <summary>
        /// Constructor
        /// </summary>
        public LocalidadLoadersProvider()
        {
            //TODO: hay que borrar FixturePartido y tomar provinciasArgentinasLoader como parametro a los new de loaders de partido
            //para cada loader de localidad.
            fixturePartido = new FixturePartido();
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
                new BuenosAiresLoader(fixturePartido),
                new CatamarcaLoader(fixturePartido),
                new ChacoLoader(fixturePartido),
                new ChubutLoader(fixturePartido),
                new CordobaLoader(fixturePartido),
                new CorrientesLoader(fixturePartido),
                new EntreRiosLoader(fixturePartido),
                new FormosaLoader(fixturePartido),
                new JujuyLoader(fixturePartido),
                new LaPampaLoader(fixturePartido),
                new LaRiojaLoader(fixturePartido),
                new MendozaLoader(fixturePartido),
                new MisionesLoader(fixturePartido),
                new NeuquenLoader(fixturePartido),
                new RioNegroLoader(fixturePartido),
                new SaltaLoader(fixturePartido),
                new SanJuanLoader(fixturePartido),
                new SanLuisLoader(fixturePartido),
                new SantaCruzLoader(fixturePartido),
                new SantaFeLoader(fixturePartido),
                new SantiagoDelEsteroLoader(fixturePartido),
                new TierraDelFuegoLoader(fixturePartido),
                new TucumanLoader(fixturePartido)
            };
        }
    }
}
