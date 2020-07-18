using SiMaVeh.Domain.Enums.Parsers.Interfaces;

namespace SiMaVeh.Domain.Enums.Parsers
{
    /// <summary>
    /// TipoAirbagLateralParser
    /// </summary>
    public class TipoAirbagLateralParser : IEnumParser<TipoAirbagLateral>
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ToString(TipoAirbagLateral value)
        {
            return value switch
            {
                TipoAirbagLateral.Ambos => "A",
                TipoAirbagLateral.Cortina => "C",
                TipoAirbagLateral.Lateral => "L",
                TipoAirbagLateral.NoPosee => "N",
                _ => string.Empty,
            };
        }
    }
}
