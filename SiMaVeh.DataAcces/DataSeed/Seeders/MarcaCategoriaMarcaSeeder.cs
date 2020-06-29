using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de relacion marca - categoria marca
    /// </summary>
    public class MarcaCategoriaMarcaSeeder : ISeeder<MarcaCategoriaMarca>
    {
        private readonly IFixtureMarca fixtureMarca;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureMarca"></param>
        public MarcaCategoriaMarcaSeeder(IFixtureMarca fixtureMarca)
        {
            this.fixtureMarca = fixtureMarca;
        }

        /// <summary>
        /// Genera las marcas default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureMarca.GetMarcas().SelectMany(marcaFixture => marcaFixture.Categorias.Select(categoria => new
            {
                CategoriaMarcaId = categoria.Id,
                MarcaId = marcaFixture.Id
            }));
        }
    }
}
