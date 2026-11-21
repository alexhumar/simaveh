using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Fluidos Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class FluidosController(IControllerParameter parameters, IRepository<Fluido, long> repository) : GenericController<Fluido, long>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene la descripcion del fluido
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Descripcion del fluido</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDescripcion([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Descripcion);
        }

        /// <summary>
        /// Obtiene el nombre del fluido
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre del fluido</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            return await ObtenerPropiedad(key, entity => entity.Nombre);
        }

        #endregion
    }
}