using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Reparador
    /// </summary>
    public class Reparador : Persona, IEntityChanger<EntidadReparadora, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Reparador()
        {
            // EntidadesReparadoras = new List<EntidadReparadora>();
            ReparadorEntidadReparadora = new List<ReparadorEntidadReparadora>();
        }

        /// <summary>
        /// Entidades reparadoras en las que trabaja el reparador
        /// </summary>
        public virtual IList<EntidadReparadora> EntidadesReparadoras
        {
            get { return ReparadorEntidadReparadora.Select(e => e.EntidadReparadora).ToList(); }
        }

        #region relations

        /// <summary>
        /// Relacion Reparador-EntidadReparadora
        /// </summary>
        public virtual IList<ReparadorEntidadReparadora> ReparadorEntidadReparadora { get; }

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

        #region IEntityChanger

        /// <summary>
        /// Cambiar entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(EntidadReparadora entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Agregar entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(EntidadReparadora entity)
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
        }

        /// <summary>
        /// Quitar entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(EntidadReparadora entity)
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
        }

        #endregion
    }
}
