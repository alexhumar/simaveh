using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.FixtureGetters
{
    class TipoEntidadReparadoraFixtureGetter : ITipoEntidadReparadoraFixtureGetter
    {
        private readonly DatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> tiposEntidadesReparadoras;

        public TipoEntidadReparadoraFixtureGetter()
        {
            datosEntidadBuilder = new DatosEntidadBuilder();
            tiposEntidadesReparadoras = new List<DatosEntidad>();

            Initialize();
        }

        public ICollection<DatosEntidad> Get()
        {
            return tiposEntidadesReparadoras;
        }

        private void Initialize()
        {
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(1,
                Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.MecanicoParticular, Constants.TiposEntidadReparadora.TipoEntidadReparadora.MecanicoParticular));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(2,
                Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.TallerMecanico, Constants.TiposEntidadReparadora.TipoEntidadReparadora.TallerMecanico));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(3,
                Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.EstacionDeServicio, Constants.TiposEntidadReparadora.TipoEntidadReparadora.EstacionDeServicio));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(4,
                Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.Lubricentro, Constants.TiposEntidadReparadora.TipoEntidadReparadora.Lubricentro));
            tiposEntidadesReparadoras.Add(datosEntidadBuilder.Build(5,
                Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.Hogar, Constants.TiposEntidadReparadora.TipoEntidadReparadora.Hogar));
        }
    }
}
