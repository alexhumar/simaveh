using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento.Interfaces
{
    /// <summary>
    /// Interfaz de FixtureTipoDocumento
    /// </summary>
    public interface IFixtureTipoDocumento
    {
        /// <summary>
        /// Get Tipos Documento
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosEntidad> GetTiposDocumento();
    }
}
