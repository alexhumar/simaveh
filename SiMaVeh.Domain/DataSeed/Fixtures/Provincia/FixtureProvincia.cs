using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia
{
    /// <summary>
    /// Fixture con informacion de Provincias
    /// </summary>
    public class FixtureProvincia : IFixtureProvincia
    {
        private readonly IProvinciaFixtureGettersProvider provinciaFixtureGettersProvider;
        private IDictionary<long, List<DatosEntidad>> provincias;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixtureProvincia()
        {
            provinciaFixtureGettersProvider = new ProvinciaFixtureGettersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Provincias
        /// </summary>
        /// <returns></returns>
        public IDictionary<long, List<DatosEntidad>> GetProvincias()
        {
            return provincias;
        }

        private void Initialize()
        {
            provincias = provinciaFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get())
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
