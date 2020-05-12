using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures
{
    /// <summary>
    /// Fixture con informacion de Provincias
    /// </summary>
    public class FixtureProvincia : IFixtureProvincia
    {
        private readonly IFixturePais fixturePais;

        private Dictionary<long, Dictionary<long, string>> Provincias => new Dictionary<long, Dictionary<long, string>>()
        {
            {
                fixturePais.FindByNombre(NombrePais.Argentina).Value.Key, new Dictionary<long, string>
                {
                    { 1, NombreProvincia.BuenosAires },
                    { 2, NombreProvincia.Chaco }
                }
            }
        };

        /// <summary>
        /// Constructor
        /// </summary>
        public FixtureProvincia()
        {
            fixturePais = new FixturePais();
        }

        /// <summary>
        /// Get Provincias
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, Dictionary<long, string>> GetProvincias()
        {
            return Provincias;
        }
    }
}
