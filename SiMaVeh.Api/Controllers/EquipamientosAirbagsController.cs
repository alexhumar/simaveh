using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Equipamientos Airbags Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class EquipamientosAirbagsController(IControllerParameter parameters, IRepository<EquipamientoAirbags, string> repository) : GenericController<EquipamientoAirbags, string>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene si el equipamiento airbag es delantero derecho
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es delantero derecho</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDelanteroDerecho([FromODataUri] string key)
        {
            return await ObtenerPropiedad(key, entity => entity.DelanteroDerecho);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es delantero izquierdo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es delantero izquierdo</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDelanteroIzquierdo([FromODataUri] string key)
        {
            return await ObtenerPropiedad(key, entity => entity.DelanteroIzquierdo);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es de acompañante
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es de guantera</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAcompanante([FromODataUri] string key)
        {
            return await ObtenerPropiedad(key, entity => entity.Acompanante);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es trasero derecho
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es trasero derecho</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetTraseroDerecho([FromODataUri] string key)
        {
            return await ObtenerPropiedad(key, entity => entity.TraseroDerecho);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es trasero izquierdo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es trasero izquierdo</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetTraseroIzquierdo([FromODataUri] string key)
        {
            return await ObtenerPropiedad(key, entity => entity.TraseroIzquierdo);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es de conductor
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es de volante</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetConductor([FromODataUri] string key)
        {
            return await ObtenerPropiedad(key, entity => entity.Conductor);
        }

        #endregion
    }
}