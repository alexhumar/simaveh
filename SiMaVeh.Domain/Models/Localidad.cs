using SiMaVeh.Domain.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Localidad
    /// </summary>
    public class Localidad : DomainMember<long>, IEntityChanger<Partido, long>
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
        public virtual Partido Partido { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(Nombre, "(", CPA, "), ", Partido.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as Localidad;

            if (item == null)
                return false;
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
        public void Cambiar(Partido entity)
        {
            Partido?.Quitar(this);
            entity?.Agregar(this);
        }

        /// <summary>
        /// Agregar partido
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Partido entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar partido
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Partido entity)
        {
            throw new System.NotSupportedException();
        }

        #endregion
    }
}
