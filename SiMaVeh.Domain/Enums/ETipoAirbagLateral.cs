namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// ETipoAirbagLateral
    /// </summary>
    public enum ETipoAirbagLateral
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
        public static string ToString(ETipoAirbagLateral value)
        {
            return value switch
            {
                ETipoAirbagLateral.Ambos => "A",
                ETipoAirbagLateral.Cortina => "C",
                ETipoAirbagLateral.Lateral => "L",
                ETipoAirbagLateral.NoPosee => "N",
                _ => string.Empty,
            };
        }
    }
}
