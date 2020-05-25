using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosLaPampaLoader : PartidosLoader
    {
        public PartidosLaPampaLoader(IProvinciasLoader<long, long, string> provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.LaPampa).Key, new Dictionary<long, string>
            {
                { 285, PartidoLaPampa.Atreuco },
                { 286, PartidoLaPampa.CaleuCaleu },
                { 287, PartidoLaPampa.Capital },
                { 288, PartidoLaPampa.Catrilo },
                { 289, PartidoLaPampa.Chalileo },
                { 290, PartidoLaPampa.Chapaleufu },
                { 291, PartidoLaPampa.ChicalCo },
                { 292, PartidoLaPampa.Conhelo },
                { 293, PartidoLaPampa.Curaco },
                { 294, PartidoLaPampa.Guatrache },
                { 295, PartidoLaPampa.Hucal },
                { 296, PartidoLaPampa.LihuelCalel },
                { 297, PartidoLaPampa.LimayMahuida },
                { 298, PartidoLaPampa.Loventue },
                { 299, PartidoLaPampa.Maraco },
                { 300, PartidoLaPampa.Puelen },
                { 301, PartidoLaPampa.QuemuQuemu },
                { 302, PartidoLaPampa.Rancul },
                { 303, PartidoLaPampa.Realico },
                { 304, PartidoLaPampa.Toay },
                { 305, PartidoLaPampa.Trenel },
                { 306, PartidoLaPampa.Utracan }
            });
        }
    }
}
