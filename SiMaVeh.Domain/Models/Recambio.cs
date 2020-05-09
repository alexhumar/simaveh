using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Recambio
    /// </summary>
    public abstract class Recambio : DomainMember<long>,
        IEntityChanger<Marca, long, Recambio, long>,
        ICollectionManager<Kit, long, Recambio, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Recambio()
        {
            KitRecambio = new HashSet<KitRecambio>();
        }

        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; set; }

        /// <summary>
        /// Kits a los que pertenece
        /// </summary>
        public virtual ISet<Kit> Kits
        {
            get
            {
                return KitRecambio.Select(k => k.Kit).ToHashSet();
            }
        }

        /// <summary>
        /// GetRepuestos
        /// </summary>
        /// <returns>Repuesto o Lista de repuestos para el caso de los kits</returns>
        public abstract ISet<Repuesto> GetRepuestos();

        #region relations

        /// <summary>
        /// Relacion Kit-Recambio
        /// </summary>
        public virtual ISet<KitRecambio> KitRecambio { get; protected set; }

        #endregion

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public abstract override bool Equals(object obj);

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public abstract override int GetHashCode();

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar marca
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Recambio Cambiar(Marca entity)
        {
            if (entity != null)
                Marca = entity;

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar kit
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Recambio Agregar(Kit entity)
        {
            if (entity != null)
            {
                KitRecambio?.Add(new KitRecambio
                {
                    Recambio = this,
                    Kit = entity
                });
            }

            return this;
        }

        /// <summary>
        /// Quitar Kit
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Recambio Quitar(Kit entity)
        {
            if (entity != null)
            {
                var toRemove = KitRecambio?
                    .Where(r => r.Recambio == this && r.Kit == entity)
                    .FirstOrDefault();
                if (toRemove != null)
                    KitRecambio.Remove(toRemove);
            }

            return this;
        }

        #endregion
    }
}
