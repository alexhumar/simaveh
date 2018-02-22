using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Interfaces
{
    /// <summary>
    /// IEntityChanger
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    public interface IEntityChanger<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        /// <summary>
        /// Cambiar
        /// </summary>
        /// <param name="entity"></param>
        void Cambiar(TBe entity);

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
