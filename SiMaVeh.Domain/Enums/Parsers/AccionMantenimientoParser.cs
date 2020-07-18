using SiMaVeh.Domain.Enums.Parsers.Interfaces;

namespace SiMaVeh.Domain.Enums.Parsers
{
    /// <summary>
    /// AccionMantenimientoParser
    /// </summary>
    public class AccionMantenimientoParser : IEnumParser<AccionMantenimiento>
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ToString(AccionMantenimiento value)
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
