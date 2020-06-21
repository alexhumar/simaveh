namespace SiMaVeh.Domain.DataSeed.Models
{
    /// <summary>
    /// Datos generales de fuentes de energia
    /// </summary>
    public class DatosFuenteEnergia : DatosEntidadBase<long>
    {
        /// <summary>
        /// Marca
        /// </summary>
        public DatosMarca Marca { get; set; }

        /// <summary>
        /// Tipo de fuente de energia
        /// </summary>
        public DatosEntidad TipoFuenteEnergia { get; set; }
    }
}
