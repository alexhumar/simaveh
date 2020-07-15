using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Recambio
    /// </summary>
    public abstract class Recambio : DomainMember<long>,
        IEntityChanger<Marca, long, Recambio, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Recambio()
        {
            KitRepuesto = new HashSet<KitRepuesto>();
        }

        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; set; /*el set no puede ser protected porque rompe OData*/ }

        #region relations

        /// <summary>
        /// Relacion Kit-Repuesto
        /// </summary>
        public virtual ISet<KitRepuesto> KitRepuesto { get; }

        #endregion

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
        /// <returns></returns>
        public Recambio Cambiar(Marca entity)
        {
            if (entity != null)
            {
                Marca = entity;
            }

            return this;
        }

        #endregion
    }
}
