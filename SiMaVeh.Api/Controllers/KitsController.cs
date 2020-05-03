using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Kits Controller
    /// </summary>
    public class KitsController : GenericController<Kit, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public KitsController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion del kit</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene los kits del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Kits del kit</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetKits([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Kits.AsQueryable());
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
            var entity = await _repository.Find(key);

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
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene los recambios del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Recambios del kit</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetRecambios([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Recambios.AsQueryable());
        }

        /// <summary>
        /// Asocia un kit existente en la coleccion de kits del kit.
        /// O asocia un recambio existente en la coleccion de recambios mantenimiento del kit.
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

            var kit = await _repository.Find(key);
            if (kit == null)
                return NotFound();

            var kitsCollectionName = EntityTypeGetter<Kit, long>.GetCollectionNameAsString();
            var recambiosCollectionName = EntityTypeGetter<Recambio, long>.GetCollectionNameAsString();
            var marcaTypeName = EntityTypeGetter<Marca, long>.GetTypeAsString();

            if (navigationProperty.Equals(kitsCollectionName))
            {
                //El kit se agrega a un kit existente
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var anotherKit = await _entityGetter.TryGetEntityFromRelatedLink<Kit, long>(link);
                if (anotherKit == null)
                    return NotFound();

                (kit as Recambio).Agregar(anotherKit);
            }
            else if (navigationProperty.Equals(recambiosCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                Recambio anotherKit = await _entityGetter.TryGetEntityFromRelatedLink<Kit, long>(link);
                if (anotherKit == null)
                {
                    anotherKit = await _entityGetter.TryGetEntityFromRelatedLink<Repuesto, long>(link);

                    if (anotherKit == null)
                        return NotFound();
                }

                kit.Agregar(anotherKit);
            }
            else if (navigationProperty.Equals(marcaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var marca = await _entityGetter.TryGetEntityFromRelatedLink<Marca, long>(link);
                if (marca == null)
                    return NotFound();

                kit.Cambiar(marca);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}