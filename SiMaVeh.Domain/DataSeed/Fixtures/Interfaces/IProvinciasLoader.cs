using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    interface IProvinciasLoader<TIdBeParent, TIdBeChild, TValueBe> : IFixtureItemKeyValueLoader<TIdBeParent, TIdBeChild, TValueBe>
    {
        KeyValuePair<TIdBeChild, TValueBe> FindByNombre(TValueBe nombre);
    }
}
