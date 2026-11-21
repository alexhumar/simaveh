using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Tipos Entidad Reparadora Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class TiposEntidadReparadoraController(IControllerParameter parameters, IRepository<TipoEntidadReparadora, long> repository) : GenericController<TipoEntidadReparadora, long>(parameters, repository)
    {

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