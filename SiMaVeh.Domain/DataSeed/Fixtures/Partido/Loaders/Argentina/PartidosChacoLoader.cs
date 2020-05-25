using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosChacoLoader : PartidosLoader
    {
        public PartidosChacoLoader(IProvinciasLoader<long, long, string> provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.Chaco).Key, new Dictionary<long, string>
            {
                { 152, PartidoChaco.AlmiranteBrown },
                { 153, PartidoChaco.Bermejo },
                { 154, PartidoChaco.Chacabuco },
                { 155, PartidoChaco.ComandanteFernandez },
                { 156, PartidoChaco.DoceDeOctubre },
                { 157, PartidoChaco.DosDeAbril },
                { 158, PartidoChaco.FrayJustoSantaMariaDeOro },
                { 159, PartidoChaco.GeneralBelgrano },
                { 160, PartidoChaco.GeneralDonovan },
                { 161, PartidoChaco.GeneralGuemes },
                { 162, PartidoChaco.Independencia },
                { 163, PartidoChaco.Libertad },
                { 164, PartidoChaco.LibertadorGeneralSanMartin },
                { 165, PartidoChaco.Maipu },
                { 166, PartidoChaco.MayorLuisJorgeFontana },
                { 167, PartidoChaco.NueveDeJulio },
                { 168, PartidoChaco.OHiggins },
                { 169, PartidoChaco.PresidenciaDeLaPlaza },
                { 170, PartidoChaco.PrimeroDeMayo },
                { 171, PartidoChaco.Quitilipi },
                { 172, PartidoChaco.SanFernando },
                { 173, PartidoChaco.SanLorenzo },
                { 174, PartidoChaco.SargentoCabral },
                { 175, PartidoChaco.Tapenaga },
                { 176, PartidoChaco.VeinticincoDeMayo }
            });
        }
    }
}
