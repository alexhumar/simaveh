using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Partido
    /// </summary>
    public class Partido : DomainMember<long>, IEntityChanger<Provincia, long>, IEntityChanger<Localidad, long>
    {
        /// <summary>
        /// Partido
        /// </summary>
        public Partido()
        {
            Localidades = new List<Localidad>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Provincia
        /// </summary>
        public virtual Provincia Provincia { get; set; }

        /// <summary>
        /// Localidades
        /// </summary>
        public virtual IList<Localidad> Localidades { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(Nombre, " ", Provincia?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as Partido;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) ||
                        (Nombre.ToUpper() == item.Nombre.ToUpper() && (Provincia.Equals(item.Provincia)));
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Partido).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar provincia
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Provincia entity)
        {
            Provincia?.Quitar(this);
            entity?.Agregar(this);
        }

        /// <summary>
        /// Agregar provincia
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Provincia entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar provincia
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Provincia entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar localidad
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Localidad entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Agregar localidad
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Localidad entity)
        {
            if (entity != null)
            {
                Localidades?.Add(entity);
                entity.Partido = this;
            }
        }

        /// <summary>
        /// Quitar localidad
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Localidad entity)
        {
            if (entity != null)
            {
                Localidades?.Remove(entity);
                if ((bool)entity.Partido?.Equals(this))
                    entity.Partido = null;
            }
        }

        #endregion
    }
}
