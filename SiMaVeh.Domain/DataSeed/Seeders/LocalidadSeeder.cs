using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de localidad
    /// </summary>
    public class LocalidadSeeder : ISeeder<Localidad, long>
    {
        private readonly IFixtureLocalidad fixtureLocalidad;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureLocalidad"></param>
        public LocalidadSeeder(IFixtureLocalidad fixtureLocalidad)
        {
            this.fixtureLocalidad = fixtureLocalidad;
        }

        /// <summary>
        /// Genera las localidades default
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
                        localidad.Id,
                        localidad.Nombre,
                        CPA = string.Empty,
                        PartidoId = idPartido
                    });
                }
            }

            return result;
        }
    }
}
