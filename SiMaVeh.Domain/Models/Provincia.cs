﻿using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Provincia
    /// </summary>
    public class Provincia : DomainMember<long>,
        IEntityChanger<Pais, long, Provincia, long>,
        ICollectionManager<Partido, long, Provincia, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Provincia()
        {
            Partidos = new HashSet<Partido>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Pais
        /// </summary>
        public virtual Pais Pais { get; protected set; }

        /// <summary>
        /// Partidos
        /// </summary>
        public virtual ISet<Partido> Partidos { get; protected set; }

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
        /// <returns></returns>
        public Provincia Cambiar(Pais entity)
        {
            if (Pais != entity)
            {
                Pais?.Quitar(this);
                Pais = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar partido
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Provincia Agregar(Partido entity)
        {
            if (entity != null)
            {
                Partidos?.Add(entity);
                entity.Provincia = this;
            }

            return this;
        }

        /// <summary>
        /// Quitar partido
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Provincia Quitar(Partido entity)
        {
            if (entity != null)
            {
                Partidos?.Remove(entity);
                if ((bool)entity.Provincia?.Equals(this))
                    entity.Provincia = null;
            }

            return this;
        }

        #endregion
    }
}
