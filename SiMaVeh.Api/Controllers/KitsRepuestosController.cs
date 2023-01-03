using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
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
    /// Kits Repuestos Controller
    /// NOTA: si lo denomino KitsController, no funciona la ruta.
    /// </summary>
    public class KitsRepuestosController : GenericController<Kit, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public KitsRepuestosController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion del kit</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene la marca del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Marca del kit</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMarca([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Marca);
        }

        /// <summary>
        /// Obtiene el nombre del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del kit</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene los repuestos del kit
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Repuestos del kit</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetRepuestos([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Repuestos);
        }

        /// <summary>
        /// Asocia un repuesto existente en la coleccion de repuesto del kit.
        /// O modifica la marca asociada al kit.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var repuestoCollectionName = entityTypeGetter.GetCollectionNameAsString<Repuesto, long>();
            var marcaTypeName = entityTypeGetter.GetTypeAsString<Marca, long>();

            if (navigationProperty.Equals(repuestoCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Kit, long, Repuesto, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(marcaTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Recambio, long, Marca, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        /// <summary>
        /// Borra la referencia de un repuesto en la coleccion de repuestos.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override async Task<IActionResult> DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var repuestoCollectionName = entityTypeGetter.GetCollectionNameAsString<Repuesto, long>();

            if (navigationProperty.Equals(repuestoCollectionName))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<Kit, long, Repuesto, long>(Request, key, Convert.ToInt64(relatedKey));
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}