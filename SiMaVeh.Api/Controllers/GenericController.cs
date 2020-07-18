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
            entityTypeGetter = parameters.EntityTypeGetter;
            errorsBuilder = parameters.ErrorsBuilder;
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
        [EnableQuery(/*MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop,*/ PageSize = QueryConstants.PageSize)]
        public virtual async Task</*PageResult*/IQueryable<TBe>> Get(/*ODataQueryOptions<TBe> options*/)
        {
            //Con este codigo comentado se consigue un resultado paginado y con el inlinecount seteado, pero no soporta expand.
            // ODataQuerySettings settings = new ODataQuerySettings()
            // {
            //     PageSize = QueryConstants.PageSize
            // };

            // IQueryable results = options.ApplyTo(await Task.Run(() => _repository.GetCollection()), settings);

            // return new PageResult<TBe>(
            //     results as IEnumerable<TBe>, 
            //     Request.GetNextPageLink(QueryConstants.PageSize),
            //     (results as IEnumerable<TBe>).Count());

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
            //Esto lo comparo asi porque si comparo directamente con el Equals, Linq me tira error. Tener cuidado con esto, si algun
            //dia se me da por tener claves compuestas. Como son todas long, por ahora esto funciona bien. Pero si fueran compuestas,
            //el ToString podria devolver un valor que no sea unico.
            //IQueryable<TBe> result = await Task.Run(() => _repository.GetCollection().Where(p => p.Id.ToString() == key.ToString()));

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

            try
            {
                await repository.AddAsync(entity);
            }
            catch (Exception e)
            {
                return StatusCode(500, errorsBuilder.BuildErrors(e));
            }

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

            if (!await ExisteEntidad(key))
            {
                return NotFound();
            }

            if (!key.Equals(entity.Id))
            {
                return BadRequest();
            }

            try
            {
                await repository.UpdateAsync(entity);
            }
            catch (Exception e)
            {
                return StatusCode(500, errorsBuilder.BuildErrors(e));
            }

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

            try
            {
                await repository.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return StatusCode(500, errorsBuilder.BuildErrors(e));
            }

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
        /// <param name="link"></param>
        /// <returns></returns>
        public virtual async Task<IActionResult> DeleteRef([FromODataUri] TBeId key, string navigationProperty, [FromBody] Uri link)
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