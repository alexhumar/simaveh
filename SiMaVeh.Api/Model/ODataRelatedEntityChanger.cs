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
    public class ODataRelatedEntityChanger : IODataRelatedEntityChanger
    {
        //TODO: mejorar la implementacion de estos metodos. Sobre todo los de tipo cambio.

        private readonly IUriParser uriParser;
        private readonly IRelatedEntityChanger relatedEntityChanger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uriParser"></param>
        /// <param name="relatedEntityChanger"></param>
        public ODataRelatedEntityChanger(IUriParser uriParser,
            IRelatedEntityChanger relatedEntityChanger)
        {
            this.uriParser = uriParser;
            this.relatedEntityChanger = relatedEntityChanger;
        }

        /// <summary>
        /// TryChangeRelatedEntity
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="request"></param>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeLink"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId targetBeKey, Uri relatedBeLink)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            if ((relatedBeLink == null) || !HttpMethods.IsPut(request.Method))
            {
                return HttpStatusCode.BadRequest;
            }

            var relatedBeKey = uriParser.GetKeyFromRelatedEntityUri<TRelatedBeId>(relatedBeLink);
            var result = await relatedEntityChanger.TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(targetBeKey, relatedBeKey);

            return result ? HttpStatusCode.NoContent : HttpStatusCode.NotFound;
        }

        /// <summary>
        /// TryChangeMonedaOrigenAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="tipoCambioKey"></param>
        /// <param name="monedaLink"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryChangeMonedaOrigenAsync(HttpRequest request, long tipoCambioKey, Uri monedaLink)
        {
            if (monedaLink == null || !HttpMethods.IsPut(request.Method))
            {
                return HttpStatusCode.BadRequest;
            }

            var monedaKey = uriParser.GetKeyFromRelatedEntityUri<string>(monedaLink);
            var result = await relatedEntityChanger.TryChangeMonedaOrigenAsync(tipoCambioKey, monedaKey);

            return result ? HttpStatusCode.NoContent : HttpStatusCode.NotFound;
        }

        /// <summary>
        /// TryChangeMonedaDestinoAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="tipoCambioKey"></param>
        /// <param name="monedaLink"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryChangeMonedaDestinoAsync(HttpRequest request, long tipoCambioKey, Uri monedaLink)
        {
            if (monedaLink == null || !HttpMethods.IsPut(request.Method))
            {
                return HttpStatusCode.BadRequest;
            }

            var monedaKey = uriParser.GetKeyFromRelatedEntityUri<string>(monedaLink);
            var result = await relatedEntityChanger.TryChangeMonedaDestinoAsync(tipoCambioKey, monedaKey);

            return result ? HttpStatusCode.NoContent : HttpStatusCode.NotFound;
        }
    }
}
