using Microsoft.AspNetCore.Http;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model
{
    /// <summary>
    /// ODataRelatedEntityRemover
    /// </summary>
    public class ODataRelatedEntityRemover : IODataRelatedEntityRemover
    {
        private readonly IRelatedEntityRemover relatedEntityRemover;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="relatedEntityRemover"></param>
        public ODataRelatedEntityRemover(IRelatedEntityRemover relatedEntityRemover)
        {
            this.relatedEntityRemover = relatedEntityRemover;
        }

        /// <summary>
        /// TryRemoveRelatedEntityAsync
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="request"></param>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeKey"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId targetBeKey, TRelatedBeId relatedBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            if (!HttpMethods.IsDelete(request.Method))
            {
                return HttpStatusCode.BadRequest;
            }

            var result = await relatedEntityRemover.TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(targetBeKey, relatedBeKey);

            return result ? HttpStatusCode.NoContent : HttpStatusCode.NotFound;
        }

        /// <summary>
        /// TryRemoveRelatedEntityAsync
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="request"></param>
        /// <param name="link"></param>
        /// <param name="targetBeKey"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId targetBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            if (!HttpMethods.IsDelete(request.Method))
            {
                return HttpStatusCode.BadRequest;
            }

            var result = await relatedEntityRemover.TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(targetBeKey);

            return result ? HttpStatusCode.NoContent : HttpStatusCode.NotFound;
        }
    }
}
