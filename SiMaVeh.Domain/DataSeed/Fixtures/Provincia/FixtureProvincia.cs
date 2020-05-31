using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia
{
    /// <summary>
    /// Fixture con informacion de provincias
    /// </summary>
    public class FixtureProvincia : IFixtureProvincia
    {
        private readonly IProvinciaFixtureGettersProvider provinciaFixtureGettersProvider;
        private IDictionary<long, List<DatosEntidad>> provincias;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="provinciaFixtureGettersProvider"></param>
        public FixtureProvincia(IProvinciaFixtureGettersProvider provinciaFixtureGettersProvider)
        {
            this.provinciaFixtureGettersProvider = provinciaFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Get provincias
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
