using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Domain.Models;
using SiMaVeh.Parametrization;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Fluidos Controller
    /// </summary>
    public class FluidosController : GenericController<Fluido, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FluidosController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del fluido
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion del fluido</returns>
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
        /// Obtiene el nombre del fluido
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del fluido</returns>
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