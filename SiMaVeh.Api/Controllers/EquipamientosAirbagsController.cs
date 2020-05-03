using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Domain.Models;
using SiMaVeh.Parametrization;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Equipamientos Airbags Controller
    /// </summary>
    public class EquipamientosAirbagsController : GenericController<EquipamientoAirbags, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EquipamientosAirbagsController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene si el equipamiento airbag es delantero derecho
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es delantero derecho</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDelanteroDerecho([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.DelanteroDerecho);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es delantero izquierdo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es delantero izquierdo</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDelanteroIzquierdo([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.DelanteroIzquierdo);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es de guantera
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es de guantera</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetGuantera([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Guantera);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es trasero derecho
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es trasero derecho</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetTraseroDerecho([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.TraseroDerecho);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es trasero izquierdo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es trasero izquierdo</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetTraseroIzquierdo([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.TraseroIzquierdo);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es de volante
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es de volante</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetVolante([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Volante);
        }

        #endregion
    }
}