using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model.Interfaces
{
    /// <summary>
    /// Interfaz de RelatedEntityChanger
    /// </summary>
    public interface IRelatedEntityChanger
    {
        /// <summary>
        /// TryChangeRelatedEntity
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="targetBeKey"></param>
        /// <param name="relatedBeKey"></param>
        /// <returns></returns>
        Task<bool> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>;

        /// <summary>
        /// TryChangeMonedaOrigenAsync
        /// </summary>
        /// <param name="tipoCambioKey"></param>
        /// <param name="monedaKey"></param>
        /// <returns></returns>
        Task<bool> TryChangeMonedaOrigenAsync(long tipoCambioKey, string monedaKey);

        /// <summary>
        /// TryChangeMonedaDestinoAsync
        /// </summary>
        /// <param name="tipoCambioKey"></param>
        /// <param name="monedaKey"></param>
        /// <returns></returns>
        Task<bool> TryChangeMonedaDestinoAsync(long tipoCambioKey, string monedaKey);
    }
}
