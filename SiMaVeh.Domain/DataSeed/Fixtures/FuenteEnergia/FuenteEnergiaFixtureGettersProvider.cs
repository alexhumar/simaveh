using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia
{
    /// <summary>
    /// Provider de fixture getters de fuentes de energia
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="datosEntidadBuilder"></param>
    /// <param name="marcaFixtureGetter"></param>
    /// <param name="tipoFuenteEnergiaFixtureGetter"></param>
    public class FuenteEnergiaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder,
        IMarcaFixtureGetter marcaFixtureGetter,
        ITipoFuenteEnergiaFixtureGetter tipoFuenteEnergiaFixtureGetter) : IFuenteEnergiaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder = datosEntidadBuilder;
        private readonly IMarcaFixtureGetter marcaFixtureGetter = marcaFixtureGetter;
        private readonly ITipoFuenteEnergiaFixtureGetter tipoFuenteEnergiaFixtureGetter = tipoFuenteEnergiaFixtureGetter;

        /// <summary>
        /// Retorna los providers de fixture getters de fuentes de energia
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosFuenteEnergia>> GetFixtureGetters()
        {
            return
            [
                new FuenteEnergiaFixtureGetter(datosEntidadBuilder, marcaFixtureGetter, tipoFuenteEnergiaFixtureGetter)
            ];
        }
    }
}
