using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Direccion
    /// </summary>
    public class Direccion : DomainMember<long>,
        IEntityChanger<Localidad, long, Direccion, long>
    {
        /// <summary>
        /// Calle
        /// </summary>
        public virtual string Calle { get; set; }

        /// <summary>
        /// Numero Calle
        /// </summary>
        public virtual int NumeroCalle { get; set; }

        /// <summary>
        /// Localidad
        /// </summary>
        public virtual Localidad Localidad { get; set; /*el set no puede ser protected porque rompe OData*/ }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(Calle, " ", NumeroCalle, ", ", Localidad?.ToString());
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar localidad
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Direccion Cambiar(Localidad entity)
        {
            if (entity != null)
            {
                Localidad = entity;
            }

            return this;
        }

        #endregion
    }
}
