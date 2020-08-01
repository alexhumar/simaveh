namespace SiMaVeh.Domain.Models.Relations
{
    /// <summary>
    /// Relacion many-to-many Modelo Vehiculo-Fuente Energia
    /// </summary>
    public class ModeloVehiculoFuenteEnergia
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
        /// Id. Fuente Energia
        /// </summary>
        public virtual long FuenteEnergiaId { get; set; }

        /// <summary>
        /// Fuente Energia
        /// </summary>
        public virtual FuenteEnergia FuenteEnergia { get; set; }
    }
}
