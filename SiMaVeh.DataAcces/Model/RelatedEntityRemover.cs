using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model
{
    /// <summary>
    /// RelatedEntityRemover
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="context"></param>
    /// <param name="relatedEntityGetter"></param>
    public class RelatedEntityRemover(SiMaVehContext context,
        IGenericEntityGetter relatedEntityGetter) : IRelatedEntityRemover
    {
        private readonly SiMaVehContext context = context;
        private readonly IGenericEntityGetter relatedEntityGetter = relatedEntityGetter;

        /// <summary>
        /// TryRemoveRelatedEntityAsync
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeKey"></param>
        /// <returns></returns>
        public async Task<bool> TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            var repositoryTargetBe = new Repository<TTargetBe, TTargetBeId>(context);

            var targetBe = await repositoryTargetBe.FindAsync(targetBeKey);
            if (targetBe == null)
            {
                return false;
            }

            var relatedBe = await relatedEntityGetter.TryGetEntity<TRelatedBe, TRelatedBeId>(relatedBeKey);
            if (relatedBe == null)
            {
                return false;
            }

            targetBe.Quitar(relatedBe);

            await repositoryTargetBe.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// TryRemoveRelatedEntityAsync
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <returns></returns>
        public async Task<bool> TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            var repositoryTargetBe = new Repository<TTargetBe, TTargetBeId>(context);

            var targetBe = await repositoryTargetBe.FindAsync(targetBeKey);
            if (targetBe == null)
            {
                return false;
            }

            targetBe.Cambiar(null);

            await repositoryTargetBe.SaveChangesAsync();

            return true;
        }
    }
}
