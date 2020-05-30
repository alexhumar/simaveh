using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosSanLuisLoader : PartidosLoader
    {
        public PartidosSanLuisLoader(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.SanLuis).Key, new Dictionary<long, string>
            {
                { 431, PartidoSanLuis.JuanMartinDePueyrredon },
                { 432, PartidoSanLuis.GeneralPedernera },
                { 433, PartidoSanLuis.Junin },
                { 434, PartidoSanLuis.Chacabuco },
                { 435, PartidoSanLuis.Ayacucho },
                { 436, PartidoSanLuis.CoronelPringles },
                { 437, PartidoSanLuis.GobernadorDupuy },
                { 438, PartidoSanLuis.LibertadorGeneralSanMartin },
                { 439, PartidoSanLuis.Belgrano }
            });
        }
    }
}
