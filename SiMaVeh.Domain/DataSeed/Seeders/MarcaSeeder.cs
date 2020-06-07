using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de marca
    /// </summary>
    public class MarcaSeeder : ISeeder<Marca, long>
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
            var result = new List<object>();

            foreach (var marcaFixture in fixtureMarca.GetMarcas())
            {
                result.Add(new
                {
                    marcaFixture.Id,
                    marcaFixture.Nombre,
                    marcaFixture.Categoria
                });
            }

            return result;
        }
    }
}
