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
        /// Cambia la entidad relacionada de la entidad destino mediante IEntityChanger.
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
        /// Cambia la entidad relacionada de la entidad destino mediante la accion indicada.
        /// Util cuando la entidad destino tiene mas de una navegacion al mismo tipo (por ejemplo TipoCambio y sus monedas).
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="request"></param>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeLink"></param>
        /// <param name="cambio"></param>
        /// <returns></returns>
        Task<HttpStatusCode> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, TTargetBeId targetBeKey, Uri relatedBeLink, Action<TTargetBe, TRelatedBe> cambio)
            where TTargetBe : DomainMember<TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>;
    }
}
