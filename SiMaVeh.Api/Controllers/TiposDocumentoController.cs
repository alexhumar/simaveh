using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Tipos Documento Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class TiposDocumentoController(IControllerParameter parameters, IRepository<TipoDocumento, long> repository) : GenericController<TipoDocumento, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene la descripcion del tipo de documento
        /// </summary>
        /// <returns>Descripcion del tipo de documento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre del tipo de documento
        /// </summary>
        /// <returns>Nombre del tipo de documento</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Nombre);
        }

        #endregion
    }
}