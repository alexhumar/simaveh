namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// CategoriaMarca
    /// </summary>
    public enum CategoriaMarca
    {
        /// <summary>
        /// Automóvil
        /// </summary>
        Automovil,
        /// <summary>
        /// Repuesto
        /// </summary>
        Repuesto,
        /// <summary>
        /// Neumático
        /// </summary>
        Neumatico,
        /// <summary>
        /// Fuente Energía
        /// </summary>
        FuenteEnergia,
    }

    /// <summary>
    /// CategoriaMarcaParser
    /// </summary>
    public static class CategoriaMarcaParser
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToString(CategoriaMarca value)
        {
            return value switch
            {
                CategoriaMarca.Automovil => "Automóvil",
                CategoriaMarca.FuenteEnergia => "Fuente Energía",
                CategoriaMarca.Neumatico => "Neumático",
                CategoriaMarca.Repuesto => "Repuesto",
                _ => string.Empty,
            };
        }
    }
}
