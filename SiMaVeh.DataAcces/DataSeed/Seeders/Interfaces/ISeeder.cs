using System.Collections.Generic;

namespace SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces
{
    /// <summary>
    /// Interfaz de seeder
    /// </summary>
    public interface ISeeder<TBe>
    {
        /// <summary>
        /// Obtiene los seeds de una entidad determinada
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> GetSeeds();
    }
}
