using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de telefono
    /// </summary>
    public class TipoTelefonoSeeder : IDomainSeeder<TipoTelefono, long>
    {
        private readonly IFixtureTipoTelefono fixtureTipoTelefono;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureTipoTelefono"></param>
        public TipoTelefonoSeeder(IFixtureTipoTelefono fixtureTipoTelefono)
        {
            this.fixtureTipoTelefono = fixtureTipoTelefono;
        }

        /// <summary>
        /// Genera los tipos de telefono default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureTipoTelefono.GetTiposTelefono().Select(tipoTelefonoFixture => new
            {
                tipoTelefonoFixture.Id,
                tipoTelefonoFixture.Nombre,
                tipoTelefonoFixture.Descripcion
            });
        }
    }
}
