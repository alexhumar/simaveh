using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces
{
    /// <summary>
    /// Fixture getter de pais
    /// </summary>
    public interface IPaisFixtureGetter : IFixtureGetter<DatosEntidad>
    {
        /// <summary>
        /// FindByNombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        DatosEntidad FindByNombre(string nombre);
    }
}
