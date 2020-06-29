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
        /// Add (async)
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<int> Add(TBe element);

        /// <summary>
        /// GetAll (async)
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TBe>> GetAllAsync();

        /// <summary>
        /// GetCollection
        /// </summary>
        /// <returns></returns>
        IQueryable<TBe> GetCollection();

        /// <summary>
        /// Find (async)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<TBe> Find(TBeId key);

        /// <summary>
        /// Remove (async)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<int> Remove(TBeId key);

        /// <summary>
        /// Remove (async)
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        Task<int> Remove(TBe elem);

        /// <summary>
        /// Update (async)
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<int> Update(TBe element);

        /// <summary>
        /// Dispose
        /// </summary>
        void Dispose();

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