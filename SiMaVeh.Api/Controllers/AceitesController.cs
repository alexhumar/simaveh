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
    /// Aceites Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class AceitesController(IControllerParameter parameters, IRepository<Aceite, long> repository) : GenericController<Aceite, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene la descripcion del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Nombre);
        }

        /// <summary>
        /// Obtiene la Viscosidad SAE Alta Temperatura del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Viscosidad SAE Alta Tempeatura del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetViscosidadSAEAltaTemperatura([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.ViscosidadSAEAltaTemperatura);
        }

        /// <summary>
        /// Obtiene la Viscosidad SAE Baja Temperatura del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Viscosidad SAE Baja Tempeatura del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetViscosidadSAEBajaTemperatura([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.ViscosidadSAEBajaTemperatura);
        }

        /// <summary>
        /// Obtiene las recomendaciones de modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Modelo vehiculo de la presion neumatico</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetRecomendacionesModeloVehiculo([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.RecomendacionesModeloVehiculo);
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