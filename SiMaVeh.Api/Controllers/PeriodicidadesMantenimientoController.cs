using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Periodicidades Mantenimiento Controller
    /// </summary>
    public class PeriodicidadesMantenimientoController : GenericController<PeriodicidadMantenimiento, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PeriodicidadesMantenimientoController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene los anios de la periodicidad mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Anios de la periodicidad mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAnios([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Anios);
        }

        /// <summary>
        /// Obtiene los dias de la periodicidad mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Dias de la periodicidad mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDias([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Dias);
        }

        /// <summary>
        /// Obtiene si la periodicidad mantenimiento es default
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si la periodicidad mantenimiento es default</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetEsDefault([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.EsDefault);
        }

        /// <summary>
        /// Obtiene los kilometros de la periodicidad mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Kilometros de la periodicidad mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetKilometros([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Kilometros);
        }

        /// <summary>
        /// Obtiene los meses de la periodicidad mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Meses de la periodicidad mantenimiento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetMeses([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Meses);
        }

        /// <summary>
        /// Obtiene el modelo vehiculo de la periodicidad mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Modelo vehiculo de la periodicidad mantenimiento</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetModeloVehiculo([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.ModeloVehiculo);
        }

        /// <summary>
        /// Obtiene el repuesto de la periodicidad mantenimiento
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Repuesto de la periodicidad mantenimiento</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTargetMantenimiento([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.TargetMantenimiento);
        }

        /// <summary>
        /// Modifica el modelo vehiculo asociado a la periodicidad mantenimiento.
        /// O modifica el repuesto asociado a la periodicidad mantenimiento.
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

            var periodicidadMantenimiento = await repository.Find(key);
            if (periodicidadMantenimiento == null)
                return NotFound();

            var modeloVehiculoTypeName = EntityTypeGetter<ModeloVehiculo, long>.GetTypeAsString();

            if (navigationProperty.Equals(modeloVehiculoTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var modeloVehiculo = await entityGetter.TryGetEntityFromRelatedLink<ModeloVehiculo, long>(link);
                if (modeloVehiculo == null)
                    return NotFound();

                periodicidadMantenimiento.Cambiar(modeloVehiculo);
            }
            else if (navigationProperty.Equals(EntityProperty.TargetMantenimiento))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var repuesto = await entityGetter.TryGetEntityFromRelatedLink<Repuesto, long>(link);
                if (repuesto == null)
                    return NotFound();

                periodicidadMantenimiento.Cambiar(repuesto);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}