using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.Constants;
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
        /// Obtiene si la presion neumatico se corresponde a condicion de vehiculo cargado
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si la presion neumatico es para vehiculo cargado</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetVehiculoCargado([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.VehiculoCargado);
        }

        /// <summary>
        /// Obtiene si la presion neumatico es independiente de un neumático en especial
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si la presion neumatico es universal</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetEsUniversal([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.EsUniversal);
        }

        /// <summary>
        /// Obtiene las recomendaciones de modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Modelo vehiculo de la presion neumatico</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetRecomendacionesModeloVehiculo([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.RecomendacionesModeloVehiculo);
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

            return entity == null ? NotFound() : Ok(entity.Neumatico);
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

            return entity == null ? NotFound() : Ok(entity.RuedasDelanteras);
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

            return entity == null ? NotFound() : Ok(entity.RuedasTraseras);
        }

        /// <summary>
        /// Agrega un modelo vehiculo asociado a la coleccion de recomendaciones de modelo vehiculo.
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
            var neumaticoTypeName = entityTypeGetter.GetTypeAsString<Neumatico, long>();

            if (navigationProperty.Equals(EntityProperty.RecomendacionesModeloVehiculo))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<PresionNeumatico, long, ModeloVehiculo, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(neumaticoTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<PresionNeumatico, long, Neumatico, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        /// <summary>
        /// Borra la referencia de un modelo de vehiculo asociado a la coleccion de recomendaciones de modelo vehiculo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override async Task<IActionResult> DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var resultado = HttpStatusCode.NotImplemented;

            if (navigationProperty.Equals(EntityProperty.RecomendacionesModeloVehiculo))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<PresionNeumatico, long, ModeloVehiculo, long>(Request, key, Convert.ToInt64(relatedKey));
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}