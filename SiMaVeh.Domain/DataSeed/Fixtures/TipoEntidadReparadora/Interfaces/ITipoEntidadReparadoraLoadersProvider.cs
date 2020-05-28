using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces
{
    /// <summary>
    /// Interfaz de provider de loaders de tipo de entidad reparadora
    /// </summary>
    public interface ITipoEntidadReparadoraLoadersProvider : IFixtureKeyValueLoaderProvider<long, string>
    {
    }
}
