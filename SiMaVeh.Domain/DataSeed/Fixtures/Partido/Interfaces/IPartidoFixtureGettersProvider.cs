using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces
{
    /// <summary>
    /// Interfaz de provider de fixture getters de partido
    /// </summary>
    public interface IPartidoFixtureGettersProvider : IFixtureDetailGetterProvider<long, DatosEntidad>
    {
    }
}
