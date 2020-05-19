using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class RioNegroLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public RioNegroLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.RioNegro).Value.Key, new Dictionary<long, string>
            {
                { 375, PartidoRioNegro.AdolfoAlsina },
                { 376, PartidoRioNegro.Avellaneda },
                { 377, PartidoRioNegro.Bariloche },
                { 378, PartidoRioNegro.Conesa },
                { 379, PartidoRioNegro.ElCuy },
                { 380, PartidoRioNegro.GeneralRoca },
                { 381, PartidoRioNegro.NueveDeJulio },
                { 382, PartidoRioNegro.Norquinco },
                { 383, PartidoRioNegro.PichiMahuida },
                { 384, PartidoRioNegro.Pilcaniyeu },
                { 385, PartidoRioNegro.SanAntonio },
                { 386, PartidoRioNegro.Valcheta },
                { 387, PartidoRioNegro.VeinticincoDeMayo }
            });
        }
    }
}
