using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces
{
    internal interface IFixtureTipoFuenteEnergia
    {
        IEnumerable<DatosEntidad> GetTiposFuenteEnergia();
    }
}
