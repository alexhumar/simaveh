using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces
{
    /// <summary>
    /// Fixture getter de tipo de fuente de energia
    /// </summary>
    public interface ITipoFuenteEnergiaFixtureGetter : IFixtureGetter<DatosEntidad>
    {
        /// <summary>
        /// FindByNombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        DatosEntidad FindByNombre(string nombre);
    }
}
