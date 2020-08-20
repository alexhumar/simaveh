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
    /// RelatedEntityChanger
    /// </summary>
    internal class RelatedEntityChanger : IRelatedEntityChanger
    {
        //TODO: mejorar la implementacion de estos metodos. Sobre todo los de tipo cambio.

        private readonly SiMaVehContext context;
        private readonly IRelatedEntityGetter relatedEntityGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="relatedEntityGetter"></param>
        public RelatedEntityChanger(SiMaVehContext context,
            IRelatedEntityGetter relatedEntityGetter)
        {

            this.context = context;
            this.relatedEntityGetter = relatedEntityGetter;
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

            var repositoryTargetBe = new Repository<TTargetBe, TTargetBeId>(context);

            var targetBe = await repositoryTargetBe.FindAsync(targetBeKey);
            if (targetBe == null)
            {
                return HttpStatusCode.NotFound;
            }

            var relatedBe = await relatedEntityGetter.TryGetEntityFromRelatedLink<TRelatedBe, TRelatedBeId>(relatedBeLink);
            if (relatedBe == null)
            {
                return HttpStatusCode.NotFound;
            }

            targetBe.Cambiar(relatedBe);

            await repositoryTargetBe.SaveChangesAsync();

            return HttpStatusCode.NoContent;
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

            var repositoryTipoCambio = new Repository<TipoCambio, long>(context);

            var tipoCambio = await repositoryTipoCambio.FindAsync(tipoCambioKey);
            if (tipoCambio == null)
            {
                return HttpStatusCode.NotFound;
            }

            var moneda = await relatedEntityGetter.TryGetEntityFromRelatedLink<Moneda, string>(monedaLink);
            if (moneda == null)
            {
                return HttpStatusCode.NotFound;
            }

            tipoCambio.CambiarMonedaOrigen(moneda);

            await repositoryTipoCambio.SaveChangesAsync();

            return HttpStatusCode.NoContent;
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

            var repositoryTipoCambio = new Repository<TipoCambio, long>(context);

            var tipoCambio = await repositoryTipoCambio.FindAsync(tipoCambioKey);
            if (tipoCambio == null)
            {
                return HttpStatusCode.NotFound;
            }

            var moneda = await relatedEntityGetter.TryGetEntityFromRelatedLink<Moneda, string>(monedaLink);
            if (moneda == null)
            {
                return HttpStatusCode.NotFound;
            }

            tipoCambio.CambiarMonedaDestino(moneda);

            await repositoryTipoCambio.SaveChangesAsync();

            return HttpStatusCode.NoContent;
        }
    }
}
