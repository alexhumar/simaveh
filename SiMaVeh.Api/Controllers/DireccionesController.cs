using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.BusinessLogic.Entities;
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
        public DireccionesController(IControllerParameter parameters) : base(parameters) { }

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

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Calle);
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

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Localidad);
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

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.NumeroCalle);
        }

        /// <summary>
        /// Modifica la Localidad asociada a la direccion
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

            var direccion = await repository.FindAsync(key);
            if (direccion == null)
                return NotFound();

            if (navigationProperty.Equals(EntityTypeGetter<Localidad, long>.GetTypeAsString()))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var localidad = await relatedEntityGetter.TryGetEntityFromRelatedLink<Localidad, long>(link);
                if (localidad == null)
                    return NotFound();

                direccion.Cambiar(localidad);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}