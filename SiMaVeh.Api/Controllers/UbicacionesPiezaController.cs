using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Ubicacion Pieza Controller
    /// </summary>
    public class UbicacionesPiezaController : GenericController<UbicacionPieza, string>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UbicacionesPiezaController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene si es pieza izquierda
        /// </summary>
        /// <returns>Si es pieza izquierda</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetIzquierda([FromODataUri] string key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Izquierda);
        }

        /// <summary>
        /// Obtiene si es pieza superior
        /// </summary>
        /// <returns>Si es pieza superior</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetSuperior([FromODataUri] string key)
        {
            var entity = await repository.FindAsync(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Superior);
        }

        #endregion
    }
}