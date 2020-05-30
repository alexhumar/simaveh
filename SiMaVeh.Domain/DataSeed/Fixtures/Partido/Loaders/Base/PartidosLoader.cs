using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base
{
    abstract class PartidosLoader : IPartidosLoader
    {
        protected readonly IDictionary<long, IDictionary<long, string>> partidos;
        protected readonly IProvinciaFixtureGetter provinciasLoader;

        protected abstract void Initialize();

        public PartidosLoader(IProvinciaFixtureGetter provinciasLoader)
        {
            this.provinciasLoader = provinciasLoader;
            partidos = (IDictionary<long, IDictionary<long, string>>)new Dictionary<long, Dictionary<long, string>>();

            Initialize();
        }

        public KeyValuePair<long, string> FindByNombre(string nombre)
        {
            return partidos
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Value == nombre);
        }

        public IDictionary<long, IDictionary<long, string>> Get()
        {
            return partidos;
        }
    }
}
