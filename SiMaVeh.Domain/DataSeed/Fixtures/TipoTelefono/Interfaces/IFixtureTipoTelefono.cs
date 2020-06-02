using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.Interfaces
{
    /// <summary>
    /// Fixture de tipo de telefono
    /// </summary>
    public interface IFixtureTipoTelefono
    {
        /// <summary>
        /// Retorna los tipos de telefono default
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosEntidad> GetTiposTelefono();
    }
}
