namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Automovil
    /// </summary>
    public class Automovil : Vehiculo
    {
        /// <summary>
        /// Patente
        /// </summary>
        public virtual string Patente { get; set; }

        /// <summary>
        /// Numero de Chasis
        /// </summary>
        public virtual string NumeroChasis { get; set; }

        /// <summary>
        /// Codigo Color Pintura
        /// </summary>
        public virtual string CodigoColorPintura { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(", Patente, ") ", ModeloVehiculo?.ToString(), " ", AnioFabricacion);
        }

        #endregion
    }
}
