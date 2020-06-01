using SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de documento
    /// </summary>
    public class TipoDocumentoSeeder : ISeeder<TipoDocumento, long>
    {
        private readonly IFixtureTipoDocumento fixtureTipoDocumento;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureTipoDocumento"></param>
        public TipoDocumentoSeeder(IFixtureTipoDocumento fixtureTipoDocumento)
        {
            this.fixtureTipoDocumento = fixtureTipoDocumento;
        }

        /// <summary>
        /// Genera los tipos de documento default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var tipoDocumentoFixture in fixtureTipoDocumento.GetTiposDocumento())
            {
                result.Add(new
                {
                    tipoDocumentoFixture.Id,
                    tipoDocumentoFixture.Nombre,
                    tipoDocumentoFixture.Descripcion
                });
            }

            return result;
        }
    }
}
