using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class TierraDelFuegoLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public TierraDelFuegoLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.TierraDelFuego).Value.Key, new Dictionary<long, string>
            {
                { 493, PartidoTierraDelFuego.AntartidaArgentina },
                { 494, PartidoTierraDelFuego.IslasDelAtlanticoSur },
                { 495, PartidoTierraDelFuego.RioGrande },
                { 496, PartidoTierraDelFuego.Tolhuin },
                { 497, PartidoTierraDelFuego.Ushuaia }
            });
        }
    }
}
