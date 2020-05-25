using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosSantiagoDelEsteroLoader : PartidosLoader
    {
        public PartidosSantiagoDelEsteroLoader(IProvinciasLoader<long, long, string> provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.SantiagoDelEstero).Key, new Dictionary<long, string>
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
