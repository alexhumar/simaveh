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
    /// Neumaticos Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class NeumaticosController(IControllerParameter parameters, IRepository<Neumatico, long> repository) : GenericController<Neumatico, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene la anchura seccion nominal del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Anchura seccion nominal del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAnchuraSeccionalNominal([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.AnchuraSeccionalNominal);
        }

        /// <summary>
        /// Obtiene la construccion carcasa del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Construccion carcasa del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetConstruccionCarcasa([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.ConstruccionCarcasa);
        }

        /// <summary>
        /// Obtiene el diametro de llanta del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Diametro de llanta del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDiametroLLanta([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.DiametroLLanta);
        }

        /// <summary>
        /// Obtiene el indice de carga del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Indice de carga del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetIndiceCarga([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.IndiceCarga);
        }

        /// <summary>
        /// Obtiene el indice de velocidad del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Indice de velocidad del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetIndiceVelocidad([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.IndiceVelocidad);
        }

        /// <summary>
        /// Obtiene la marca del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Marca del neumatico</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMarca([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Marca);
        }

        /// <summary>
        /// Obtiene el modelo del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Modelo del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetModelo([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Modelo);
        }

        /// <summary>
        /// Obtiene la relacion alto ancho del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Relacion alto ancho del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetRelacionAnchoAlto([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.RelacionAnchoAlto);
        }

        /// <summary>
        /// Obtiene el tipo de vehiculo del neumatico
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Tipo de vehiculo del neumatico</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetTipo([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Tipo);
        }

        /// <summary>
        /// Modifica la marca asociada al neumatico.
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
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Neumatico, long, Marca, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}