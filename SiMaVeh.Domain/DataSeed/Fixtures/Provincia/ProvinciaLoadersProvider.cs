using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Uruguay;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia
{
    /// <summary>
    /// Provider de Loaders de Provincia
    /// </summary>
    public class ProvinciaLoadersProvider : IProvinciaLoadersProvider
    {
        private readonly IPaisesLoader<long, string> paisesLoader;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProvinciaLoadersProvider()
        {
            paisesLoader = new PaisesLoader();
        }

        /// <summary>
        /// Retorna los providers de loaders de provincias
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureItemKeyValueLoader<long, long, string>> GetLoaders()
        {
            return new List<IFixtureItemKeyValueLoader<long, long, string>>
            {
                new ProvinciasArgentinaLoader(paisesLoader),
                new ProvinciasUruguayLoader(paisesLoader),
            };
        }
    }
}
