using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz de provider de objetos para cargar items en colecciones
    /// </summary>
    /// <typeparam name="TIdBe"></typeparam>
    public interface IFixtureGetterProvider<TIdBe>
    {
        /// <summary>
        /// Metodo para obtener los fixture getters
        /// </summary>
        /// <returns></returns>
        IEnumerable<IFixtureGetter<TIdBe>> GetFixtureGetters();
    }
}
