namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Moneda - su ID almacena el código ISO alfabético de la moneda
    /// </summary>
    public class Moneda : DomainMember<string>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nombre;
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Moneda item && (ReferenceEquals(this, item) || (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper()));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Moneda).FullName, Id.ToString()).GetHashCode();
        }

        #endregion
    }
}
