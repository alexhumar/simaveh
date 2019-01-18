using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess;
using SiMaVeh.Domain.Models;
using SiMaVeh.Helpers;
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
        /// Constructor
        /// </summary>
        public GenericController(SiMaVehContext context)
        {
            _context = context;
            _repository = new Repository<TBe, TBeId>(_context);
        }

        /// <summary>
        /// ExisteEntidad
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Si existe entidad</returns>
        protected bool ExisteEntidad(TBeId key)
        {
            return _repository.GetCollection().Find(key) != null;
        }

        /// <summary>
        /// Obtiene todos los Paises
        /// </summary>
        /// <returns>Lista de entidades</returns>
        /// <response code="200"></response>
        [EnableQuery(MaxSkip = QueryConstants.MaxSkip, MaxTop = QueryConstants.MaxTop)]
        public virtual async Task<IQueryable<TBe>> Get()
        {
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
                return BadRequest(ModelState);

            await _repository.Add(entity);

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
                return BadRequest(ModelState);

            if (!key.Equals(entity.Id))
                return BadRequest();

            try
            {
                await _repository.Update(entity);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExisteEntidad(key))
                    return NotFound();
                else
                    throw;
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
                return BadRequest(ModelState);

            var existingEntity = await _repository.Find(key);
            if (existingEntity == null)
                return NotFound();

            entity.Patch(existingEntity);

            try
            {
                await _repository.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExisteEntidad(key))
                    return NotFound();
                else
                    throw;
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