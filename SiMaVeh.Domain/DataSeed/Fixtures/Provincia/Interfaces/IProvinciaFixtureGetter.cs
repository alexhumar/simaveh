using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces
{
    /// <summary>
    /// Interfaz de provincia fixture getter
    /// </summary>
    public interface IProvinciaFixtureGetter : IFixtureDetailGetter<long, DatosEntidad>
    {
        /// <summary>
        /// FindByNombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        DatosEntidad FindByNombre(string nombre);
    }
}
