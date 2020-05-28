using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces
{
    /// <summary>
    /// Interfaz de provider de loaders de provincia
    /// </summary>
    public interface IProvinciaLoadersProvider : IFixtureItemKeyValueLoaderProvider<long, long, string>
    {
    }
}
