using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Recambio
    /// </summary>
    public abstract class Recambio : DomainMember<long>, IEntityChanger<Marca, long>, ICollectionManager<Kit, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Recambio()
        {
            // Kits = new List<Kit>();
            KitRecambio = new List<KitRecambio>();
        }

        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; set; }

        /// <summary>
        /// Kits a los que pertenece
        /// </summary>
        public virtual IList<Kit> Kits
        {
            get
            {
                return KitRecambio.Select(k => k.Kit).ToList();
            }
        }

        /// <summary>
        /// GetRepuestos
        /// </summary>
        /// <returns>Repuesto o Lista de repuestos para el caso de los kits</returns>
        public abstract IList<Repuesto> GetRepuestos();

        #region relations

        /// <summary>
        /// Relacion Kit-Recambio
        /// </summary>
        public virtual IList<KitRecambio> KitRecambio { get; protected set; }

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
        public void Cambiar(Marca entity)
        {
            if (entity != null)
                Marca = entity;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar kit
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Kit entity)
        {
            if (entity != null)
            {
                // Kits?.Add(entity);
                // entity.Recambios.Add(this);
                KitRecambio?.Add(new KitRecambio
                {
                    Recambio = this,
                    Kit = entity
                });
            }
        }

        /// <summary>
        /// Quitar Kit
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Kit entity)
        {
            if (entity != null)
            {
                // Kits?.Remove(entity);
                // entity.Recambios.Remove(this);
                var toRemove = KitRecambio?
                    .Where(r => r.Recambio == this && r.Kit == entity)
                    .FirstOrDefault();
                if (toRemove != null)
                    KitRecambio.Remove(toRemove);
            }
        }

        #endregion
    }
}
