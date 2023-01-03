using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model
{
    /// <summary>
    /// RelatedEntityAdder
    /// </summary>
    public class RelatedEntityAdder : IRelatedEntityAdder
    {
        private readonly SiMaVehContext context;
        private readonly IGenericEntityGetter genericEntityGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="genericEntityGetter"></param>
        public RelatedEntityAdder(SiMaVehContext context,
            IGenericEntityGetter genericEntityGetter)
        {

            this.context = context;
            this.genericEntityGetter = genericEntityGetter;
        }

        /// <summary>
        /// TryAddRelatedEntityAsync
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeKey"></param>
        /// <returns></returns>
        public async Task<bool> TryAddRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            var repositoryTargetBe = new Repository<TTargetBe, TTargetBeId>(context);

            var targetBe = await repositoryTargetBe.FindAsync(targetBeKey);
            if (targetBe == null)
            {
                return false;
            }

            var relatedBe = await genericEntityGetter.TryGetEntity<TRelatedBe, TRelatedBeId>(relatedBeKey);
            if (relatedBe == null)
            {
                return false;
            }

            targetBe.Agregar(relatedBe);

            await repositoryTargetBe.SaveChangesAsync();

            return true;
        }
    }
}
