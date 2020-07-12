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
        /// GetAllAsync
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TBe>> GetAllAsync()
        {
            return await context.Set<TBe>().ToListAsync();
        }

        /// <summary>
        /// AddAsync
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<int> AddAsync(TBe item)
        {
            context.Set<TBe>().Add(item);

            return await SaveChangesAsync();
        }

        /// <summary>
        /// FindAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<TBe> FindAsync(TBeId key)
        {
            return await context.Set<TBe>().FindAsync(key);
        }

        /// <summary>
        /// RemoveAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<int> RemoveAsync(TBeId key)
        {
            var entity = await FindAsync(key);
            context.Set<TBe>().Remove(entity);

            return await SaveChangesAsync();
        }

        /// <summary>
        /// RemoveAsync
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        public async Task<int> RemoveAsync(TBe elem)
        {
            context.Set<TBe>().Remove(elem);

            return await SaveChangesAsync();
        }

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(TBe item)
        {
            var entity = await FindAsync((TBeId)item.GetType().GetProperty("Id").GetValue(item));
            if (entity != null)
            {
                Entry(entity).CurrentValues.SetValues(item);
            }

            return await SaveChangesAsync();
        }

        /// <summary>
        /// GetCollectionAsync
        /// </summary>
        /// <returns></returns>
        public async Task<IQueryable<TBe>> GetCollectionAsync()
        {
            return await Task.Run(() => context.Set<TBe>().AsQueryable());
        }

        /// <summary>
        /// DisposeAsync
        /// </summary>
        public async Task DisposeAsync()
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
