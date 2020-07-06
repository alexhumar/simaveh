using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Servicios Reparadores Controller
    /// </summary>
    public class ServiciosReparadoresController : GenericController<ServicioReparador, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ServiciosReparadoresController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene la entidad reparadora del servicio reparador
        /// </summary>
        /// <returns>Entidad reparadora del servicio reparador</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetEntidadReparadora([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.EntidadReparadora);
        }

        /// <summary>
        /// Obtiene la fecha fin del servicio reparador
        /// </summary>
        /// <returns>Fecha fin del servicio reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetFechaFin([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.FechaFin);
        }

        /// <summary>
        /// Obtiene la fecha inicio del servicio reparador
        /// </summary>
        /// <returns>Fecha inicio del servicio reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetFechaInicio([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.FechaInicio);
        }

        /// <summary>
        /// Obtiene el kilometraje vehiculo del servicio reparador
        /// </summary>
        /// <returns>Kilometraje vehiculo del servicio reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetKilometrajeVehiculo([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.KilometrajeVehiculo);
        }

        /// <summary>
        /// Obtiene los mantenimientos del servicio reparador
        /// </summary>
        /// <returns>Mantenimientos del servicio reparador</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetMantenimientos([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Mantenimientos.AsQueryable());
        }

        /// <summary>
        /// Obtiene la moneda del monto de mano de obra del servicio reparador
        /// </summary>
        /// <returns>Moneda del monto de mano de obra del servicio reparador</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMonedaMontoManoObra([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.MonedaMontoManoObra);
        }

        /// <summary>
        /// Obtiene el monto de mano de obra del servicio reparador
        /// </summary>
        /// <returns>Monto de mano de obra del servicio reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetMontoManoObra([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.MontoManoObra);
        }

        /// <summary>
        /// Obtiene el vehiculo del servicio reparador
        /// </summary>
        /// <returns>Vehiculo del servicio reparador</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetVehiculo([FromODataUri] long key)
        {
            var entity = await repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Vehiculo);
        }

        /// <summary>
        /// Asocia un mantenimiento existente en la coleccion de mantenimientos del servicio reparador.
        /// O modifica el vehiculo asociado al servicio reparador.
        /// O modifica la entidad reparadora asociada al servicio reparador.
        /// O modifica la moneda del monto de mano de obra asociada al servicio reparador.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs("POST", "PUT")]
        public async Task<IActionResult> CreateRef([FromODataUri] long key,
        string navigationProperty, [FromBody] Uri link)
        {
            if (link == null)
                return BadRequest();

            var servicioReparador = await repository.Find(key);
            if (servicioReparador == null)
                return NotFound();

            var mantenimientoCollectionName = EntityTypeGetter<Mantenimiento, long>.GetCollectionNameAsString();
            var vehiculoTypeName = EntityTypeGetter<Vehiculo, long>.GetCollectionNameAsString();
            var entidadReparadoraTypeName = EntityTypeGetter<EntidadReparadora, long>.GetTypeAsString();

            if (navigationProperty.Equals(mantenimientoCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var mantenimiento = await entityGetter.TryGetEntityFromRelatedLink<Mantenimiento, long>(link);
                if (mantenimiento == null)
                    return NotFound();

                servicioReparador.Agregar(mantenimiento);
            }
            else if (navigationProperty.Equals(vehiculoTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var vehiculo = await entityGetter.TryGetEntityFromRelatedLink<Vehiculo, long>(link);
                if (vehiculo == null)
                    return NotFound();

                servicioReparador.Cambiar(vehiculo);
            }
            else if (navigationProperty.Equals(entidadReparadoraTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var entidadReparadora = await entityGetter.TryGetEntityFromRelatedLink<EntidadReparadora, long>(link);
                if (entidadReparadora == null)
                    return NotFound();

                servicioReparador.Cambiar(entidadReparadora);
            }
            else if (navigationProperty.Equals(EntityProperty.MonedaMontoManoObra))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var moneda = await entityGetter.TryGetEntityFromRelatedLink<Moneda, string>(link);
                if (moneda == null)
                    return NotFound();

                servicioReparador.Cambiar(moneda);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}