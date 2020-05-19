using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class CordobaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public CordobaLoader()
        {
            fixtureProvincia = new FixtureProvincia();
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Cordoba).Value.Key, new Dictionary<long, string>
            {
                { 514, PartidoCordoba.Calamuchita },
                { 192, PartidoCordoba.Capital },
                { 193, PartidoCordoba.Colon },
                { 194, PartidoCordoba.CruzDelEje },
                { 195, PartidoCordoba.GeneralRoca },
                { 196, PartidoCordoba.GeneralSanMartin },
                { 197, PartidoCordoba.Ischilin },
                { 198, PartidoCordoba.JuarezCelman },
                { 199, PartidoCordoba.MarcosJuarez },
                { 200, PartidoCordoba.Minas },
                { 201, PartidoCordoba.Pocho },
                { 202, PartidoCordoba.PresidenteRoqueSaenzPena },
                { 203, PartidoCordoba.Punilla },
                { 204, PartidoCordoba.RioCuarto },
                { 205, PartidoCordoba.RioPrimero },
                { 206, PartidoCordoba.RioSeco },
                { 207, PartidoCordoba.RioSegundo },
                { 208, PartidoCordoba.SanAlberto },
                { 209, PartidoCordoba.SanJavier },
                { 210, PartidoCordoba.SanJusto },
                { 211, PartidoCordoba.SantaMaria },
                { 212, PartidoCordoba.Sobremonte },
                { 213, PartidoCordoba.TerceroArriba },
                { 214, PartidoCordoba.Totoral },
                { 215, PartidoCordoba.Tulumba },
                { 216, PartidoCordoba.Union }
            });
        }
    }
}
