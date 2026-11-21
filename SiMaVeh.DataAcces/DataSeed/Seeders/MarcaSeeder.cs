using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de marca
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureMarca"></param>
    public class MarcaSeeder(IFixtureMarca fixtureMarca) : SeederBase<Marca>
    {
        private readonly IFixtureMarca fixtureMarca = fixtureMarca;

        /// <summary>
        /// Genera las marcas default
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<object> GetSeeds()
        {
            return fixtureMarca.GetMarcas().Select(marcaFixture => new
            {
                marcaFixture.Id,
                marcaFixture.Nombre
            });
        }
    }
}
