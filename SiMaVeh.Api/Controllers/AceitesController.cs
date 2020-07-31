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
    /// Aceites Controller
    /// </summary>
    public class AceitesController : GenericController<Aceite, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public AceitesController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene la Viscosidad SAE Alta Temperatura del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Viscosidad SAE Alta Tempeatura del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetViscosidadSAEAltaTemperatura([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.ViscosidadSAEAltaTemperatura);
        }

        /// <summary>
        /// Obtiene la Viscosidad SAE Baja Temperatura del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Viscosidad SAE Baja Tempeatura del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetViscosidadSAEBajaTemperatura([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.ViscosidadSAEBajaTemperatura);
        }

        /// <summary>
        /// Agrega un modelo de vehiculo a la coleccion de recomendaciones de modelos de vehiculo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;

            if (navigationProperty.Equals(EntityProperty.RecomendacionesModeloVehiculo))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Aceite, long, ModeloVehiculo, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        /// <summary>
        /// Borra la referencia de un modelo de vehiculo a la coleccion de recomendaciones de modelos de vehiculo.
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
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<Aceite, long, ModeloVehiculo, long>(Request, key, Convert.ToInt64(relatedKey));
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}