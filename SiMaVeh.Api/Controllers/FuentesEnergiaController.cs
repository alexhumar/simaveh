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
    /// Fuentes Energia Controller
    /// </summary>
    public class FuentesEnergiaController : GenericController<FuenteEnergia, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FuentesEnergiaController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la marca de la fuente de energia
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Marca de la fuente de energia</returns>
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
        /// Obtiene el nombre de la fuente de energia
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la fuente de energia</returns>
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
        /// Obtiene el tipo de la fuente de energia
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Tipo de la fuente de energia</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTipo([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.TipoFuenteEnergia);
        }

        /// <summary>
        /// Modifica el tipo fuente energia asociado a la fuente energia.
        /// O modifica la marca asociada a la fuente energia.
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

            var tipoFuenteEnergiaTypeName = EntityTypeGetter<TipoFuenteEnergia, long>.GetTypeAsString();
            var marcaTypeName = EntityTypeGetter<Marca, long>.GetTypeAsString();

            if (navigationProperty.Equals(tipoFuenteEnergiaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var tipoFuenteEnergia = await entityGetter.TryGetEntityFromRelatedLink<TipoFuenteEnergia, long>(link);
                if (tipoFuenteEnergia == null)
                    return NotFound();

                fuenteEnergia.Cambiar(tipoFuenteEnergia);
            }
            else if (navigationProperty.Equals(marcaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var marca = await entityGetter.TryGetEntityFromRelatedLink<Marca, long>(link);
                if (marca == null)
                    return NotFound();

                fuenteEnergia.Cambiar(marca);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}