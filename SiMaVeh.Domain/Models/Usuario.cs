using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Usuario
    /// </summary>
    public class Usuario : Persona,
        ICollectionManager<Vehiculo, long, Usuario, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Usuario()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        /// <summary>
        /// Vehiculos
        /// </summary>
        public virtual ISet<Vehiculo> Vehiculos { get; protected set; }

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
            return obj is Usuario item && (ReferenceEquals(this, item) || base.Equals(obj));
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

        #region ICollectionManager

        /// <summary>
        /// Agregar vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Usuario Agregar(Vehiculo entity)
        {
            if ((entity != null) && !Vehiculos.Contains(entity))
            {
                Vehiculos.Add(entity);
                entity.Cambiar(this);
            }

            return this;
        }

        /// <summary>
        /// Quitar vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Usuario Quitar(Vehiculo entity)
        {
            if ((entity != null) && Vehiculos.Contains(entity))
            {
                Vehiculos.Remove(entity);
                if ((bool)entity.Usuario?.Equals(this))
                {
                    entity.Cambiar((Usuario)null);
                }
            }

            return this;
        }

        #endregion
    }
}
