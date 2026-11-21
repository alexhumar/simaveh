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

        #endregion
    }
}
