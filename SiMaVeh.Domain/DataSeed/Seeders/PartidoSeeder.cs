using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de Partido
    /// </summary>
    public class PartidoSeeder : ISeeder<Partido, long>
    {
        private readonly IFixturePartido fixturePartido;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixturePartido"></param>
        public PartidoSeeder(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        /// <summary>
        /// Genera los Partidos default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var partidosPorProvincia in fixturePartido.GetPartidos())
            {
                var idProvincia = partidosPorProvincia.Key;

                foreach (var partido in partidosPorProvincia.Value)
                {
                    result.Add(new
                    {
                        partido.Id,
                        partido.Nombre,
                        ProvinciaId = idProvincia
                    });
                }
            }

            return result;
        }
    }
}
