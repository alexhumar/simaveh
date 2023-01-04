using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Categorias Marca Controller
    /// </summary>
    public class CategoriasMarcaController : GenericController<CategoriaMarca, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public CategoriasMarcaController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene las marcas de la categoría
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Categoria de la marca</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetMarcas([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Marcas);
        }

        /// <summary>
        /// Obtiene el nombre de la categoría
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la marca</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Nombre);
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
            var marcaCollectionName = entityTypeGetter.GetCollectionNameAsString<Marca, long>();

            if (navigationProperty.Equals(marcaCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<CategoriaMarca, long, Marca, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        /// <summary>
        /// Borra la referencia de una marca en la coleccion de marcas.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override async Task<IActionResult> DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var marcaCollectionName = entityTypeGetter.GetCollectionNameAsString<Marca, long>();

            if (navigationProperty.Equals(marcaCollectionName))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<CategoriaMarca, long, Marca, long>(Request, key, Convert.ToInt64(relatedKey));
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}