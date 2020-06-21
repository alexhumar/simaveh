using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.FixtureGetters
{
    /// <summary>
    /// Fixture getter de tipo fuente energia
    /// </summary>
    public class TipoFuenteEnergiaFixtureGetter : ITipoFuenteEnergiaFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> tiposFuentesEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public TipoFuenteEnergiaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            tiposFuentesEnergia = new List<DatosEntidad>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosEntidad> Get()
        {
            return tiposFuentesEnergia;
        }

        /// <summary>
        /// FindByNombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public DatosEntidad FindByNombre(string nombre)
        {
            return tiposFuentesEnergia.FirstOrDefault(t => t.Nombre == nombre);
        }

        private void Initialize()
        {
            tiposFuentesEnergia.Add(datosEntidadBuilder.Build(1,
                Constants.TiposFuenteEnergia.TipoFuenteEnergia.Alcohol, Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Alcohol));
            tiposFuentesEnergia.Add(datosEntidadBuilder.Build(2,
                Constants.TiposFuenteEnergia.TipoFuenteEnergia.Carbon, Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Carbon));
            tiposFuentesEnergia.Add(datosEntidadBuilder.Build(3,
                Constants.TiposFuenteEnergia.TipoFuenteEnergia.Electricidad, Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Electricidad));
            tiposFuentesEnergia.Add(datosEntidadBuilder.Build(4,
                Constants.TiposFuenteEnergia.TipoFuenteEnergia.GasNatural, Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.GasNatural));
            tiposFuentesEnergia.Add(datosEntidadBuilder.Build(5,
                Constants.TiposFuenteEnergia.TipoFuenteEnergia.Petroleo, Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Petroleo));
        }
    }
}
