using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces
{
    interface ILocalidadFixtureGetter : IFixtureDetailGetter<long, DatosEntidad>
    {
        DatosEntidad FindByNombre(string nombre);
    }
}
