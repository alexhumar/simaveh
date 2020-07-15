using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Telefonos Controller
    /// </summary>
    public class TelefonosController : GenericController<Telefono, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TelefonosController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene el numero del telefono
        /// </summary>
        /// <returns>Numero del telefono</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNumero([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Numero);
        }

        /// <summary>
        /// Obtiene la persona del telefono
        /// </summary>
        /// <returns>Persona del telefono</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetPersona([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Persona);
        }

        /// <summary>
        /// Obtiene el tipo del telefono
        /// </summary>
        /// <returns>Tipo del telefono</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTipo([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.TipoTelefono);
        }

        /// <summary>
        /// Modifica el tipo telefono asociado al telefono.
        /// O modifica la persona asociada al telefono.
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

            var telefono = await repository.FindAsync(key);
            if (telefono == null)
                return NotFound();

            var tipoTelefonoTypeName = EntityTypeGetter<TipoTelefono, long>.GetTypeAsString();
            var personaTypeName = EntityTypeGetter<Persona, long>.GetTypeAsString();

            if (navigationProperty.Equals(tipoTelefonoTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var tipoTelefono = await relatedEntityGetter.TryGetEntityFromRelatedLink<TipoTelefono, long>(link);
                if (tipoTelefono == null)
                    return NotFound();

                telefono.Cambiar(tipoTelefono);
            }
            else if (navigationProperty.Equals(personaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var persona = await relatedEntityGetter.TryGetEntityFromRelatedLink<Persona, long>(link);
                if (persona == null)
                    return NotFound();

                telefono.Cambiar(persona);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}