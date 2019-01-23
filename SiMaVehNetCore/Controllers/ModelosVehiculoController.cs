using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Domain.Models;
using SiMaVeh.Helpers;
using SiMaVeh.HelpersHttpConstants;
using SiMaVeh.Parametrization;
using SiMaVeh.Repository;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Modelos Vehiculo Controller
    /// </summary>
    public class ModelosVehiculoController : GenericController<ModeloVehiculo, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ModelosVehiculoController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene el aceite recomendado del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Aceite recomendado del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetAceiteRecomendado([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.AceiteRecomendado);
        }

        /// <summary>
        /// Obtiene el equipamiento airbag del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Equipamiento airbag del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetAirbags([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Airbags);
        }

        /// <summary>
        /// Obtiene la fuente de energia recomendada del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Fuente de energia del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetFuenteEnergiaRecomendada([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.FuenteEnergiaRecomendada);
        }

        /// <summary>
        /// Obtiene el grupo modelo del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Grupo modelo del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetGrupoModelo([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.GrupoModelo);
        }

        /// <summary>
        /// Obtiene las presiones de neumaticos recomendada del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Presiones de neumaticos recomendada del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetPresionesNeumaticosRecomendadas([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.PresionesNeumaticosRecomendadas.AsQueryable());
        }

        /// <summary>
        /// Obtiene los repuestos recomendados del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Repuestos recomendados del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetRepuestosRecomendados([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.RepuestosRecomendados.AsQueryable());
        }

        /// <summary>
        /// Obtiene el tipo de fuente de energia del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Tipo de fuente de energia del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTipoFuenteEnergia([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.TipoFuenteEnergia);
        }

        /// <summary>
        /// Obtiene la version del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Version del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetVersion([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Version);
        }

        /// <summary>
        /// Modifica el tipo fuente energia asociado a la fuente energia.
        /// O modifica la marca asociada a la fuente energia.
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

            var modeloVehiculo = await _repository.Find(key);
            if (modeloVehiculo == null)
                return NotFound();

            var grupoModeloTypeName = EntityTypeGetter<GrupoModelo, long>.GetTypeAsString();
            var tipoFuenteEnergiaTypeName = EntityTypeGetter<TipoFuenteEnergia, long>.GetTypeAsString();
            

            if (navigationProperty.Equals(grupoModeloTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var grupoModelo = await _entityGetter.TryGetEntityFromRelatedLink<GrupoModelo, long>(link);
                if (grupoModelo == null)
                    return NotFound();

                modeloVehiculo.Cambiar(grupoModelo);
            }
            else if (navigationProperty.Equals(PropertyConstants.AceiteRecomendado))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var aceite = await _entityGetter.TryGetEntityFromRelatedLink<Aceite, long>(link);
                if (aceite == null)
                    return NotFound();

                modeloVehiculo.Cambiar(aceite);
            }
            else if (navigationProperty.Equals(PropertyConstants.Airbags))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var airbags = await _entityGetter.TryGetEntityFromRelatedLink<EquipamientoAirbags, long>(link);
                if (airbags == null)
                    return NotFound();

                modeloVehiculo.Cambiar(airbags);
            }
            else if (navigationProperty.Equals(tipoFuenteEnergiaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var tipoFuenteEnergia = await _entityGetter.TryGetEntityFromRelatedLink<TipoFuenteEnergia, long>(link);
                if (tipoFuenteEnergia == null)
                    return NotFound();

                modeloVehiculo.Cambiar(tipoFuenteEnergia);
            }
            else if (navigationProperty.Equals(PropertyConstants.FuenteEnergiaRecomendada))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var fuenteEnergia = await _entityGetter.TryGetEntityFromRelatedLink<FuenteEnergia, long>(link);
                if (fuenteEnergia == null)
                    return NotFound();

                modeloVehiculo.Cambiar(fuenteEnergia);
            }
            else if (navigationProperty.Equals(PropertyConstants.RepuestosRecomendados))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var repuesto = await _entityGetter.TryGetEntityFromRelatedLink<Repuesto, long>(link);
                if (repuesto == null)
                    return NotFound();

                modeloVehiculo.Agregar(repuesto);
            }
            else if (navigationProperty.Equals(PropertyConstants.PresionesNeumaticosRecomendadas))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var presionNeumatico = await _entityGetter.TryGetEntityFromRelatedLink<PresionNeumatico, long>(link);
                if (presionNeumatico == null)
                    return NotFound();

                modeloVehiculo.Agregar(presionNeumatico);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Borra la referencia de un repuesto en la coleccion de repuestos recomendados.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override IActionResult DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var modeloVehiculo = _repository.Find(key).Result;
            if (modeloVehiculo == null)
                return NotFound();

            if (navigationProperty.Equals(PropertyConstants.RepuestosRecomendados))
            {
                var repuesto = new Repository<Repuesto, long>(_context).Find(Convert.ToInt64(relatedKey)).Result;
                if (repuesto == null)
                    return NotFound();

                modeloVehiculo.Quitar(repuesto);
            }

            _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}