using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base
{
    public abstract class PartidoFixtureGetter : IPartidoFixtureGetter
    {
        protected readonly IProvinciaFixtureGetter provinciaFixtureGetter;
        protected readonly IDatosEntidadBuilder datosEntidadBuilder;
        protected readonly IDictionary<long, List<DatosEntidad>> partidos;

        protected abstract void Initialize();

        public PartidoFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            this.provinciaFixtureGetter = provinciaFixtureGetter;
            partidos = new Dictionary<long, List<DatosEntidad>>();

            Initialize();
        }

        public DatosEntidad FindByNombre(string nombre)
        {
            return partidos
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Nombre == nombre);
        }

        public IDictionary<long, List<DatosEntidad>> Get()
        {
            return partidos;
        }
    }
}
