namespace SiMaVeh.Domain.Models.Relations
{
    /// <summary>
    /// Relacion many-to-many Modelo Vehiculo-Aceite
    /// </summary>
    public class ModeloVehiculoAceite
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
        /// Id. Aceite
        /// </summary>
        public virtual long AceiteId { get; set; }

        /// <summary>
        /// Aceite
        /// </summary>
        public virtual Aceite Aceite { get; set; }
    }
}
