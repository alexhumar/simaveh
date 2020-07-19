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
    /// RelatedEntityAdder
    /// </summary>
    internal class RelatedEntityAdder : IRelatedEntityAdder
    {
        private readonly SiMaVehContext context;
        private readonly IRelatedEntityGetter relatedEntityGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="relatedEntityGetter"></param>
        public RelatedEntityAdder(SiMaVehContext context,
            IRelatedEntityGetter relatedEntityGetter)
        {

            this.context = context;
            this.relatedEntityGetter = relatedEntityGetter;
        }

        /// <summary>
        /// TryAddRelatedEntityAsync
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="request"></param>
        /// <param name="link"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryAddRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, Uri link, TTargetBeId key)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            try
            {
                if ((link == null) || !HttpMethods.IsPost(request.Method))
                {
                    return HttpStatusCode.BadRequest;
                }

                var repositoryMainBe = new Repository<TTargetBe, TTargetBeId>(context);

                var mainBe = await repositoryMainBe.FindAsync(key);
                if (mainBe == null)
                {
                    return HttpStatusCode.NotFound;
                }

                var relatedBe = await relatedEntityGetter.TryGetEntityFromRelatedLink<TRelatedBe, TRelatedBeId>(link);
                if (relatedBe == null)
                {
                    return HttpStatusCode.NotFound;
                }

                mainBe.Agregar(relatedBe);

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
