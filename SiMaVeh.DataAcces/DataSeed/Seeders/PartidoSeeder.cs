using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de Partido
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixturePartido"></param>
    public class PartidoSeeder(IFixturePartido fixturePartido) : SeederBase<Partido>
    {
        private readonly IFixturePartido fixturePartido = fixturePartido;

        /// <summary>
        /// Genera los Partidos default
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var partidosPorProvincia in fixturePartido.GetPartidos())
            {
                var idProvincia = partidosPorProvincia.Key;
                result.AddRange(partidosPorProvincia.Value.Select(partido => new
                {
                    partido.Id,
                    partido.Nombre,
                    ProvinciaId = idProvincia
                }));
            }

            return result;
        }
    }
}
