using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model
{
    /// <summary>
    /// RelatedEntityChanger
    /// </summary>
    /// <param name="operador"></param>
    public class RelatedEntityChanger(IOperadorEntidadesRelacionadas operador) : IRelatedEntityChanger
    {
        private readonly IOperadorEntidadesRelacionadas operador = operador;

        /// <summary>
        /// Cambia la entidad relacionada de la entidad destino mediante IEntityChanger.
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeKey"></param>
        /// <returns>false si alguna de las entidades no existe</returns>
        public Task<bool> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            return TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(targetBeKey, relatedBeKey,
                (targetBe, relatedBe) => targetBe.Cambiar(relatedBe));
        }

        /// <summary>
        /// Cambia la entidad relacionada de la entidad destino mediante la accion indicada.
        /// Util cuando la entidad destino tiene mas de una navegacion al mismo tipo (por ejemplo TipoCambio y sus monedas).
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeKey"></param>
        /// <param name="cambio"></param>
        /// <returns>false si alguna de las entidades no existe</returns>
        public Task<bool> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey, Action<TTargetBe, TRelatedBe> cambio)
            where TTargetBe : DomainMember<TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            return operador.AplicarAsync(targetBeKey, relatedBeKey, cambio);
        }
    }
}
