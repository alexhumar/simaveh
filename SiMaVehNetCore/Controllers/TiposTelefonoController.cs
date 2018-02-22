using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.DataAccess;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Tipos Telefono Controller
    /// </summary>
    public class TiposTelefonoController : GenericController<TipoTelefono, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TiposTelefonoController(SiMaVehContext context) : base(context) { }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del tipo telefono
        /// </summary>
        /// <returns>Descripcion del tipo telefono</returns>
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
        /// Obtiene el nombre del tipo telefono
        /// </summary>
        /// <returns>Nombre del tipo telefono</returns>
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