using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.DataSeed.Models
{
    /// <summary>
    /// Datos de entidad UbicacionPieza
    /// </summary>
    public class DatosUbicacionPieza : IUbicacionPieza
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Izquierda
        /// </summary>
        public bool Izquierda { get; set; }

        /// <summary>
        /// Superior
        /// </summary>
        public bool Superior { get; set; }
    }
}
