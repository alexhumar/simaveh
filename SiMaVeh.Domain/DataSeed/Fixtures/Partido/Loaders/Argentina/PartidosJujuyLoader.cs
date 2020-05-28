using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosJujuyLoader : PartidosLoader
    {
        public PartidosJujuyLoader(IProvinciasLoader provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.Jujuy).Key, new Dictionary<long, string>
            {
                { 269, PartidoJujuy.Cochinoca },
                { 270, PartidoJujuy.DrManuelBelgrano },
                { 271, PartidoJujuy.ElCarmen },
                { 272, PartidoJujuy.Humahuaca },
                { 273, PartidoJujuy.Ledesma },
                { 274, PartidoJujuy.Palpala },
                { 275, PartidoJujuy.Rinconada },
                { 276, PartidoJujuy.SanAntonio },
                { 277, PartidoJujuy.SanPedro },
                { 278, PartidoJujuy.SantaBarbara },
                { 279, PartidoJujuy.SantaCatalina },
                { 280, PartidoJujuy.Susques },
                { 281, PartidoJujuy.Tilcara },
                { 282, PartidoJujuy.Tumbaya },
                { 283, PartidoJujuy.ValleGrande },
                { 284, PartidoJujuy.Yavi }
            });
        }
    }
}
