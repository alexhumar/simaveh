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
        protected readonly IDictionary<long, ICollection<DatosEntidad>> localidades;

        protected abstract void Initialize();

        public LocalidadFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
        {
            this.partidoFixtureGetter = partidoFixtureGetter;
            localidades = (IDictionary<long, ICollection<DatosEntidad>>)new Dictionary<long, List<DatosEntidad>>();

            Initialize();
        }

        public DatosEntidad FindByNombre(string nombre)
        {
            return localidades
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Nombre == nombre);
        }

        public IDictionary<long, ICollection<DatosEntidad>> Get()
        {
            return localidades;
        }
    }
}
