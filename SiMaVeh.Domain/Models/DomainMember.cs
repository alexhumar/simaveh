namespace SiMaVeh.Domain.Models
{
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
