using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Ubicacion Pieza Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class UbicacionesPiezaController(IControllerParameter parameters, IRepository<UbicacionPieza, string> repository) : GenericController<UbicacionPieza, string>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene si es pieza izquierda
        /// </summary>
        /// <returns>Si es pieza izquierda</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetIzquierda([FromODataUri] string key)
        {
            return await ObtenerPropiedad(key, entity => entity.Izquierda);
        }

        /// <summary>
        /// Obtiene si es pieza superior
        /// </summary>
        /// <returns>Si es pieza superior</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetSuperior([FromODataUri] string key)
        {
            return await ObtenerPropiedad(key, entity => entity.Superior);
        }

        #endregion
    }
}