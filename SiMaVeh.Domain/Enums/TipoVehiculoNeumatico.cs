namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// TipoVehiculoNeumatico
    /// </summary>
    public enum TipoVehiculoNeumatico
    {
        /// <summary>
        /// Pasajero
        /// </summary>
        Pasajero,
        /// <summary>
        /// CamionLigero
        /// </summary>
        CamionLigero,
        /// <summary>
        /// TrailerEspecial
        /// </summary>
        TrailerEspecial,
        /// <summary>
        /// UsoTemporal
        /// </summary>
        UsoTemporal
    }

    /// <summary>
    /// TipoVehiculoNeumaticoParser
    /// </summary>
    public static class TipoVehiculoNeumaticoParser
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToString(TipoVehiculoNeumatico value)
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
