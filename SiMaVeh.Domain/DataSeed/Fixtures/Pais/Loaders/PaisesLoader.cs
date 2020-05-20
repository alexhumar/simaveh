using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class PaisesLoader : IFixtureKeyValueLoader<long, string>
    {
        public void Load(Dictionary<long, string> dictionary)
        {
            dictionary.Add(1, Pais.Argentina);
            dictionary.Add(2, Pais.Uruguay);
        }
    }
}
