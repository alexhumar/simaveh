using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces
{
    interface IPartidosLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        KeyValuePair<long, string> FindByNombre(string nombre);
    }
}
