using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base
{
    abstract class ProvinciasLoader : IProvinciasLoader<long, long, string>
    {
        protected readonly Dictionary<long, Dictionary<long, string>> provincias;
        protected readonly IPaisesLoader<long, string> paisesLoader;

        protected abstract void Initialize();

        public ProvinciasLoader(IPaisesLoader<long, string> paisesLoader)
        {
            this.paisesLoader = paisesLoader;
            provincias = new Dictionary<long, Dictionary<long, string>>();

            Initialize();
        }

        public KeyValuePair<long, string> FindByNombre(string nombre)
        {
            return provincias
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Value == nombre);
        }

        public Dictionary<long, Dictionary<long, string>> Get()
        {
            return provincias;
        }
    }
}
