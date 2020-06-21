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
        private IDictionary<long, List<DatosEntidad>> partidos;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="partidoFixtureGettersProvider"></param>
        public FixturePartido(IPartidoFixtureGettersProvider partidoFixtureGettersProvider)
        {
            this.partidoFixtureGettersProvider = partidoFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Get Partidos
        /// </summary>
        /// <returns></returns>
        public IDictionary<long, List<DatosEntidad>> GetPartidos()
        {
            return partidos;
        }

        private void Initialize()
        {
            partidos = partidoFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get())
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
