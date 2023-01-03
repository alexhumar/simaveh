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
    public class RelatedEntityRemover : IRelatedEntityRemover
    {
        private readonly SiMaVehContext context;
        private readonly IGenericEntityGetter relatedEntityGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="relatedEntityGetter"></param>
        public RelatedEntityRemover(SiMaVehContext context,
            IGenericEntityGetter relatedEntityGetter)
        {
            this.context = context;
            this.relatedEntityGetter = relatedEntityGetter;
        }

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
