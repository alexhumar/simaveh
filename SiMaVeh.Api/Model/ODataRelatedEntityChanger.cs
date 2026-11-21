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
    /// ODataRelatedEntityChanger
    /// </summary>
    /// <param name="uriParser"></param>
    /// <param name="relatedEntityChanger"></param>
    public class ODataRelatedEntityChanger(IUriParser uriParser,
        IRelatedEntityChanger relatedEntityChanger) : IODataRelatedEntityChanger
    {
        private readonly IUriParser uriParser = uriParser;
        private readonly IRelatedEntityChanger relatedEntityChanger = relatedEntityChanger;

        /// <inheritdoc/>
        public Task<HttpStatusCode> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId targetBeKey, Uri relatedBeLink)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            return TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(request, targetBeKey, relatedBeLink,
                (targetBe, relatedBe) => targetBe.Cambiar(relatedBe));
        }

        /// <inheritdoc/>
        public async Task<HttpStatusCode> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId targetBeKey, Uri relatedBeLink, Action<TTargetBe, TRelatedBe> cambio)
            where TTargetBe : DomainMember<TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            if ((relatedBeLink == null) || !HttpMethods.IsPut(request.Method))
            {
                return HttpStatusCode.BadRequest;
            }

            var relatedBeKey = uriParser.GetKeyFromRelatedEntityUri<TRelatedBeId>(relatedBeLink);
            var result = await relatedEntityChanger.TryChangeRelatedEntityAsync(targetBeKey, relatedBeKey, cambio);

            return result ? HttpStatusCode.NoContent : HttpStatusCode.NotFound;
        }
    }
}
