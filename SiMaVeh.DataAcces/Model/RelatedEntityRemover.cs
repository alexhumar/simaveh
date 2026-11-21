using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model
{
    /// <summary>
    /// RelatedEntityRemover
    /// </summary>
    /// <param name="operador"></param>
    public class RelatedEntityRemover(IOperadorEntidadesRelacionadas operador) : IRelatedEntityRemover
    {
        private readonly IOperadorEntidadesRelacionadas operador = operador;

        /// <summary>
        /// Quita la entidad relacionada de la coleccion de la entidad destino.
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeKey"></param>
        /// <returns>false si alguna de las entidades no existe</returns>
        public Task<bool> TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            return operador.AplicarAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(targetBeKey, relatedBeKey,
                (targetBe, relatedBe) => targetBe.Quitar(relatedBe));
        }

        /// <summary>
        /// Quita la referencia de la entidad destino a la entidad relacionada.
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <returns>false si la entidad destino no existe</returns>
        public Task<bool> TryRemoveRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            return operador.AplicarAsync<TTargetBe, TTargetBeId>(targetBeKey, targetBe => targetBe.Cambiar(null));
        }
    }
}
