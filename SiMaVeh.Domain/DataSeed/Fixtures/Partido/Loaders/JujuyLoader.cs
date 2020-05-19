using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class JujuyLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public JujuyLoader()
        {
            fixtureProvincia = new FixtureProvincia();
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Jujuy).Value.Key, new Dictionary<long, string>
            {
                { 268, PartidoJujuy.Cochinoca },
                { 269, PartidoJujuy.DrManuelBelgrano },
                { 270, PartidoJujuy.ElCarmen },
                { 271, PartidoJujuy.Humahuaca },
                { 272, PartidoJujuy.Ledesma },
                { 273, PartidoJujuy.Palpala },
                { 274, PartidoJujuy.Rinconada },
                { 275, PartidoJujuy.SanAntonio },
                { 276, PartidoJujuy.SanPedro },
                { 277, PartidoJujuy.SantaBarbara },
                { 278, PartidoJujuy.SantaCatalina },
                { 279, PartidoJujuy.Susques },
                { 280, PartidoJujuy.Tilcara },
                { 281, PartidoJujuy.Tumbaya },
                { 282, PartidoJujuy.ValleGrande },
                { 283, PartidoJujuy.Yavi }
            });
        }
    }
}
