using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Relations
{
    /// <summary>
    /// Relacion many-to-many Kit-Recambio
    /// </summary>
    public class KitRecambio
    {
        /// <summary>
        /// Id. Kit
        /// </summary>
        public virtual long KitId { get; set; }

        /// <summary>
        /// Kit
        /// </summary>
        public virtual Kit Kit { get; set; }

        /// <summary>
        /// Id. Recambio
        /// </summary>
        public virtual long RecambioId { get; set; }

        /// <summary>
        /// Recambio
        /// </summary>
        public virtual Recambio Recambio { get; set; }
    }
}
