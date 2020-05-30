using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoSantaFeFixtureGetter : PartidoFixtureGetter
    {
        public PartidoSantaFeFixtureGetter(IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.SantaFe).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(447, PartidoSantaFe.Rosario),
                datosEntidadBuilder.Build(448, PartidoSantaFe.LaCapital),
                datosEntidadBuilder.Build(449, PartidoSantaFe.GeneralLopez),
                datosEntidadBuilder.Build(450, PartidoSantaFe.Castellanos),
                datosEntidadBuilder.Build(451, PartidoSantaFe.GeneralObligado),
                datosEntidadBuilder.Build(452, PartidoSantaFe.SanLorenzo),
                datosEntidadBuilder.Build(453, PartidoSantaFe.LasColonias),
                datosEntidadBuilder.Build(454, PartidoSantaFe.Constitucion),
                datosEntidadBuilder.Build(455, PartidoSantaFe.Caseros),
                datosEntidadBuilder.Build(456, PartidoSantaFe.SanJeronimo),
                datosEntidadBuilder.Build(457, PartidoSantaFe.SanCristobal),
                datosEntidadBuilder.Build(458, PartidoSantaFe.Iriondo),
                datosEntidadBuilder.Build(459, PartidoSantaFe.SanMartin),
                datosEntidadBuilder.Build(460, PartidoSantaFe.Vera),
                datosEntidadBuilder.Build(461, PartidoSantaFe.Belgrano),
                datosEntidadBuilder.Build(462, PartidoSantaFe.SanJusto),
                datosEntidadBuilder.Build(463, PartidoSantaFe.SanJavier),
                datosEntidadBuilder.Build(464, PartidoSantaFe.NueveDeJulio),
                datosEntidadBuilder.Build(465, PartidoSantaFe.Garay)
            });
        }
    }
}
