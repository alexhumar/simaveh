using Microsoft.AspNetCore.Http;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.Api.Utils.Interfaces;
using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model
{
    /// <summary>
    /// ODataRelatedEntityAdder
    /// </summary>
    public class ODataRelatedEntityAdder : IODataRelatedEntityAdder
    {
        private readonly IUriParser uriParser;
        private readonly IRelatedEntityAdder relatedEntityAdder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uriParser"></param>
        /// <param name="relatedEntityAdder"></param>
        public ODataRelatedEntityAdder(IUriParser uriParser,
            IRelatedEntityAdder relatedEntityAdder)
        {
            this.uriParser = uriParser;
            this.relatedEntityAdder = relatedEntityAdder;
        }

        /// <summary>
        /// TryAddRelatedEntityAsync
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="request"></param>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeLink"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryAddRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId targetBeKey, Uri relatedBeLink)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            if ((relatedBeLink == null) || !HttpMethods.IsPost(request.Method))
            {
                return HttpStatusCode.BadRequest;
            }

            var relatedBeKey = uriParser.GetKeyFromRelatedEntityUri<TRelatedBeId>(relatedBeLink);
            var result = await relatedEntityAdder.TryAddRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(targetBeKey, relatedBeKey);

            return result ? HttpStatusCode.NoContent : HttpStatusCode.NotFound;
        }
    }
}
