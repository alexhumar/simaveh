using SiMaVeh.Domain.Models;
using System;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model.Interfaces
{
    /// <summary>
    /// Interfaz de RelatedEntityGetter
    /// </summary>
    public interface IRelatedEntityGetter
    {
        /// <summary>
        /// Obtiene una entidad a partir de la key pasada por parametro
        /// </summary>
        /// <typeparam name="TLinkBe"></typeparam>
        /// <typeparam name="TLinkBeId"></typeparam>
        /// <param name="link"></param>
        /// <returns></returns>
        Task<TLinkBe> TryGetEntityFromRelatedKey<TLinkBe, TLinkBeId>(TLinkBeId key) where TLinkBe : DomainMember<TLinkBeId>;

        /// <summary>
        /// TryGetEntityFromRelatedLink
        /// </summary>
        /// <typeparam name="TLinkBe"></typeparam>
        /// <typeparam name="TLinkBeId"></typeparam>
        /// <param name="link"></param>
        /// <returns></returns>
        Task<TLinkBe> TryGetEntityFromRelatedLink<TLinkBe, TLinkBeId>(Uri link) where TLinkBe : DomainMember<TLinkBeId>;
    }
}