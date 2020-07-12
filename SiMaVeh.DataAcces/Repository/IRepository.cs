using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Repository
{
    /// <summary>
    /// IRepository
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    public interface IRepository<TBe, TBeId> where TBe : class
    {
        /// <summary>
        /// Add async
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<int> AddAsync(TBe element);

        /// <summary>
        /// GetAllAsync
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TBe>> GetAllAsync();

        /// <summary>
        /// GetCollection
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<TBe>> GetCollectionAsync();

        /// <summary>
        /// FindAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<TBe> FindAsync(TBeId key);

        /// <summary>
        /// RemoveAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<int> RemoveAsync(TBeId key);

        /// <summary>
        /// RemoveAsync
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        Task<int> RemoveAsync(TBe elem);

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<int> UpdateAsync(TBe element);

        /// <summary>
        /// DisposeAsync
        /// </summary>
        Task DisposeAsync();

        /// <summary>
        /// Entry
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        EntityEntry<TBe> Entry(TBe element);

        /// <summary>
        /// SaveChangesASync
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync();
    }
}