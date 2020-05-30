using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces
{
    interface IPaisFixtureGetter : IFixtureGetter<DatosEntidad>
    {
        DatosEntidad FindByNombre(string nombre);
    }
}
