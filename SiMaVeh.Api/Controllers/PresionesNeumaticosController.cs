using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Presiones Neumaticos Controller
    /// </summary>
    public class PresionesNeumaticosController : GenericController<PresionNeumatico, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PresionesNeumaticosController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene si la presion neumatico es default
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si la presion neumatico es default</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetEsDefault([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.EsDefault);
        }

        /// <summary>
        /// Obtiene el modelo vehiculo de la presion neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Modelo vehiculo de la presion neumatico</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetModeloVehiculo([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.ModeloVehiculo);
        }

        /// <summary>
        /// Obtiene el neumatico de la presion neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Neumatico de la presion neumatico</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetNeumatico([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Neumatico);
        }

        /// <summary>
        /// Obtiene la presion de ruedas delanteras de la presion neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Presion de ruedas delanteras de la presion neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetRuedasDelanteras([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.RuedasDelanteras);
        }

        /// <summary>
        /// Obtiene la presion de ruedas traseras de la presion neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Presion de ruedas traseras de la presion neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetRuedasTraseras([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.RuedasTraseras);
        }

        /// <summary>
        /// Modifica el modelo vehiculo asociado a la presion neumatico.
        /// O modifica el neumatico asociado a la presion neumatico.
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

            var presionNeumatico = await _repository.Find(key);
            if (presionNeumatico == null)
                return NotFound();

            var modeloVehiculoTypeName = EntityTypeGetter<ModeloVehiculo, long>.GetTypeAsString();
            var neumaticoTypeName = EntityTypeGetter<Neumatico, long>.GetTypeAsString();

            if (navigationProperty.Equals(modeloVehiculoTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var modeloVehiculo = await _entityGetter.TryGetEntityFromRelatedLink<ModeloVehiculo, long>(link);
                if (modeloVehiculo == null)
                    return NotFound();

                presionNeumatico.Cambiar(modeloVehiculo);
            }
            else if (navigationProperty.Equals(neumaticoTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var neumatico = await _entityGetter.TryGetEntityFromRelatedLink<Neumatico, long>(link);
                if (neumatico == null)
                    return NotFound();

                presionNeumatico.Cambiar(neumatico);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}