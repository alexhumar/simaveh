using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces
{
    /// <summary>
    /// Fixture de categoria marca
    /// </summary>
    public interface IFixtureCategoriaMarca
    {
        /// <summary>
        /// Retorna las categorias de marca default
        /// </summary>
        /// <returns></returns>
        IEnumerable<DatosEntidad> GetCategoriasMarca();
    }
}
