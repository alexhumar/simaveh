using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Direcciones Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class DireccionesController(IControllerParameter parameters, IRepository<Direccion, long> repository) : GenericController<Direccion, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene la calle de la direccion
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Calle de la direccion</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCalle([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Calle);
        }

        /// <summary>
        /// Obtiene la Localidad de la direccion
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Localidad de la direccion</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetLocalidad([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Localidad);
        }

        /// <summary>
        /// Obtiene el numero de calle de la direccion
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Numero de calle de la direccion</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNumeroCalle([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.NumeroCalle);
        }

        /// <summary>
        /// Modifica la Localidad asociada a la direccion
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var localidadTypeName = entityTypeGetter.GetTypeAsString<Localidad, long>();

            if (navigationProperty.Equals(localidadTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Direccion, long, Localidad, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}