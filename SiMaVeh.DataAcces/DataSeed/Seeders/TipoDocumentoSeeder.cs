using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de documento
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureTipoDocumento"></param>
    public class TipoDocumentoSeeder(IFixtureTipoDocumento fixtureTipoDocumento) : IDomainSeeder<TipoDocumento, long>
    {
        private readonly IFixtureTipoDocumento fixtureTipoDocumento = fixtureTipoDocumento;

        /// <summary>
        /// Genera los tipos de documento default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureTipoDocumento.GetTiposDocumento().Select(tipoDocumentoFixture => new
            {
                tipoDocumentoFixture.Id,
                tipoDocumentoFixture.Nombre,
                tipoDocumentoFixture.Descripcion
            });
        }
    }
}
