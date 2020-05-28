using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces
{
    interface IPaisesLoader : IFixtureKeyValueLoader<long, string>
    {
        KeyValuePair<long, string> FindByNombre(string nombre);
    }
}
