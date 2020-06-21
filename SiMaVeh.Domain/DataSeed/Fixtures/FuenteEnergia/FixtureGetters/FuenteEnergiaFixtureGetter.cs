using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
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
        private readonly ICollection<DatosFuenteEnergia> fuentesEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        public FuenteEnergiaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
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
