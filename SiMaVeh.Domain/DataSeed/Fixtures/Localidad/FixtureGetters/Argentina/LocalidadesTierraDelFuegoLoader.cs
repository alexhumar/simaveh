using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesTierraDelFuegoLoader : LocalidadFixtureGetter
    {
        public LocalidadesTierraDelFuegoLoader(IPartidoFixtureGetter partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.AntartidaArgentina).Key, new Dictionary<long, string>
            {
                { 4153, LocalidadTierraDelFuego.AntartidaArgentina }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.IslasDelAtlanticoSur).Key, new Dictionary<long, string>
            {
                { 4154, LocalidadTierraDelFuego.IslasMalvinas },
                { 4155, LocalidadTierraDelFuego.IslasGeorgiasDelSur },
                { 4156, LocalidadTierraDelFuego.IslasSandwichDelSur }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.RioGrande).Key, new Dictionary<long, string>
            {
                { 4157, LocalidadTierraDelFuego.RioGrande },
                { 4158, LocalidadTierraDelFuego.SanSebastian }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.Ushuaia).Key, new Dictionary<long, string>
            {
                { 4159, LocalidadTierraDelFuego.Ushuaia },
                { 4160, LocalidadTierraDelFuego.PuertoAlmanza },
                { 4161, LocalidadTierraDelFuego.PuntaParana },
                { 4162, LocalidadTierraDelFuego.PuertoParry }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.Tolhuin).Key, new Dictionary<long, string>
            {
                { 4163, LocalidadTierraDelFuego.Tolhuin },
                { 4164, LocalidadTierraDelFuego.Sarmiento },
                { 4165, LocalidadTierraDelFuego.LagoEscondido }
            });
        }
    }
}
