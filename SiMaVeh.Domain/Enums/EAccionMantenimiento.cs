namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// EAccionMantenimiento
    /// </summary>
    public enum EAccionMantenimiento
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
        public static string ToString(EAccionMantenimiento value)
        {
            return value switch
            {
                EAccionMantenimiento.Reemplazo => "Reemplazo",
                EAccionMantenimiento.Reparacion => "Reparación",
                _ => string.Empty,
            };
        }
    }
}
