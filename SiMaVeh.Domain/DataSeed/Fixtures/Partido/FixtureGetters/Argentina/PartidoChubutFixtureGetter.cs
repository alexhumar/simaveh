using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoChubutFixtureGetter : PartidoFixtureGetter
    {
        public PartidoChubutFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Chubut).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(177, PartidoChubut.Biedma),
                datosEntidadBuilder.Build(178, PartidoChubut.Cushamen),
                datosEntidadBuilder.Build(179, PartidoChubut.Escalante),
                datosEntidadBuilder.Build(180, PartidoChubut.FlorentinoAmeghino),
                datosEntidadBuilder.Build(181, PartidoChubut.Futaleufu),
                datosEntidadBuilder.Build(182, PartidoChubut.Gaiman),
                datosEntidadBuilder.Build(183, PartidoChubut.Gastre),
                datosEntidadBuilder.Build(184, PartidoChubut.Languineo),
                datosEntidadBuilder.Build(185, PartidoChubut.Martires),
                datosEntidadBuilder.Build(186, PartidoChubut.PasoDeIndios),
                datosEntidadBuilder.Build(187, PartidoChubut.Rawson),
                datosEntidadBuilder.Build(188, PartidoChubut.RioSenguer),
                datosEntidadBuilder.Build(189, PartidoChubut.Sarmiento),
                datosEntidadBuilder.Build(190, PartidoChubut.Tehuelches),
                datosEntidadBuilder.Build(191, PartidoChubut.Telsen)
            });
        }
    }
}
