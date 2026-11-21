using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.Domain.Models;
using System;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model
{
    /// <summary>
    /// Implementacion unica del algoritmo "buscar destino, buscar relacionada, aplicar, guardar".
    /// </summary>
    /// <param name="context"></param>
    /// <param name="genericEntityGetter"></param>
    public class OperadorEntidadesRelacionadas(SiMaVehContext context,
        IGenericEntityGetter genericEntityGetter) : IOperadorEntidadesRelacionadas
    {
        private readonly SiMaVehContext context = context;
        private readonly IGenericEntityGetter genericEntityGetter = genericEntityGetter;

        /// <inheritdoc/>
        public async Task<bool> AplicarAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey, Action<TTargetBe, TRelatedBe> accion)
            where TTargetBe : DomainMember<TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            var relatedBe = await genericEntityGetter.TryGetEntity<TRelatedBe, TRelatedBeId>(relatedBeKey);
            if (relatedBe == null)
            {
                return false;
            }

            return await AplicarAsync<TTargetBe, TTargetBeId>(targetBeKey, targetBe => accion(targetBe, relatedBe));
        }

        /// <inheritdoc/>
        public async Task<bool> AplicarAsync<TTargetBe, TTargetBeId>(TTargetBeId targetBeKey, Action<TTargetBe> accion)
            where TTargetBe : DomainMember<TTargetBeId>
        {
            var targetBe = await genericEntityGetter.TryGetEntity<TTargetBe, TTargetBeId>(targetBeKey);
            if (targetBe == null)
            {
                return false;
            }

            accion(targetBe);

            await context.SaveChangesAsync();

            return true;
        }
    }
}
