using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
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
    /// Fuentes Energia Controller
    /// </summary>
    public class FuentesEnergiaController : GenericController<FuenteEnergia, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public FuentesEnergiaController(IControllerParameter parameters)
            : base(parameters)
        {
        }

        #region properties

        /// <summary>
        /// Obtiene la marca de la fuente de energia
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Marca de la fuente de energia</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetMarca([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Marca);
        }

        /// <summary>
        /// Obtiene el nombre de la fuente de energia
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Nombre de la fuente de energia</returns>
        /// <response code="200"></response>
        public async Task<IActionResult> GetNombre([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.Nombre);
        }

        /// <summary>
        /// Obtiene el tipo de la fuente de energia
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Tipo de la fuente de energia</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public async Task<IActionResult> GetTipo([FromODataUri] long key)
        {
            var entity = await repository.FindAsync(key);

            return entity == null ? NotFound() : (IActionResult)Ok(entity.TipoFuenteEnergia);
        }

        /// <summary>
        /// Modifica el tipo fuente energia asociado a la fuente energia.
        /// O modifica la marca asociada a la fuente energia.
        /// O agrega un modelo de vehiculo a la coleccion de recomendaciones de modelos de vehiculo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpConstants.Post, HttpConstants.Put)]
        public async Task<IActionResult> CreateRef([FromODataUri] long key, string navigationProperty, [FromBody] Uri link)
        {
            var resultado = HttpStatusCode.NotImplemented;
            var tipoFuenteEnergiaTypeName = entityTypeGetter.GetTypeAsString<TipoFuenteEnergia, long>();
            var marcaTypeName = entityTypeGetter.GetTypeAsString<Marca, long>();

            if (navigationProperty.Equals(tipoFuenteEnergiaTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<FuenteEnergia, long, TipoFuenteEnergia, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(marcaTypeName))
            {
                resultado = await relatedEntityChanger.TryChangeRelatedEntityAsync<FuenteEnergia, long, Marca, long>(Request, key, link);
            }
            else if (navigationProperty.Equals(EntityProperty.RecomendacionesModeloVehiculo))
            {
                resultado = await relatedEntityAdder.TryAddRelatedEntityAsync<FuenteEnergia, long, ModeloVehiculo, long>(Request, key, link);
            }

            return ResultFromHttpStatusCode(resultado);
        }

        /// <summary>
        /// Borra la referencia de un modelo de vehiculo en la coleccion de recomendaciones de modelos de vehiculo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public override async Task<IActionResult> DeleteRef([FromODataUri] long key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            var resultado = HttpStatusCode.NotImplemented;

            if (navigationProperty.Equals(EntityProperty.RecomendacionesModeloVehiculo))
            {
                resultado = await relatedEntityRemover.TryRemoveRelatedEntityAsync<FuenteEnergia, long, ModeloVehiculo, long>(Request, key, Convert.ToInt64(relatedKey));
            }

            return ResultFromHttpStatusCode(resultado);
        }

        #endregion
    }
}