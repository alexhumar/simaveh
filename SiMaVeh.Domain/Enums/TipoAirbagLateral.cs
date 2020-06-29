namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// TipoAirbagLateral
    /// </summary>
    public enum TipoAirbagLateral
    {
        /// <summary>
        /// No posee
        /// </summary>
        NoPosee,
        /// <summary>
        /// Lateral
        /// </summary>
        Lateral,
        /// <summary>
        /// Cortina
        /// </summary>
        Cortina,
        /// <summary>
        /// Ambos
        /// </summary>
        Ambos
    }

    /// <summary>
    /// TipoAirbagLateralParser
    /// </summary>
    public static class TipoAirbagLateralParser
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToString(TipoAirbagLateral value)
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
