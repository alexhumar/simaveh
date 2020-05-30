using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosCordobaLoader : PartidosLoader
    {
        public PartidosCordobaLoader(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.Cordoba).Key, new Dictionary<long, string>
            {
                { 192, PartidoCordoba.Calamuchita },
                { 193, PartidoCordoba.Capital },
                { 194, PartidoCordoba.Colon },
                { 195, PartidoCordoba.CruzDelEje },
                { 196, PartidoCordoba.GeneralRoca },
                { 197, PartidoCordoba.GeneralSanMartin },
                { 198, PartidoCordoba.Ischilin },
                { 199, PartidoCordoba.JuarezCelman },
                { 200, PartidoCordoba.MarcosJuarez },
                { 201, PartidoCordoba.Minas },
                { 202, PartidoCordoba.Pocho },
                { 203, PartidoCordoba.PresidenteRoqueSaenzPena },
                { 204, PartidoCordoba.Punilla },
                { 205, PartidoCordoba.RioCuarto },
                { 206, PartidoCordoba.RioPrimero },
                { 207, PartidoCordoba.RioSeco },
                { 208, PartidoCordoba.RioSegundo },
                { 209, PartidoCordoba.SanAlberto },
                { 210, PartidoCordoba.SanJavier },
                { 211, PartidoCordoba.SanJusto },
                { 212, PartidoCordoba.SantaMaria },
                { 213, PartidoCordoba.Sobremonte },
                { 214, PartidoCordoba.TerceroArriba },
                { 215, PartidoCordoba.Totoral },
                { 216, PartidoCordoba.Tulumba },
                { 217, PartidoCordoba.Union }
            });
        }
    }
}
