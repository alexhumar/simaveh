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
        /// <param name="link"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, Uri link, TTargetBeId key)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            try
            {
                if ((link == null) || !HttpMethods.IsPut(request.Method))
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

                mainBe.Cambiar(relatedBe);

                await repositoryMainBe.SaveChangesAsync();

                return HttpStatusCode.NoContent;
            }
            catch (Exception)
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        /// <summary>
        /// TryChangeMonedaOrigenAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="link"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryChangeMonedaOrigenAsync(HttpRequest request, Uri link, long key)
        {
            try
            {
                if (link == null || !HttpMethods.IsPut(request.Method))
                {
                    return HttpStatusCode.BadRequest;
                }

                var repositoryTipoCambio = new Repository<TipoCambio, long>(context);

                var tipoCambio = await repositoryTipoCambio.FindAsync(key);
                if (tipoCambio == null)
                {
                    return HttpStatusCode.NotFound;
                }

                var moneda = await relatedEntityGetter.TryGetEntityFromRelatedLink<Moneda, string>(link);
                if (moneda == null)
                {
                    return HttpStatusCode.NotFound;
                }

                tipoCambio.CambiarMonedaOrigen(moneda);

                await repositoryTipoCambio.SaveChangesAsync();

                return HttpStatusCode.NoContent;
            }
            catch (Exception)
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        /// <summary>
        /// TryChangeMonedaDestinoAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="link"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> TryChangeMonedaDestinoAsync(HttpRequest request, Uri link, long key)
        {
            try
            {
                if (link == null || !HttpMethods.IsPut(request.Method))
                {
                    return HttpStatusCode.BadRequest;
                }

                var repositoryTipoCambio = new Repository<TipoCambio, long>(context);

                var tipoCambio = await repositoryTipoCambio.FindAsync(key);
                if (tipoCambio == null)
                {
                    return HttpStatusCode.NotFound;
                }

                var moneda = await relatedEntityGetter.TryGetEntityFromRelatedLink<Moneda, string>(link);
                if (moneda == null)
                {
                    return HttpStatusCode.NotFound;
                }

                tipoCambio.CambiarMonedaDestino(moneda);

                await repositoryTipoCambio.SaveChangesAsync();

                return HttpStatusCode.NoContent;
            }
            catch (Exception)
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
