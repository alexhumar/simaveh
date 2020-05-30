using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Fixture con informacion de Partidos
    /// </summary>
    public class FixturePartido : IFixturePartido
    {
        private readonly IPartidoFixtureGettersProvider partidoFixtureGettersProvider;
        private IDictionary<long, IEnumerable<DatosEntidad>> partidos;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixturePartido()
        {
            partidoFixtureGettersProvider = new PartidoFixtureGettersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Partidos
        /// </summary>
        /// <returns></returns>
        public IDictionary<long, IEnumerable<DatosEntidad>> GetPartidos()
        {
            return partidos;
        }

        private void Initialize()
        {
            partidos = (IDictionary<long, IEnumerable<DatosEntidad>>)partidoFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get())
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
