using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de pais
    /// </summary>
    public class PaisSeeder : IDomainSeeder<Pais, long>
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
        /// Obtiene los seeds de pais
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixturePais.GetPaises().Select(paisFixture => new
            {
                paisFixture.Id,
                paisFixture.Nombre
            });
        }
    }
}
