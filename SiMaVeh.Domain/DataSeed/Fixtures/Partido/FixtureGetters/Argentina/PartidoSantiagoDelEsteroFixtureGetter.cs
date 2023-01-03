using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoSantiagoDelEsteroFixtureGetter : PartidoFixtureGetter
    {
        public PartidoSantiagoDelEsteroFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.SantiagoDelEstero).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(466, PartidoSantiagoDelEstero.Aguirre),
                datosEntidadBuilder.Build(467, PartidoSantiagoDelEstero.Alberdi),
                datosEntidadBuilder.Build(468, PartidoSantiagoDelEstero.Atamisqui),
                datosEntidadBuilder.Build(469, PartidoSantiagoDelEstero.Avellaneda),
                datosEntidadBuilder.Build(470, PartidoSantiagoDelEstero.Banda),
                datosEntidadBuilder.Build(471, PartidoSantiagoDelEstero.Belgrano),
                datosEntidadBuilder.Build(472, PartidoSantiagoDelEstero.Capital),
                datosEntidadBuilder.Build(473, PartidoSantiagoDelEstero.Choya),
                datosEntidadBuilder.Build(474, PartidoSantiagoDelEstero.Copo),
                datosEntidadBuilder.Build(475, PartidoSantiagoDelEstero.Figueroa),
                datosEntidadBuilder.Build(476, PartidoSantiagoDelEstero.GeneralTaboada),
                datosEntidadBuilder.Build(477, PartidoSantiagoDelEstero.Guasayan),
                datosEntidadBuilder.Build(478, PartidoSantiagoDelEstero.Jimenez),
                datosEntidadBuilder.Build(479, PartidoSantiagoDelEstero.JuanFelipeIbarra),
                datosEntidadBuilder.Build(480, PartidoSantiagoDelEstero.Loreto),
                datosEntidadBuilder.Build(481, PartidoSantiagoDelEstero.Mitre),
                datosEntidadBuilder.Build(482, PartidoSantiagoDelEstero.Moreno),
                datosEntidadBuilder.Build(483, PartidoSantiagoDelEstero.OjoDeAgua),
                datosEntidadBuilder.Build(484, PartidoSantiagoDelEstero.Pellegrini),
                datosEntidadBuilder.Build(485, PartidoSantiagoDelEstero.Quebrachos),
                datosEntidadBuilder.Build(486, PartidoSantiagoDelEstero.RioHondo),
                datosEntidadBuilder.Build(487, PartidoSantiagoDelEstero.Rivadavia),
                datosEntidadBuilder.Build(488, PartidoSantiagoDelEstero.Robles),
                datosEntidadBuilder.Build(489, PartidoSantiagoDelEstero.Salavina),
                datosEntidadBuilder.Build(490, PartidoSantiagoDelEstero.SanMartin),
                datosEntidadBuilder.Build(491, PartidoSantiagoDelEstero.Sarmiento),
                datosEntidadBuilder.Build(492, PartidoSantiagoDelEstero.Silipica)
            });
        }
    }
}
