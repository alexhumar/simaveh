namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Tipo Entidad Reparadora
    /// </summary>
    public class TipoEntidadReparadora : DomainMember<long>
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
            return obj is TipoEntidadReparadora item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper()));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(TipoEntidadReparadora).FullName, Id.ToString()).GetHashCode();
        }

        #endregion
    }
}
