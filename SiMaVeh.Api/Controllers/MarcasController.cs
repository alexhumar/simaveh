using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Marcas Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class MarcasController(IControllerParameter parameters, IRepository<Marca, long> repository) : GenericController<Marca, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene las categorías de la marca
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Categoria de la marca</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetCategorias([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Categorias);
        }

        /// <summary>
        /// Obtiene el nombre de la marca
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la marca</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Nombre);
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
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Marca, long, CategoriaMarca, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        /// <summary>
        /// Borra la referencia de una categoria en la coleccion de categorias.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override async Task<IActionResult> DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var resultado = HttpStatusCode.NotImplemented;

            if (navigationProperty.Equals(EntityProperty.Categorias))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<Marca, long, CategoriaMarca, long>(Request, key, Convert.ToInt64(relatedKey));
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}