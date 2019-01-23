using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Domain.Models;
using SiMaVeh.Helpers;
using SiMaVeh.HelpersHttpConstants;
using SiMaVeh.Parametrization;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Entidades Reparadoras Controller
    /// </summary>
    public class EntidadesReparadorasController : GenericController<EntidadReparadora, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EntidadesReparadorasController(IControllerParameter parameters) : base(parameters) { }
        
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
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Direccion);
        }

        /// <summary>
        /// Obtiene el nombre de la Entidad reparadora
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la Entidad reparadora</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene los reparadores de la Entidad reparadora
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Reparadores de la Entidad reparadora</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetReparadores([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Reparadores.AsQueryable());
        }

        /// <summary>
        /// Obtiene los servicios reparadores de la Entidad reparadora
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Servicios reparadores de la Entidad reparadora</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetServiciosReparadores([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.ServiciosReparadores.AsQueryable());
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
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.TipoEntidadReparadora);
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
        [AcceptVerbs("POST", "PUT")]
        public async Task<IActionResult> CreateRef([FromODataUri] long key,
        string navigationProperty, [FromBody] Uri link)
        {
            if (link == null)
                return BadRequest();

            var entidadReparadora = await _repository.Find(key);
            if (entidadReparadora == null)
                return NotFound();

            var reparadorCollectionName = EntityTypeGetter<Reparador, long>.GetCollectionNameAsString();
            var servicioReparadorCollectionName = EntityTypeGetter<ServicioReparador, long>.GetCollectionNameAsString();
            var direccionTypeName = EntityTypeGetter<Direccion, long>.GetTypeAsString();
            var tipoEntidadTypeName = EntityTypeGetter<TipoEntidadReparadora, long>.GetTypeAsString();
            
            if (navigationProperty.Equals(reparadorCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var reparador = await _entityGetter.TryGetEntityFromRelatedLink<Reparador, long>(link);
                if (reparador == null)
                    return NotFound();

                entidadReparadora.Agregar(reparador);
            }
            else if (navigationProperty.Equals(servicioReparadorCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var servicioReparador = await _entityGetter.TryGetEntityFromRelatedLink<ServicioReparador, long>(link);
                if (servicioReparador == null)
                    return NotFound();

                entidadReparadora.Agregar(servicioReparador);
            }
            else if (navigationProperty.Equals(direccionTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var direccion = await _entityGetter.TryGetEntityFromRelatedLink<Direccion, long>(link);
                if (direccion == null)
                    return NotFound();

                entidadReparadora.Cambiar(direccion);
            }
            else if (navigationProperty.Equals(tipoEntidadTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var tipoEntidad = await _entityGetter.TryGetEntityFromRelatedLink<TipoEntidadReparadora, long>(link);
                if (tipoEntidad == null)
                    return NotFound();

                entidadReparadora.Cambiar(tipoEntidad);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}