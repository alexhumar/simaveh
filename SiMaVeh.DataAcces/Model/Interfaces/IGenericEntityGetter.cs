using SiMaVeh.Domain.Models;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model.Interfaces
{
    /// <summary>
    /// Interfaz de GenericEntityGetter
    /// </summary>
    public interface IGenericEntityGetter
    {
        /// <summary>
        /// Obtiene una entidad a partir de la key pasada por parametro
        /// </summary>
        /// <typeparam name="TBe"></typeparam>
        /// <typeparam name="TBeId"></typeparam>
        /// <param name="link"></param>
        /// <returns></returns>
        Task<TBe> TryGetEntity<TBe, TBeId>(TBeId key) where TBe : DomainMember<TBeId>;
    }
}