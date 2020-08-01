namespace SiMaVeh.Domain.Models.Relations
{
    /// <summary>
    /// Relacion many-to-many Modelo Vehiculo-Presion Neumatico
    /// </summary>
    public class ModeloVehiculoPresionNeumatico
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
        /// Id. Presion Neumatico
        /// </summary>
        public virtual long PresionNeumaticoId { get; set; }

        /// <summary>
        /// Presion Neumatico
        /// </summary>
        public virtual PresionNeumatico PresionNeumatico { get; set; }
    }
}
