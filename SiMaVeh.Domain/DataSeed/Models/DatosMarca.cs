using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Models
{
    /// <summary>
    /// Datos generales de marcas
    /// </summary>
    public class DatosMarca : DatosEntidadBase<long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DatosMarca()
        {
            Categorias = [];
        }

        /// <summary>
        /// Categorías
        /// </summary>
        public List<DatosEntidad> Categorias { get; }
    }
}
