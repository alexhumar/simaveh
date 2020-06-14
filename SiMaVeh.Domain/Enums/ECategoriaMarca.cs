namespace SiMaVeh.Domain.Enums
{
    /// <summary>
    /// CategoriaMarca
    /// </summary>
    public enum ECategoriaMarca
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
        public static string ToString(ECategoriaMarca value)
        {
            return value switch
            {
                ECategoriaMarca.Automovil => "Automóvil",
                ECategoriaMarca.FuenteEnergia => "Fuente Energía",
                ECategoriaMarca.Neumatico => "Neumático",
                ECategoriaMarca.Repuesto => "Repuesto",
                _ => string.Empty,
            };
        }
    }
}
