using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoMendozaFixtureGetter : PartidoFixtureGetter
    {
        public PartidoMendozaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Mendoza).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(325, PartidoMendoza.Capital),
                datosEntidadBuilder.Build(326, PartidoMendoza.GeneralAlvear),
                datosEntidadBuilder.Build(327, PartidoMendoza.GodoyCruz),
                datosEntidadBuilder.Build(328, PartidoMendoza.Guaymallen),
                datosEntidadBuilder.Build(329, PartidoMendoza.Junin),
                datosEntidadBuilder.Build(330, PartidoMendoza.LaPaz),
                datosEntidadBuilder.Build(331, PartidoMendoza.LasHeras),
                datosEntidadBuilder.Build(332, PartidoMendoza.Lavalle),
                datosEntidadBuilder.Build(333, PartidoMendoza.LujanDeCuyo),
                datosEntidadBuilder.Build(334, PartidoMendoza.Maipu),
                datosEntidadBuilder.Build(335, PartidoMendoza.Malargue),
                datosEntidadBuilder.Build(336, PartidoMendoza.Rivadavia),
                datosEntidadBuilder.Build(337, PartidoMendoza.SanCarlos),
                datosEntidadBuilder.Build(338, PartidoMendoza.GeneralSanMartin),
                datosEntidadBuilder.Build(339, PartidoMendoza.SanRafael),
                datosEntidadBuilder.Build(340, PartidoMendoza.SantaRosa),
                datosEntidadBuilder.Build(341, PartidoMendoza.Tunuyan),
                datosEntidadBuilder.Build(342, PartidoMendoza.Tupungato)
            });
        }
    }
}
