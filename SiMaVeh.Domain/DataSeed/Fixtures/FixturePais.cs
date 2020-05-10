using SiMaVeh.Domain.DataSeed.Constants;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures
{
    /// <summary>
    /// Fixture con informacion de Paises
    /// </summary>
    public class FixturePais
    {
        /// <summary>
        /// Argentina
        /// </summary>
        public static readonly Dictionary<long, string> Paises = new Dictionary<long, string>()
        {
            { 1, NombrePais.Argentina },
            { 2, NombrePais.Uruguay }
        };

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static KeyValuePair<long, string>? FindByNombre(string nombre)
        {
            return Paises.FirstOrDefault(p => p.Value == nombre);
        }
    }
}
