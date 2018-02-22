using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.DataAccess;
using SiMaVeh.Domain.Models;
using SiMaVeh.Helpers;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Direcciones Controller
    /// </summary>
    public class DireccionesController : GenericController<Direccion, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DireccionesController(SiMaVehContext context) : base(context) { }

        #region properties

        /// <summary>
        /// Obtiene la calle de la direccion
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Calle de la direccion</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCalle([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

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
            var entity = await _repository.Find(key);

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
            var entity = await _repository.Find(key);

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

            var direccion = await _repository.Find(key);
            if (direccion == null)
                return NotFound();

            if (navigationProperty.Equals(EntityTypeGetter<Localidad, long>.GetTypeAsString()))
            {
                if (!Request.Method.Equals(HttpMethod.Put))
                    return BadRequest();

                var localidad = await EntityGetter.Instance.TryGetEntityFromRelatedLink<Localidad, long>(link);
                if (localidad == null)
                    return NotFound();

                direccion.Cambiar(localidad);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}