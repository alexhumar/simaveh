using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Enums.Parsers.Interfaces;
using SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags
{
    /// <summary>
    /// Calculador de Id de EquipamientoAirbags
    /// </summary>
    public class CalculadorIdEquipamientoAirbags : ICalculadorIdEquipamientoAirbags
    {
        private readonly IEnumParser<TipoAirbagLateral> tipoAirbagLateralParser;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tipoAirbagLateralParser"></param>
        public CalculadorIdEquipamientoAirbags(IEnumParser<TipoAirbagLateral> tipoAirbagLateralParser)
        {
            this.tipoAirbagLateralParser = tipoAirbagLateralParser;
        }

        /// <summary>
        /// Calcular
        /// </summary>
        /// <param name="equipamientoAirbags"></param>
        /// <returns></returns>
        public string Calcular(IEquipamientoAirbags equipamientoAirbags)
        {
            return string.Concat(equipamientoAirbags.Conductor ? "C" : "NC", equipamientoAirbags.Acompanante ? "A" : "NA", tipoAirbagLateralParser.ToString(equipamientoAirbags.DelanteroIzquierdo),
                tipoAirbagLateralParser.ToString(equipamientoAirbags.DelanteroDerecho), tipoAirbagLateralParser.ToString(equipamientoAirbags.TraseroIzquierdo), tipoAirbagLateralParser.ToString(equipamientoAirbags.TraseroDerecho));
        }
    }
}
