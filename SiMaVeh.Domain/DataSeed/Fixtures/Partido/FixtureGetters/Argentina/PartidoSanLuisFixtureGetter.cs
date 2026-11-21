using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoSanLuisFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
        IProvinciaFixtureGetter provinciaFixtureGetter) : PartidoFixtureGetter(datosEntidadBuilder, provinciaFixtureGetter)
    {
        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.SanLuis).Id,
            [
                datosEntidadBuilder.Build(431, PartidoSanLuis.JuanMartinDePueyrredon),
                datosEntidadBuilder.Build(432, PartidoSanLuis.GeneralPedernera),
                datosEntidadBuilder.Build(433, PartidoSanLuis.Junin),
                datosEntidadBuilder.Build(434, PartidoSanLuis.Chacabuco),
                datosEntidadBuilder.Build(435, PartidoSanLuis.Ayacucho),
                datosEntidadBuilder.Build(436, PartidoSanLuis.CoronelPringles),
                datosEntidadBuilder.Build(437, PartidoSanLuis.GobernadorDupuy),
                datosEntidadBuilder.Build(438, PartidoSanLuis.LibertadorGeneralSanMartin),
                datosEntidadBuilder.Build(439, PartidoSanLuis.Belgrano)
            ]);
        }
    }
}
