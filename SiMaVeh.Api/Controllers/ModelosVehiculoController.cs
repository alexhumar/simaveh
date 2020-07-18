using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Modelos Vehiculo Controller
    /// </summary>
    public class ModelosVehiculoController : GenericController<ModeloVehiculo, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public ModelosVehiculoController(IControllerParameter parameters)
            : base(parameters)
        {
        }

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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.AceiteRecomendado);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Airbags);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.FuenteEnergiaRecomendada);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.GrupoModelo);
        }

        /// <summary>
        /// Obtiene las presiones de neumaticos recomendada del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Presiones de neumaticos recomendada del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetPresionesNeumaticosRecomendadas([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.PresionesNeumaticosRecomendadas);
        }

        /// <summary>
        /// Obtiene los repuestos recomendados del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Repuestos recomendados del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetRepuestosRecomendados([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.RepuestosRecomendados);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.TipoFuenteEnergia);
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
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Version);
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
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            if (link == null)
            {
                return BadRequest();
            }

            var modeloVehiculo = await repository.FindAsync(key);
            if (modeloVehiculo == null)
            {
                return NotFound();
            }

            var grupoModeloTypeName = entityTypeGetter.GetTypeAsString<GrupoModelo, long>();
            var tipoFuenteEnergiaTypeName = entityTypeGetter.GetTypeAsString<TipoFuenteEnergia, long>();

            if (navigationProperty.Equals(grupoModeloTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                {
                    return BadRequest();
                }

                var grupoModelo = await relatedEntityGetter.TryGetEntityFromRelatedLink<GrupoModelo, long>(link);
                if (grupoModelo == null)
                {
                    return NotFound();
                }

                modeloVehiculo.Cambiar(grupoModelo);
            }
            else if (navigationProperty.Equals(EntityProperty.AceiteRecomendado))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                {
                    return BadRequest();
                }

                var aceite = await relatedEntityGetter.TryGetEntityFromRelatedLink<Aceite, long>(link);
                if (aceite == null)
                {
                    return NotFound();
                }

                modeloVehiculo.Cambiar(aceite);
            }
            else if (navigationProperty.Equals(EntityProperty.Airbags))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                {
                    return BadRequest();
                }

                var airbags = await relatedEntityGetter.TryGetEntityFromRelatedLink<EquipamientoAirbags, string>(link);
                if (airbags == null)
                {
                    return NotFound();
                }

                modeloVehiculo.Cambiar(airbags);
            }
            else if (navigationProperty.Equals(tipoFuenteEnergiaTypeName))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                {
                    return BadRequest();
                }

                var tipoFuenteEnergia = await relatedEntityGetter.TryGetEntityFromRelatedLink<TipoFuenteEnergia, long>(link);
                if (tipoFuenteEnergia == null)
                {
                    return NotFound();
                }

                modeloVehiculo.Cambiar(tipoFuenteEnergia);
            }
            else if (navigationProperty.Equals(EntityProperty.FuenteEnergiaRecomendada))
            {
                if (!Request.Method.Equals(HttpConstants.Put))
                {
                    return BadRequest();
                }

                var fuenteEnergia = await relatedEntityGetter.TryGetEntityFromRelatedLink<FuenteEnergia, long>(link);
                if (fuenteEnergia == null)
                {
                    return NotFound();
                }

                modeloVehiculo.Cambiar(fuenteEnergia);
            }
            else if (navigationProperty.Equals(EntityProperty.RepuestosRecomendados))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                {
                    return BadRequest();
                }

                var repuesto = await relatedEntityGetter.TryGetEntityFromRelatedLink<Repuesto, long>(link);
                if (repuesto == null)
                {
                    return NotFound();
                }

                modeloVehiculo.Agregar(repuesto);
            }
            else if (navigationProperty.Equals(EntityProperty.PresionesNeumaticosRecomendadas))
            {
                if (!Request.Method.Equals(HttpConstants.Post))
                {
                    return BadRequest();
                }

                var presionNeumatico = await relatedEntityGetter.TryGetEntityFromRelatedLink<PresionNeumatico, long>(link);
                if (presionNeumatico == null)
                {
                    return NotFound();
                }

                modeloVehiculo.Agregar(presionNeumatico);
            }
            else
            {
                return StatusCode((int)HttpStatusCode.NotImplemented);
            }

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Borra la referencia de un repuesto en la coleccion de repuestos recomendados.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override async Task<IActionResult> DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var modeloVehiculo = await repository.FindAsync(key);
            if (modeloVehiculo == null)
            {
                return NotFound();
            }

            if (navigationProperty.Equals(EntityProperty.RepuestosRecomendados))
            {
                //TODO: a nuevo metodo en RelatedEntityGetter
                var repuesto = await new Repository<Repuesto, long>(context).FindAsync(Convert.ToInt64(relatedKey));
                if (repuesto == null)
                {
                    return NotFound();
                }

                modeloVehiculo.Quitar(repuesto);
            }

            await repository.SaveChangesAsync();

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion
    }
}