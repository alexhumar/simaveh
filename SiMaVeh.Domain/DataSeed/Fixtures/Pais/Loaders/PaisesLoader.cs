using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class PaisesLoader : IPaisesLoader<long, string>
    {
        private readonly Dictionary<long, string> paises;

        public PaisesLoader()
        {
            paises = new Dictionary<long, string>();

            Initialize();
        }

        public Dictionary<long, string> Get()
        {
            return paises;
        }

        public KeyValuePair<long, string> FindByNombre(string nombre)
        {
            return paises.FirstOrDefault(p => p.Value == nombre);
        }

        private void Initialize()
        {
            paises.Add(1, Pais.Argentina);
            paises.Add(2, Pais.Uruguay);
        }
    }
}
