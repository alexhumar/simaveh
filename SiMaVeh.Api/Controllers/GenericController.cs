using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Api.ErrorManagement.Interfaces;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.Models;
using System;
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
        /// context
        /// </summary>
        protected readonly SiMaVehContext context;

        /// <summary>
        /// repository
        /// </summary>
        protected readonly IRepository<TBe, TBeId> repository;

        /// <summary>
        /// relatedEntityGetter
        /// </summary>
        protected readonly IRelatedEntityGetter relatedEntityGetter;

        /// <summary>
        /// relatedEntityChanger
        /// </summary>
        protected readonly IRelatedEntityChanger relatedEntityChanger;

        /// <summary>
        /// relatedEntityAdder
        /// </summary>
        protected readonly IRelatedEntityAdder relatedEntityAdder;

        /// <summary>
        /// relatedEntityRemover
        /// </summary>
        protected readonly IRelatedEntityRemover relatedEntityRemover;

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
            context = parameters.Context;
            repository = new Repository<TBe, TBeId>(context);
            relatedEntityGetter = parameters.RelatedEntityGetter;
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
                HttpStatusCode.NotImplemented => StatusCode((int)HttpStatusCode.NoContent),
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
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(errorsBuilder.BuildErrors(ModelState));
                }

                await repository.AddAsync(entity);

                return Created(entity);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, errorsBuilder.BuildErrors(e));
            }
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
            try
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
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, errorsBuilder.BuildErrors(e));
            }
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
            try
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
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, errorsBuilder.BuildErrors(e));
            }
        }

        /// <summary>
        /// Borra una entidad existente
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Sin return</returns>
        /// <response code="204"></response>
        public virtual async Task<IActionResult> Delete([FromODataUri] TBeId key)
        {
            try
            {
                var entity = await repository.FindAsync(key);
                if (entity == null)
                {
                    return NotFound();
                }

                await repository.RemoveAsync(entity);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, errorsBuilder.BuildErrors(e));
            }
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