using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class TierraDelFuegoLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public TierraDelFuegoLoader()
        {
            fixtureProvincia = new FixtureProvincia();
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.TierraDelFuego).Value.Key, new Dictionary<long, string>
            {
                { 492, PartidoTierraDelFuego.AntartidaArgentina },
                { 493, PartidoTierraDelFuego.IslasDelAtlanticoSur },
                { 494, PartidoTierraDelFuego.RioGrande },
                { 495, PartidoTierraDelFuego.Tolhuin },
                { 496, PartidoTierraDelFuego.Ushuaia }
            });
        }
    }
}
