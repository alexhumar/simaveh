using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.Api.Utils.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model
{
    /// <summary>
    /// RelatedEntityGetter
    /// </summary>
    internal class RelatedEntityGetter : IRelatedEntityGetter
    {
        /// <summary>
        /// context
        /// </summary>
        private readonly SiMaVehContext context;

        /// <summary>
        /// uriParser
        /// </summary>
        private readonly IUriParser uriParser;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="uriParser"></param>
        public RelatedEntityGetter(SiMaVehContext context,
            IUriParser uriParser)
        {
            this.context = context;
            this.uriParser = uriParser;
        }

        /// <summary>
        /// Obtiene una entidad a partir de la key pasada por parametro
        /// </summary>
        /// <typeparam name="TLinkBe"></typeparam>
        /// <typeparam name="TLinkBeId"></typeparam>
        /// <param name="link"></param>
        /// <returns></returns>
        public async Task<TLinkBe> TryGetEntityFromRelatedKey<TLinkBe, TLinkBeId>(TLinkBeId key) where TLinkBe : DomainMember<TLinkBeId>
        {
            try
            {
                var repository = new Repository<TLinkBe, TLinkBeId>(context);

                return await repository.FindAsync(key);
            }
            catch (Exception)
            {
                return null;
            }
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
            try
            {
                var key = uriParser.GetKeyFromRelatedEntityUri<TLinkBeId>(link);

                return await TryGetEntityFromRelatedKey<TLinkBe, TLinkBeId>(key);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}