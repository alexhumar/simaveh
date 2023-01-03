using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Reparador
    /// </summary>
    public class Reparador : Persona,
        ICollectionManager<EntidadReparadora, long, Reparador, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Reparador()
        {
            EntidadesReparadoras = new HashSet<EntidadReparadora>();
        }

        /// <summary>
        /// Entidades reparadoras en las que trabaja el reparador
        /// </summary>
        public virtual ISet<EntidadReparadora> EntidadesReparadoras { get; init; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Reparador item && (ReferenceEquals(this, item) || base.Equals(obj));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Reparador).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Reparador Agregar(EntidadReparadora entity)
        {
            if (entity != null)
            {
                EntidadesReparadoras.Add(entity);
            }

            return this;
        }

        /// <summary>
        /// Quitar entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Reparador Quitar(EntidadReparadora entity)
        {
            if (entity != null)
            {
                var toRemove = EntidadesReparadoras.FirstOrDefault(e => e == entity);
                if (toRemove != null)
                {
                    EntidadesReparadoras.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
