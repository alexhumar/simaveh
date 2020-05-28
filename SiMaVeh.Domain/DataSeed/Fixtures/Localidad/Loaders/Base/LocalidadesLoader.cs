using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base
{
    abstract class LocalidadesLoader : ILocalidadesLoader
    {
        protected readonly IDictionary<long, IDictionary<long, string>> localidades;
        protected readonly IPartidosLoader partidosLoader;

        protected abstract void Initialize();

        public LocalidadesLoader(IPartidosLoader partidosLoader)
        {
            this.partidosLoader = partidosLoader;
            localidades = (IDictionary<long, IDictionary<long, string>>)new Dictionary<long, Dictionary<long, string>>();

            Initialize();
        }

        public KeyValuePair<long, string> FindByNombre(string nombre)
        {
            return localidades
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Value == nombre);
        }

        public IDictionary<long, IDictionary<long, string>> Get()
        {
            return localidades;
        }
    }
}
