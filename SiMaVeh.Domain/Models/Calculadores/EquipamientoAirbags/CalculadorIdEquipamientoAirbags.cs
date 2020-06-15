using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags
{
    /// <summary>
    /// Calculador de Id de EquipamientoAirbags
    /// </summary>
    public class CalculadorIdEquipamientoAirbags
    {
        /// <summary>
        /// Calcular
        /// </summary>
        /// <param name="equipamientoAirbags"></param>
        /// <returns></returns>
        public string Calcular(IEquipamientoAirbags equipamientoAirbags)
        {
            return string.Concat(equipamientoAirbags.Conductor ? "C" : "NC", equipamientoAirbags.Acompanante ? "A" : "NA", TipoAirbagLateralParser.ToString(equipamientoAirbags.DelanteroIzquierdo),
                TipoAirbagLateralParser.ToString(equipamientoAirbags.DelanteroDerecho), TipoAirbagLateralParser.ToString(equipamientoAirbags.TraseroIzquierdo), TipoAirbagLateralParser.ToString(equipamientoAirbags.TraseroDerecho));
        }
    }
}
