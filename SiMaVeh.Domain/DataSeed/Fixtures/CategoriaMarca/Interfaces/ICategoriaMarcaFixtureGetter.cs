using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces
{
    /// <summary>
    /// Interfaz de CategoriaMarcaFixtureGetter
    /// </summary>
    public interface ICategoriaMarcaFixtureGetter : IFixtureGetter<DatosEntidad>
    {
        /// <summary>
        /// FindByNombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        DatosEntidad FindByNombre(string nombre);
    }
}
