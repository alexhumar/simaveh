using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Pais
    /// </summary>
    public class Pais : DomainMember<long>,
        ICollectionManager<Provincia, long, Pais, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Pais()
        {
            Provincias = new HashSet<Provincia>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Provincias
        /// </summary>
        public virtual ISet<Provincia> Provincias { get; protected set; }

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
            return obj is Pais item && (ReferenceEquals(this, item) || (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper()));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Pais).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Agregar provincia
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Pais Agregar(Provincia entity)
        {
            if ((entity != null) && !Provincias.Contains(entity))
            {
                Provincias.Add(entity);
                entity.Cambiar(this);
            }

            return this;
        }

        /// <summary>
        /// Quitar provincia
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Pais Quitar(Provincia entity)
        {
            if ((entity != null) && Provincias.Contains(entity))
            {
                Provincias.Remove(entity);
                if ((bool)entity.Pais?.Equals(this))
                {
                    entity.Cambiar(null);
                }
            }

            return this;
        }

        #endregion
    }
}
