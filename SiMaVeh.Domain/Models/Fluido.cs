namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Fluido
    /// </summary>
    public class Fluido : TargetMantenimiento
    {
        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(Fluido) ", Nombre);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Fluido item && (ReferenceEquals(this, item) || base.Equals(obj));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Fluido).FullName, Id.ToString()).GetHashCode();
        }

        #endregion
    }
}
