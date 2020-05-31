using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad
{
    /// <summary>
    /// Provider de Fixture Getters de Localidad
    /// </summary>
    public class LocalidadFixtureGettersProvider : ILocalidadFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly IProvinciaFixtureGetter provinciaArgentinaFixtureGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        public LocalidadFixtureGettersProvider()
        {
            datosEntidadBuilder = new DatosEntidadBuilder();
            provinciaArgentinaFixtureGetter = new ProvinciaArgentinaFixtureGetter(datosEntidadBuilder, new PaisFixtureGetter(datosEntidadBuilder));
        }

        /// <summary>
        /// Retorna los providers de fixture getters de localidades
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureDetailGetter<long, DatosEntidad>>
            {
                new LocalidadBuenosAiresFixtureGetter(new PartidoBuenosAiresFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadCatamarcaFixtureGetter(new PartidoCatamarcaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadChacoFixtureGetter(new PartidoChacoFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadChubutFixtureGetter(new PartidoChubutFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadCordobaFixtureGetter(new PartidoCordobaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadCorrientesFixtureGetter(new PartidoCorrientesFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadEntreRiosFixtureGetter(new PartidoEntreRiosFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadFormosaFixtureGetter(new PartidoFormosaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadJujuyFixtureGetter(new PartidoJujuyFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadLaPampaFixtureGetter(new PartidoLaPampaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadLaRiojaFixtureGetter(new PartidoLaRiojaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadMendozaFixtureGetter(new PartidoMendozaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadMisionesFixtureGetter(new PartidoMisionesFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadNeuquenFixtureGetter(new PartidoNeuquenFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadRioNegroFixtureGetter(new PartidoRioNegroFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSaltaFixtureGetter(new PartidoSaltaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSanJuanFixtureGetter(new PartidoSanJuanFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSanLuisFixtureGetter(new PartidoSanLuisFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSantaCruzFixtureGetter(new PartidoSantaCruzFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSantaFeFixtureGetter(new PartidoSantaFeFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSantiagoDelEsteroFixtureGetter(new PartidoSantiagoDelEsteroFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadTierraDelFuegoFixtureGetter(new PartidoTierraDelFuegoFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadTucumanFixtureGetter(new PartidoTucumanFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter))
            };
        }
    }
}
