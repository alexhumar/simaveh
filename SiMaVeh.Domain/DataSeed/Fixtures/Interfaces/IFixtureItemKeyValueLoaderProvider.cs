using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz de provider de objetos para cargar items en un diccionario y subdiccionario 
    /// </summary>
    /// <typeparam name="TIdBeParent"></typeparam>
    /// <typeparam name="TIdBeChild"></typeparam>
    /// <typeparam name="TValueBe"></typeparam>
    public interface IFixtureItemKeyValueLoaderProvider<TIdBeParent, TIdBeChild, TValueBe>
    {
        /// <summary>
        /// Metodo para obtener los providers
        /// </summary>
        /// <returns></returns>
        List<IFixtureItemKeyValueLoader<TIdBeParent, TIdBeChild, TValueBe>> GetProviders();
    }
}
