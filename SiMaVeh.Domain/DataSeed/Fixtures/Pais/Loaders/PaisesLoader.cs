using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais.Loaders
{
    class PaisesLoader : IPaisesLoader
    {
        private readonly IDictionary<long, string> paises;

        public PaisesLoader()
        {
            paises = new Dictionary<long, string>();

            Initialize();
        }

        public IDictionary<long, string> Get()
        {
            return paises;
        }

        public KeyValuePair<long, string> FindByNombre(string nombre)
        {
            return paises.FirstOrDefault(p => p.Value == nombre);
        }

        private void Initialize()
        {
            paises.Add(1, Constants.Paises.Pais.Argentina);
            paises.Add(2, Constants.Paises.Pais.Uruguay);
        }
    }
}
