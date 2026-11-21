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
    /// Localidades Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class LocalidadesController(IControllerParameter parameters, IRepository<Localidad, long> repository) : GenericController<Localidad, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene el nombre de la localidad
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la localidad</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Nombre);
        }

        /// <summary>
        /// Obtiene el CPA de la localidad
        /// </summary>
        /// <param name="key"></param>
        /// <returns>CPA de la localidad</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCPA([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.CPA);
        }

        /// <summary>
        /// Obtiene el partido de una localidad
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Partido de una localidad</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetPartido([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Partido);
        }

        /// <summary>
        /// Modifica el Partido asociado a la Localidad.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var partidoTypeName = entityTypeGetter.GetTypeAsString<Partido, long>();

            if (navigationProperty.Equals(partidoTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Localidad, long, Partido, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}