using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Paises Controller
    /// </summary>
    public class PaisesController : GenericController<Pais, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public PaisesController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene todas las provincias
        /// </summary>
        /// <returns>Lista de provincias del pais</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetProvincias([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Provincias);
        }

        /// <summary>
        /// Obtiene el nombre del pais
        /// </summary>
        /// <returns>Nombre del pais</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Nombre);
        }

        /// <summary>
        /// Asocia una provincia existente en la coleccion de provincias del pais
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var provinciaCollectionName = entityTypeGetter.GetCollectionNameAsString<Provincia, long>();

            if (navigationProperty.Equals(provinciaCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Pais, long, Provincia, long>(Request, link, key);
            }

            return ResultFromHttpStatusCode(resultado);
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