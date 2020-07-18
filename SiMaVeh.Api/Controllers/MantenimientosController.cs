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
    /// Mentenimientos Controller
    /// </summary>
    public class MantenimientosController : GenericController<Mantenimiento, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public MantenimientosController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la accion del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Accion del mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAccion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Accion);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.MonedaMontoRecambio);
        }

        /// <summary>
        /// Obtiene el monto del recambio del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Monto del recambio del mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetMontoRecambio([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.MontoRecambio);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Recambio);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Reparador);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.ServicioReparador);
        }

        /// <summary>
        /// Modifica el tipo fuente energia asociado a la fuente energia.
        /// O modifica la marca asociada a la fuente energia.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs("POST", "PUT")]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            if (link == null)
            {
                return BadRequest();
            }

            var mantenimiento = await repository.FindAsync(key);
            if (mantenimiento == null)
            {
                return NotFound();
            }

            var recambioTypeName = entityTypeGetter.GetTypeAsString<Recambio, long>();
            var servicioReparadorTypeName = entityTypeGetter.GetTypeAsString<ServicioReparador, long>();
            var reparadorTypeName = entityTypeGetter.GetTypeAsString<Reparador, long>();

            if (navigationProperty.Equals(recambioTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                {
                    return BadRequest();
                }

                var recambio = await relatedEntityGetter.TryGetEntityFromRelatedLink<Recambio, long>(link);
                if (recambio == null)
                {
                    return NotFound();
                }

                mantenimiento.Cambiar(recambio);
            }
            else if (navigationProperty.Equals(EntityProperty.MonedaMontoRecambio))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                {
                    return BadRequest();
                }

                var moneda = await relatedEntityGetter.TryGetEntityFromRelatedLink<Moneda, string>(link);
                if (moneda == null)
                {
                    return NotFound();
                }

                mantenimiento.Cambiar(moneda);
            }
            else if (navigationProperty.Equals(servicioReparadorTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                {
                    return BadRequest();
                }

                var servicioReparador = await relatedEntityGetter.TryGetEntityFromRelatedLink<ServicioReparador, long>(link);
                if (servicioReparador == null)
                {
                    return NotFound();
                }

                mantenimiento.Cambiar(servicioReparador);
            }
            else if (navigationProperty.Equals(reparadorTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                {
                    return BadRequest();
                }

                var reparador = await relatedEntityGetter.TryGetEntityFromRelatedLink<Reparador, long>(link);
                if (reparador == null)
                {
                    return NotFound();
                }

                mantenimiento.Cambiar(reparador);
            }
            else
            {
                return StatusCode((int)HttpStatusCode.NotImplemented);
            }

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}