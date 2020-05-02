using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Domain.Models;
using SiMaVeh.Parametrization;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Tipos Fuente Energia Controller
    /// </summary>
    public class TiposFuenteEnergiaController : GenericController<TipoFuenteEnergia, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TiposFuenteEnergiaController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del tipo de fuente de energia
        /// </summary>
        /// <returns>Descripcion del tipo de fuente de energia</returns>
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
        /// Obtiene el nombre del tipo de fuente de energia
        /// </summary>
        /// <returns>Nombre del tipo de fuente de energia</returns>
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