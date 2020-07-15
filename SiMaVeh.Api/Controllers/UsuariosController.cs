using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Usuarios Controller
    /// </summary>
    public class UsuariosController : GenericController<Usuario, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UsuariosController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene el apellido del usuario
        /// </summary>
        /// <returns>Apellido del usuario</returns>
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
        /// Obtiene el nombre del usuario
        /// </summary>
        /// <returns>Nombre del usuario</returns>
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
        /// Obtiene el numero de documento del usuario
        /// </summary>
        /// <returns>Numero de documento del usuario</returns>
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
        /// Obtiene los telefonos del usuario
        /// </summary>
        /// <returns>Telefonos del usuario</returns>
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
        /// Obtiene el tipo de documento del usuario
        /// </summary>
        /// <returns>Tipo de documento del usuario</returns>
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
        /// Obtiene los vehiculos del usuario
        /// </summary>
        /// <returns>Vehiculos del usuario</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetVehiculos([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Vehiculos);
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

            var usuario = await repository.FindAsync(key);
            if (usuario == null)
                return NotFound();

            var vehiculosCollectionName = EntityTypeGetter<Vehiculo, long>.GetCollectionNameAsString();
            var tipoDocumentoTypeName = EntityTypeGetter<TipoDocumento, long>.GetTypeAsString();
            var telefonosCollectionName = EntityTypeGetter<Telefono, long>.GetCollectionNameAsString();

            if (navigationProperty.Equals(vehiculosCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var automovil = await relatedEntityGetter.TryGetEntityFromRelatedLink<Automovil, long>(link);
                if (automovil == null)
                    return NotFound();

                usuario.Agregar(automovil);
            }
            else if (navigationProperty.Equals(telefonosCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var telefono = await relatedEntityGetter.TryGetEntityFromRelatedLink<Telefono, long>(link);
                if (telefono == null)
                    return NotFound();

                usuario.Agregar(telefono);
            }
            else if (navigationProperty.Equals(tipoDocumentoTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var tipoDocumento = await relatedEntityGetter.TryGetEntityFromRelatedLink<TipoDocumento, long>(link);
                if (tipoDocumento == null)
                    return NotFound();

                usuario.Cambiar(tipoDocumento);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}