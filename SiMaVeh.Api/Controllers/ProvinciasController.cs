using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
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

            return entity == null ? NotFound() : Ok(entity.Nombre);
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

            return entity == null ? NotFound() : Ok(entity.Pais);
        }

        /// <summary>
        /// Obtiene todos los partidos de la provincia
        /// </summary>
        /// <returns>Lista de partidos de la provincia</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetPartidos([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Partidos.AsQueryable());
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
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Provincia, long, Partido, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(paisTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Provincia, long, Pais, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        ///// <summary>
        ///// Borra la referencia al pais - no aplica pero lo dejo para saber como se implementa en caso de llegar a necesitarlo en alguna entidad
        ///// </summary>
        ///// <param name="key"></param>
        ///// <param name="navigationProperty"></param>
        ///// <param name="link"></param>
        ///// <returns></returns>
        //public override async Task<IActionResult> DeleteRef([FromODataUri] long key, string navigationProperty)
        //{
        //    var resultado = HttpStatusCode.NotImplemented;
        //    var paisTypeName = entityTypeGetter.GetTypeAsString<Pais, long>();

        //    if (navigationProperty.Equals(paisTypeName))
        //    {
        //        resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<Provincia, long, Pais, long>(Request, key);
        //    }

        //    return ResultFromHttpStatusCode(resultado);
        //}

        #endregion
    }
}