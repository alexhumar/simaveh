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

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as Direccion;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                    return (Id == item.Id) ||
                        (Calle == item.Calle && NumeroCalle == item.NumeroCalle && Localidad.Equals(item.Localidad));
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Direccion).FullName, Id.ToString()).GetHashCode();
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
