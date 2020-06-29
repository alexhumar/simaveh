using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de marca
    /// </summary>
    public class MarcaSeeder : IDomainSeeder<Marca, long>
    {
        private readonly IFixtureMarca fixtureMarca;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureMarca"></param>
        public MarcaSeeder(IFixtureMarca fixtureMarca)
        {
            this.fixtureMarca = fixtureMarca;
        }

        /// <summary>
        /// Genera las marcas default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureMarca.GetMarcas().Select(marcaFixture => new
            {
                marcaFixture.Id,
                marcaFixture.Nombre
            });
        }
    }
}
