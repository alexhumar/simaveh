using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Monedas Controller
    /// </summary>
    public class MonedasController : GenericController<Moneda, string>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public MonedasController(IControllerParameter parameters)
            : base(parameters)
        {
        }

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