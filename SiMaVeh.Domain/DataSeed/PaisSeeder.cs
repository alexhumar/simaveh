using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed
{
    /// <summary>
    /// Seeder de Pais
    /// </summary>
    public class PaisSeeder : ISeeder<Pais>
    {
        /// <summary>
        /// Genera los Paises default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Pais> GetSeeds()
        {
            var result = new List<Pais>
            {
                new Pais { Id = 1, Nombre = "Argentina" }
            };

            return result;
        }
    }
}
