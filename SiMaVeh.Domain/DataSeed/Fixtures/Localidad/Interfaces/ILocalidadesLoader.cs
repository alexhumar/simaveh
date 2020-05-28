﻿using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces
{
    interface ILocalidadesLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        KeyValuePair<long, string> FindByNombre(string nombre);
    }
}
