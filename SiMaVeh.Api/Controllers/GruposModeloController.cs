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
    /// Grupos Modelo Controller
    /// </summary>
    public class GruposModeloController : GenericController<GrupoModelo, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public GruposModeloController(IControllerParameter parameters)
            : base(parameters)
        {
        }

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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Marca);
        }

        /// <summary>
        /// Obtiene el nombre del grupo modelo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del grupo modelo</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Nombre);
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