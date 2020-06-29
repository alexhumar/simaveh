using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.DataSeed.Models
{
    /// <summary>
    /// Datos de entidad EquipamientoAirbags
    /// </summary>
    public class DatosEquipamientoAirbags : IEquipamientoAirbags
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Airbag de Conductor
        /// </summary>
        public bool Conductor { get; set; }

        /// <summary>
        /// Airbag de Acompañante
        /// </summary>
        public bool Acompanante { get; set; }

        /// <summary>
        /// Delantero Izquierdo
        /// </summary>
        public TipoAirbagLateral DelanteroIzquierdo { get; set; }

        /// <summary>
        /// Delantero Derecho
        /// </summary>
        public TipoAirbagLateral DelanteroDerecho { get; set; }

        /// <summary>
        /// Trasero Izquierdo
        /// </summary>
        public TipoAirbagLateral TraseroIzquierdo { get; set; }

        /// <summary>
        /// Trasero Derecho
        /// </summary>
        public TipoAirbagLateral TraseroDerecho { get; set; }
    }
}
