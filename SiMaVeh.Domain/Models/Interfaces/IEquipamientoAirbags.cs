using SiMaVeh.Domain.Enums;

namespace SiMaVeh.Domain.Models.Interfaces
{
    /// <summary>
    /// Interfaz de Equipamiento Airbags
    /// </summary>
    public interface IEquipamientoAirbags
    {
        /// <summary>
        /// Airbag de Conductor
        /// </summary>
        bool Conductor { get; }

        /// <summary>
        /// Airbag de Acompañante
        /// </summary>
        bool Acompanante { get; }

        /// <summary>
        /// Delantero Izquierdo
        /// </summary>
        TipoAirbagLateral DelanteroIzquierdo { get; }

        /// <summary>
        /// Delantero Derecho
        /// </summary>
        TipoAirbagLateral DelanteroDerecho { get; }

        /// <summary>
        /// Trasero Izquierdo
        /// </summary>
        TipoAirbagLateral TraseroIzquierdo { get; }

        /// <summary>
        /// Trasero Derecho
        /// </summary>
        TipoAirbagLateral TraseroDerecho { get; }
    }
}
