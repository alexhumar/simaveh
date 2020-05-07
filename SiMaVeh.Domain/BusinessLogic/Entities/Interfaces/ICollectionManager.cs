using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.BusinessLogic.Entities.Interfaces
{
    /// <summary>
    /// ICollectionManager
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    public interface ICollectionManager<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        /// <summary>
        /// Agregar
        /// </summary>
        /// <param name="entity"></param>
        void Agregar(TBe entity);

        /// <summary>
        /// Quitar
        /// </summary>
        /// <param name="entity"></param>
        void Quitar(TBe entity);
    }
}
