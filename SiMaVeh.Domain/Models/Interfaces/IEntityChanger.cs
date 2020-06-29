namespace SiMaVeh.Domain.Models.Interfaces
{
    /// <summary>
    /// IEntityChanger
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    /// <typeparam name="TBeReturn"></typeparam>
    /// <typeparam name="TBeReturnId"></typeparam>
    public interface IEntityChanger<TBe, TBeId, TBeReturn, TBeReturnId> where TBe : DomainMember<TBeId> where TBeReturn : DomainMember<TBeReturnId>
    {
        /// <summary>
        /// Cambiar
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TBeReturn Cambiar(TBe entity);
    }
}
