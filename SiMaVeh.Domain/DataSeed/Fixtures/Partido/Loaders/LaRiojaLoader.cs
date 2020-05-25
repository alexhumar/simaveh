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
                { 307, PartidoLaRioja.Arauco },
                { 308, PartidoLaRioja.Capital },
                { 309, PartidoLaRioja.CastroBarros },
                { 310, PartidoLaRioja.Chamical },
                { 311, PartidoLaRioja.Chilecito },
                { 312, PartidoLaRioja.CoronelFelipeVarela },
                { 313, PartidoLaRioja.Famatina },
                { 314, PartidoLaRioja.GeneralAngelVPenaloza },
                { 315, PartidoLaRioja.GeneralBelgrano },
                { 316, PartidoLaRioja.GeneralJuanFacundoQuiroga },
                { 317, PartidoLaRioja.GeneralLamadrid },
                { 318, PartidoLaRioja.GeneralOcampo },
                { 319, PartidoLaRioja.GeneralSanMartin },
                { 320, PartidoLaRioja.Independencia },
                { 321, PartidoLaRioja.RosarioVeraPenaloza },
                { 322, PartidoLaRioja.SanBlasDeLosSauces },
                { 323, PartidoLaRioja.Sanagasta },
                { 324, PartidoLaRioja.Vinchina }
            });
        }
    }
}
