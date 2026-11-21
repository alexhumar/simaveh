namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Target Mantenimiento
    /// </summary>
    public abstract class TargetMantenimiento : DomainMember<long>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public virtual string Descripcion { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

        #endregion
    }
}
