using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.BusinessLogic.Entities.Interfaces
{
    /// <summary>
    /// Interfaz de EntityTypeGetter
    /// </summary>
    public interface IEntityTypeGetter
    {
        /// <summary>
        /// GetTypeAsString
        /// </summary>
        /// <typeparam name="TBe"></typeparam>
        /// <typeparam name="TBeId"></typeparam>
        /// <returns></returns>
        string GetTypeAsString<TBe, TBeId>() where TBe : DomainMember<TBeId>;

        /// <summary>
        /// GetCollectionNameAsString
        /// </summary>
        /// <typeparam name="TBe"></typeparam>
        /// <typeparam name="TBeId"></typeparam>
        /// <returns></returns>
        string GetCollectionNameAsString<TBe, TBeId>() where TBe : DomainMember<TBeId>;
    }
}
