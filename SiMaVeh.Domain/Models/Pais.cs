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
        public virtual ISet<Provincia> Provincias { get; init; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nombre;
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
                if (Equals(entity.Pais, this))
                {
                    entity.Cambiar(null);
                }
            }

            return this;
        }

        #endregion
    }
}
