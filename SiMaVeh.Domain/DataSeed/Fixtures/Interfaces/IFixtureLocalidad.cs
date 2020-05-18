using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz de FixtureProvinciaLocalidad
    /// </summary>
    public interface IFixtureLocalidad
    {
        /// <summary>
        /// Get Localidades
        /// </summary>
        /// <returns></returns>
        Dictionary<long, Dictionary<long, string>> GetLocalidades();

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public KeyValuePair<long, string>? FindByNombre(string nombre);
    }
}
