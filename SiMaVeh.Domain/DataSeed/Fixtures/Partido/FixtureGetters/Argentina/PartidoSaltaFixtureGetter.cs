using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoSaltaFixtureGetter : PartidoFixtureGetter
    {
        public PartidoSaltaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Salta).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(389, PartidoSalta.Anta),
                datosEntidadBuilder.Build(390, PartidoSalta.Cachi),
                datosEntidadBuilder.Build(391, PartidoSalta.Cafayate),
                datosEntidadBuilder.Build(392, PartidoSalta.Capital),
                datosEntidadBuilder.Build(393, PartidoSalta.Cerrillos),
                datosEntidadBuilder.Build(394, PartidoSalta.Chicoana),
                datosEntidadBuilder.Build(395, PartidoSalta.GeneralGuemes),
                datosEntidadBuilder.Build(396, PartidoSalta.GeneralJoseDeSanMartin),
                datosEntidadBuilder.Build(397, PartidoSalta.Guachipas),
                datosEntidadBuilder.Build(398, PartidoSalta.Iruya),
                datosEntidadBuilder.Build(399, PartidoSalta.LaCaldera),
                datosEntidadBuilder.Build(400, PartidoSalta.LaCandelaria),
                datosEntidadBuilder.Build(401, PartidoSalta.LaPoma),
                datosEntidadBuilder.Build(402, PartidoSalta.LaVina),
                datosEntidadBuilder.Build(403, PartidoSalta.LosAndes),
                datosEntidadBuilder.Build(404, PartidoSalta.Metan),
                datosEntidadBuilder.Build(405, PartidoSalta.Molinos),
                datosEntidadBuilder.Build(406, PartidoSalta.Oran),
                datosEntidadBuilder.Build(407, PartidoSalta.Rivadavia),
                datosEntidadBuilder.Build(408, PartidoSalta.RosarioDeLaFrontera),
                datosEntidadBuilder.Build(409, PartidoSalta.RosarioDeLerma),
                datosEntidadBuilder.Build(410, PartidoSalta.SanCarlos),
                datosEntidadBuilder.Build(411, PartidoSalta.SantaVictoria)
            });
        }
    }
}
