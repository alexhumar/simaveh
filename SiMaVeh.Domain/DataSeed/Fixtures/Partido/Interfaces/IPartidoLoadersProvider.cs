using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces
{
    /// <summary>
    /// Interfaz de provider de loaders de partido
    /// </summary>
    public interface IPartidoLoadersProvider : IFixtureDetailGetterProvider<long, long, string>
    {
    }
}
