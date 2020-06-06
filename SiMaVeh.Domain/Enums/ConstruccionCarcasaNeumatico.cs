namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// ConstruccionCarcasaNeumatico
    /// </summary>
    public enum ConstruccionCarcasaNeumatico
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
        public static string ToString(ConstruccionCarcasaNeumatico value)
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
