using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Tipos Cambio Controller
    /// </summary>
    public class TiposCambioController : GenericController<TipoCambio, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public TiposCambioController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene el coeficiente de cambio del tipo de cambio
        /// </summary>
        /// <returns>Coeficiente de cambio del tipo de cambio</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCoeficienteCambio([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.CoeficienteCambio);
        }

        /// <summary>
        /// Obtiene la fecha del tipo de cambio
        /// </summary>
        /// <returns>Fecha del tipo de cambio</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetFecha([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Fecha);
        }

        /// <summary>
        /// Obtiene la moneda destino del tipo de cambio
        /// </summary>
        /// <returns>Moneda destino del tipo de cambio</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMonedaDestino([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.MonedaDestino);
        }

        /// <summary>
        /// Obtiene la moneda origen del tipo de cambio
        /// </summary>
        /// <returns>Moneda origen del tipo de cambio</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMonedaOrigen([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.MonedaOrigen);
        }

        /// <summary>
        /// Modifica la moneda origen asociada al tipo cambio.
        /// O modifica la moneda destino asociada al tipo cambio.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;

            if (navigationProperty.Equals(EntityProperty.MonedaOrigen))
            {
                resultado = await relatedEntityChanger.TryChangeMonedaOrigenAsync(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.MonedaDestino))
            {
                resultado = await relatedEntityChanger.TryChangeMonedaDestinoAsync(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}