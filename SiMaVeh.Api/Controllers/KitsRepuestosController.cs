using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Kits Repuestos Controller
    /// NOTA: si lo denomino KitsController, no funciona la ruta.
    /// </summary>
    public class KitsRepuestosController : GenericController<Kit, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public KitsRepuestosController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion del kit</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene la marca del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Marca del kit</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMarca([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Marca);
        }

        /// <summary>
        /// Obtiene el nombre del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del kit</returns>
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
        /// Obtiene los repuestos del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Repuestos del kit</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetRepuestos([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Repuestos);
        }

        /// <summary>
        /// Asocia un repuesto existente en la coleccion de repuesto del kit.
        /// O modifica la marca asociada al kit.
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

            var kit = await repository.FindAsync(key);
            if (kit == null)
                return NotFound();

            var repuestosCollectionName = EntityTypeGetter<Repuesto, long>.GetCollectionNameAsString();
            var marcaTypeName = EntityTypeGetter<Marca, long>.GetTypeAsString();

            if (navigationProperty.Equals(repuestosCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var repuesto = await entityGetter.TryGetEntityFromRelatedLink<Repuesto, long>(link);
                if (repuesto == null)
                    return NotFound();

                kit.Agregar(repuesto);
            }
            else if (navigationProperty.Equals(marcaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var marca = await entityGetter.TryGetEntityFromRelatedLink<Marca, long>(link);
                if (marca == null)
                    return NotFound();

                kit.Cambiar(marca);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}