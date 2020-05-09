using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed
{
    /// <summary>
    /// Seeder de Provincia
    /// </summary>
    public class ProvinciaSeeder
    {
        /// <summary>
        /// Genera las Provincias default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Provincia> GetSeeds(IEnumerable<Pais> paises)
        {
            var result = new List<Provincia>();
            var argentina = paises.FirstOrDefault(p => p.Nombre == NombrePais.Argentina);

            //TODO - esto asi NO funciona. EFCore requiere que se le especifique el valor a la property PaisId
            //(ya sea porque esta en el modelo, o si es la property que crea a nivel interno)
            if (argentina != null)
            {
                var bsAs = new Provincia { Id = 1, Nombre = "Buenos Aires" };
                bsAs.Cambiar(argentina);
                var chaco = new Provincia { Id = 2, Nombre = "Chaco" };
                chaco.Cambiar(argentina);

                result.AddRange(new List<Provincia>{ bsAs, chaco });
            }

            return result;
        }
    }
}
