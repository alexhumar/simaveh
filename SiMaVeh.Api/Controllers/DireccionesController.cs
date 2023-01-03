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
    /// Direcciones Controller
    /// </summary>
    public class DireccionesController : GenericController<Direccion, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public DireccionesController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la calle de la direccion
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Calle de la direccion</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCalle([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Calle);
        }

        /// <summary>
        /// Obtiene la Localidad de la direccion
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Localidad de la direccion</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetLocalidad([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Localidad);
        }

        /// <summary>
        /// Obtiene el numero de calle de la direccion
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Numero de calle de la direccion</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNumeroCalle([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.NumeroCalle);
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