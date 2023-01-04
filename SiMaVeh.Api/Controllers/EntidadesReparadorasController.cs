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
    /// Entidades Reparadoras Controller
    /// </summary>
    public class EntidadesReparadorasController : GenericController<EntidadReparadora, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public EntidadesReparadorasController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la direccion de la Entidad reparadora
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Direccion de la Entidad reparadora</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetDireccion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Direccion);
        }

        /// <summary>
        /// Obtiene el nombre de la Entidad reparadora
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la Entidad reparadora</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene los reparadores de la Entidad reparadora
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Reparadores de la Entidad reparadora</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetReparadores([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Reparadores);
        }

        /// <summary>
        /// Obtiene los servicios reparadores de la Entidad reparadora
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Servicios reparadores de la Entidad reparadora</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetServiciosReparadores([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.ServiciosReparadores);
        }

        /// <summary>
        /// Obtiene el tipo de la Entidad reparadora
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Tipo de la Entidad reparadora</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTipoEntidad([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.TipoEntidadReparadora);
        }

        /// <summary>
        /// Asocia un servicio reparador existente en la coleccion de servicios reparadores de la entidad reparadora.
        /// O asocia un reparador existente en la coleccion de reparadores de la entidad reparadora.
        /// O modifica la direccion asociada a la entidad reparadora.
        /// O modifica el tipo entidad asociada a la entidad reparadora.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var reparadorCollectionName = entityTypeGetter.GetCollectionNameAsString<Reparador, long>();
            var servicioReparadorCollectionName = entityTypeGetter.GetCollectionNameAsString<ServicioReparador, long>();
            var direccionTypeName = entityTypeGetter.GetTypeAsString<Direccion, long>();
            var tipoEntidadTypeName = entityTypeGetter.GetTypeAsString<TipoEntidadReparadora, long>();

            if (navigationProperty.Equals(reparadorCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<EntidadReparadora, long, Reparador, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(servicioReparadorCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<EntidadReparadora, long, ServicioReparador, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(direccionTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<EntidadReparadora, long, Direccion, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(tipoEntidadTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<EntidadReparadora, long, TipoEntidadReparadora, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        /// <summary>
        /// Borra la referencia de un reparador en la coleccion de reparadores.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override async Task<IActionResult> DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var reparadorCollectionName = entityTypeGetter.GetCollectionNameAsString<Reparador, long>();

            if (navigationProperty.Equals(reparadorCollectionName))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<EntidadReparadora, long, Reparador, long>(Request, key, Convert.ToInt64(relatedKey));
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}