using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia
{
    /// <summary>
    /// Fixture con informacion de Provincias
    /// </summary>
    public class FixtureProvincia : IFixtureProvincia
    {
        private readonly IProvinciaLoadersProvider provinciaLoadersProvider;
        private Dictionary<long, Dictionary<long, string>> provincias;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixtureProvincia()
        {
            provinciaLoadersProvider = new ProvinciaLoadersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Provincias
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, Dictionary<long, string>> GetProvincias()
        {
            return provincias;
        }

        private void Initialize()
        {
            provincias = provinciaLoadersProvider
                .GetLoaders()
                .SelectMany(l => l.Get())
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
