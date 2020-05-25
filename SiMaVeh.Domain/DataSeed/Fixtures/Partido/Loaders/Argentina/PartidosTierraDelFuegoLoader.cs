using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosTierraDelFuegoLoader : PartidosLoader
    {
        public PartidosTierraDelFuegoLoader(IProvinciasLoader<long, long, string> provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.TierraDelFuego).Key, new Dictionary<long, string>
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
