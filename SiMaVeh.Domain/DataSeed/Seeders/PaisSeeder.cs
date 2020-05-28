using SiMaVeh.Domain.DataSeed.Fixtures.Pais;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de Pais
    /// </summary>
    public class PaisSeeder : ISeeder<Pais, long>
    {
        private readonly IFixturePais fixturePais;

        /// <summary>
        /// Constructor
        /// </summary>
        public PaisSeeder()
        {
            fixturePais = new FixturePais();
        }

        /// <summary>
        /// Genera los Paises default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var paisFixture in fixturePais.GetPaises())
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
