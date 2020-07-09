using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Reparadores Controller
    /// </summary>
    public class ReparadoresController : GenericController<Reparador, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ReparadoresController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene el apellido del reparador
        /// </summary>
        /// <returns>Apellido del reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetApellido([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Apellido);
        }

        /// <summary>
        /// Obtiene las entidades reparadoras del reparador
        /// </summary>
        /// <returns>Entidades reparadoras del reparador</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetEntidadesReparadoras([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.EntidadesReparadoras);
        }

        /// <summary>
        /// Obtiene el nombre del reparador
        /// </summary>
        /// <returns>Nombre del reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene el numero de documento del reparador
        /// </summary>
        /// <returns>Numero de documento del reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNumeroDocumento([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.NumeroDocumento);
        }

        /// <summary>
        /// Obtiene los telefonos del reparador
        /// </summary>
        /// <returns>Telefonos del reparador</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetTelefonos([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Telefonos);
        }

        /// <summary>
        /// Obtiene el tipo de documento del reparador
        /// </summary>
        /// <returns>Tipo de documento del reparador</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTipoDocumento([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.TipoDocumento);
        }

        /// <summary>
        /// Asocia un vehiculo existente en la coleccion de vehiculos del usuario.
        /// O asocia un telefono existente en la coleccion de telefonos del usuario.
        /// O modifica el tipo documento asociado al usuario.
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

            var reparador = await repository.FindAsync(key);
            if (reparador == null)
                return NotFound();

            var entidadesReparadorasCollectionName = EntityTypeGetter<EntidadReparadora, long>.GetCollectionNameAsString();
            var tipoDocumentoTypeName = EntityTypeGetter<TipoDocumento, long>.GetTypeAsString();
            var telefonosCollectionName = EntityTypeGetter<Telefono, long>.GetCollectionNameAsString();

            if (navigationProperty.Equals(entidadesReparadorasCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var entidadReparadora = await entityGetter.TryGetEntityFromRelatedLink<EntidadReparadora, long>(link);
                if (entidadReparadora == null)
                    return NotFound();

                reparador.Agregar(entidadReparadora);
            }
            else if (navigationProperty.Equals(telefonosCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var telefono = await entityGetter.TryGetEntityFromRelatedLink<Telefono, long>(link);
                if (telefono == null)
                    return NotFound();

                reparador.Agregar(telefono);
            }
            else if (navigationProperty.Equals(tipoDocumentoTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var tipoDocumento = await entityGetter.TryGetEntityFromRelatedLink<TipoDocumento, long>(link);
                if (tipoDocumento == null)
                    return NotFound();

                reparador.Cambiar(tipoDocumento);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}