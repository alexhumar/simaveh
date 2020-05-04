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
    /// Paises Controller
    /// </summary>
    public class PaisesController : GenericController<Pais, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PaisesController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene todas las provincias
        /// </summary>
        /// <returns>Lista de provincias del pais</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetProvincias([FromODataUri] long key)
        {
            //return await Task.Run(() => _repository.GetCollection().Where(p => p.Id == key).SelectMany(p => p.Provincias));
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Provincias.AsQueryable());
        }

        /// <summary>
        /// Obtiene el nombre del pais
        /// </summary>
        /// <returns>Nombre del pais</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            //El $value anda solo!
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Nombre);
        }

        /// <summary>
        /// Asocia una provincia existente en la coleccion de provincias del pais
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

            var pais = await _repository.Find(key);
            if (pais == null)
                return NotFound();

            var provinciaCollectionName = EntityTypeGetter<Provincia, long>.GetCollectionNameAsString();

            if (navigationProperty.Equals(provinciaCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var provincia = await _entityGetter.TryGetEntityFromRelatedLink<Provincia, long>(link);
                if (provincia == null)
                    return NotFound();

                pais.Agregar(provincia);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        /*/// <summary>
        /// Borra una Provincia de la coleccion de Provincias del Pais
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        //public async Task<IActionResult> DeleteRef([FromODataUri] int key,
        public IActionResult DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            //var pais = await _repository.GetCollection().SingleOrDefaultAsync(p => p.Id == key);
            //if (pais == null)
            //    return NotFound();

            //switch (navigationProperty)
            //{
            //    case "Provincias":

            //        var idProvincia = Convert.ToInt64(relatedKey);
            //        var provincia = await _repositoryProvincia.GetCollection().SingleOrDefaultAsync(p => p.Id == idProvincia);

            //        if (provincia == null)
            //            return NotFound();

            //        pais.QuitarProvincia(provincia);
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