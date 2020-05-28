using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces
{
    /// <summary>
    /// Interfaz de provider de loaders de pais
    /// </summary>
    public interface IPaisLoadersProvider : IFixtureKeyValueLoaderProvider<long, string>
    {
    }
}
