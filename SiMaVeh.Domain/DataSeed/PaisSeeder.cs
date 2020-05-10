using SiMaVeh.Domain.DataSeed.Fixtures;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed
{
    /// <summary>
    /// Seeder de Pais
    /// </summary>
    public class PaisSeeder
    {
        /// <summary>
        /// Genera los Paises default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var paisFixture in FixturePais.Paises)
            {
                result.Add(new
                {
                    Id = paisFixture.Key,
                    Nombre = paisFixture.Value
                });
            }

            return result;
        }
    }
}
