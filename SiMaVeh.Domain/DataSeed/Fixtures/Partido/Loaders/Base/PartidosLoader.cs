using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base
{
    abstract class PartidosLoader : IPartidosLoader<long, long, string>
    {
        protected readonly Dictionary<long, Dictionary<long, string>> partidos;
        protected readonly IProvinciasLoader<long, long, string> provinciasLoader;

        protected abstract void Initialize();

        public PartidosLoader(IProvinciasLoader<long, long, string> provinciasLoader)
        {
            this.provinciasLoader = provinciasLoader;
            partidos = new Dictionary<long, Dictionary<long, string>>();

            Initialize();
        }

        public KeyValuePair<long, string> FindByNombre(string nombre)
        {
            return partidos
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Value == nombre);
        }

        public Dictionary<long, Dictionary<long, string>> Get()
        {
            return partidos;
        }
    }
}
