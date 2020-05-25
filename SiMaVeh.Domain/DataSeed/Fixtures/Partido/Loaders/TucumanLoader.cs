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
                { 498, PartidoTucuman.Burruyacu },
                { 499, PartidoTucuman.Capital },
                { 500, PartidoTucuman.Chicligasta },
                { 501, PartidoTucuman.CruzAlta },
                { 502, PartidoTucuman.Famailla },
                { 503, PartidoTucuman.Graneros },
                { 504, PartidoTucuman.JuanBautistaAlberdi },
                { 505, PartidoTucuman.LaCocha },
                { 506, PartidoTucuman.Leales },
                { 507, PartidoTucuman.Lules },
                { 508, PartidoTucuman.Monteros },
                { 509, PartidoTucuman.RioChico },
                { 510, PartidoTucuman.Simoca },
                { 511, PartidoTucuman.TafiDelValle },
                { 512, PartidoTucuman.TafiViejo },
                { 513, PartidoTucuman.Trancas },
                { 514, PartidoTucuman.YerbaBuena }
            });
        }
    }
}
