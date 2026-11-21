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
        public virtual ISet<Vehiculo> Vehiculos { get; init; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
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
                if (Equals(entity.Usuario, this))
                {
                    entity.Cambiar((Usuario)null);
                }
            }

            return this;
        }

        #endregion
    }
}
