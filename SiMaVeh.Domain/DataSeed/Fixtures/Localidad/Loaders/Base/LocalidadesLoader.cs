using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base
{
    abstract class LocalidadesLoader : ILocalidadesLoader<long, long, string>
    {
        protected readonly Dictionary<long, Dictionary<long, string>> localidades;
        protected readonly IPartidosLoader<long, long, string> partidosLoader;

        protected abstract void Initialize();

        public LocalidadesLoader(IPartidosLoader<long, long, string> partidosLoader)
        {
            this.partidosLoader = partidosLoader;
            localidades = new Dictionary<long, Dictionary<long, string>>();

            Initialize();
        }

        public KeyValuePair<long, string> FindByNombre(string nombre)
        {
            return localidades
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Value == nombre);
        }

        public Dictionary<long, Dictionary<long, string>> Get()
        {
            return localidades;
        }
    }
}
