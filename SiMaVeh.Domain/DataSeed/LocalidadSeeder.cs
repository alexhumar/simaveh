using SiMaVeh.Domain.DataSeed.Fixtures;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed
{
    /// <summary>
    /// Seeder de Localidad
    /// </summary>
    public class LocalidadSeeder : ISeeder<Localidad, long>
    {
        private readonly IFixtureLocalidad fixtureLocalidad;

        /// <summary>
        /// Constructor
        /// </summary>
        public LocalidadSeeder()
        {
            fixtureLocalidad = new FixtureLocalidad();
        }

        /// <summary>
        /// Genera las Localidades default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var localidadesPorPartido in fixtureLocalidad.GetLocalidades())
            {
                var idPartido = localidadesPorPartido.Key;

                foreach (var localidad in localidadesPorPartido.Value)
                {
                    result.Add(new
                    {
                        Id = localidad.Key,
                        Nombre = localidad.Value,
                        CPA = string.Empty,
                        PartidoId = idPartido
                    });
                }
            }

            return result;
        }
    }
}
