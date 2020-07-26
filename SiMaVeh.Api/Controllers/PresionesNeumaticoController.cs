using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Presiones Neumatico Controller
    /// </summary>
    public class PresionesNeumaticoController : GenericController<PresionNeumatico, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public PresionesNeumaticoController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene si la presion neumatico es default
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si la presion neumatico es default</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetEsDefault([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.EsDefault);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.ModeloVehiculo);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Neumatico);
        }

        /// <summary>
        /// Obtiene la presion de ruedas delanteras de la presion neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Presion de ruedas delanteras de la presion neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetRuedasDelanteras([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.RuedasDelanteras);
        }

        /// <summary>
        /// Obtiene la presion de ruedas traseras de la presion neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Presion de ruedas traseras de la presion neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetRuedasTraseras([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.RuedasTraseras);
        }

        /// <summary>
        /// Modifica el modelo vehiculo asociado a la presion neumatico.
        /// O modifica el neumatico asociado a la presion neumatico.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var modeloVehiculoTypeName = entityTypeGetter.GetTypeAsString<ModeloVehiculo, long>();
            var neumaticoTypeName = entityTypeGetter.GetTypeAsString<Neumatico, long>();

            if (navigationProperty.Equals(modeloVehiculoTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<PresionNeumatico, long, ModeloVehiculo, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(neumaticoTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<PresionNeumatico, long, Neumatico, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}