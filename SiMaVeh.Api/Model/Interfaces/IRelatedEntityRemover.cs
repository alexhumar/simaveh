using Microsoft.AspNetCore.Http;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model.Interfaces
{
    /// <summary>
    /// Interfaz de RelatedEntityRemover
    /// </summary>
    public interface IRelatedEntityRemover
    {
        /// <summary>
        /// TryRemoveRelatedEntityAsync
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="request"></param>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <returns></returns>
        Task<HttpStatusCode> TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId key, TRelatedBeId relatedKey)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>;
    }
}
