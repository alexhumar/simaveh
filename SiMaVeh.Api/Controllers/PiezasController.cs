using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Piezas Controller
    /// </summary>
    public class PiezasController : GenericController<Pieza, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public PiezasController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la descripcion de la pieza
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion de la pieza</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre de la pieza
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la pieza</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene la ubicacion de la pieza
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Ubicacion de la pieza</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetUbicacion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.UbicacionPieza);
        }

        /// <summary>
        /// Modifica la ubicacion pieza asociada a la pieza.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var ubicacionPiezaTypeName = entityTypeGetter.GetTypeAsString<UbicacionPieza, string>();

            if (navigationProperty.Equals(ubicacionPiezaTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Pieza, long, UbicacionPieza, string>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}