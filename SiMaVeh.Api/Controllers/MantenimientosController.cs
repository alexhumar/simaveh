using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Domain.Models;
using SiMaVeh.Helpers;
using SiMaVeh.HelpersHttpConstants;
using SiMaVeh.Parametrization;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Mentenimientos Controller
    /// </summary>
    public class MantenimientosController : GenericController<Mantenimiento, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MantenimientosController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la accion del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Accion del mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAccion([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Accion);
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
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.MonedaMontoRecambio);
        }

        /// <summary>
        /// Obtiene el monto del recambio del mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Monto del recambio del mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetMontoRecambio([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.MontoRecambio);
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
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Recambio);
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
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Reparador);
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
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.ServicioReparador);
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
        public async Task<IActionResult> CreateRef([FromODataUri] long key,
        string navigationProperty, [FromBody] Uri link)
        {
            if (link == null)
                return BadRequest();

            var mantenimiento = await _repository.Find(key);
            if (mantenimiento == null)
                return NotFound();
            
            var recambioTypeName = EntityTypeGetter<Recambio, long>.GetTypeAsString();
            var servicioReparadorTypeName = EntityTypeGetter<ServicioReparador, long>.GetTypeAsString();
            var reparadorTypeName = EntityTypeGetter<Reparador, long>.GetTypeAsString();

            if (navigationProperty.Equals(recambioTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var recambio = await _entityGetter.TryGetEntityFromRelatedLink<Recambio, long>(link);
                if (recambio == null)
                    return NotFound();

                mantenimiento.Cambiar(recambio);
            }
            else if (navigationProperty.Equals(PropertyConstants.MonedaMontoRecambio))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var moneda = await _entityGetter.TryGetEntityFromRelatedLink<Moneda, long>(link);
                if (moneda == null)
                    return NotFound();

                mantenimiento.Cambiar(moneda);
            }
            else if (navigationProperty.Equals(servicioReparadorTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var servicioReparador = await _entityGetter.TryGetEntityFromRelatedLink<ServicioReparador, long>(link);
                if (servicioReparador == null)
                    return NotFound();

                mantenimiento.Cambiar(servicioReparador);
            }
            else if (navigationProperty.Equals(reparadorTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var reparador = await _entityGetter.TryGetEntityFromRelatedLink<Reparador, long>(link);
                if (reparador == null)
                    return NotFound();

                mantenimiento.Cambiar(reparador);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}