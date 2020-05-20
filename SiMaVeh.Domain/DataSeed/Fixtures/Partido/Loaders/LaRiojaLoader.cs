using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class LaRiojaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public LaRiojaLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.LaRioja).Value.Key, new Dictionary<long, string>
            {
                { 306, PartidoLaRioja.Arauco },
                { 307, PartidoLaRioja.Capital },
                { 308, PartidoLaRioja.CastroBarros },
                { 309, PartidoLaRioja.Chamical },
                { 310, PartidoLaRioja.Chilecito },
                { 311, PartidoLaRioja.CoronelFelipeVarela },
                { 312, PartidoLaRioja.Famatina },
                { 313, PartidoLaRioja.GeneralAngelVPenaloza },
                { 314, PartidoLaRioja.GeneralBelgrano },
                { 315, PartidoLaRioja.GeneralJuanFacundoQuiroga },
                { 316, PartidoLaRioja.GeneralLamadrid },
                { 317, PartidoLaRioja.GeneralOcampo },
                { 318, PartidoLaRioja.GeneralSanMartin },
                { 319, PartidoLaRioja.Independencia },
                { 320, PartidoLaRioja.RosarioVeraPenaloza },
                { 321, PartidoLaRioja.SanBlasDeLosSauces },
                { 322, PartidoLaRioja.Sanagasta },
                { 323, PartidoLaRioja.Vinchina }
            });
        }
    }
}
