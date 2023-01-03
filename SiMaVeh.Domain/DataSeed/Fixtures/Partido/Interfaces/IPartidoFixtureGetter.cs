﻿using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces
{
    public interface IPartidoFixtureGetter : IFixtureDetailGetter<long, DatosEntidad>
    {
        DatosEntidad FindByNombre(string nombre);
    }
}
