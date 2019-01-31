using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess;
using SiMaVeh.Domain.Models;
using SiMaVeh.Helpers;
using SiMaVeh.Parametrization;
using SiMaVeh.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Controllers
{
    /// <summary>
    /// Paises Controller
    /// </summary>
    public class GenericController<TBe, TBeId> : ODataController where TBe : DomainMember<TBeId>
    {
        /// <summary>
        /// _context
        /// </summary>
        protected readonly SiMaVehContext _context;

        /// <summary>
        /// _repository
        /// </summary>
        protected readonly IRepository<TBe, TBeId> _repository;

        /// <summary>
        /// _entityGetter
        /// </summary>
        protected readonly IEntityGetter _entityGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        public GenericController(IControllerParameter parameters)
        {
            _context = parameters.Context;
            _repository = new Repository<TBe, TBeId>(_context);
            _entityGetter = parameters.EntityGetter;
        }

        /// <summary>
        /// ExisteEntidad
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si existe entidad</returns>
        protected async Task<bool> ExisteEntidad(TBeId key)
        {
            return await _repository.Find(key) != null;
        }

        /// <summary>
        /// Obtiene todos los Paises
        /// </summary>
        /// <returns>Lista de entidades</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop, PageSize = QueryConstants.PageSize)]
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

            return await Task.Run(() => _repository.GetCollection());
        }

        /// <summary>
        /// Obtiene un Pais dado un Id
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

            var entity = await _repository.Find(key);

            if (entity != null)
                result.Add(entity);

            return SingleResult.Create(result.AsQueryable());
        }

        /// <summary>
        /// Crea un Pais
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Entidad creada</returns>
        /// <response code="201"></response>
        public virtual async Task<IActionResult> Post([FromBody] TBe entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ErrorsBuilder.BuildErrors(ModelState));

            try
            {
                await _repository.Add(entity);
            }
            catch(Exception e)
            {
                return StatusCode(500, ErrorsBuilder.BuildErrors(e));
            }

            return Created(entity);
        }

        /// <summary>
        /// Actualiza un Pais existente (HTTP PUT)
        /// </summary>
        /// <param name="key"></param>
        /// <param name="entity"></param>
        /// <returns>Entidad actualizada</returns>
        /// <response code="204"></response>
        public virtual async Task<IActionResult> Put([FromODataUri] TBeId key, [FromBody] TBe entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ErrorsBuilder.BuildErrors(ModelState));

            if (!await ExisteEntidad(key))
                return NotFound();

            if (!key.Equals(entity.Id))
                return BadRequest();

            try
            {
                await _repository.Update(entity);
            }
            catch (Exception e)
            {
                return StatusCode(500, ErrorsBuilder.BuildErrors(e));
            }

            return Updated(entity);
        }

        /// <summary>
        /// Actualiza un Pais existente (HTTP PATCH)
        /// </summary>
        /// <param name="key"></param>
        /// <param name="entity"></param>
        /// <returns>Entidad actualizada</returns>
        /// <response code="204"></response>
        public virtual async Task<IActionResult> Patch([FromODataUri] TBeId key, [FromBody] Delta<TBe> entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ErrorsBuilder.BuildErrors(ModelState));

            var existingEntity = await _repository.Find(key);
            if (existingEntity == null)
                return NotFound();

            entity.Patch(existingEntity);

            try
            {
                await _repository.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return StatusCode(500, ErrorsBuilder.BuildErrors(e));
            }

            return Updated(existingEntity);
        }

        /// <summary>
        /// Borra un Pais existente
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Sin return</returns>
        /// <response code="204"></response>
        public virtual async Task<IActionResult> Delete([FromODataUri] TBeId key)
        {
            var entity = await _repository.Find(key);
            if (entity == null)
                return NotFound();

            await _repository.Remove(entity);

            return NoContent();
        }

        /// <summary>
        /// Borra la referencia a la entidad, dependiendo del navigationProperty
        /// </summary>
        /// <param name="key"></param>
        /// <param name="navigationProperty"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        public virtual IActionResult DeleteRef([FromODataUri] TBeId key, string navigationProperty, [FromBody] Uri link)
        {
            return StatusCode((int)HttpStatusCode.NotImplemented);
        }

        /// <summary>
        /// Borra la referencia de un elemento en una coleccion determinada.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="relatedKey"></param>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        public virtual IActionResult DeleteRef([FromODataUri] TBeId key, [FromODataUri] string relatedKey, string navigationProperty)
        {
            return StatusCode((int)HttpStatusCode.NotImplemented);
        }
    }
}