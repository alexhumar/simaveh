using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models.Calculadores.UbicacionPieza.Interfaces
{
    /// <summary>
    /// Interfaz de CalculadorIdUbicacionPieza
    /// </summary>
    public interface ICalculadorIdUbicacionPieza
    {
        /// <summary>
        /// Calcular
        /// </summary>
        /// <param name="ubicacionPieza"></param>
        /// <returns></returns>
        string Calcular(IUbicacionPieza ubicacionPieza);
    }
}
