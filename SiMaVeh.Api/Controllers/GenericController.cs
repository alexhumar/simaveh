using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Api.ErrorManagement.Interfaces;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Controllers
{
    /// <summary>
    /// Generic Controller
    /// </summary>
    public class GenericController<TBe, TBeId> : ODataController where TBe : DomainMember<TBeId>
    {
        /// <summary>
        /// repository
        /// </summary>
        protected readonly IRepository<TBe, TBeId> repository;

        /// <summary>
        /// relatedEntityChanger
        /// </summary>
        protected readonly IODataRelatedEntityChanger relatedEntityChanger;

        /// <summary>
        /// relatedEntityAdder
        /// </summary>
        protected readonly IODataRelatedEntityAdder relatedEntityAdder;

        /// <summary>
        /// relatedEntityRemover
        /// </summary>
        protected readonly IODataRelatedEntityRemover relatedEntityRemover;

        /// <summary>
        /// entityTypeGetter
        /// </summary>
        protected readonly IEntityTypeGetter entityTypeGetter;

        /// <summary>
        /// errorsBuilder
        /// </summary>
        protected readonly IErrorsBuilder errorsBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parameters"></param>
        public GenericController(IControllerParameter parameters)
        {
            repository = new Repository<TBe, TBeId>(parameters.Context);
            relatedEntityChanger = parameters.RelatedEntityChanger;
            relatedEntityAdder = parameters.RelatedEntityAdder;
            relatedEntityRemover = parameters.RelatedEntityRemover;
            entityTypeGetter = parameters.EntityTypeGetter;
            errorsBuilder = parameters.ErrorsBuilder;
        }

        protected IActionResult ResultFromHttpStatusCode(HttpStatusCode httpStatusCode)
        {
            return httpStatusCode switch
            {
                HttpStatusCode.BadRequest => BadRequest(),
                HttpStatusCode.NoContent => NoContent(),
                HttpStatusCode.NotFound => NotFound(),
                HttpStatusCode.NotImplemented => StatusCode((int)HttpStatusCode.NotImplemented),
                HttpStatusCode.InternalServerError => StatusCode((int)HttpStatusCode.InternalServerError),
                _ => Ok(),
            };
        }

        /// <summary>
        /// ExisteEntidad
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si existe entidad</returns>
        protected async Task<bool> ExisteEntidad(TBeId key)
        {
            return await repository.FindAsync(key) != null;
        }

        /// <summary>
        /// Obtiene todas las entidades, sin filtrar
        /// </summary>
        /// <returns>Lista de entidades</returns>
        /// <response code="200"></response>
        [EnableQuery(PageSize = QueryConstants.PageSize)]
        public virtual async Task<IQueryable<TBe>> Get()
        {
            return await repository.GetCollectionAsync();
        }

        /// <summary>
        /// Obtiene una entidad dado su key
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Una entidad o null</returns>
        /// <response code="200"></response>
        [EnableQuery]
        public virtual async Task<SingleResult<TBe>> Get([FromODataUri] TBeId key)
        {
            IList<TBe> result = new List<TBe>();

            var entity = await repository.FindAsync(key);

            if (entity != null)
            {
                result.Add(entity);
            }

            return SingleResult.Create(result.AsQueryable());
        }

        /// <summary>
        /// Crea una entidad
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Entidad creada</returns>
        /// <response code="201"></response>
        public virtual async Task<IActionResult> Post([FromBody] TBe entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(errorsBuilder.BuildErrors(ModelState));
            }

            await repository.AddAsync(entity);

            return Created(entity);
        }

        /// <summary>
        /// Actualiza una entidad existente
        /// </summary>
        /// <param name="key"></param>
        /// <param name="entity"></param>
        /// <returns>Entidad actualizada</returns>
        /// <response code="204"></response>
        public virtual async Task<IActionResult> Put([FromODataUri] TBeId key, [FromBody] TBe entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(errorsBuilder.BuildErrors(ModelState));
            }

            if (!key.Equals(entity.Id))
            {
                return BadRequest();
            }

            if (!await ExisteEntidad(key))
            {
                return NotFound();
            }

            await repository.UpdateAsync(entity);

            return Updated(entity);
        }

        /// <summary>
        /// Actualiza una entidad existente
        /// </summary>
        /// <param name="key"></param>
        /// <param name="entity"></param>
        /// <returns>Entidad actualizada</returns>
        /// <response code="204"></response>
        public virtual async Task<IActionResult> Patch([FromODataUri] TBeId key, [FromBody] Delta<TBe> entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(errorsBuilder.BuildErrors(ModelState));
            }

            var existingEntity = await repository.FindAsync(key);
            if (existingEntity == null)
            {
                return NotFound();
            }

            entity.Patch(existingEntity);

            await repository.SaveChangesAsync();

            return Updated(existingEntity);
        }

        /// <summary>
        /// Borra una entidad existente
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Sin return</returns>
        /// <response code="204"></response>
        public virtual async Task<IActionResult> Delete([FromODataUri] TBeId key)
        {
            var entity = await repository.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }

            await repository.RemoveAsync(entity);

            return NoContent();
        }

        /// <summary>
        /// Borra la referencia a la entidad, dependiendo del navigationProperty
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public virtual async Task<IActionResult> DeleteRef([FromODataUri] TBeId key, string navigationProperty)
        {
            return await Task.Run(() => StatusCode((int)HttpStatusCode.NotImplemented));
        }

        /// <summary>
        /// Borra la referencia de un elemento en una coleccion determinada.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public virtual async Task<IActionResult> DeleteRef([FromODataUri] TBeId key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            return await Task.Run(() => StatusCode((int)HttpStatusCode.NotImplemented));
        }
    }
}