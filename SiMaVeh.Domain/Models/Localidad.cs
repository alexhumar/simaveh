using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Localidad
    /// </summary>
    public class Localidad : DomainMember<long>,
        IEntityChanger<Partido, long, Localidad, long>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Codigo Postal
        /// </summary>
        public virtual string CPA { get; set; }

        /// <summary>
        /// Partido
        /// </summary>
        public virtual Partido Partido { get; set; /*el set no puede ser protected porque rompe OData*/ }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var cpa = !string.IsNullOrWhiteSpace(CPA) ? $" ({CPA}) " : " ";

            return string.Concat(Nombre, cpa, Partido?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Localidad item))
            {
                return false;
            }
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                    return (Id == item.Id) || (CPA == item.CPA) || (Nombre == item.Nombre && Partido.Equals(item.Partido));
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Localidad).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar partido
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Localidad Cambiar(Partido entity)
        {
            if (Partido != entity)
            {
                Partido?.Quitar(this);
                Partido = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        #endregion
    }
}
