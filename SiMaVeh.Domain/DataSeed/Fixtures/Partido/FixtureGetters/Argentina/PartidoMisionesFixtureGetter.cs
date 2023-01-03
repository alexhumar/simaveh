﻿using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoMisionesFixtureGetter : PartidoFixtureGetter
    {
        public PartidoMisionesFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Misiones).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(343, PartidoMisiones.Apostoles),
                datosEntidadBuilder.Build(344, PartidoMisiones.Cainguas),
                datosEntidadBuilder.Build(345, PartidoMisiones.Candelaria),
                datosEntidadBuilder.Build(346, PartidoMisiones.Capital),
                datosEntidadBuilder.Build(347, PartidoMisiones.Concepcion),
                datosEntidadBuilder.Build(348, PartidoMisiones.Eldorado),
                datosEntidadBuilder.Build(349, PartidoMisiones.GeneralManuelBelgrano),
                datosEntidadBuilder.Build(350, PartidoMisiones.Guarani),
                datosEntidadBuilder.Build(351, PartidoMisiones.Iguazu),
                datosEntidadBuilder.Build(352, PartidoMisiones.LeandroNAlem),
                datosEntidadBuilder.Build(353, PartidoMisiones.LibertadorGeneralSanMartin),
                datosEntidadBuilder.Build(354, PartidoMisiones.Montecarlo),
                datosEntidadBuilder.Build(355, PartidoMisiones.Obera),
                datosEntidadBuilder.Build(356, PartidoMisiones.SanIgnacio),
                datosEntidadBuilder.Build(357, PartidoMisiones.SanJavier),
                datosEntidadBuilder.Build(358, PartidoMisiones.SanPedro),
                datosEntidadBuilder.Build(359, PartidoMisiones.VeinticincoDeMayo)
            });
        }
    }
}
