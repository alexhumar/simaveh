namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Clase base DomainMember
    /// </summary>
    public class DomainMember<TBeId>
    {
        /// <summary>
        /// Id
        /// </summary>
        public virtual TBeId Id { get; set; }
    }
}
