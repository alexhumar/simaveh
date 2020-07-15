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
    /// Neumaticos Controller
    /// </summary>
    public class NeumaticosController : GenericController<Neumatico, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public NeumaticosController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la anchura seccion nominal del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Anchura seccion nominal del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAnchuraSeccionalNominal([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.AnchuraSeccionalNominal);
        }

        /// <summary>
        /// Obtiene la construccion carcasa del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Construccion carcasa del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetConstruccionCarcasa([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.ConstruccionCarcasa);
        }

        /// <summary>
        /// Obtiene el diametro de llanta del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Diametro de llanta del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDiametroLLanta([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.DiametroLLanta);
        }

        /// <summary>
        /// Obtiene el indice de carga del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Indice de carga del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetIndiceCarga([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.IndiceCarga);
        }

        /// <summary>
        /// Obtiene el indice de velocidad del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Indice de velocidad del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetIndiceVelocidad([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.IndiceVelocidad);
        }

        /// <summary>
        /// Obtiene la marca del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Marca del neumatico</returns>
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
        /// Obtiene el modelo del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Modelo del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetModelo([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Modelo);
        }

        /// <summary>
        /// Obtiene la relacion alto ancho del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Relacion alto ancho del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetRelacionAnchoAlto([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.RelacionAnchoAlto);
        }

        /// <summary>
        /// Obtiene el tipo de vehiculo del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Tipo de vehiculo del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetTipo([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Tipo);
        }

        /// <summary>
        /// Modifica la marca asociada al neumatico.
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

            var neumatico = await repository.FindAsync(key);
            if (neumatico == null)
                return NotFound();

            var marcaTypeName = EntityTypeGetter<Marca, long>.GetTypeAsString();

            if (navigationProperty.Equals(marcaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var marca = await relatedEntityGetter.TryGetEntityFromRelatedLink<Marca, long>(link);
                if (marca == null)
                    return NotFound();

                neumatico.Cambiar(marca);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}