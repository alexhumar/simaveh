using SiMaVeh.Domain.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Recambio
    /// </summary>
    public abstract class Recambio : DomainMember<long>, IEntityChanger<Marca, long>, IEntityChanger<Kit, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Recambio()
        {
            Kits = new List<Kit>();
        }

        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; set; }

        /// <summary>
        /// Kits a los que pertenece
        /// </summary>
        public virtual IList<Kit> Kits { get; set; }

        /// <summary>
        /// GetRepuestos
        /// </summary>
        /// <returns>Repuesto o Lista de repuestos para el caso de los kits</returns>
        public abstract IList<Repuesto> GetRepuestos();

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

        /// <summary>
        /// Agregar marca
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Marca entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar marca
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Marca entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar kit
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Kit entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Agregar kit
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Kit entity)
        {
            if (entity != null)
            {
                Kits?.Add(entity);
                entity.Recambios.Add(this);
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
                Kits?.Remove(entity);
                entity.Recambios.Remove(this);
            }
        }

        #endregion
    }
}
