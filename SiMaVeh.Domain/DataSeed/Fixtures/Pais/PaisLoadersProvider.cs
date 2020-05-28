using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Loaders;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais
{
    /// <summary>
    /// Provider de Loaders de Pais
    /// </summary>
    public class PaisLoadersProvider : IPaisLoadersProvider
    {
        /// <summary>
        /// Retorna los providers de loaders de paises
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureKeyValueLoader<long, string>> GetLoaders()
        {
            return new List<IFixtureKeyValueLoader<long, string>>
            {
                new PaisesLoader()
            };
        }
    }
}
