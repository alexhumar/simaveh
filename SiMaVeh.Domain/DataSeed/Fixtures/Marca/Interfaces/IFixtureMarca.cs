using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces
{
    /// <summary>
    /// Fixture de marca
    /// </summary>
    public interface IFixtureMarca
    {
        /// <summary>
        /// Retorna las marcas default, cada una con sus categorías asociadas
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosMarca> GetMarcas();
    }
}
