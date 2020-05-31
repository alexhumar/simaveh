using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Base
{
    internal abstract class ProvinciaFixtureGetter : IProvinciaFixtureGetter
    {
        protected readonly IPaisFixtureGetter paisFixtureGetter;
        protected readonly IDatosEntidadBuilder datosEntidadBuilder;
        protected readonly IDictionary<long, List<DatosEntidad>> provincias;

        protected abstract void Initialize();

        public ProvinciaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPaisFixtureGetter paisFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            this.paisFixtureGetter = paisFixtureGetter;
            provincias = new Dictionary<long, List<DatosEntidad>>();

            Initialize();
        }

        public DatosEntidad FindByNombre(string nombre)
        {
            return provincias
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Nombre == nombre);
        }

        public IDictionary<long, List<DatosEntidad>> Get()
        {
            return provincias;
        }
    }
}
