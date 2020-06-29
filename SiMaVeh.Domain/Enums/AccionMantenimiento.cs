namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// AccionMantenimiento
    /// </summary>
    public enum AccionMantenimiento
    {
        /// <summary>
        /// Reparacion
        /// </summary>
        Reparacion,
        /// <summary>
        /// Reemplazo
        /// </summary>
        Reemplazo
    }

    /// <summary>
    /// AccionMantenimientoParser
    /// </summary>
    public static class AccionMantenimientoParser
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToString(AccionMantenimiento value)
        {
            return value switch
            {
                AccionMantenimiento.Reemplazo => "Reemplazo",
                AccionMantenimiento.Reparacion => "Reparación",
                _ => string.Empty,
            };
        }
    }
}
