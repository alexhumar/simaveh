using Microsoft.AspNetCore.Http;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System;
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
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId key, TRelatedBeId relatedKey)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            try
            {
                if (!HttpMethods.IsDelete(request.Method))
                {
                    return HttpStatusCode.BadRequest;
                }

                var repositoryMainBe = new Repository<TTargetBe, TTargetBeId>(context);

                var mainBe = await repositoryMainBe.FindAsync(key);
                if (mainBe == null)
                {
                    return HttpStatusCode.NotFound;
                }

                var relatedBe = await relatedEntityGetter.TryGetEntityFromRelatedKey<TRelatedBe, TRelatedBeId>(relatedKey);
                if (relatedBe == null)
                {
                    return HttpStatusCode.NotFound;
                }

                mainBe.Quitar(relatedBe);

                await repositoryMainBe.SaveChangesAsync();

                return HttpStatusCode.NoContent;
            }
            catch (Exception)
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
