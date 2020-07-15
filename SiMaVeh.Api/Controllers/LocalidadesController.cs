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
    /// Localidades Controller
    /// </summary>
    public class LocalidadesController : GenericController<Localidad, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LocalidadesController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene el nombre de la localidad
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la localidad</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene el CPA de la localidad
        /// </summary>
        /// <param name="key"></param>
        /// <returns>CPA de la localidad</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCPA([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.CPA);
        }

        /// <summary>
        /// Obtiene el partido de una localidad
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Partido de una localidad</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetPartido([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Partido);
        }

        /// <summary>
        /// Modifica el Partido asociado a la Localidad.
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

            var localidad = await repository.FindAsync(key);
            if (localidad == null)
                return NotFound();

            if (navigationProperty.Equals(EntityTypeGetter<Partido, long>.GetTypeAsString()))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var partido = await relatedEntityGetter.TryGetEntityFromRelatedLink<Partido, long>(link);
                if (partido == null)
                    return NotFound();

                localidad.Cambiar(partido);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}