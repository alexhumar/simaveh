using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces
{
    /// <summary>
    /// Fixture getter de marca
    /// </summary>
    public interface IMarcaFixtureGetter : IFixtureGetter<DatosMarca>
    {
        /// <summary>
        /// FindByNombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        DatosMarca FindByNombre(string nombre);
    }
}
