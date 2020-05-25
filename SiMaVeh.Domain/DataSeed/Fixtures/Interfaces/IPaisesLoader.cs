using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    interface IPaisesLoader<TIdBe, TValueBe> : IFixtureKeyValueLoader<TIdBe, TValueBe>
    {
        KeyValuePair<TIdBe, TValueBe> FindByNombre(TValueBe nombre);
    }
}
