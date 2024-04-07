using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de entidad reparadora
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureTipoEntidadReparadora"></param>
    public class TipoEntidadReparadoraSeeder(IFixtureTipoEntidadReparadora fixtureTipoEntidadReparadora) : IDomainSeeder<TipoEntidadReparadora, long>
    {
        private readonly IFixtureTipoEntidadReparadora fixtureTipoEntidadReparadora = fixtureTipoEntidadReparadora;

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
