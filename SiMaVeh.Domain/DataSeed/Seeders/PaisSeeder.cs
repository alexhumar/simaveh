using SiMaVeh.Domain.DataSeed.Fixtures.Pais;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de pais
    /// </summary>
    public class PaisSeeder : ISeeder<Pais, long>
    {
        private readonly IFixturePais fixturePais;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixturePais"></param>
        public PaisSeeder(IFixturePais fixturePais)
        {
            this.fixturePais = fixturePais;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PaisSeeder()
        {
            fixturePais = new FixturePais();
        }

        /// <summary>
        /// Obtiene los seeds de pais
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var paisFixture in fixturePais.GetPaises())
            {
                result.Add(new
                {
                    paisFixture.Id,
                    paisFixture.Nombre
                });
            }

            return result;
        }
    }
}
