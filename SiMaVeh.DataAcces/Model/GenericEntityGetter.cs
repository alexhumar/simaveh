using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model
{
    /// <summary>
    /// GenericEntityGetter
    /// </summary>
    /// <param name="context"></param>
    public class GenericEntityGetter(SiMaVehContext context) : IGenericEntityGetter
    {
        private readonly SiMaVehContext context = context;

        /// <summary>
        /// Obtiene una entidad a partir de la key pasada por parametro
        /// </summary>
        /// <typeparam name="TBe"></typeparam>
        /// <typeparam name="TBeId"></typeparam>
        /// <param name="key"></param>
        /// <returns>La entidad o null</returns>
        public async Task<TBe> TryGetEntity<TBe, TBeId>(TBeId key) where TBe : DomainMember<TBeId>
        {
            return await context.Set<TBe>().FindAsync(key);
        }
    }
}
