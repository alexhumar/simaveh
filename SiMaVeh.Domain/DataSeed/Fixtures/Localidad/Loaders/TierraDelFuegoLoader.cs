using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class TierraDelFuegoLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public TierraDelFuegoLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoTierraDelFuego.AntartidaArgentina).Value.Key, new Dictionary<long, string>
            {
                { 4153, LocalidadTierraDelFuego.AntartidaArgentina }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTierraDelFuego.IslasDelAtlanticoSur).Value.Key, new Dictionary<long, string>
            {
                { 4154, LocalidadTierraDelFuego.IslasMalvinas },
                { 4155, LocalidadTierraDelFuego.IslasGeorgiasDelSur },
                { 4156, LocalidadTierraDelFuego.IslasSandwichDelSur }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTierraDelFuego.RioGrande).Value.Key, new Dictionary<long, string>
            {
                { 4157, LocalidadTierraDelFuego.RioGrande },
                { 4158, LocalidadTierraDelFuego.SanSebastian }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTierraDelFuego.Ushuaia).Value.Key, new Dictionary<long, string>
            {
                { 4159, LocalidadTierraDelFuego.Ushuaia },
                { 4160, LocalidadTierraDelFuego.PuertoAlmanza },
                { 4161, LocalidadTierraDelFuego.PuntaParana },
                { 4162, LocalidadTierraDelFuego.PuertoParry }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTierraDelFuego.Tolhuin).Value.Key, new Dictionary<long, string>
            {
                { 4163, LocalidadTierraDelFuego.Tolhuin },
                { 4164, LocalidadTierraDelFuego.Sarmiento },
                { 4165, LocalidadTierraDelFuego.LagoEscondido }
            });
        }
    }
}
