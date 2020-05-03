using System;
using System.Threading.Tasks;
using SiMaVeh.DataAccess;
using SiMaVeh.Domain.Models;
using SiMaVeh.Repository;

namespace SiMaVeh.Helpers
{
    /// <summary>
    /// EntityGetter
    /// </summary>
    public class EntityGetter : IEntityGetter
    {
        /// <summary>
        /// _context
        /// </summary>
        protected readonly SiMaVehContext _context;

        public EntityGetter(SiMaVehContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene una entidad a partir del link odata pasado como parametro
        /// </summary>
        /// <typeparam name="TLinkBe"></typeparam>
        /// <typeparam name="TLinkBeId"></typeparam>
        /// <param name="link"></param>
        /// <returns></returns>
        public async Task<TLinkBe> TryGetEntityFromRelatedLink<TLinkBe, TLinkBeId>(Uri link) where TLinkBe : DomainMember<TLinkBeId>
        {
            TLinkBeId relatedKey = Helpers.GetKeyFromUri<TLinkBeId>(
                EntityTypeGetter<TLinkBe, TLinkBeId>.GetCollectionNameAsString(), link);
            IRepository<TLinkBe, TLinkBeId> _repo = new Repository<TLinkBe, TLinkBeId>(_context);
            TLinkBe result;

            try
            {
                result = await _repo.Find(relatedKey);
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }
    }
}