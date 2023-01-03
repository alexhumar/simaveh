using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
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
    /// Usuarios Controller
    /// </summary>
    public class UsuariosController : GenericController<Usuario, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public UsuariosController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene el apellido del usuario
        /// </summary>
        /// <returns>Apellido del usuario</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetApellido([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Apellido);
        }

        /// <summary>
        /// Obtiene el nombre del usuario
        /// </summary>
        /// <returns>Nombre del usuario</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene el numero de documento del usuario
        /// </summary>
        /// <returns>Numero de documento del usuario</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNumeroDocumento([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.NumeroDocumento);
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

            return entity == null ? NotFound() : Ok(entity.Telefonos);
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

            return entity == null ? NotFound() : Ok(entity.TipoDocumento);
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

            return entity == null ? NotFound() : Ok(entity.Vehiculos);
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
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var vehiculoCollectionName = entityTypeGetter.GetCollectionNameAsString<Vehiculo, long>();
            var tipoDocumentoTypeName = entityTypeGetter.GetTypeAsString<TipoDocumento, long>();
            var telefonoCollectionName = entityTypeGetter.GetCollectionNameAsString<Telefono, long>();

            if (navigationProperty.Equals(vehiculoCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Usuario, long, Vehiculo, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(telefonoCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Persona, long, Telefono, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(tipoDocumentoTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Persona, long, TipoDocumento, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}