using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Partido
    /// </summary>
    public class Partido : DomainMember<long>,
        IEntityChanger<Provincia, long, Partido, long>,
        ICollectionManager<Localidad, long, Partido, long>
    {
        /// <summary>
        /// Partido
        /// </summary>
        public Partido()
        {
            Localidades = new HashSet<Localidad>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Provincia
        /// </summary>
        public virtual Provincia Provincia { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Localidades
        /// </summary>
        public virtual ISet<Localidad> Localidades { get; init; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(Nombre, " ", Provincia?.ToString());
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar provincia
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Partido Cambiar(Provincia entity)
        {
            if (Provincia != entity)
            {
                Provincia?.Quitar(this);
                Provincia = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar localidad
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Partido Agregar(Localidad entity)
        {
            if ((entity != null) && !Localidades.Contains(entity))
            {
                Localidades.Add(entity);
                entity.Cambiar(this);
            }

            return this;
        }

        /// <summary>
        /// Quitar localidad
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Partido Quitar(Localidad entity)
        {
            if ((entity != null) && Localidades.Contains(entity))
            {
                Localidades.Remove(entity);
                if (Equals(entity.Partido, this))
                {
                    entity.Cambiar(null);
                }
            }

            return this;
        }

        #endregion
    }
}
