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
    /// Grupos Modelo Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class GruposModeloController(IControllerParameter parameters, IRepository<GrupoModelo, long> repository) : GenericController<GrupoModelo, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene la marca del grupo modelo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Marca del grupo modelo</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMarca([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Marca);
        }

        /// <summary>
        /// Obtiene el nombre del grupo modelo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del grupo modelo</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Nombre);
        }

        /// <summary>
        /// Modifica la marca del grupo modelo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var marcaTypeName = entityTypeGetter.GetTypeAsString<Marca, long>();

            if (navigationProperty.Equals(marcaTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<GrupoModelo, long, Marca, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}