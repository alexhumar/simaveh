using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoSanJuanFixtureGetter : PartidoFixtureGetter
    {
        public PartidoSanJuanFixtureGetter(IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.SanJuan).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(412, PartidoSanJuan.Albardon),
                datosEntidadBuilder.Build(413, PartidoSanJuan.Angaco),
                datosEntidadBuilder.Build(414, PartidoSanJuan.Calingasta),
                datosEntidadBuilder.Build(415, PartidoSanJuan.Capital),
                datosEntidadBuilder.Build(416, PartidoSanJuan.Caucete),
                datosEntidadBuilder.Build(417, PartidoSanJuan.Chimbas),
                datosEntidadBuilder.Build(418, PartidoSanJuan.Iglesia),
                datosEntidadBuilder.Build(419, PartidoSanJuan.Jachal),
                datosEntidadBuilder.Build(420, PartidoSanJuan.NueveDeJulio),
                datosEntidadBuilder.Build(421, PartidoSanJuan.Pocito),
                datosEntidadBuilder.Build(422, PartidoSanJuan.Rawson),
                datosEntidadBuilder.Build(423, PartidoSanJuan.Rivadavia),
                datosEntidadBuilder.Build(424, PartidoSanJuan.SanMartin),
                datosEntidadBuilder.Build(425, PartidoSanJuan.SantaLucia),
                datosEntidadBuilder.Build(426, PartidoSanJuan.Sarmiento),
                datosEntidadBuilder.Build(427, PartidoSanJuan.Ullum),
                datosEntidadBuilder.Build(428, PartidoSanJuan.ValleFertil),
                datosEntidadBuilder.Build(429, PartidoSanJuan.VeinticincoDeMayo),
                datosEntidadBuilder.Build(430, PartidoSanJuan.Zonda)
            });
        }
    }
}
