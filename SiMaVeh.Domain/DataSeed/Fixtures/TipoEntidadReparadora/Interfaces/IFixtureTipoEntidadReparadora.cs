using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces
{
    /// <summary>
    /// Interfaz de FixtureTipoEntidadReparadora
    /// </summary>
    public interface IFixtureTipoEntidadReparadora
    {
        /// <summary>
        /// Get Tipos Entidad Reparadora
        /// </summary>
        /// <returns></returns>
        IDictionary<long, DatosEntidad> GetTiposEntidadReparadora();
    }
}
