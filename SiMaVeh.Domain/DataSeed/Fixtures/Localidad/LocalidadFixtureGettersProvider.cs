using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
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
        private readonly IProvinciaFixtureGetter provinciaArgentinaFixtureGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        public LocalidadFixtureGettersProvider()
        {
            provinciaArgentinaFixtureGetter = new ProvinciaArgentinaFixtureGetter(new DatosEntidadBuilder(), new PaisFixtureGetter(new DatosEntidadBuilder()));
        }

        /// <summary>
        /// Retorna los providers de fixture getters de localidades
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureDetailGetter<long, DatosEntidad>>
            {
                new LocalidadBuenosAiresFixtureGetter(new PartidoBuenosAiresFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadCatamarcaFixtureGetter(new PartidoCatamarcaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadChacoFixtureGetter(new PartidoChacoFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadChubutFixtureGetter(new PartidoChubutFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadCordobaFixtureGetter(new PartidoCordobaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadCorrientesFixtureGetter(new PartidoCorrientesFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadEntreRiosFixtureGetter(new PartidoEntreRiosFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadFormosaFixtureGetter(new PartidoFormosaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadJujuyFixtureGetter(new PartidoJujuyFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadLaPampaFixtureGetter(new PartidoLaPampaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadLaRiojaFixtureGetter(new PartidoLaRiojaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadMendozaFixtureGetter(new PartidoMendozaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadMisionesFixtureGetter(new PartidoMisionesFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadNeuquenFixtureGetter(new PartidoNeuquenFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadRioNegroFixtureGetter(new PartidoRioNegroFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadSaltaFixtureGetter(new PartidoSaltaFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadSanJuanFixtureGetter(new PartidoSanJuanFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadSanLuisFixtureGetter(new PartidoSanLuisFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadSantaCruzFixtureGetter(new PartidoSantaCruzFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadSantaFeFixtureGetter(new PartidoSantaFeFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadSantiagoDelEsteroFixtureGetter(new PartidoSantiagoDelEsteroFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadTierraDelFuegoFixtureGetter(new PartidoTierraDelFuegoFixtureGetter(provinciaArgentinaFixtureGetter)),
                new LocalidadTucumanFixtureGetter(new PartidoTucumanFixtureGetter(provinciaArgentinaFixtureGetter))
            };
        }
    }
}
