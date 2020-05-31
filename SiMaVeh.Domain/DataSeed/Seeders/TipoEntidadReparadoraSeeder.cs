using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de entidad reparadora
    /// </summary>
    public class TipoEntidadReparadoraSeeder : ISeeder<TipoEntidadReparadora, long>
    {
        private readonly IFixtureTipoEntidadReparadora fixtureTipoEntidadReparadora;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureTipoEntidadReparadora"></param>
        public TipoEntidadReparadoraSeeder(IFixtureTipoEntidadReparadora fixtureTipoEntidadReparadora)
        {
            this.fixtureTipoEntidadReparadora = fixtureTipoEntidadReparadora;
        }

        /// <summary>
        /// Genera los tipos de entidad reparadora default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var tipoEntidadReparadoraFixture in fixtureTipoEntidadReparadora.GetTiposEntidadReparadora())
            {
                result.Add(new
                {
                    tipoEntidadReparadoraFixture.Id,
                    tipoEntidadReparadoraFixture.Nombre,
                    tipoEntidadReparadoraFixture.Descripcion
                });
            }

            return result;
        }
    }
}
