using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures
{
    /// <summary>
    /// Fixture con informacion de Localidades
    /// </summary>
    public class FixtureLocalidad : IFixtureLocalidad
    {
        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public KeyValuePair<long, string>? FindByNombre(string nombre)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Get Localidades
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, Dictionary<long, string>> GetLocalidades()
        {
            throw new System.NotImplementedException();
        }
    }
}
