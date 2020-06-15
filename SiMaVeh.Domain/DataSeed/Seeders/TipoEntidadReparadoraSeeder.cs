using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de entidad reparadora
    /// </summary>
    public class TipoEntidadReparadoraSeeder : IDomainSeeder<TipoEntidadReparadora, long>
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
            return fixtureTipoEntidadReparadora.GetTiposEntidadReparadora().Select(tipoEntidadReparadoraFixture => new
            {
                tipoEntidadReparadoraFixture.Id,
                tipoEntidadReparadoraFixture.Nombre,
                tipoEntidadReparadoraFixture.Descripcion
            });
        }
    }
}
