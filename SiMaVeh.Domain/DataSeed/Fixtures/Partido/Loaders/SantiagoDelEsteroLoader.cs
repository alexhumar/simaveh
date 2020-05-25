using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class SantiagoDelEsteroLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public SantiagoDelEsteroLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.SantiagoDelEstero).Value.Key, new Dictionary<long, string>
            {
                { 466, PartidoSantiagoDelEstero.Aguirre },
                { 467, PartidoSantiagoDelEstero.Alberdi },
                { 468, PartidoSantiagoDelEstero.Atamisqui },
                { 469, PartidoSantiagoDelEstero.Avellaneda },
                { 470, PartidoSantiagoDelEstero.Banda },
                { 471, PartidoSantiagoDelEstero.Belgrano },
                { 472, PartidoSantiagoDelEstero.Capital },
                { 473, PartidoSantiagoDelEstero.Choya },
                { 474, PartidoSantiagoDelEstero.Copo },
                { 475, PartidoSantiagoDelEstero.Figueroa },
                { 476, PartidoSantiagoDelEstero.GeneralTaboada },
                { 477, PartidoSantiagoDelEstero.Guasayan },
                { 478, PartidoSantiagoDelEstero.Jimenez },
                { 479, PartidoSantiagoDelEstero.JuanFelipeIbarra },
                { 480, PartidoSantiagoDelEstero.Loreto },
                { 481, PartidoSantiagoDelEstero.Mitre },
                { 482, PartidoSantiagoDelEstero.Moreno },
                { 483, PartidoSantiagoDelEstero.OjoDeAgua },
                { 484, PartidoSantiagoDelEstero.Pellegrini },
                { 485, PartidoSantiagoDelEstero.Quebrachos },
                { 486, PartidoSantiagoDelEstero.RioHondo },
                { 487, PartidoSantiagoDelEstero.Rivadavia },
                { 488, PartidoSantiagoDelEstero.Robles },
                { 489, PartidoSantiagoDelEstero.Salavina },
                { 490, PartidoSantiagoDelEstero.SanMartin },
                { 491, PartidoSantiagoDelEstero.Sarmiento },
                { 492, PartidoSantiagoDelEstero.Silipica }
            });
        }
    }
}
