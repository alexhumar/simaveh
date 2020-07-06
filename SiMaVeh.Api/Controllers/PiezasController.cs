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
    /// Piezas Controller
    /// </summary>
    public class PiezasController : GenericController<Pieza, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PiezasController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la descripcion de la pieza
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion de la pieza</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre de la pieza
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la pieza</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene la ubicacion de la pieza
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Ubicacion de la pieza</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetUbicacion([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.UbicacionPieza);
        }

        /// <summary>
        /// Modifica la ubicacion pieza asociada a la pieza.
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

            var fuenteEnergia = await repository.Find(key);
            if (fuenteEnergia == null)
                return NotFound();

            var ubicacionPiezaTypeName = EntityTypeGetter<UbicacionPieza, string>.GetTypeAsString();

            if (navigationProperty.Equals(ubicacionPiezaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var ubicacionPieza = await entityGetter.TryGetEntityFromRelatedLink<UbicacionPieza, string>(link);
                if (ubicacionPieza == null)
                    return NotFound();

                fuenteEnergia.Cambiar(ubicacionPieza);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}