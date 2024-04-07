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
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureCategoriaMarca"></param>
    public class CategoriaMarcaSeeder(IFixtureCategoriaMarca fixtureCategoriaMarca) : IDomainSeeder<CategoriaMarca, long>
    {
        private readonly IFixtureCategoriaMarca fixtureCategoriaMarca = fixtureCategoriaMarca;

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
