using SiMaVeh.Domain.Enums.Parsers.Interfaces;

namespace SiMaVeh.Domain.Enums.Parsers
{
    /// <summary>
    /// ConstruccionCarcasaNeumaticoParser
    /// </summary>
    public class ConstruccionCarcasaNeumaticoParser : IEnumParser<ConstruccionCarcasaNeumatico>
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ToString(ConstruccionCarcasaNeumatico value)
        {
            return value switch
            {
                ConstruccionCarcasaNeumatico.CintasOpuestas => "B",
                ConstruccionCarcasaNeumatico.Diagonal => "D",
                ConstruccionCarcasaNeumatico.Radial => "R",
                _ => string.Empty,
            };
        }
    }
}
