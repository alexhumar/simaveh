using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Interfaces
{
    /// <summary>
    /// Interfaz de seeder
    /// </summary>
    public interface ISeeder<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        /// <summary>
        /// Obtiene los seeds para determinadas entidades.
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> GetSeeds();
    }
}
