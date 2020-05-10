using SiMaVeh.Domain.DataSeed.Constants;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures
{
    /// <summary>
    /// Fixture con informacion de Provincias
    /// </summary>
    public class FixtureProvincia
    {
        /// <summary>
        /// Argentina
        /// </summary>
        public static readonly Dictionary<long, Dictionary<long, string>> Provincias = new Dictionary<long, Dictionary<long, string>>()
        {
            {
                FixturePais.FindByNombre(NombrePais.Argentina).Value.Key, new Dictionary<long, string>
                {
                    { 1, NombreProvincia.BuenosAires },
                    { 2, NombreProvincia.Chaco }
                }
            }
        };
    }
}
