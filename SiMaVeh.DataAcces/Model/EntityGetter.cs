using SiMaVeh.DataAccess.Repository;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.Models;
using System;
using System.Threading.Tasks;

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
            //TODO - este metodo tiene un problema: que va a parar a una capa de DataAccess y usa el UriParser. Lo que hay que hacer es que en vez de recibir un link,
            //desde afuera (hay que ver algun metodo a nivel Api) se le pase una relatedKey ya procesada con el UriParser, que a fin de cuentas es de la capa de Api.
            TLinkBeId relatedKey = DataAccess.Model.UriParser.GetKeyFromUri<TLinkBeId>(
                EntityTypeGetter<TLinkBe, TLinkBeId>.GetCollectionNameAsString(), link);
            IRepository<TLinkBe, TLinkBeId> repo = new Repository<TLinkBe, TLinkBeId>(_context);
            TLinkBe result;

            try
            {
                result = await repo.Find(relatedKey);
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }
    }
}