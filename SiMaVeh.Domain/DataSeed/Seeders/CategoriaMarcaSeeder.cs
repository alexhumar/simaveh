using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de categoria de marca
    /// </summary>
    public class CategoriaMarcaSeeder : ISeeder<CategoriaMarca, long>
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
            var result = new List<object>();

            foreach (var categoriaMarcaFixture in fixtureCategoriaMarca.GetCategoriasMarca())
            {
                result.Add(new
                {
                    categoriaMarcaFixture.Id,
                    categoriaMarcaFixture.Nombre
                });
            }

            return result;
        }
    }
}
