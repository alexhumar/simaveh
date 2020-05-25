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
        /// Metodo que retorna la informacion organizada en un diccionario.
        /// </summary>
        /// <returns></returns>
        Dictionary<TIdBe, TValueBe> Get();
    }
}
