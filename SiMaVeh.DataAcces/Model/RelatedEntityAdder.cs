using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model
{
    /// <summary>
    /// RelatedEntityAdder
    /// </summary>
    /// <param name="operador"></param>
    public class RelatedEntityAdder(IOperadorEntidadesRelacionadas operador) : IRelatedEntityAdder
    {
        private readonly IOperadorEntidadesRelacionadas operador = operador;

        /// <summary>
        /// Agrega la entidad relacionada a la coleccion de la entidad destino.
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeKey"></param>
        /// <returns>false si alguna de las entidades no existe</returns>
        public Task<bool> TryAddRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            return operador.AplicarAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(targetBeKey, relatedBeKey,
                (targetBe, relatedBe) => targetBe.Agregar(relatedBe));
        }
    }
}
