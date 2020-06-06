using SiMaVeh.Domain.Enums;

namespace SiMaVeh.Domain.DataSeed.Models
{
    /// <summary>
    /// Datos de entidad EquipamientoAirbags
    /// </summary>
    public class DatosEquipamientoAirbags
    {
        /// <summary>
        /// Airbag de Conductor
        /// </summary>
        public virtual bool Conductor { get; set; }

        /// <summary>
        /// Airbag de Acompañante
        /// </summary>
        public virtual bool Acompanante { get; set; }

        /// <summary>
        /// Delantero Izquierdo
        /// </summary>
        public virtual TipoAirbagLateral DelanteroIzquierdo { get; set; }

        /// <summary>
        /// Delantero Derecho
        /// </summary>
        public virtual TipoAirbagLateral DelanteroDerecho { get; set; }

        /// <summary>
        /// Trasero Izquierdo
        /// </summary>
        public virtual TipoAirbagLateral TraseroIzquierdo { get; set; }

        /// <summary>
        /// Trasero Derecho
        /// </summary>
        public virtual TipoAirbagLateral TraseroDerecho { get; set; }
    }
}
