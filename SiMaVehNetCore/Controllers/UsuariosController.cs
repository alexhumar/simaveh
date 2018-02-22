using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.DataAccess;
using SiMaVeh.Domain.Models;
using SiMaVeh.Helpers;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Usuarios Controller
    /// </summary>
    public class UsuariosController : GenericController<Usuario, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UsuariosController(SiMaVehContext context) : base(context) { }

        #region properties

        /// <summary>
        /// Obtiene el apellido del usuario
        /// </summary>
        /// <returns>Apellido del usuario</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetApellido([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

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
            var entity = await _repository.Find(key);

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
            var entity = await _repository.Find(key);

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
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetTelefonos([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Telefonos.AsQueryable());
        }

        /// <summary>
        /// Obtiene el tipo de documento del usuario
        /// </summary>
        /// <returns>Tipo de documento del usuario</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTipoDocumento([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

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
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetVehiculos([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Vehiculos.AsQueryable());
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

            var usuario = await _repository.Find(key);
            if (usuario == null)
                return NotFound();

            var vehiculosCollectionName = EntityTypeGetter<Vehiculo, long>.GetCollectionNameAsString();
            var tipoDocumentoTypeName = EntityTypeGetter<TipoDocumento, long>.GetTypeAsString();
            var telefonosCollectionName = EntityTypeGetter<Telefono, long>.GetCollectionNameAsString();

            if (navigationProperty.Equals(vehiculosCollectionName))
            {
                if (!Request.Method.Equals(HttpMethod.Post))
                    return BadRequest();

                var automovil = await EntityGetter.Instance.TryGetEntityFromRelatedLink<Automovil, long>(link);
                if (automovil == null)
                    return NotFound();

                usuario.Agregar(automovil);
            }
            else if (navigationProperty.Equals(telefonosCollectionName))
            {
                if (!Request.Method.Equals(HttpMethod.Post))
                    return BadRequest();

                var telefono = await EntityGetter.Instance.TryGetEntityFromRelatedLink<Telefono, long>(link);
                if (telefono == null)
                    return NotFound();

                usuario.Agregar(telefono);
            }
            else if (navigationProperty.Equals(tipoDocumentoTypeName))
            {
                if (!Request.Method.Equals(HttpMethod.Put))
                    return BadRequest();

                var tipoDocumento = await EntityGetter.Instance.TryGetEntityFromRelatedLink<TipoDocumento, long>(link);
                if (tipoDocumento == null)
                    return NotFound();

                usuario.Cambiar(tipoDocumento);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}