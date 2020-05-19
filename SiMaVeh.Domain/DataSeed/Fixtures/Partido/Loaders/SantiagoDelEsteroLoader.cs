using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class SantiagoDelEsteroLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public SantiagoDelEsteroLoader()
        {
            fixtureProvincia = new FixtureProvincia();
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.SantiagoDelEstero).Value.Key, new Dictionary<long, string>
            {
                { 465, PartidoSantiagoDelEstero.Aguirre },
                { 466, PartidoSantiagoDelEstero.Alberdi },
                { 467, PartidoSantiagoDelEstero.Atamisqui },
                { 468, PartidoSantiagoDelEstero.Avellaneda },
                { 469, PartidoSantiagoDelEstero.Banda },
                { 470, PartidoSantiagoDelEstero.Belgrano },
                { 471, PartidoSantiagoDelEstero.Capital },
                { 472, PartidoSantiagoDelEstero.Choya },
                { 473, PartidoSantiagoDelEstero.Copo },
                { 474, PartidoSantiagoDelEstero.Figueroa },
                { 475, PartidoSantiagoDelEstero.GeneralTaboada },
                { 476, PartidoSantiagoDelEstero.Guasayan },
                { 477, PartidoSantiagoDelEstero.Jimenez },
                { 478, PartidoSantiagoDelEstero.JuanFelipeIbarra },
                { 479, PartidoSantiagoDelEstero.Loreto },
                { 480, PartidoSantiagoDelEstero.Mitre },
                { 481, PartidoSantiagoDelEstero.Moreno },
                { 482, PartidoSantiagoDelEstero.OjoDeAgua },
                { 483, PartidoSantiagoDelEstero.Pellegrini },
                { 484, PartidoSantiagoDelEstero.Quebrachos },
                { 485, PartidoSantiagoDelEstero.RioHondo },
                { 486, PartidoSantiagoDelEstero.Rivadavia },
                { 487, PartidoSantiagoDelEstero.Robles },
                { 488, PartidoSantiagoDelEstero.Salavina },
                { 489, PartidoSantiagoDelEstero.SanMartin },
                { 490, PartidoSantiagoDelEstero.Sarmiento },
                { 491, PartidoSantiagoDelEstero.Silipica }
            });
        }
    }
}
