using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.Relations
{
    /// <summary>
    /// Relacion many-to-many Reparador-Entidad Reparadora
    /// </summary>
    public class ReparadorEntidadReparadora
    {
        /// <summary>
        /// Id. Reparador
        /// </summary>
        public virtual long ReparadorId { get; set; }

        /// <summary>
        /// Reparador
        /// </summary>
        public virtual Reparador Reparador { get; set; }

        /// <summary>
        /// Id. Entidad Reparadora
        /// </summary>
        public virtual long EntidadReparadoraId { get; set; }

        /// <summary>
        /// Entidad Reparadora
        /// </summary>
        public virtual EntidadReparadora EntidadReparadora { get; set; }
    }
}
