using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz para retornar items en un diccionario y subdiccionario
    /// </summary>
    /// <typeparam name="TIdBeParent"></typeparam>
    /// <typeparam name="TIdBeChild"></typeparam>
    /// <typeparam name="TValueBe"></typeparam>
    public interface IFixtureItemKeyValueLoader<TIdBeParent, TIdBeChild, TValueBe>
    {
        /// <summary>
        /// Metodo que retorna items en un diccionario y subdiccionario
        /// </summary>
        /// <returns></returns>
        IDictionary<TIdBeParent, IDictionary<TIdBeChild, TValueBe>> Get();
    }
}
