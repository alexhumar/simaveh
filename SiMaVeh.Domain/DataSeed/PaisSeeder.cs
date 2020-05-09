using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed
{
    /// <summary>
    /// Seeder de Pais
    /// </summary>
    public class PaisSeeder
    {
        /// <summary>
        /// Genera los Paises default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Pais> GetSeeds()
        {
            var result = new List<Pais>
            {
                new Pais { Id = 1, Nombre = NombrePais.Argentina }
            };

            return result;
        }
    }
}
