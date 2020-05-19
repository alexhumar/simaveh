using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Fixture con informacion de Provincias
    /// </summary>
    public class FixturePartido : IFixturePartido
    {
        private readonly IFixtureItemKeyValueLoaderProvider<long, long, string> fixtureItemKeyValueLoaderProvider;
        private readonly Dictionary<long, Dictionary<long, string>> partidos;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixturePartido()
        {
            fixtureItemKeyValueLoaderProvider = new PartidoLoadersProvider();
            partidos = new Dictionary<long, Dictionary<long, string>>();

            Initialize();
        }

        /// <summary>
        /// Get Provincias
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, Dictionary<long, string>> GetPartidos()
        {
            return partidos;
        }

        private void Initialize()
        {
            foreach (var provider in fixtureItemKeyValueLoaderProvider.GetProviders())
            {
                provider.Add(partidos);
            }
        }
    }
}
