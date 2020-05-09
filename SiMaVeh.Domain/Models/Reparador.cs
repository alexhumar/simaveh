using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
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
            ReparadorEntidadReparadora = new HashSet<ReparadorEntidadReparadora>();
        }

        /// <summary>
        /// Entidades reparadoras en las que trabaja el reparador
        /// </summary>
        public virtual ISet<EntidadReparadora> EntidadesReparadoras
        {
            get { return ReparadorEntidadReparadora.Select(e => e.EntidadReparadora).ToHashSet(); }
        }

        #region relations

        /// <summary>
        /// Relacion Reparador-EntidadReparadora
        /// </summary>
        public virtual ISet<ReparadorEntidadReparadora> ReparadorEntidadReparadora { get; protected set; }

        #endregion

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
            var item = obj as Reparador;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return base.Equals(obj);
                }
            }
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
                // EntidadesReparadoras?.Add(entity);
                // entity.Agregar(this);
                // Reparadores?.Add(entity);
                // entity.EntidadesReparadoras?.Add(this);
                ReparadorEntidadReparadora?.Add(new ReparadorEntidadReparadora
                {
                    Reparador = this,
                    EntidadReparadora = entity
                });
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
                // EntidadesReparadoras?.Remove(entity);
                // entity.Quitar(this);
                var toRemove = ReparadorEntidadReparadora?
                    .Where(r => r.Reparador == this && r.EntidadReparadora == entity)
                    .FirstOrDefault();
                if (toRemove != null)
                    ReparadorEntidadReparadora.Remove(toRemove);
            }

            return this;
        }

        #endregion
    }
}
