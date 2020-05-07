using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed
{
    /// <summary>
    /// Seeder de Provincia
    /// </summary>
    public class ProvinciaSeeder : ISeeder<Provincia>
    {
        /// <summary>
        /// Genera las Provincias default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Provincia> GetSeeds()
        {
            var result = new List<Provincia>
            {
                new Provincia { Id = 1, Nombre = "Buenos Aires", IdPais = 1 }
            };

            return result;
        }
    }
}
