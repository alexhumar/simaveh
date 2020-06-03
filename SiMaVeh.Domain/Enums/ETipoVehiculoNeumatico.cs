namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// ETipoVehiculoNeumatico
    /// </summary>
    public enum ETipoVehiculoNeumatico
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
        public static string ToString(ETipoVehiculoNeumatico value)
        {
            return value switch
            {
                ETipoVehiculoNeumatico.Pasajero => "P",
                ETipoVehiculoNeumatico.CamionLigero => "LT",
                ETipoVehiculoNeumatico.TrailerEspecial => "ST",
                ETipoVehiculoNeumatico.UsoTemporal => "T",
                _ => string.Empty,
            };
        }
    }
}
