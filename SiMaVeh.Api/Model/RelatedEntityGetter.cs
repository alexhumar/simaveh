using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;
using System;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model
{
    /// <summary>
    /// RelatedEntityGetter
    /// </summary>
    public class RelatedEntityGetter : IRelatedEntityGetter
    {
        /// <summary>
        /// context
        /// </summary>
        private readonly SiMaVehContext context;

        public RelatedEntityGetter(SiMaVehContext context)
        {
            this.context = context;
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
            TLinkBeId relatedKey = Utils.UriParser
                .GetKeyFromUri<TLinkBeId>(EntityTypeGetter<TLinkBe, TLinkBeId>.GetCollectionNameAsString(), link);

            IRepository<TLinkBe, TLinkBeId> repo = new Repository<TLinkBe, TLinkBeId>(context);

            try
            {
                return await repo.FindAsync(relatedKey);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}