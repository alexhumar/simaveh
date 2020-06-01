using SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento
{
    /// <summary>
    /// Fixture con informacion de tipos de documento
    /// </summary>
    public class FixtureTipoDocumento : IFixtureTipoDocumento
    {
        private readonly ITipoDocumentoFixtureGettersProvider tipoDocumentoFixtureGettersProvider;
        private IEnumerable<DatosEntidad> tiposDocumento;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tipoDocumentoFixtureGettersProvider"></param>
        public FixtureTipoDocumento(ITipoDocumentoFixtureGettersProvider tipoDocumentoFixtureGettersProvider)
        {
            this.tipoDocumentoFixtureGettersProvider = tipoDocumentoFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Get Tipos Documento
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosEntidad> GetTiposDocumento()
        {
            return tiposDocumento;
        }

        private void Initialize()
        {
            tiposDocumento = tipoDocumentoFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
