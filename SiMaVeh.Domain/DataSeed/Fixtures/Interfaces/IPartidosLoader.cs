using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Interfaces
{
    interface IPartidosLoader<TIdBeParent, TIdBeChild, TValueBe> : IFixtureItemKeyValueLoader<TIdBeParent, TIdBeChild, TValueBe>
    {
        KeyValuePair<TIdBeChild, TValueBe> FindByNombre(TValueBe nombre);
    }
}
