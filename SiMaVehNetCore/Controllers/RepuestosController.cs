using Microsoft.AspNet.OData;
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
    /// Repuestos Controller
    /// </summary>
    public class RepuestosController : GenericController<Repuesto, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RepuestosController(IControllerParameter parameters) : base(parameters) { }

        #region properties

        /// <summary>
        /// Obtiene el codigo identificador del repuesto
        /// </summary>
        /// <returns>Codigo identificador del repuesto</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCodigoIdentificador([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.CodigoIdentificador);
        }

        /// <summary>
        /// Obtiene los kits a los que pertenece el repuesto
        /// </summary>
        /// <returns>Kits a los que pertenece el repuesto</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetKits([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Kits.AsQueryable());
        }

        /// <summary>
        /// Obtiene la marca del repuesto
        /// </summary>
        /// <returns>Marca del repuesto</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMarca([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.Marca);
        }

        /// <summary>
        /// Obtiene las periodicidades de mantenimiento del repuesto
        /// </summary>
        /// <returns>Periodicidades de mantenimiento del repuesto</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public async Task<IActionResult> GetPeriodicidadesMantenimiento([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.PeriodicidadesMantenimiento.AsQueryable());
        }

        /// <summary>
        /// Obtiene el target de mantenimiento del repuesto
        /// </summary>
        /// <returns>Target de mantenimiento del repuesto</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTargetMantenimiento([FromODataUri] long key)
        {
            var entity = await _repository.Find(key);

            if (entity == null)
                return NotFound();
            else
                return Ok(entity.TargetMantenimiento);
        }

        /// <summary>
        /// Asocia un kit existente en la coleccion de kits del repuesto.
        /// O asocia una periodicidad mantenimiento existente en la coleccion de periodicidades mantenimiento del repuesto.
        /// O modifica la marca asociada al repuesto.
        /// O modifica el target mantenimiento asociado al repuesto.
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

            var repuesto = await _repository.Find(key);
            if (repuesto == null)
                return NotFound();

            var kitsCollectionName = EntityTypeGetter<Kit, long>.GetCollectionNameAsString();
            var periodicidadMantenimientoCollectionName = EntityTypeGetter<PeriodicidadMantenimiento, long>.GetCollectionNameAsString();
            var marcaTypeName = EntityTypeGetter<Marca, long>.GetTypeAsString();
            var targetMantenimientoTypeName = EntityTypeGetter<TargetMantenimiento, long>.GetTypeAsString();

            if (navigationProperty.Equals(kitsCollectionName))
            {
                //El repuesto se agrega a un kit existente
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var kit = await _entityGetter.TryGetEntityFromRelatedLink<Kit, long>(link);
                if (kit == null)
                    return NotFound();

                repuesto.Agregar(kit);
            }
            else if (navigationProperty.Equals(periodicidadMantenimientoCollectionName))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                    return BadRequest();

                var periodicidadMantenimiento = await _entityGetter.TryGetEntityFromRelatedLink<PeriodicidadMantenimiento, long>(link);
                if (periodicidadMantenimiento == null)
                    return NotFound();

                repuesto.Agregar(periodicidadMantenimiento);
            }
            else if (navigationProperty.Equals(marcaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var marca = await _entityGetter.TryGetEntityFromRelatedLink<Marca, long>(link);
                if (marca == null)
                    return NotFound();

                repuesto.Cambiar(marca);
            }
            else if (navigationProperty.Equals(targetMantenimientoTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                    return BadRequest();

                var targetMantenimiento = await _entityGetter.TryGetEntityFromRelatedLink<TargetMantenimiento, long>(link);
                if (targetMantenimiento == null)
                    return NotFound();

                repuesto.Cambiar(targetMantenimiento);
            }
            else
                return StatusCode((int)HttpStatusCode.NotImplemented);

            await _repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}