using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Provider de fixture getters de partido
    /// </summary>
    public class PartidoFixtureGettersProvider : IPartidoFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly IProvinciaFixtureGetter provinciaArgentinaFixtureGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        /// <param name="paisFixtureGetter"></param>
        public PartidoFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder,
            IPaisFixtureGetter paisFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            provinciaArgentinaFixtureGetter = new ProvinciaArgentinaFixtureGetter(this.datosEntidadBuilder, paisFixtureGetter);
        }

        /// <summary>
        /// Retorna los providers de fixture getters de partidos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureDetailGetter<long, DatosEntidad>>
            {
                new PartidoBuenosAiresFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoCatamarcaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoChacoFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoChubutFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoCordobaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoCorrientesFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoEntreRiosFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoFormosaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoJujuyFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoLaPampaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoLaRiojaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoMendozaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoMisionesFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoNeuquenFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoRioNegroFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoSaltaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoSanJuanFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoSanLuisFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoSantaCruzFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoSantaFeFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoSantiagoDelEsteroFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoTierraDelFuegoFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter),
                new PartidoTucumanFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)
            };
        }
    }
}
