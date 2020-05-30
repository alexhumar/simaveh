using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.FixtureGetters
{
    /// <summary>
    /// Fixture Getter de Tipo Entidad Reparadora
    /// </summary>
    public class TipoEntidadReparadoraFixtureGetter : ITipoEntidadReparadoraFixtureGetter
    {
        private readonly DatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> tiposEntidadesReparadoras;

        /// <summary>
        /// Constructor
        /// </summary>
        public TipoEntidadReparadoraFixtureGetter()
        {
            datosEntidadBuilder = new DatosEntidadBuilder();
            tiposEntidadesReparadoras = new List<DatosEntidad>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosEntidad> Get()
        {
            return tiposEntidadesReparadoras;
        }

        private void Initialize()
        {
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(1,
                Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.MecanicoParticular, Constants.TiposEntidadReparadora.TipoEntidadReparadora.MecanicoParticular));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(2,
                Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.TallerMecanico, Constants.TiposEntidadReparadora.TipoEntidadReparadora.TallerMecanico));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(3,
                Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.EstacionDeServicio, Constants.TiposEntidadReparadora.TipoEntidadReparadora.EstacionDeServicio));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(4,
                Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.Lubricentro, Constants.TiposEntidadReparadora.TipoEntidadReparadora.Lubricentro));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(5,
                Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.Hogar, Constants.TiposEntidadReparadora.TipoEntidadReparadora.Hogar));
        }
    }
}
