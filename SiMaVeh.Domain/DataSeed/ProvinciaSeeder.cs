using SiMaVeh.Domain.DataSeed.Fixtures;
using System.Collections.Generic;

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
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            //TODO - por limitaciones de EFCore en torno a DataSeed, y para no ensuciar el modelo con 
            //definiciones de FKs, se utilizan tipos anonimos para cargar las entidades y poder especificar la 
            //shadow property que EFCore utiliza a nivel interno. Seguir el tema para ver si en algun momento se soluciona.
            foreach (var provinciasPorPais in FixtureProvincia.Provincias)
            {
                var idPais = provinciasPorPais.Key;

                foreach (var provincia in provinciasPorPais.Value)
                {
                    result.Add(new
                    {
                        Id = provincia.Key,
                        Nombre = provincia.Value,
                        PaisId = idPais
                    });
                }
            }

            return result;
        }
    }
}
