using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Argentina;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad
{
    /// <summary>
    /// Provider de fixture getters de localidad
    /// </summary>
    public class LocalidadFixtureGettersProvider : ILocalidadFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly IProvinciaFixtureGetter provinciaArgentinaFixtureGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        /// <param name="paisFixtureGetter"></param>
        public LocalidadFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder,
            IPaisFixtureGetter paisFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            provinciaArgentinaFixtureGetter = new ProvinciaArgentinaFixtureGetter(this.datosEntidadBuilder, paisFixtureGetter);
        }

        /// <summary>
        /// Retorna los providers de fixture getters de localidades
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureDetailGetter<long, DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureDetailGetter<long, DatosEntidad>>
            {
                new LocalidadBuenosAiresFixtureGetter(datosEntidadBuilder, new PartidoBuenosAiresFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadCatamarcaFixtureGetter(datosEntidadBuilder, new PartidoCatamarcaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadChacoFixtureGetter(datosEntidadBuilder, new PartidoChacoFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadChubutFixtureGetter(datosEntidadBuilder, new PartidoChubutFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadCordobaFixtureGetter(datosEntidadBuilder, new PartidoCordobaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadCorrientesFixtureGetter(datosEntidadBuilder, new PartidoCorrientesFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadEntreRiosFixtureGetter(datosEntidadBuilder, new PartidoEntreRiosFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadFormosaFixtureGetter(datosEntidadBuilder, new PartidoFormosaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadJujuyFixtureGetter(datosEntidadBuilder, new PartidoJujuyFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadLaPampaFixtureGetter(datosEntidadBuilder, new PartidoLaPampaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadLaRiojaFixtureGetter(datosEntidadBuilder, new PartidoLaRiojaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadMendozaFixtureGetter(datosEntidadBuilder, new PartidoMendozaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadMisionesFixtureGetter(datosEntidadBuilder, new PartidoMisionesFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadNeuquenFixtureGetter(datosEntidadBuilder, new PartidoNeuquenFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadRioNegroFixtureGetter(datosEntidadBuilder, new PartidoRioNegroFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSaltaFixtureGetter(datosEntidadBuilder, new PartidoSaltaFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSanJuanFixtureGetter(datosEntidadBuilder, new PartidoSanJuanFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSanLuisFixtureGetter(datosEntidadBuilder, new PartidoSanLuisFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSantaCruzFixtureGetter(datosEntidadBuilder, new PartidoSantaCruzFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSantaFeFixtureGetter(datosEntidadBuilder, new PartidoSantaFeFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadSantiagoDelEsteroFixtureGetter(datosEntidadBuilder, new PartidoSantiagoDelEsteroFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadTierraDelFuegoFixtureGetter(datosEntidadBuilder, new PartidoTierraDelFuegoFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter)),
                new LocalidadTucumanFixtureGetter(datosEntidadBuilder, new PartidoTucumanFixtureGetter(datosEntidadBuilder, provinciaArgentinaFixtureGetter))
            };
        }
    }
}
