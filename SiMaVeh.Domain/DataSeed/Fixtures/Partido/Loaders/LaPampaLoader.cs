using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class LaPampaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public LaPampaLoader()
        {
            fixtureProvincia = new FixtureProvincia();
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.LaPampa).Value.Key, new Dictionary<long, string>
            {
                { 284, PartidoLaPampa.Atreuco },
                { 285, PartidoLaPampa.CaleuCaleu },
                { 286, PartidoLaPampa.Capital },
                { 287, PartidoLaPampa.Catrilo },
                { 288, PartidoLaPampa.Chalileo },
                { 289, PartidoLaPampa.Chapaleufu },
                { 290, PartidoLaPampa.ChicalCo },
                { 291, PartidoLaPampa.Conhelo },
                { 292, PartidoLaPampa.Curaco },
                { 293, PartidoLaPampa.Guatrache },
                { 294, PartidoLaPampa.Hucal },
                { 295, PartidoLaPampa.LihuelCalel },
                { 296, PartidoLaPampa.LimayMahuida },
                { 297, PartidoLaPampa.Loventue },
                { 298, PartidoLaPampa.Maraco },
                { 299, PartidoLaPampa.Puelen },
                { 300, PartidoLaPampa.QuemuQuemu },
                { 301, PartidoLaPampa.Rancul },
                { 302, PartidoLaPampa.Realico },
                { 303, PartidoLaPampa.Toay },
                { 304, PartidoLaPampa.Trenel },
                { 305, PartidoLaPampa.Utracan }
            });
        }
    }
}
