using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Kit
    /// </summary>
    public class Kit : Recambio,
        ICollectionManager<Repuesto, long, Kit, long>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public virtual string Descripcion { get; set; }

        /// <summary>
        /// Repuestos
        /// </summary>
        public virtual ISet<Repuesto> Repuestos => KitRepuesto.Select(k => k.Repuesto).ToHashSet();

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nombre;
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Kit item && (ReferenceEquals(this, item) || (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper()));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Kit).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar repuesto
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Kit Agregar(Repuesto entity)
        {
            if (entity != null)
            {
                KitRepuesto?.Add(new KitRepuesto
                {
                    Repuesto = entity,
                    Kit = this
                });
            }

            return this;
        }

        /// <summary>
        /// Quitar repuesto
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Kit Quitar(Repuesto entity)
        {
            if (entity != null)
            {
                var toRemove = KitRepuesto?
                    .FirstOrDefault(r => r.Repuesto == entity && r.Kit == this);
                if (toRemove != null)
                {
                    KitRepuesto.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
