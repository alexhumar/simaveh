using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
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
        /// Obtiene los aceites recomendados del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Aceites recomendados del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetAceitesRecomendados([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.AceitesRecomendados);
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

            return entity == null ? NotFound() : Ok(entity.Airbags);
        }

        /// <summary>
        /// Obtiene las fuentes de energia recomendadas del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Fuentes de energia del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetFuentesEnergiaRecomendadas([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.FuentesEnergiaRecomendadas);
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

            return entity == null ? NotFound() : Ok(entity.GrupoModelo);
        }

        /// <summary>
        /// Obtiene las presiones de neumatico recomendadas del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Presiones de neumatico recomendadas del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetPresionesNeumaticoRecomendadas([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.PresionesNeumaticoRecomendadas);
        }

        /// <summary>
        /// Obtiene los repuestos recomendados del modelo vehiculo
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Repuestos recomendados del modelo vehiculo</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = ODataQueryConstants.PageSize)]
        public async Task<IActionResult> GetRepuestosRecomendados([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : Ok(entity.RepuestosRecomendados);
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

            return entity == null ? NotFound() : Ok(entity.TipoFuenteEnergia);
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

            return entity == null ? NotFound() : Ok(entity.Version);
        }

        /// <summary>
        /// Modifica el tipo fuente energia asociado a la fuente energia.
        /// O modifica la marca asociada a la fuente energia.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var grupoModeloTypeName = entityTypeGetter.GetTypeAsString<GrupoModelo, long>();
            var tipoFuenteEnergiaTypeName = entityTypeGetter.GetTypeAsString<TipoFuenteEnergia, long>();

            if (navigationProperty.Equals(grupoModeloTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<ModeloVehiculo, long, GrupoModelo, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.Airbags))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<ModeloVehiculo, long, EquipamientoAirbags, string>(Request, key, link);
            }
            else if (navigationProperty.Equals(tipoFuenteEnergiaTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<ModeloVehiculo, long, TipoFuenteEnergia, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.AceitesRecomendados))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<ModeloVehiculo, long, Aceite, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.FuentesEnergiaRecomendadas))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<ModeloVehiculo, long, FuenteEnergia, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.RepuestosRecomendados))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<ModeloVehiculo, long, Repuesto, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.PresionesNeumaticoRecomendadas))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<ModeloVehiculo, long, PresionNeumatico, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        /// <summary>
        /// Borra la referencia de un repuesto en la coleccion de repuestos recomendados.
        /// O borra la referencia de una presion de neumatico en la coleccion de presiones de neumaticos recomendadas.
        /// O borra la referencia de una fuente de energia en la coleccion de fuentes de energia recomendadas.
        /// O borra la referencia de un aceite en la coleccion de aceites recomendados.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override async Task<IActionResult> DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var resultado = HttpStatusCode.NotImplemented;

            if (navigationProperty.Equals(EntityProperty.RepuestosRecomendados))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<ModeloVehiculo, long, Repuesto, long>(Request, key, Convert.ToInt64(relatedKey));
            }
            else if (navigationProperty.Equals(EntityProperty.PresionesNeumaticoRecomendadas))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<ModeloVehiculo, long, PresionNeumatico, long>(Request, key, Convert.ToInt64(relatedKey));
            }
            else if (navigationProperty.Equals(EntityProperty.FuentesEnergiaRecomendadas))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<ModeloVehiculo, long, FuenteEnergia, long>(Request, key, Convert.ToInt64(relatedKey));
            }
            else if (navigationProperty.Equals(EntityProperty.AceitesRecomendados))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<ModeloVehiculo, long, Aceite, long>(Request, key, Convert.ToInt64(relatedKey));
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}