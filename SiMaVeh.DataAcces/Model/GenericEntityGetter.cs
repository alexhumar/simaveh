using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model
{
    /// <summary>
    /// GenericEntityGetter
    /// </summary>
    public class GenericEntityGetter : IGenericEntityGetter
    {
        /// <summary>
        /// context
        /// </summary>
        private readonly SiMaVehContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="uriParser"></param>
        public GenericEntityGetter(SiMaVehContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Obtiene una entidad a partir de la key pasada por parametro
        /// </summary>
        /// <typeparam name="TBe"></typeparam>
        /// <typeparam name="TBeId"></typeparam>
        /// <param name="link"></param>
        /// <returns></returns>
        public async Task<TBe> TryGetEntity<TBe, TBeId>(TBeId key) where TBe : DomainMember<TBeId>
        {
            var repository = new Repository<TBe, TBeId>(context);

            return await repository.FindAsync(key);
        }
    }
}