using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.Interfaces
{
    internal interface ITipoTelefonoFixtureGetter : IFixtureGetter<DatosEntidad>
    {
        DatosEntidad FindByNombre(string nombre);
    }
}
