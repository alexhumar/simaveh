using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Provincias Controller
    /// </summary>
    public class ProvinciasController : GenericController<Provincia, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public ProvinciasController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene el nombre de la provincia
        /// </summary>
        /// <returns>Nombre de la provincia</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Nombre);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Pais);
        }

        /// <summary>
        /// Obtiene todos los partidos de la provincia
        /// </summary>
        /// <returns>Lista de partidos de la provincia</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetPartidos([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Partidos.AsQueryable());
        }

        /// <summary>
        /// Asocia un partido existente en la coleccion de partidos de la provincia.
        /// O modifica el pais asociado a la provincia.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var partidoCollectionName = entityTypeGetter.GetCollectionNameAsString<Partido, long>();
            var paisTypeName = entityTypeGetter.GetTypeAsString<Pais, long>();

            if (navigationProperty.Equals(partidoCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Provincia, long, Partido, long>(Request, link, key);
            }
            else if (navigationProperty.Equals(paisTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Provincia, long, Pais, long>(Request, link, key);
            }

            return ResultFromHttpStatusCode(resultado);
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