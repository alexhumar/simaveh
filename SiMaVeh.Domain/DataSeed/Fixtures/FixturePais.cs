using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures
{
    /// <summary>
    /// Fixture con informacion de Paises
    /// </summary>
    public class FixturePais : IFixturePais
    {
        private Dictionary<long, string> Paises => new Dictionary<long, string>()
        {
            { 1, Pais.Argentina },
            { 2, Pais.Uruguay }
        };

        /// <summary>
        /// Get Paises
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, string> GetPaises()
        {
            return Paises;
        }

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public KeyValuePair<long, string>? FindByNombre(string nombre)
        {
            return Paises.FirstOrDefault(p => p.Value == nombre);
        }
    }
}
