using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SiMaVeh.DataAcces.Model;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiMaVeh.DataAcces.Repository
{
    /// <summary>
    /// Repository
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    public class Repository<TBe, TBeId> : IRepository<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        private readonly SiMaVehContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public Repository(SiMaVehContext context)
        {
            _context = context;
        }

        #region ITodoRepository

        /// <summary>
        /// GetAll (async)
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TBe>> GetAllAsync()
        {
            return await Task.Run(() => _context.Set<TBe>().ToListAsync());
        }

        /// <summary>
        /// Add (async)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<int> Add(TBe item)
        {
            _context.Set<TBe>().Add(item);

            return await SaveChangesAsync();
        }

        /// <summary>
        /// Find (async)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<TBe> Find(TBeId key)
        {
            return await _context.Set<TBe>().FindAsync(key);
        }

        /// <summary>
        /// Remove (async)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<int> Remove(TBeId key)
        {
            var entity = await Find(key);
            _context.Set<TBe>().Remove(entity);

            return await SaveChangesAsync();
        }

        /// <summary>
        /// Remove (async)
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        public async Task<int> Remove(TBe elem)
        {
            _context.Set<TBe>().Remove(elem);

            return await SaveChangesAsync();
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<int> Update(TBe item)
        {
            var entity = await Find((TBeId)item.GetType().GetProperty("Id").GetValue(item));
            if (entity != null)
            {
                Entry(entity).CurrentValues.SetValues(item);
            }

            return await SaveChangesAsync();
        }

        /// <summary>
        /// GetCollection
        /// </summary>
        /// <returns></returns>
        public IQueryable<TBe> GetCollection()
        {
            return _context.Set<TBe>();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }

        /// <summary>
        /// Entry
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public EntityEntry<TBe> Entry(TBe element)
        {
            return _context.Entry(element);
        }

        /// <summary>
        /// SaveChangesAsync
        /// </summary>
        /// <returns></returns>
        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
        #endregion
    }
}
