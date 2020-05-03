using System;
using System.Threading.Tasks;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Helpers
{
    /// <summary>
    /// EntityGetter
    /// </summary>
    public interface IEntityGetter
    {
        Task<TLinkBe> TryGetEntityFromRelatedLink<TLinkBe, TLinkBeId>(Uri link) where TLinkBe : DomainMember<TLinkBeId>;
    }
}