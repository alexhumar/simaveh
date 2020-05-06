using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Direccion
    /// </summary>
    public class Direccion : DomainMember<long>, IEntityChanger<Localidad, long>
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
        public virtual Localidad Localidad { get; set; }

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
        public void Cambiar(Localidad entity)
        {
            if (entity != null)
                Localidad = entity;
        }

        /// <summary>
        /// Agregar localidad
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Localidad entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar localidad
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Localidad entity)
        {
            throw new System.NotSupportedException();
        }

        #endregion
    }
}
