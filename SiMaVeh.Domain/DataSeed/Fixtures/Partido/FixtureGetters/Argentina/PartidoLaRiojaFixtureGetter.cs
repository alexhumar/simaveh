using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoLaRiojaFixtureGetter : PartidoFixtureGetter
    {
        public PartidoLaRiojaFixtureGetter(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.LaRioja).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(307, PartidoLaRioja.Arauco),
                datosEntidadBuilder.Build(308, PartidoLaRioja.Capital),
                datosEntidadBuilder.Build(309, PartidoLaRioja.CastroBarros),
                datosEntidadBuilder.Build(310, PartidoLaRioja.Chamical),
                datosEntidadBuilder.Build(311, PartidoLaRioja.Chilecito),
                datosEntidadBuilder.Build(312, PartidoLaRioja.CoronelFelipeVarela),
                datosEntidadBuilder.Build(313, PartidoLaRioja.Famatina),
                datosEntidadBuilder.Build(314, PartidoLaRioja.GeneralAngelVPenaloza),
                datosEntidadBuilder.Build(315, PartidoLaRioja.GeneralBelgrano),
                datosEntidadBuilder.Build(316, PartidoLaRioja.GeneralJuanFacundoQuiroga),
                datosEntidadBuilder.Build(317, PartidoLaRioja.GeneralLamadrid),
                datosEntidadBuilder.Build(318, PartidoLaRioja.GeneralOcampo),
                datosEntidadBuilder.Build(319, PartidoLaRioja.GeneralSanMartin),
                datosEntidadBuilder.Build(320, PartidoLaRioja.Independencia),
                datosEntidadBuilder.Build(321, PartidoLaRioja.RosarioVeraPenaloza),
                datosEntidadBuilder.Build(322, PartidoLaRioja.SanBlasDeLosSauces),
                datosEntidadBuilder.Build(323, PartidoLaRioja.Sanagasta),
                datosEntidadBuilder.Build(324, PartidoLaRioja.Vinchina)
            });
        }
    }
}
