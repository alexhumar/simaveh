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
    /// Marcas Controller
    /// </summary>
    public class MarcasController : GenericController<Marca, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public MarcasController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene las categorías de la marca
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Categoria de la marca</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetCategorias([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Categorias);
        }

        /// <summary>
        /// Obtiene el nombre de la marca
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la marca</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Nombre);
        }

        /// <summary>
        /// Asocia una categoria de marca existente en la coleccion de categorias de la marca.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var categoriaMarcaCollectionName = entityTypeGetter.GetCollectionNameAsString<CategoriaMarca, long>();

            if (navigationProperty.Equals(categoriaMarcaCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Marca, long, CategoriaMarca, long>(Request, link, key);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}