using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Provincia
    /// </summary>
    public class Provincia : DomainMember<long>, IEntityChanger<Pais, long>, ICollectionManager<Partido, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Provincia()
        {
            Partidos = new List<Partido>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Id. Pais
        /// </summary>
        public virtual long IdPais { get; set; }

        /// <summary>
        /// Pais
        /// </summary>
        public virtual Pais Pais { get; set; }

        /// <summary>
        /// Partidos
        /// </summary>
        public virtual IList<Partido> Partidos { get; protected set; }

        #region override

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(Nombre, " ", Pais?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as Provincia;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) ||
                        (Nombre.ToUpper() == item.Nombre.ToUpper() && Pais.Equals(item.Pais));
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Provincia).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar pais
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Pais entity)
        {
            Pais?.Quitar(this);
            entity?.Agregar(this);
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar partido
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Partido entity)
        {
            if (entity != null)
            {
                Partidos?.Add(entity);
                entity.Provincia = this;
            }
        }

        /// <summary>
        /// Quitar partido
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Partido entity)
        {
            if (entity != null)
            {
                Partidos?.Remove(entity);
                if ((bool)entity.Provincia?.Equals(this))
                    entity.Provincia = null;
            }
        }

        #endregion
    }
}
