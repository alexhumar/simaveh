using Microsoft.AspNetCore.Http;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model.Interfaces
{
    /// <summary>
    /// Interfaz de RelatedEntityChanger
    /// </summary>
    public interface IRelatedEntityChanger
    {
        /// <summary>
        /// TryChangeRelatedEntity
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="request"></param>
        /// <param name="link"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<HttpStatusCode> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, Uri link, TTargetBeId key)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>;

        /// <summary>
        /// TryChangeMonedaOrigenAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="link"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<HttpStatusCode> TryChangeMonedaOrigenAsync(HttpRequest request, Uri link, long key);

        /// <summary>
        /// TryChangeMonedaDestinoAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="link"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<HttpStatusCode> TryChangeMonedaDestinoAsync(HttpRequest request, Uri link, long key);
    }
}
