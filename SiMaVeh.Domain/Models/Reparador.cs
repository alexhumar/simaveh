using SiMaVeh.Domain.Interfaces;
using System.Collections.Generic;

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
            EntidadesReparadoras = new List<EntidadReparadora>();
        }

        /// <summary>
        /// Entidades reparadoras en las que trabaja el reparador
        /// </summary>
        public virtual IList<EntidadReparadora> EntidadesReparadoras { get; set; }

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
                EntidadesReparadoras?.Add(entity);
                entity.Agregar(this);
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
                EntidadesReparadoras?.Remove(entity);
                entity.Quitar(this);
            }
        }

        #endregion
    }
}
