using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base
{
    abstract class PartidoFixtureGetter : IPartidoFixtureGetter
    {
        protected readonly IProvinciaFixtureGetter provinciaFixtureGetter;
        protected readonly DatosEntidadBuilder datosEntidadBuilder;
        protected readonly IDictionary<long, ICollection<DatosEntidad>> partidos;

        protected abstract void Initialize();

        public PartidoFixtureGetter(IProvinciaFixtureGetter provinciaFixtureGetter)
        {
            this.provinciaFixtureGetter = provinciaFixtureGetter;
            datosEntidadBuilder = new DatosEntidadBuilder();
            partidos = (IDictionary<long, ICollection<DatosEntidad>>)new Dictionary<long, List<DatosEntidad>>();

            Initialize();
        }

        public DatosEntidad FindByNombre(string nombre)
        {
            return partidos
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Nombre == nombre);
        }

        public IDictionary<long, ICollection<DatosEntidad>> Get()
        {
            return partidos;
        }
    }
}
