using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Monedas Controller
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="parameters"></param>
    /// <param name="repository"></param>
    public class MonedasController(IControllerParameter parameters, IRepository<Moneda, string> repository) : GenericController<Moneda, string>(parameters, repository)
    {

        #region properties

        /// <summary>
        /// Obtiene el nombre de la moneda
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la moneda</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] string key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Nombre);
        }

        #endregion
    }
}