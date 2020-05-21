using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Provider de Loaders de Localidad
    /// </summary>
    public class LocalidadLoadersProvider : ILocalidadLoadersProvider
    {
        private readonly IFixturePartido fixturePartido;

        /// <summary>
        /// Constructor
        /// </summary>
        public LocalidadLoadersProvider()
        {
            fixturePartido = new FixturePartido();
        }

        /// <summary>
        /// Retorna los providers de loaders de localidades
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureItemKeyValueLoader<long, long, string>> GetLoaders()
        {
            return new List<IFixtureItemKeyValueLoader<long, long, string>>
            {
                //TODO: implementar
            };
        }
    }
}
