using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz para retornar items detail en un diccionario
    /// </summary>
    /// <typeparam name="TIdBeParent"></typeparam>
    /// <typeparam name="TBeChild"></typeparam>
    public interface IFixtureDetailGetter<TIdBeParent, TBeChild>
    {
        /// <summary>
        /// Metodo que retorna items detail en un diccionario
        /// </summary>
        /// <returns></returns>
        IDictionary<TIdBeParent, List<TBeChild>> Get();
    }
}
