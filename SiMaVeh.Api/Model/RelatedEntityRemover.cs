using Microsoft.AspNetCore.Http;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model
{
    /// <summary>
    /// RelatedEntityRemover
    /// </summary>
    internal class RelatedEntityRemover : IRelatedEntityRemover
    {
        private readonly SiMaVehContext context;
        private readonly IRelatedEntityGetter relatedEntityGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="relatedEntityGetter"></param>
        public RelatedEntityRemover(SiMaVehContext context,
            IRelatedEntityGetter relatedEntityGetter)
        {

            this.context = context;
            this.relatedEntityGetter = relatedEntityGetter;
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

            var repositoryTargetBe = new Repository<TTargetBe, TTargetBeId>(context);

            var targetBe = await repositoryTargetBe.FindAsync(targetBeKey);
            if (targetBe == null)
            {
                return HttpStatusCode.NotFound;
            }

            var relatedBe = await relatedEntityGetter.TryGetEntityFromRelatedKey<TRelatedBe, TRelatedBeId>(relatedBeKey);
            if (relatedBe == null)
            {
                return HttpStatusCode.NotFound;
            }

            targetBe.Quitar(relatedBe);

            await repositoryTargetBe.SaveChangesAsync();

            return HttpStatusCode.NoContent;
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

            var repositoryTargetBe = new Repository<TTargetBe, TTargetBeId>(context);

            var targetBe = await repositoryTargetBe.FindAsync(targetBeKey);
            if (targetBe == null)
            {
                return HttpStatusCode.NotFound;
            }

            targetBe.Cambiar(null);

            await repositoryTargetBe.SaveChangesAsync();

            return HttpStatusCode.NoContent;
        }
    }
}
