using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Domain.Models;
using SiMaVeh.Parametrization;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Tipos Entidad Reparadora Controller
    /// </summary>
    public class TiposEntidadReparadoraController : GenericController<TipoEntidadReparadora, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TiposEntidadReparadoraController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del tipo de entidad reparadora
        /// </summary>
        /// <returns>Descripcion del tipo de entidad reparadora</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre del tipo de entidad reparadora
        /// </summary>
        /// <returns>Nombre del tipo de entidad reparadora</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Nombre);
        }

        #endregion
    }
}