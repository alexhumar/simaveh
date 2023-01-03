using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.Relations
{
    /// <summary>
    /// Relacion many-to-many Modelo Vehiculo-Repuesto
    /// </summary>
    public class ModeloVehiculoRepuesto
    {
        /// <summary>
        /// Id. Modelo Vehiculo
        /// </summary>
        public virtual long ModeloVehiculoId { get; set; }

        /// <summary>
        /// Modelo Vehiculo
        /// </summary>
        public virtual ModeloVehiculo ModeloVehiculo { get; set; }

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
