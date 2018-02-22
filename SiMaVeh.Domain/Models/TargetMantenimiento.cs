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

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as TargetMantenimiento;

            if (item == null)
                return false;
            else
                return (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper());
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public abstract override int GetHashCode();

        #endregion
    }
}
