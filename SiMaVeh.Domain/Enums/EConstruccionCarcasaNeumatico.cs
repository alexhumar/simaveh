namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// EConstruccionCarcasaNeumatico
    /// </summary>
    public enum EConstruccionCarcasaNeumatico
    {
        /// <summary>
        /// CintasOpuestas - B
        /// </summary>
        CintasOpuestas,
        /// <summary>
        /// Diagonal - D
        /// </summary>
        Diagonal,
        /// <summary>
        /// Radial - R
        /// </summary>
        Radial
    }

    /// <summary>
    /// ConstruccionCarcasaNeumaticoParser
    /// </summary>
    public static class ConstruccionCarcasaNeumaticoParser
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToString(EConstruccionCarcasaNeumatico value)
        {
            return value switch
            {
                EConstruccionCarcasaNeumatico.CintasOpuestas => "B",
                EConstruccionCarcasaNeumatico.Diagonal => "D",
                EConstruccionCarcasaNeumatico.Radial => "R",
                _ => string.Empty,
            };
        }
    }
}
