using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base
{
    abstract class ProvinciasLoader : IProvinciasLoader
    {
        protected readonly IDictionary<long, IDictionary<long, string>> provincias;
        protected readonly IPaisesLoader paisesLoader;

        protected abstract void Initialize();

        public ProvinciasLoader(IPaisesLoader paisesLoader)
        {
            this.paisesLoader = paisesLoader;
            provincias = (IDictionary<long, IDictionary<long, string>>)new Dictionary<long, Dictionary<long, string>>();

            Initialize();
        }

        public KeyValuePair<long, string> FindByNombre(string nombre)
        {
            return provincias
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Value == nombre);
        }

        public IDictionary<long, IDictionary<long, string>> Get()
        {
            return provincias;
        }
    }
}
