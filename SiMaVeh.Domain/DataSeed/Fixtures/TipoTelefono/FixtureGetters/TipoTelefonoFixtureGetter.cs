using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.FixtureGetters
{
    /// <summary>
    /// Fixture getter de tipo telefono
    /// </summary>
    internal class TipoTelefonoFixtureGetter : ITipoTelefonoFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> tiposTelefono;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public TipoTelefonoFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            tiposTelefono = new List<DatosEntidad>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosEntidad> Get()
        {
            return tiposTelefono;
        }

        private void Initialize()
        {
            tiposTelefono.Add(datosEntidadBuilder.Build(1,
                Constants.TiposTelefono.TipoTelefono.Casa, Constants.TiposTelefono.DescripcionTipoTelefono.Casa));
            tiposTelefono.Add(datosEntidadBuilder.Build(2,
                Constants.TiposTelefono.TipoTelefono.FaxLaboral, Constants.TiposTelefono.DescripcionTipoTelefono.FaxLaboral));
            tiposTelefono.Add(datosEntidadBuilder.Build(3,
                Constants.TiposTelefono.TipoTelefono.FaxPersonal, Constants.TiposTelefono.DescripcionTipoTelefono.FaxPersonal));
            tiposTelefono.Add(datosEntidadBuilder.Build(4,
                Constants.TiposTelefono.TipoTelefono.Localizador, Constants.TiposTelefono.DescripcionTipoTelefono.Localizador));
            tiposTelefono.Add(datosEntidadBuilder.Build(5,
                Constants.TiposTelefono.TipoTelefono.Movil, Constants.TiposTelefono.DescripcionTipoTelefono.Movil));
            tiposTelefono.Add(datosEntidadBuilder.Build(6,
                Constants.TiposTelefono.TipoTelefono.Trabajo, Constants.TiposTelefono.DescripcionTipoTelefono.Trabajo));
        }
    }
}
