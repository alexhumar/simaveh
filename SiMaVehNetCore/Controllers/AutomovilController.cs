﻿using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Domain.Models;
using SiMaVeh.Helpers;
using SiMaVeh.HelpersHttpConstants;
using SiMaVeh.Parametrization;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Automovil Controller
    /// </summary>
    public class AutomovilController : GenericController<Automovil, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AutomovilController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene el anio de fabricacion del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Anio de fabricacion del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetAnioFabricacion([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.AnioFabricacion);
        }

        /// <summary>
        /// Obtiene el codigo de color de pintura del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Codigo de color de pintura del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCodigoColorPintura([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.CodigoColorPintura);
        }

        /// <summary>
        /// Obtiene el kilometraje del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Kilometraje del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetKilometraje([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Kilometraje);
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
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.ModeloVehiculo);
        }

        /// <summary>
        /// Obtiene el numero de chasis del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Numero de chasis del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNumeroChasis([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.NumeroChasis);
        }

        /// <summary>
        /// Obtiene la patente del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Patente del automovil</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetPatente([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Patente);
        }

        /// <summary>
        /// Obtiene los servicios reparadores del automovil
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Servicios reparadores del automovil</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetServiciosReparadores([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.ServiciosReparadores.AsQueryable());
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
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Usuario);
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
        [AcceptVerbs("POST", "PUT")]
        public async Task<IActionResult> CreateRef([FromODataUri] long key,
        string navigationProperty, [FromBody] Uri link)
        {
            if (link == null)
                return BadRequest();

            var automovil = await _repository.Find(key);
            if (automovil == null)
                return NotFound();

            var servicioReparadorCollectionName = EntityTypeGetter<ServicioReparador, long>.GetCollectionNameAsString();
            var modeloVehiculoTypeName = EntityTypeGetter<ModeloVehiculo, long>.GetTypeAsString();
            var usuarioTypeName = EntityTypeGetter<Usuario, long>.GetTypeAsString();

            if (navigationProperty.Equals(servicioReparadorCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var servicioReparador = await _entityGetter.TryGetEntityFromRelatedLink<ServicioReparador, long>(link);
                if (servicioReparador == null)
                    return NotFound();

                automovil.Agregar(servicioReparador);
            }
            else if (navigationProperty.Equals(modeloVehiculoTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var modeloVehiculo = await _entityGetter.TryGetEntityFromRelatedLink<ModeloVehiculo, long>(link);
                if (modeloVehiculo == null)
                    return NotFound();

                automovil.Cambiar(modeloVehiculo);
            }
            else if (navigationProperty.Equals(usuarioTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var usuario = await _entityGetter.TryGetEntityFromRelatedLink<Usuario, long>(link);
                if (usuario == null)
                    return NotFound();

                automovil.Cambiar(usuario);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}