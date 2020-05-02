using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Domain.Models;
using SiMaVeh.Parametrization;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Marcas Controller
    /// </summary>
    public class MarcasController : GenericController<Marca, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MarcasController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la descripcion de la marca
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion de la marca</returns>
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
        /// Obtiene el nombre de la marca
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la marca</returns>
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