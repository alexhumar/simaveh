using SiMaVeh.Domain.Models;
using System;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model.Interfaces
{
    /// <summary>
    /// Aplica una operacion sobre la relacion entre una entidad destino y una entidad relacionada,
    /// y persiste el resultado.
    /// </summary>
    public interface IOperadorEntidadesRelacionadas
    {
        /// <summary>
        /// Busca la entidad destino y la relacionada; si ambas existen, aplica la accion y guarda los cambios.
        /// </summary>
        /// <returns>false si alguna de las dos entidades no existe</returns>
        Task<bool> AplicarAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey, Action<TTargetBe, TRelatedBe> accion)
            where TTargetBe : DomainMember<TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>;

        /// <summary>
        /// Busca la entidad destino; si existe, aplica la accion y guarda los cambios.
        /// </summary>
        /// <returns>false si la entidad destino no existe</returns>
        Task<bool> AplicarAsync<TTargetBe, TTargetBeId>(TTargetBeId targetBeKey, Action<TTargetBe> accion)
            where TTargetBe : DomainMember<TTargetBeId>;
    }
}
