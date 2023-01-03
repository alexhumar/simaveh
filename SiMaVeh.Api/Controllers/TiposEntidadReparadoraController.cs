using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Tipos Entidad Reparadora Controller
    /// </summary>
    public class TiposEntidadReparadoraController : GenericController<TipoEntidadReparadora, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public TiposEntidadReparadoraController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del tipo de entidad reparadora
        /// </summary>
        /// <returns>Descripcion del tipo de entidad reparadora</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre del tipo de entidad reparadora
        /// </summary>
        /// <returns>Nombre del tipo de entidad reparadora</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Nombre);
        }

        #endregion
    }
}