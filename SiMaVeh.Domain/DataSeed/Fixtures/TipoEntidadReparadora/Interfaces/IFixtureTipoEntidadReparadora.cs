using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces
{
    /// <summary>
    /// Interfaz de FixtureTipoEntidadReparadora
    /// </summary>
    public interface IFixtureTipoEntidadReparadora
    {
        //TODO: probablemente se pueda declarar este metodo en una interfaz comun
        /// <summary>
        /// Get Tipos Entidad Reparadora
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosEntidad> GetTiposEntidadReparadora();
    }
}
