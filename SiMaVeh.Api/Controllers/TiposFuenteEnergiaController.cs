using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Tipos Fuente Energia Controller
    /// </summary>
    public class TiposFuenteEnergiaController : GenericController<TipoFuenteEnergia, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public TiposFuenteEnergiaController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del tipo de fuente de energia
        /// </summary>
        /// <returns>Descripcion del tipo de fuente de energia</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre del tipo de fuente de energia
        /// </summary>
        /// <returns>Nombre del tipo de fuente de energia</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Nombre);
        }

        #endregion
    }
}