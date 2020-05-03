using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Tipos Documento Controller
    /// </summary>
    public class TiposDocumentoController : GenericController<TipoDocumento, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TiposDocumentoController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la descripcion del tipo de documento
        /// </summary>
        /// <returns>Descripcion del tipo de documento</returns>
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
        /// Obtiene el nombre del tipo de documento
        /// </summary>
        /// <returns>Nombre del tipo de documento</returns>
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