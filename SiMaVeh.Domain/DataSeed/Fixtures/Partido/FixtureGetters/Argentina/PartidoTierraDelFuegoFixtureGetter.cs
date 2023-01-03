using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoTierraDelFuegoFixtureGetter : PartidoFixtureGetter
    {
        public PartidoTierraDelFuegoFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.TierraDelFuego).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(493, PartidoTierraDelFuego.AntartidaArgentina),
                datosEntidadBuilder.Build(494, PartidoTierraDelFuego.IslasDelAtlanticoSur),
                datosEntidadBuilder.Build(495, PartidoTierraDelFuego.RioGrande),
                datosEntidadBuilder.Build(496, PartidoTierraDelFuego.Tolhuin),
                datosEntidadBuilder.Build(497, PartidoTierraDelFuego.Ushuaia)
            });
        }
    }
}
