using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Base
{
    abstract class ProvinciaFixtureGetter : IProvinciaFixtureGetter
    {
        protected readonly IPaisFixtureGetter paisFixtureGetter;
        protected readonly DatosEntidadBuilder datosEntidadBuilder;
        protected readonly IDictionary<long, ICollection<DatosEntidad>> provincias;

        protected abstract void Initialize();

        public ProvinciaFixtureGetter(IPaisFixtureGetter paisFixtureGetter)
        {
            this.paisFixtureGetter = paisFixtureGetter;
            datosEntidadBuilder = new DatosEntidadBuilder();
            provincias = (IDictionary<long, ICollection<DatosEntidad>>)new Dictionary<long, List<DatosEntidad>>();

            Initialize();
        }

        public DatosEntidad FindByNombre(string nombre)
        {
            return provincias
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Nombre == nombre);
        }

        public IDictionary<long, ICollection<DatosEntidad>> Get()
        {
            return provincias;
        }
    }
}
