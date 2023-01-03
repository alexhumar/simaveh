using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoChacoFixtureGetter : PartidoFixtureGetter
    {
        public PartidoChacoFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Chaco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(152, PartidoChaco.AlmiranteBrown),
                datosEntidadBuilder.Build(153, PartidoChaco.Bermejo),
                datosEntidadBuilder.Build(154, PartidoChaco.Chacabuco),
                datosEntidadBuilder.Build(155, PartidoChaco.ComandanteFernandez),
                datosEntidadBuilder.Build(156, PartidoChaco.DoceDeOctubre),
                datosEntidadBuilder.Build(157, PartidoChaco.DosDeAbril),
                datosEntidadBuilder.Build(158, PartidoChaco.FrayJustoSantaMariaDeOro),
                datosEntidadBuilder.Build(159, PartidoChaco.GeneralBelgrano),
                datosEntidadBuilder.Build(160, PartidoChaco.GeneralDonovan),
                datosEntidadBuilder.Build(161, PartidoChaco.GeneralGuemes),
                datosEntidadBuilder.Build(162, PartidoChaco.Independencia),
                datosEntidadBuilder.Build(163, PartidoChaco.Libertad),
                datosEntidadBuilder.Build(164, PartidoChaco.LibertadorGeneralSanMartin),
                datosEntidadBuilder.Build(165, PartidoChaco.Maipu),
                datosEntidadBuilder.Build(166, PartidoChaco.MayorLuisJorgeFontana),
                datosEntidadBuilder.Build(167, PartidoChaco.NueveDeJulio),
                datosEntidadBuilder.Build(168, PartidoChaco.OHiggins),
                datosEntidadBuilder.Build(169, PartidoChaco.PresidenciaDeLaPlaza),
                datosEntidadBuilder.Build(170, PartidoChaco.PrimeroDeMayo),
                datosEntidadBuilder.Build(171, PartidoChaco.Quitilipi),
                datosEntidadBuilder.Build(172, PartidoChaco.SanFernando),
                datosEntidadBuilder.Build(173, PartidoChaco.SanLorenzo),
                datosEntidadBuilder.Build(174, PartidoChaco.SargentoCabral),
                datosEntidadBuilder.Build(175, PartidoChaco.Tapenaga),
                datosEntidadBuilder.Build(176, PartidoChaco.VeinticincoDeMayo)
            });
        }
    }
}
