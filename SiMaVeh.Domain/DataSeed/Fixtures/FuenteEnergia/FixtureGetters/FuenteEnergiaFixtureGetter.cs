using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.FixtureGetters
{
    /// <summary>
    /// Fixture getter de fuente energia
    /// </summary>
    internal class FuenteEnergiaFixtureGetter : IFuenteEnergiaFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly IMarcaFixtureGetter marcaFixtureGetter;
        private readonly ITipoFuenteEnergiaFixtureGetter tipoFuenteEnergiaFixtureGetter;
        private readonly ICollection<DatosFuenteEnergia> fuentesEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        /// <param name="marcaFixtureGetter"></param>
        /// <param name="tipoFuenteEnergiaFixtureGetter"></param>
        public FuenteEnergiaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IMarcaFixtureGetter marcaFixtureGetter,
            ITipoFuenteEnergiaFixtureGetter tipoFuenteEnergiaFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            this.marcaFixtureGetter = marcaFixtureGetter;
            this.tipoFuenteEnergiaFixtureGetter = tipoFuenteEnergiaFixtureGetter;
            fuentesEnergia = new List<DatosFuenteEnergia>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosFuenteEnergia> Get()
        {
            return fuentesEnergia;
        }

        private void Initialize()
        {
            //TODO: implementar.
        }
    }
}
