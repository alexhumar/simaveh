using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Repository
{
    /// <summary>
    /// Implementacion de IRepository sobre EF Core.
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    /// <param name="context"></param>
    public class Repository<TBe, TBeId>(SiMaVehContext context) : IRepository<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        private readonly SiMaVehContext context = context;

        /// <inheritdoc/>
        public async Task<int> AddAsync(TBe element)
        {
            context.Set<TBe>().Add(element);

            return await SaveChangesAsync();
        }

        /// <inheritdoc/>
        public IQueryable<TBe> GetQueryable()
        {
            return context.Set<TBe>();
        }

        /// <inheritdoc/>
        public async Task<TBe> FindAsync(TBeId key)
        {
            return await context.Set<TBe>().FindAsync(key);
        }

        /// <inheritdoc/>
        public async Task<int> RemoveAsync(TBe element)
        {
            context.Set<TBe>().Remove(element);

            return await SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task<int> UpdateAsync(TBe element)
        {
            var entity = await FindAsync(element.Id);
            if (entity != null)
            {
                context.Entry(entity).CurrentValues.SetValues(element);
            }

            return await SaveChangesAsync();
        }

        /// <inheritdoc/>
        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }
    }
}
