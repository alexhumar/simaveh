using SiMaVeh.Domain.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Pais
    /// </summary>
    public class Pais : DomainMember<long>, IEntityChanger<Provincia, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Pais()
        {
            Provincias = new List<Provincia>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Provincias
        /// </summary>
        public virtual IList<Provincia> Provincias { get; set; }

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
            var item = obj as Pais;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper());
                }
            }
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
        /// Cambiar provincia
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Provincia entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Agregar provincia
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Provincia entity)
        {
            if (entity != null)
            {
                Provincias?.Add(entity);
                entity.Pais = this;
            }
        }

        /// <summary>
        /// Quitar provincia
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Provincia entity)
        {
            if (entity != null)
            {
                Provincias?.Remove(entity);
                if ((bool)entity.Pais?.Equals(this))
                    entity.Pais = null;
            }
        }

        #endregion
    }
}
