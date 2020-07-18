using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Aceites Controller
    /// </summary>
    public class AceitesController : GenericController<Aceite, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public AceitesController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene la Viscosidad SAE Alta Temperatura del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Viscosidad SAE Alta Tempeatura del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetViscosidadSAEAltaTemperatura([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.ViscosidadSAEAltaTemperatura);
        }

        /// <summary>
        /// Obtiene la Viscosidad SAE Baja Temperatura del aceite
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Viscosidad SAE Baja Tempeatura del aceite</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetViscosidadSAEBajaTemperatura([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.ViscosidadSAEBajaTemperatura);
        }

        #endregion
    }
}