using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base
{
    abstract class LocalidadFixtureGetter : ILocalidadFixtureGetter
    {
        protected readonly IPartidoFixtureGetter partidoFixtureGetter;
        protected readonly DatosEntidadBuilder datosEntidadBuilder;
        protected readonly IDictionary<long, List<DatosEntidad>> localidades;

        protected abstract void Initialize();

        public LocalidadFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
        {
            this.partidoFixtureGetter = partidoFixtureGetter;
            datosEntidadBuilder = new DatosEntidadBuilder();
            localidades = new Dictionary<long, List<DatosEntidad>>();

            Initialize();
        }

        public DatosEntidad FindByNombre(string nombre)
        {
            return localidades
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Nombre == nombre);
        }

        public IDictionary<long, List<DatosEntidad>> Get()
        {
            return localidades;
        }
    }
}
