using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Paises Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class PaisesController(IControllerParameter parameters, IRepository<Pais, long> repository) : GenericController<Pais, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene todas las provincias
        /// </summary>
        /// <returns>Lista de provincias del pais</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetProvincias([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Provincias);
        }

        /// <summary>
        /// Obtiene el nombre del pais
        /// </summary>
        /// <returns>Nombre del pais</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Nombre);
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
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Pais, long, Provincia, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}