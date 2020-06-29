using SiMaVeh.Domain.Models.Calculadores.UbicacionPieza.Interfaces;
using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models.Calculadores.UbicacionPieza
{
    /// <summary>
    /// Calculador de Id de UbicacionPieza
    /// </summary>
    public class CalculadorIdUbicacionPieza : ICalculadorIdUbicacionPieza
    {
        /// <summary>
        /// Calcular
        /// </summary>
        /// <param name="ubicacionPieza"></param>
        /// <returns></returns>
        public string Calcular(IUbicacionPieza ubicacionPieza)
        {
            return string.Concat(ubicacionPieza.Izquierda ? "I" : "D", ubicacionPieza.Superior ? "S" : "I");
        }
    }
}
