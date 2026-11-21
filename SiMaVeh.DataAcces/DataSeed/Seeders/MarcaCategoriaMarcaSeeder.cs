using SiMaVeh.DataAccess.Model.Relations;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de relacion marca - categoria marca
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureMarca"></param>
    public class MarcaCategoriaMarcaSeeder(IFixtureMarca fixtureMarca) : SeederBase<MarcaCategoriaMarca>
    {
        private readonly IFixtureMarca fixtureMarca = fixtureMarca;

        /// <summary>
        /// Genera las marcas default
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<object> GetSeeds()
        {
            return fixtureMarca.GetMarcas().SelectMany(marcaFixture => marcaFixture.Categorias.Select(categoria => new
            {
                CategoriaMarcaId = categoria.Id,
                MarcaId = marcaFixture.Id
            }));
        }
    }
}
