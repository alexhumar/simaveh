using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de categoria de marca
    /// </summary>
    public class CategoriaMarcaSeeder : IDomainSeeder<CategoriaMarca, long>
    {
        private readonly IFixtureCategoriaMarca fixtureCategoriaMarca;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureCategoriaMarca"></param>
        public CategoriaMarcaSeeder(IFixtureCategoriaMarca fixtureCategoriaMarca)
        {
            this.fixtureCategoriaMarca = fixtureCategoriaMarca;
        }

        /// <summary>
        /// Genera las categorias de marca default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureCategoriaMarca.GetCategoriasMarca().Select(categoriaMarcaFixture => new
            {
                categoriaMarcaFixture.Id,
                categoriaMarcaFixture.Nombre
            });
        }
    }
}
