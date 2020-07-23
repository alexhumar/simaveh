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
    /// Telefonos Controller
    /// </summary>
    public class TelefonosController : GenericController<Telefono, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public TelefonosController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene el numero del telefono
        /// </summary>
        /// <returns>Numero del telefono</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNumero([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Numero);
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

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Persona);
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

            return entity == null ? NotFound() : (IActionResult)Ok(entity.TipoTelefono);
        }

        /// <summary>
        /// Modifica el tipo telefono asociado al telefono.
        /// O modifica la persona asociada al telefono.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var tipoTelefonoTypeName = entityTypeGetter.GetTypeAsString<TipoTelefono, long>();
            var personaTypeName = entityTypeGetter.GetTypeAsString<Persona, long>();

            if (navigationProperty.Equals(tipoTelefonoTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Telefono, long, TipoTelefono, long>(Request, link, key);
            }
            else if (navigationProperty.Equals(personaTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Telefono, long, Persona, long>(Request, link, key);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}