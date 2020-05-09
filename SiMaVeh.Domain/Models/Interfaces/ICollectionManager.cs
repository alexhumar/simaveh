namespace SiMaVeh.Domain.Models.Interfaces
{
    /// <summary>
    /// ICollectionManager
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    /// <typeparam name="TBeReturn"></typeparam>
    /// <typeparam name="TBeReturnId"></typeparam>
    public interface ICollectionManager<TBe, TBeId, TBeReturn, TBeReturnId> where TBe : DomainMember<TBeId> where TBeReturn : DomainMember<TBeReturnId>
    {
        /// <summary>
        /// Agregar
        /// </summary>
        /// <param name="entity"></param>
        TBeReturn Agregar(TBe entity);

        /// <summary>
        /// Quitar
        /// </summary>
        /// <param name="entity"></param>
        TBeReturn Quitar(TBe entity);
    }
}
