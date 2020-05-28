using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces
{
    /// <summary>
    /// Interfaz de provider de loaders de localidad
    /// </summary>
    public interface ILocalidadLoadersProvider : IFixtureItemKeyValueLoaderProvider<long, long, string>
    {
    }
}
