using SiMaVeh.Domain.Enums.Parsers.Interfaces;

namespace SiMaVeh.Domain.Enums.Parsers
{
    /// <summary>
    /// TipoVehiculoNeumaticoParser
    /// </summary>
    public class TipoVehiculoNeumaticoParser : IEnumParser<TipoVehiculoNeumatico>
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ToString(TipoVehiculoNeumatico value)
        {
            return value switch
            {
                TipoVehiculoNeumatico.Pasajero => "P",
                TipoVehiculoNeumatico.CamionLigero => "LT",
                TipoVehiculoNeumatico.TrailerEspecial => "ST",
                TipoVehiculoNeumatico.UsoTemporal => "T",
                _ => string.Empty,
            };
        }
    }
}
