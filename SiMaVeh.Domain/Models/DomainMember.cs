namespace SiMaVeh.Domain.Models
{
    //TODO - evaluar convertir en interfaz.

    /// <summary>
    /// Interfaz DomainMember
    /// </summary>
    public class DomainMember<TBeId>
    {
        /// <summary>
        /// Id
        /// </summary>
        public virtual TBeId Id { get; set; }
    }
}
