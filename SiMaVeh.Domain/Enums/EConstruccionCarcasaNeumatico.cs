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
        /// EConstruccionCarcasaNeumaticoParser 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToString(EConstruccionCarcasaNeumatico value)
        {
            switch (value)
            {
                case EConstruccionCarcasaNeumatico.CintasOpuestas:
                    return "B";
                case EConstruccionCarcasaNeumatico.Diagonal:
                    return "D";
                case EConstruccionCarcasaNeumatico.Radial:
                    return "R";
                default:
                    return "";
            }
        }
    }
}
