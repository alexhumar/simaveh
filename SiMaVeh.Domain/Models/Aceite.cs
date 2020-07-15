namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Aceite
    /// </summary>
    public class Aceite : TargetMantenimiento
    {
        /// <summary>
        /// Viscosidad SAE Baja Temperatura
        /// </summary>
        public virtual int ViscosidadSAEBajaTemperatura { get; set; }

        /// <summary>
        /// Viscosidad SAE Alta Temperatura
        /// </summary>
        public virtual int ViscosidadSAEAltaTemperatura { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(Aceite) ", Nombre);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Aceite item && (ReferenceEquals(this, item) || base.Equals(obj));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Aceite).FullName, Id.ToString()).GetHashCode();
        }

        #endregion
    }
}
