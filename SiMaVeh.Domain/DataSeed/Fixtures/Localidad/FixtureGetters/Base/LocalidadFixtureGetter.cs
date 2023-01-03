using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base
{
    public abstract class LocalidadFixtureGetter : ILocalidadFixtureGetter
    {
        protected readonly IPartidoFixtureGetter partidoFixtureGetter;
        protected readonly IDatosEntidadBuilder datosEntidadBuilder;
        protected readonly IDictionary<long, List<DatosEntidad>> localidades;

        protected abstract void Initialize();

        public LocalidadFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
        {
            this.partidoFixtureGetter = partidoFixtureGetter;
            this.datosEntidadBuilder = datosEntidadBuilder;
            localidades = new Dictionary<long, List<DatosEntidad>>();

            Initialize();
        }

        public IDictionary<long, List<DatosEntidad>> Get()
        {
            return localidades;
        }
    }
}
