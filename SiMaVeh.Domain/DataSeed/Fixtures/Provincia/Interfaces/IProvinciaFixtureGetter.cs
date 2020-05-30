using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces
{
    interface IProvinciaFixtureGetter : IFixtureDetailGetter<long, DatosEntidad>
    {
        DatosEntidad FindByNombre(string nombre);
    }
}
