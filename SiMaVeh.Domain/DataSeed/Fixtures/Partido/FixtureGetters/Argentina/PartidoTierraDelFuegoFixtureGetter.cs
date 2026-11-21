using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoTierraDelFuegoFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
        IProvinciaFixtureGetter provinciaFixtureGetter) : PartidoFixtureGetter(datosEntidadBuilder, provinciaFixtureGetter)
    {
        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.TierraDelFuego).Id,
            [
                datosEntidadBuilder.Build(493, PartidoTierraDelFuego.AntartidaArgentina),
                datosEntidadBuilder.Build(494, PartidoTierraDelFuego.IslasDelAtlanticoSur),
                datosEntidadBuilder.Build(495, PartidoTierraDelFuego.RioGrande),
                datosEntidadBuilder.Build(496, PartidoTierraDelFuego.Tolhuin),
                datosEntidadBuilder.Build(497, PartidoTierraDelFuego.Ushuaia)
            ]);
        }
    }
}
