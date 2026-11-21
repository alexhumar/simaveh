using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Utils.Interfaces;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Expone la version de la aplicacion. Esta fuera del prefijo OData (GET /version).
    /// </summary>
    /// <param name="informacionVersion"></param>
    [ApiController]
    [Route("version")]
    public class VersionController(IInformacionVersion informacionVersion) : ControllerBase
    {
        private readonly IInformacionVersion informacionVersion = informacionVersion;

        /// <summary>
        /// Obtiene la version de la aplicacion
        /// </summary>
        /// <returns>Nombre, version y build de la aplicacion</returns>
        /// <response code="200"></response>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                aplicacion = informacionVersion.Aplicacion,
                version = informacionVersion.Version,
                build = informacionVersion.Build
            });
        }
    }
}
