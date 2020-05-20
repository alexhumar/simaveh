using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz para cargar un item a un diccionario y subdiccionario
    /// </summary>
    /// <typeparam name="TIdBe"></typeparam>
    /// <typeparam name="TValueBe"></typeparam>
    public interface IFixtureKeyValueLoader<TIdBe, TValueBe>
    {
        /// <summary>
        /// Metodo que carga un item en un diccionario
        /// </summary>
        /// <param name="dictionary"></param>
        void Load(Dictionary<TIdBe, TValueBe> dictionary);
    }
}
