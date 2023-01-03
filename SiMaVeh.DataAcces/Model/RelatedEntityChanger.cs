using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Model
{
    /// <summary>
    /// RelatedEntityChanger
    /// </summary>
    public class RelatedEntityChanger : IRelatedEntityChanger
    {
        //TODO: mejorar la implementacion de estos metodos. Sobre todo los de tipo cambio.

        private readonly SiMaVehContext context;
        private readonly IGenericEntityGetter genericEntityGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="genericEntityGetter"></param>
        public RelatedEntityChanger(SiMaVehContext context,
            IGenericEntityGetter genericEntityGetter)
        {

            this.context = context;
            this.genericEntityGetter = genericEntityGetter;
        }

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
        public async Task<bool> TryChangeRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(TTargetBeId targetBeKey, TRelatedBeId relatedBeKey)
            where TTargetBe : DomainMember<TTargetBeId>, IEntityChanger<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>
        {
            var repositoryTargetBe = new Repository<TTargetBe, TTargetBeId>(context);

            var targetBe = await repositoryTargetBe.FindAsync(targetBeKey);
            if (targetBe == null)
            {
                return false;
            }

            var relatedBe = await genericEntityGetter.TryGetEntity<TRelatedBe, TRelatedBeId>(relatedBeKey);
            if (relatedBe == null)
            {
                return false;
            }

            targetBe.Cambiar(relatedBe);

            await repositoryTargetBe.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// TryChangeMonedaOrigenAsync
        /// </summary>
        /// <param name="tipoCambioKey"></param>
        /// <param name="monedaKey"></param>
        /// <returns></returns>
        public async Task<bool> TryChangeMonedaOrigenAsync(long tipoCambioKey, string monedaKey)
        {
            var repositoryTipoCambio = new Repository<TipoCambio, long>(context);

            var tipoCambio = await repositoryTipoCambio.FindAsync(tipoCambioKey);
            if (tipoCambio == null)
            {
                return false;
            }

            var moneda = await genericEntityGetter.TryGetEntity<Moneda, string>(monedaKey);
            if (moneda == null)
            {
                return false;
            }

            tipoCambio.CambiarMonedaOrigen(moneda);

            await repositoryTipoCambio.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// TryChangeMonedaDestinoAsync
        /// </summary>
        /// <param name="tipoCambioKey"></param>
        /// <param name="monedaKey"></param>
        /// <returns></returns>
        public async Task<bool> TryChangeMonedaDestinoAsync(long tipoCambioKey, string monedaKey)
        {
            var repositoryTipoCambio = new Repository<TipoCambio, long>(context);

            var tipoCambio = await repositoryTipoCambio.FindAsync(tipoCambioKey);
            if (tipoCambio == null)
            {
                return false;
            }

            var moneda = await genericEntityGetter.TryGetEntity<Moneda, string>(monedaKey);
            if (moneda == null)
            {
                return false;
            }

            tipoCambio.CambiarMonedaDestino(moneda);

            await repositoryTipoCambio.SaveChangesAsync();

            return true;
        }
    }
}
