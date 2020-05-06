using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Interfaces
{
    /// <summary>
    /// Interfaz de Seeder
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISeeder<T>
    {
        /// <summary>
        /// Genera las entidades por default para el tipo parametrizado
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetSeeds();
    }
}
