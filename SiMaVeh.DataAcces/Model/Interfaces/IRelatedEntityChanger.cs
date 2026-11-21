using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model.Interfaces
{
    /// <summary>
    /// Interfaz de RelatedEntityChanger
    /// </summary>
    public interface IRelatedEntityChanger
    {
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
        Task<bool> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>;

        /// <summary>
        /// Cambia la entidad relacionada de la entidad destino mediante la accion indicada.
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeKey"></param>
        /// <param name="cambio"></param>
        /// <returns>false si alguna de las entidades no existe</returns>
        Task<bool> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey, Action<TTargetBe, TRelatedBe> cambio)
            where TTargetBe : DomainMember<TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>;
    }
}
