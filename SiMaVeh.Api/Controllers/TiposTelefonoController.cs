using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Tipos Telefono Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class TiposTelefonoController(IControllerParameter parameters, IRepository<TipoTelefono, long> repository) : GenericController<TipoTelefono, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene la descripcion del tipo telefono
        /// </summary>
        /// <returns>Descripcion del tipo telefono</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre del tipo telefono
        /// </summary>
        /// <returns>Nombre del tipo telefono</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Nombre);
        }

        #endregion
    }
}