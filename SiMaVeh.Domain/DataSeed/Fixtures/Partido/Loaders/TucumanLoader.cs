using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class TucumanLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public TucumanLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Tucuman).Value.Key, new Dictionary<long, string>
            {
                { 497, PartidoTucuman.Burruyacu },
                { 498, PartidoTucuman.Capital },
                { 499, PartidoTucuman.Chicligasta },
                { 500, PartidoTucuman.CruzAlta },
                { 501, PartidoTucuman.Famailla },
                { 502, PartidoTucuman.Graneros },
                { 503, PartidoTucuman.JuanBautistaAlberdi },
                { 504, PartidoTucuman.LaCocha },
                { 505, PartidoTucuman.Leales },
                { 506, PartidoTucuman.Lules },
                { 507, PartidoTucuman.Monteros },
                { 508, PartidoTucuman.RioChico },
                { 509, PartidoTucuman.Simoca },
                { 510, PartidoTucuman.TafiDelValle },
                { 511, PartidoTucuman.TafiViejo },
                { 512, PartidoTucuman.Trancas },
                { 513, PartidoTucuman.YerbaBuena }
            });
        }
    }
}
