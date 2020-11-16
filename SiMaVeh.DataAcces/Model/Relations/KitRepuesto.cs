using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.Relations
{
    /// <summary>
    /// Relacion many-to-many Kit-Repuesto
    /// </summary>
    public class KitRepuesto
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
        /// Id. Repuesto
        /// </summary>
        public virtual long RepuestoId { get; set; }

        /// <summary>
        /// Repuesto
        /// </summary>
        public virtual Repuesto Repuesto { get; set; }
    }
}
