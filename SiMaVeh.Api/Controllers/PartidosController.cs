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
    /// Partidos Controller
    /// </summary>
    public class PartidosController : GenericController<Partido, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PartidosController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene el nombre de la provincia
        /// </summary>
        /// <returns>Nombre de la provincia</returns>
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
        /// Obtiene la provincia de un partido dado el Id de este ultimo
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Provincia de un partido o Not Found</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetProvincia([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Provincia);
        }

        /// <summary>
        /// Obtiene todas las localidades del partido
        /// </summary>
        /// <returns>Lista de localidades del partido</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetLocalidades([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Localidades);
        }

        /// <summary>
        /// Asocia una Localidad existente en la coleccion de localidades del partido.
        /// O modifica la provincia asociada al partido.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs("POST", "PUT")]
        public async Task<IActionResult> CreateRef([FromODataUri] int key,
        string navigationProperty, [FromBody] Uri link)
        {
            if (link == null)
                return BadRequest();

            var partido = await repository.FindAsync(key);
            if (partido == null)
                return NotFound();

            var localidadCollectionName = EntityTypeGetter<Localidad, long>.GetCollectionNameAsString();
            var provinciaTypeName = EntityTypeGetter<Provincia, long>.GetTypeAsString();

            if (navigationProperty.Equals(localidadCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var localidad = await relatedEntityGetter.TryGetEntityFromRelatedLink<Localidad, long>(link);
                if (localidad == null)
                    return NotFound();

                partido.Agregar(localidad);
            }
            else if (navigationProperty.Equals(provinciaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var provincia = await relatedEntityGetter.TryGetEntityFromRelatedLink<Provincia, long>(link);
                if (provincia == null)
                    return NotFound();

                partido.Cambiar(provincia);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        /*/// <summary>
        /// Borra la referencia a la Provincia, dependiendo del navigationProperty
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        //public async Task<IActionResult> DeleteRef([FromODataUri] int key,
        public IActionResult DeleteRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            //var partido = await _repository.GetCollection().SingleOrDefaultAsync(p => p.Id == key);
            //if (partido == null)
            //    return NotFound();

            //switch (navigationProperty)
            //{
            //    case "Provincia":
            //        partido.Provincia.QuitarPartido(partido);
            //        break;

            //    default:
            //        return StatusCode(HttpStatusCode.NotImplemented);
            //}
            //await _repository.SaveChangesAsync();

            //return StatusCode(HttpStatusCode.NoContent);

            return StatusCode(HttpStatusCode.NotImplemented);
        }

        /// <summary>
        /// Borra la referencia de una Localidad en la coleccion de Localidades.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        //public async Task<IActionResult> DeleteRef([FromODataUri] int key,
        public IActionResult DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            //var partido = await _repository.GetCollection().SingleOrDefaultAsync(p => p.Id == key);
            //if (partido == null)
            //    return NotFound();

            //switch (navigationProperty)
            //{
            //    case "Localidades":
            //        var idLocalidad = Convert.ToInt64(relatedKey);
            //        var localidad = await _repositoryLocalidad.GetCollection().SingleOrDefaultAsync(p => p.Id == idLocalidad);

            //        if (localidad == null)
            //            return NotFound();

            //        partido.QuitarLocalidad(localidad);
            //        break;
            //    default:
            //        return StatusCode(HttpStatusCode.NotImplemented);

            //}
            //await _repository.SaveChangesAsync();

            //return StatusCode(HttpStatusCode.NoContent);

            return StatusCode(HttpStatusCode.NotImplemented);
        }*/

        #endregion
    }
}