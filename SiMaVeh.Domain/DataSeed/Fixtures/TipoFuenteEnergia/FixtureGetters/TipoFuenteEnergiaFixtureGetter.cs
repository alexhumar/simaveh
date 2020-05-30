using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.FixtureGetters
{
    /// <summary>
    /// Fixture Getter de Tipo Fuente Energia
    /// </summary>
    public class TipoFuenteEnergiaFixtureGetter : ITipoFuenteEnergiaFixtureGetter
    {
        private readonly DatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> tiposFuentesEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        public TipoFuenteEnergiaFixtureGetter()
        {
            datosEntidadBuilder = new DatosEntidadBuilder();
            tiposFuentesEnergia = new List<DatosEntidad>();

            Initialize();
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

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosEntidad> Get()
        {
            return tiposFuentesEnergia;
        }

        private void Initialize()
        {
            tiposFuentesEnergia.Add(datosEntidadBuilder.Build(1,
                Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Carbon, Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Carbon));
            tiposFuentesEnergia.Add(datosEntidadBuilder.Build(2,
                Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Electricidad, Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Electricidad));
            tiposFuentesEnergia.Add(datosEntidadBuilder.Build(3,
                Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.GasNatural, Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.GasNatural));
            tiposFuentesEnergia.Add(datosEntidadBuilder.Build(4,
                Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Petroleo, Constants.TiposFuenteEnergia.DescripcionTipoFuenteEnergia.Petroleo));
        }
    }
}
