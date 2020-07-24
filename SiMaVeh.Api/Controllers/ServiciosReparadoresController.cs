using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Servicios Reparadores Controller
    /// </summary>
    public class ServiciosReparadoresController : GenericController<ServicioReparador, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public ServiciosReparadoresController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la entidad reparadora del servicio reparador
        /// </summary>
        /// <returns>Entidad reparadora del servicio reparador</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetEntidadReparadora([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.EntidadReparadora);
        }

        /// <summary>
        /// Obtiene la fecha fin del servicio reparador
        /// </summary>
        /// <returns>Fecha fin del servicio reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetFechaFin([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.FechaFin);
        }

        /// <summary>
        /// Obtiene la fecha inicio del servicio reparador
        /// </summary>
        /// <returns>Fecha inicio del servicio reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetFechaInicio([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.FechaInicio);
        }

        /// <summary>
        /// Obtiene el kilometraje vehiculo del servicio reparador
        /// </summary>
        /// <returns>Kilometraje vehiculo del servicio reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetKilometrajeVehiculo([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.KilometrajeVehiculo);
        }

        /// <summary>
        /// Obtiene los mantenimientos del servicio reparador
        /// </summary>
        /// <returns>Mantenimientos del servicio reparador</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetMantenimientos([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Mantenimientos);
        }

        /// <summary>
        /// Obtiene la moneda del monto de mano de obra del servicio reparador
        /// </summary>
        /// <returns>Moneda del monto de mano de obra del servicio reparador</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMonedaMontoManoObra([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.MonedaMontoManoObra);
        }

        /// <summary>
        /// Obtiene el monto de mano de obra del servicio reparador
        /// </summary>
        /// <returns>Monto de mano de obra del servicio reparador</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetMontoManoObra([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.MontoManoObra);
        }

        /// <summary>
        /// Obtiene el vehiculo del servicio reparador
        /// </summary>
        /// <returns>Vehiculo del servicio reparador</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetVehiculo([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Vehiculo);
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
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var mantenimientoCollectionName = entityTypeGetter.GetCollectionNameAsString<Mantenimiento, long>();
            var vehiculoTypeName = entityTypeGetter.GetCollectionNameAsString<Vehiculo, long>();
            var entidadReparadoraTypeName = entityTypeGetter.GetTypeAsString<EntidadReparadora, long>();

            if (navigationProperty.Equals(mantenimientoCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<ServicioReparador, long, Mantenimiento, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(vehiculoTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<ServicioReparador, long, Vehiculo, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(entidadReparadoraTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<ServicioReparador, long, EntidadReparadora, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.MonedaMontoManoObra))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<ServicioReparador, long, Moneda, string>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}