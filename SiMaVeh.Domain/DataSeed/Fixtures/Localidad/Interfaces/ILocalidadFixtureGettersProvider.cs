using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces
{
    /// <summary>
    /// Interfaz de provider de fixture getters de localidad
    /// </summary>
    public interface ILocalidadFixtureGettersProvider : IFixtureDetailGetterProvider<long, DatosEntidad>
    {
    }
}
