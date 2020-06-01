using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.FixtureGetters
{
    /// <summary>
    /// Fixture getter de tipo entidad reparadora
    /// </summary>
    internal class TipoEntidadReparadoraFixtureGetter : ITipoEntidadReparadoraFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> tiposEntidadesReparadoras;

        /// <summary>
        /// Constructor
        /// </summary>
        public TipoEntidadReparadoraFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
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
                Constants.TiposEntidadReparadora.TipoEntidadReparadora.MecanicoParticular, Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.MecanicoParticular));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(2,
                Constants.TiposEntidadReparadora.TipoEntidadReparadora.TallerMecanico, Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.TallerMecanico));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(3,
                Constants.TiposEntidadReparadora.TipoEntidadReparadora.EstacionDeServicio, Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.EstacionDeServicio));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(4,
                Constants.TiposEntidadReparadora.TipoEntidadReparadora.Lubricentro, Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.Lubricentro));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(5,
                Constants.TiposEntidadReparadora.TipoEntidadReparadora.Hogar, Constants.TiposEntidadReparadora.DescripcionTipoEntidadReparadora.Hogar));
        }
    }
}
