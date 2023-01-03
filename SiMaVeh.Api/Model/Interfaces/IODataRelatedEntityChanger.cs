using Microsoft.AspNetCore.Http;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model.Interfaces
{
    /// <summary>
    /// Interfaz de ODataRelatedEntityChanger
    /// </summary>
    public interface IODataRelatedEntityChanger
    {
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
        Task<HttpStatusCode> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId targetBeKey, Uri relatedBeLink)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>;

        /// <summary>
        /// TryChangeMonedaOrigenAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="tipoCambioKey"></param>
        /// <param name="monedaLink"></param>
        /// <returns></returns>
        Task<HttpStatusCode> TryChangeMonedaOrigenAsync(HttpRequest request, long tipoCambioKey, Uri monedaLink);

        /// <summary>
        /// TryChangeMonedaDestinoAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="tipoCambioKey"></param>
        /// <param name="monedaLink"></param>
        /// <returns></returns>
        Task<HttpStatusCode> TryChangeMonedaDestinoAsync(HttpRequest request, long tipoCambioKey, Uri monedaLink);
    }
}
