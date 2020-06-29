using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.Interfaces
{
    /// <summary>
    /// Fixture de ubicacion pieza
    /// </summary>
    public interface IFixtureUbicacionPieza
    {
        /// <summary>
        /// Retorna las ubicaciones de pieza default
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosUbicacionPieza> GetUbicacionesPieza();
    }
}
