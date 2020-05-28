using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais
{
    /// <summary>
    /// Fixture con informacion de Paises
    /// </summary>
    public class FixturePais : IFixturePais
    {
        private readonly IPaisLoadersProvider paisLoadersProvider;
        private IDictionary<long, string> paises;

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
        public IDictionary<long, string> GetPaises()
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
