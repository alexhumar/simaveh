using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Interfaces
{
    /// <summary>
    /// Interfaz de seeder de domain
    /// </summary>
    public interface IDomainSeeder<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        /// <summary>
        /// Obtiene los seeds de una entidad de domain determinada
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> GetSeeds();
    }
}
