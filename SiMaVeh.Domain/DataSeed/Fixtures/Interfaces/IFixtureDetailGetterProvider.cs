using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz de provider de objetos para cargar items detail en un diccionario
    /// </summary>
    /// <typeparam name="TIdBeParent"></typeparam>
    /// <typeparam name="TBeChild"></typeparam>
    public interface IFixtureDetailGetterProvider<TIdBeParent, TBeChild>
    {
        /// <summary>
        /// Metodo para obtener los fixture getters
        /// </summary>
        /// <returns></returns>
        IEnumerable<IFixtureDetailGetter<TIdBeParent, TBeChild>> GetFixtureGetters();
    }
}
