using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento.FixtureGetters
{
    /// <summary>
    /// Fixture getter de tipo documento
    /// </summary>
    internal class TipoDocumentoFixtureGetter : ITipoDocumentoFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> tiposDocumento;

        /// <summary>
        /// Constructor
        /// </summary>
        public TipoDocumentoFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            tiposDocumento = new List<DatosEntidad>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosEntidad> Get()
        {
            return tiposDocumento;
        }

        private void Initialize()
        {
            tiposDocumento.Add(datosEntidadBuilder.Build(1,
                Constants.TiposDocumento.TipoDocumento.DNI, Constants.TiposDocumento.DescripcionTipoDocumento.DNI));
            tiposDocumento.Add(datosEntidadBuilder.Build(2,
                Constants.TiposDocumento.TipoDocumento.DocumentoViajeMercosur, Constants.TiposDocumento.DescripcionTipoDocumento.DocumentoViajeMercosur));
            tiposDocumento.Add(datosEntidadBuilder.Build(3,
                Constants.TiposDocumento.TipoDocumento.LibretaCivica, Constants.TiposDocumento.DescripcionTipoDocumento.LibretaCivica));
            tiposDocumento.Add(datosEntidadBuilder.Build(4,
                Constants.TiposDocumento.TipoDocumento.LibretaEnrolamiento, Constants.TiposDocumento.DescripcionTipoDocumento.LibretaEnrolamiento));
            tiposDocumento.Add(datosEntidadBuilder.Build(5,
                Constants.TiposDocumento.TipoDocumento.Pasaporte, Constants.TiposDocumento.DescripcionTipoDocumento.Pasaporte));
        }
    }
}
