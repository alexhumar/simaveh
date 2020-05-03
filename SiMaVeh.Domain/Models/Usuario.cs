using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Usuario
    /// </summary>
    public class Usuario : Persona, IEntityChanger<Vehiculo, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Usuario()
        {
            Vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Vehiculos
        /// </summary>
        public virtual IList<Vehiculo> Vehiculos { get; set; }

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
            var item = obj as Usuario;

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
            return string.Concat(typeof(Usuario).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Vehiculo entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Agregar vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Vehiculo entity)
        {
            if (entity != null)
            {
                Vehiculos?.Add(entity);
                entity.Usuario = this;
            }
        }

        /// <summary>
        /// Quitar vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Vehiculo entity)
        {
            if (entity != null)
            {
                Vehiculos?.Remove(entity);
                if ((bool)entity.Usuario?.Equals(this))
                    entity.Usuario = null;
            }
        }

        #endregion
    }
}
