﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Equipamientos Airbags Controller
    /// </summary>
    public class EquipamientosAirbagsController : GenericController<EquipamientoAirbags, string>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public EquipamientosAirbagsController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene si el equipamiento airbag es delantero derecho
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es delantero derecho</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDelanteroDerecho([FromODataUri] string key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.DelanteroDerecho);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es delantero izquierdo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es delantero izquierdo</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetDelanteroIzquierdo([FromODataUri] string key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.DelanteroIzquierdo);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es de acompañante
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es de guantera</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAcompanante([FromODataUri] string key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Acompanante);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es trasero derecho
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es trasero derecho</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetTraseroDerecho([FromODataUri] string key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.TraseroDerecho);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es trasero izquierdo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es trasero izquierdo</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetTraseroIzquierdo([FromODataUri] string key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.TraseroIzquierdo);
        }

        /// <summary>
        /// Obtiene si el equipamiento airbag es de conductor
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si el equipamiento airbag es de volante</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetConductor([FromODataUri] string key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Conductor);
        }

        #endregion
    }
}