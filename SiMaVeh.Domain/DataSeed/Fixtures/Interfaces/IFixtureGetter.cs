using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    /// <summary>
    /// Interfaz para cargar un item a un enumerable
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    public interface IFixtureGetter<TBe>
    {
        /// <summary>
        /// Metodo que retorna la informacion organizada en un enumerable.
        /// </summary>
        /// <returns></returns>
        ICollection<TBe> Get();
    }
}
