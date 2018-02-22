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
    /// ConstruccionCarcasaNeumaticoParser
    /// </summary>
    public static class TipoVehiculoNeumaticoParser
    {
        /// <summary>
        /// EConstruccionCarcasaNeumaticoParser 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToString(ETipoVehiculoNeumatico value)
        {
            switch (value)
            {
                case ETipoVehiculoNeumatico.Pasajero:
                    return "P";
                case ETipoVehiculoNeumatico.CamionLigero:
                    return "LT";
                case ETipoVehiculoNeumatico.TrailerEspecial:
                    return "ST";
                case ETipoVehiculoNeumatico.UsoTemporal:
                    return "T";
                default:
                    return "";
            }
        }
    }
}
