using SiMaVeh.DataAccess;
using SiMaVeh.Domain.Models;
using SiMaVeh.Repository;
using System;
using System.Threading.Tasks;

namespace SiMaVeh.Helpers
{
    /// <summary>
    /// EntityGetter
    /// </summary>
    public sealed class EntityGetter
    {
        //La obtencion del singleton se saco de la pagina de C#.
        //De esta manera el thread safe, garantizandose una unica
        //instancia.
        private static volatile EntityGetter instance;
        private static object syncRoot = new object();

        private EntityGetter() { }

        /// <summary>
        /// Instance
        /// </summary>
        public static EntityGetter Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new EntityGetter();
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Obtiene una entidad a partir del link odata pasado como parametro
        /// </summary>
        /// <typeparam name="TLinkBe"></typeparam>
        /// <typeparam name="TLinkBeId"></typeparam>
        /// <param name="link"></param>
        /// <returns></returns>
        public async Task<TLinkBe> TryGetEntityFromRelatedLink<TLinkBe, TLinkBeId>(Uri link) where TLinkBe : DomainMember<TLinkBeId>
        {
            TLinkBeId relatedKey = Helpers.GetKeyFromUri<TLinkBeId>(
                EntityTypeGetter<TLinkBe, TLinkBeId>.GetCollectionNameAsString(), link);
            IRepository<TLinkBe, TLinkBeId> _repo = new Repository<TLinkBe, TLinkBeId>(new SiMaVehContext());
            TLinkBe result;

            try
            {
                result = await _repo.Find(relatedKey);
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }
    }
}