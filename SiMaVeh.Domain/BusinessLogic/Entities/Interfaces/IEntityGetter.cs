using SiMaVeh.Domain.Models;
using System;
using System.Threading.Tasks;

namespace SiMaVeh.Domain.BusinessLogic.Entities.Interfaces
{
    /// <summary>
    /// IEntityGetter
    /// </summary>
    public interface IEntityGetter
    {
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