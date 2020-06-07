using SiMaVeh.Domain.Enums;

namespace SiMaVeh.Domain.DataSeed.Models
{
    /// <summary>
    /// Datos generales de marcas
    /// </summary>
    public class DatosMarca : DatosEntidadBase<long>
    {
        /// <summary>
        /// Categoría
        /// </summary>
        public CategoriaMarca Categoria { get; set; }
    }
}
