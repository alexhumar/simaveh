using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures
{
    /// <summary>
    /// Fixture con informacion de Paises
    /// </summary>
    public class FixturePais : IFixturePais
    {
        private readonly IPaisLoadersProvider paisLoadersProvider;
        private Dictionary<long, string> paises;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixturePais()
        {
            paisLoadersProvider = new PaisLoadersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Paises
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, string> GetPaises()
        {
            return paises;
        }

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public KeyValuePair<long, string>? FindByNombre(string nombre)
        {
            return paises.FirstOrDefault(p => p.Value == nombre);
        }

        private void Initialize()
        {
            paises = paisLoadersProvider
                .GetLoaders()
                .SelectMany(l => l.Get())
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
