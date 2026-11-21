using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Mentenimientos Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class MantenimientosController(IControllerParameter parameters, IRepository<Mantenimiento, long> repository) : GenericController<Mantenimiento, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene la accion del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Accion del mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAccion([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Accion);
        }

        /// <summary>
        /// Obtiene la moneda del monto del recambio del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Moneda del monto del recambio del mantenimiento</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMonedaMontoRecambio([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.MonedaMontoRecambio);
        }

        /// <summary>
        /// Obtiene el monto del recambio del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Monto del recambio del mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetMontoRecambio([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.MontoRecambio);
        }

        /// <summary>
        /// Obtiene el recambio del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Recambio del mantenimiento</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetRecambio([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Recambio);
        }

        /// <summary>
        /// Obtiene el reparador del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Reparador del mantenimiento</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetReparador([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Reparador);
        }

        /// <summary>
        /// Obtiene el servicio reparador del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Servicio reparador del mantenimiento</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetServicioReparador([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.ServicioReparador);
        }

        /// <summary>
        /// Modifica el tipo fuente energia asociado a la fuente energia.
        /// O modifica la marca asociada a la fuente energia.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var recambioTypeName = entityTypeGetter.GetTypeAsString<Recambio, long>();
            var servicioReparadorTypeName = entityTypeGetter.GetTypeAsString<ServicioReparador, long>();
            var reparadorTypeName = entityTypeGetter.GetTypeAsString<Reparador, long>();

            if (navigationProperty.Equals(recambioTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Mantenimiento, long, Recambio, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.MonedaMontoRecambio))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Mantenimiento, long, Moneda, string>(Request, key, link);
            }
            else if (navigationProperty.Equals(servicioReparadorTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Mantenimiento, long, ServicioReparador, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(reparadorTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Mantenimiento, long, Reparador, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}