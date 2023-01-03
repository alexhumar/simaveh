using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Automoviles Controller
    /// </summary>
    public class AutomovilesController : GenericController<Automovil, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public AutomovilesController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene el anio de fabricacion del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Anio de fabricacion del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAnioFabricacion([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.AnioFabricacion);
        }

        /// <summary>
        /// Obtiene el codigo de color de pintura del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Codigo de color de pintura del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCodigoColorPintura([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.CodigoColorPintura);
        }

        /// <summary>
        /// Obtiene el kilometraje del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Kilometraje del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetKilometraje([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Kilometraje);
        }

        /// <summary>
        /// Obtiene el Modelo del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Modelo del automovil</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetModelo([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.ModeloVehiculo);
        }

        /// <summary>
        /// Obtiene el numero de chasis del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Numero de chasis del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNumeroChasis([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.NumeroChasis);
        }

        /// <summary>
        /// Obtiene la patente del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Patente del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetPatente([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Patente);
        }

        /// <summary>
        /// Obtiene los servicios reparadores del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Servicios reparadores del automovil</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetServiciosReparadores([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.ServiciosReparadores);
        }

        /// <summary>
        /// Obtiene el usuario del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Usuario del automovil</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetUsuario([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.Usuario);
        }

        /// <summary>
        /// Asocia un servicio reparador existente en la coleccion de servicios reparadores del automovil.
        /// O modifica el modelo vehiculo asociado al automovil.
        /// O modifica el usuario asociado al automovil.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var servicioReparadorCollectionName = entityTypeGetter.GetCollectionNameAsString<ServicioReparador, long>();
            var modeloVehiculoTypeName = entityTypeGetter.GetTypeAsString<ModeloVehiculo, long>();
            var usuarioTypeName = entityTypeGetter.GetTypeAsString<Usuario, long>();

            if (navigationProperty.Equals(servicioReparadorCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Vehiculo, long, ServicioReparador, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(modeloVehiculoTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Vehiculo, long, ModeloVehiculo, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(usuarioTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Vehiculo, long, Usuario, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}