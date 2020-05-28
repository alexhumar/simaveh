using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz de provider de objetos para cargar items en un diccionario y subdiccionario
    /// </summary>
    /// <typeparam name="TIdBe"></typeparam>
    /// <typeparam name="TValueBe"></typeparam>
    public interface IFixtureKeyValueLoaderProvider<TIdBe, TValueBe>
    {
        /// <summary>
        /// Metodo para obtener los loaders
        /// </summary>
        /// <returns></returns>
        IEnumerable<IFixtureKeyValueLoader<TIdBe, TValueBe>> GetLoaders();
    }
}
