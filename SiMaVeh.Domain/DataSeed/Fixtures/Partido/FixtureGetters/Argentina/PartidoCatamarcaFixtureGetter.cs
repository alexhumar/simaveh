using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoCatamarcaFixtureGetter : PartidoFixtureGetter
    {
        public PartidoCatamarcaFixtureGetter(IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Catamarca).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(136, PartidoCatamarca.Ambato),
                datosEntidadBuilder.Build(137, PartidoCatamarca.Ancasti),
                datosEntidadBuilder.Build(138, PartidoCatamarca.Andalgala),
                datosEntidadBuilder.Build(139, PartidoCatamarca.AntofagastaDeLaSierra),
                datosEntidadBuilder.Build(140, PartidoCatamarca.Belen),
                datosEntidadBuilder.Build(141, PartidoCatamarca.Capayan),
                datosEntidadBuilder.Build(142, PartidoCatamarca.Capital),
                datosEntidadBuilder.Build(143, PartidoCatamarca.ElAlto),
                datosEntidadBuilder.Build(144, PartidoCatamarca.FrayMamertoEsquiu),
                datosEntidadBuilder.Build(145, PartidoCatamarca.LaPaz),
                datosEntidadBuilder.Build(146, PartidoCatamarca.Paclin),
                datosEntidadBuilder.Build(147, PartidoCatamarca.Poman),
                datosEntidadBuilder.Build(148, PartidoCatamarca.SantaMaria),
                datosEntidadBuilder.Build(149, PartidoCatamarca.SantaRosa),
                datosEntidadBuilder.Build(150, PartidoCatamarca.Tinogasta),
                datosEntidadBuilder.Build(151, PartidoCatamarca.ValleViejo)
            });
        }
    }
}
