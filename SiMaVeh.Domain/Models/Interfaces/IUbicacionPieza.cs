namespace SiMaVeh.Domain.Models.Interfaces
{
    /// <summary>
    /// Interfaz de Ubicacion Pieza
    /// </summary>
    public interface IUbicacionPieza
    {
        /// <summary>
        /// True -> Izquierda. False -> Derecha.
        /// </summary>
        bool Izquierda { get; }

        /// <summary>
        /// True -> Superior. False -> Inferior.
        /// </summary>
        bool Superior { get; }
    }
}
