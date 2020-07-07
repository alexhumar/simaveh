using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Provincias Controller
    /// </summary>
    public class ProvinciasController : GenericController<Provincia, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ProvinciasController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene el nombre de la provincia
        /// </summary>
        /// <returns>Nombre de la provincia</returns>
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
        /// Obtiene el pais de una provincia dado el Id de esta ultima
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Pais de la provincia o Not Found</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetPais([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Pais);
        }

        /// <summary>
        /// Obtiene todos los partidos de la provincia
        /// </summary>
        /// <returns>Lista de partidos de la provincia</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetPartidos([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Partidos.AsQueryable());
        }

        /// <summary>
        /// Asocia un partido existente en la coleccion de partidos de la provincia.
        /// O modifica el pais asociado a la provincia.
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

            var provincia = await repository.Find(key);
            if (provincia == null)
                return NotFound();

            var partidoCollectionName = EntityTypeGetter<Partido, long>.GetCollectionNameAsString();
            var paisTypeName = EntityTypeGetter<Pais, long>.GetTypeAsString();

            if (navigationProperty.Equals(partidoCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var partido = await entityGetter.TryGetEntityFromRelatedLink<Partido, long>(link);
                if (partido == null)
                    return NotFound();

                provincia.Agregar(partido);
            }
            else if (navigationProperty.Equals(paisTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var pais = await entityGetter.TryGetEntityFromRelatedLink<Pais, long>(link);
                if (pais == null)
                    return NotFound();

                provincia.Cambiar(pais);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        /*/// <summary>
        /// Borra la referencia al Pais, dependiendo del navigationProperty
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        //public async Task<IActionResult> DeleteRef([FromODataUri] int key,
        public IActionResult DeleteRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            //var provincia = await _repository.GetCollection().SingleOrDefaultAsync(p => p.Id == key);
            //if (provincia == null)
            //    return NotFound();

            //switch (navigationProperty)
            //{
            //    case "Pais":
            //        provincia.Pais.QuitarProvincia(provincia);
            //        break;

            //    default:
            //        return StatusCode(HttpStatusCode.NotImplemented);
            //}
            //await _repository.SaveChangesAsync();

            //return StatusCode(HttpStatusCode.NoContent);

            return StatusCode(HttpStatusCode.NotImplemented);
        }

        /// <summary>
        /// Borra la referencia de un Partido en la coleccion de Partidos.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        //public async Task<IActionResult> DeleteRef([FromODataUri] int key,
        public IActionResult DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            //var provincia = await _repository.GetCollection().SingleOrDefaultAsync(p => p.Id == key);
            //if (provincia == null)
            //    return NotFound();

            //switch (navigationProperty)
            //{
            //    case "Partidos":
            //        var idPartido = Convert.ToInt64(relatedKey);
            //        var partido = await _repositoryPartido.GetCollection().SingleOrDefaultAsync(p => p.Id == idPartido);

            //        if (partido == null)
            //            return NotFound();

            //        provincia.QuitarPartido(partido);
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