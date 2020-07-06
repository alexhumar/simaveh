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
    /// Grupos Modelo Controller
    /// </summary>
    public class GruposModeloController : GenericController<GrupoModelo, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GruposModeloController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la marca del grupo modelo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Marca del grupo modelo</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMarca([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Marca);
        }

        /// <summary>
        /// Obtiene el nombre del grupo modelo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del grupo modelo</returns>
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
        /// Modifica la marca del grupo modelo.
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

            var grupoModelo = await repository.Find(key);
            if (grupoModelo == null)
                return NotFound();

            var marcaTypeName = EntityTypeGetter<Marca, long>.GetTypeAsString();

            if (navigationProperty.Equals(marcaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var marca = await entityGetter.TryGetEntityFromRelatedLink<Marca, long>(link);
                if (marca == null)
                    return NotFound();

                grupoModelo.Cambiar(marca);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}