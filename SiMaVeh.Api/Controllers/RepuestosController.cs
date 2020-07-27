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
    /// Repuestos Controller
    /// </summary>
    public class RepuestosController : GenericController<Repuesto, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public RepuestosController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene el codigo identificador del repuesto
        /// </summary>
        /// <returns>Codigo identificador del repuesto</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetCodigoIdentificador([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.CodigoIdentificador);
        }

        /// <summary>
        /// Obtiene los kits a los que pertenece el repuesto
        /// </summary>
        /// <returns>Kits a los que pertenece el repuesto</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetKits([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Kits);
        }

        /// <summary>
        /// Obtiene la marca del repuesto
        /// </summary>
        /// <returns>Marca del repuesto</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMarca([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Marca);
        }

        /// <summary>
        /// Obtiene las periodicidades de mantenimiento del repuesto
        /// </summary>
        /// <returns>Periodicidades de mantenimiento del repuesto</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public async Task<IActionResult> GetPeriodicidadesMantenimiento([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.PeriodicidadesMantenimiento);
        }

        /// <summary>
        /// Obtiene el target de mantenimiento del repuesto
        /// </summary>
        /// <returns>Target de mantenimiento del repuesto</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTargetMantenimiento([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.TargetMantenimiento);
        }

        /// <summary>
        /// Asocia un kit existente en la coleccion de kits del repuesto.
        /// O asocia una periodicidad mantenimiento existente en la coleccion de periodicidades mantenimiento del repuesto.
        /// O asocia un modelo vehiculo a la coleccion de recomendaciones modelo vehiculo.
        /// O modifica la marca asociada al repuesto.
        /// O modifica el target mantenimiento asociado al repuesto.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var periodicidadMantenimientoCollectionName = entityTypeGetter.GetCollectionNameAsString<PeriodicidadMantenimiento, long>();
            var marcaTypeName = entityTypeGetter.GetTypeAsString<Marca, long>();
            var targetMantenimientoTypeName = entityTypeGetter.GetTypeAsString<TargetMantenimiento, long>();

            if (navigationProperty.Equals(EntityProperty.Kits))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Repuesto, long, Kit, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(periodicidadMantenimientoCollectionName))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Repuesto, long, PeriodicidadMantenimiento, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.RecomendacionesModeloVehiculo))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<Repuesto, long, ModeloVehiculo, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(marcaTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Recambio, long, Marca, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(targetMantenimientoTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<Repuesto, long, TargetMantenimiento, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        /// <summary>
        /// Borra la referencia de un kit en la coleccion de kits.
        /// O borra la referencia de un modelo vehiculo en la coleccion de recomendaciones modelo vehiculo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override async Task<IActionResult> DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var resultado = HttpStatusCode.NotImplemented;

            if (navigationProperty.Equals(EntityProperty.Kits))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<Repuesto, long, Kit, long>(Request, key, Convert.ToInt64(relatedKey));
            }
            else if (navigationProperty.Equals(EntityProperty.RecomendacionesModeloVehiculo))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<Repuesto, long, ModeloVehiculo, long>(Request, key, Convert.ToInt64(relatedKey));
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}