using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Repository
{
    /// <summary>
    /// Repository
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    public class Repository<TBe, TBeId> : IRepository<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        private readonly SiMaVehContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public Repository(SiMaVehContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// GetAll (async)
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TBe>> GetAllAsync()
        {
            return await context.Set<TBe>().ToListAsync();
        }

        /// <summary>
        /// Add (async)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<int> Add(TBe item)
        {
            context.Set<TBe>().Add(item);

            return await SaveChangesAsync();
        }

        /// <summary>
        /// Find (async)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<TBe> Find(TBeId key)
        {
            return await context.Set<TBe>().FindAsync(key);
        }

        /// <summary>
        /// Remove (async)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<int> Remove(TBeId key)
        {
            var entity = await Find(key);
            context.Set<TBe>().Remove(entity);

            return await SaveChangesAsync();
        }

        /// <summary>
        /// Remove (async)
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        public async Task<int> Remove(TBe elem)
        {
            context.Set<TBe>().Remove(elem);

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
            return context.Set<TBe>();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public async Task Dispose()
        {
            await context.DisposeAsync();
        }

        /// <summary>
        /// Entry
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public EntityEntry<TBe> Entry(TBe element)
        {
            return context.Entry(element);
        }

        /// <summary>
        /// SaveChangesAsync
        /// </summary>
        /// <returns></returns>
        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }
    }
}
