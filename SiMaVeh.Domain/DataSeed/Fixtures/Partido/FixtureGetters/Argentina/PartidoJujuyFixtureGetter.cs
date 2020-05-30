using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoJujuyFixtureGetter : PartidoFixtureGetter
    {
        public PartidoJujuyFixtureGetter(IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Jujuy).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(269, PartidoJujuy.Cochinoca),
                datosEntidadBuilder.Build(270, PartidoJujuy.DrManuelBelgrano),
                datosEntidadBuilder.Build(271, PartidoJujuy.ElCarmen),
                datosEntidadBuilder.Build(272, PartidoJujuy.Humahuaca),
                datosEntidadBuilder.Build(273, PartidoJujuy.Ledesma),
                datosEntidadBuilder.Build(274, PartidoJujuy.Palpala),
                datosEntidadBuilder.Build(275, PartidoJujuy.Rinconada),
                datosEntidadBuilder.Build(276, PartidoJujuy.SanAntonio),
                datosEntidadBuilder.Build(277, PartidoJujuy.SanPedro),
                datosEntidadBuilder.Build(278, PartidoJujuy.SantaBarbara),
                datosEntidadBuilder.Build(279, PartidoJujuy.SantaCatalina),
                datosEntidadBuilder.Build(280, PartidoJujuy.Susques),
                datosEntidadBuilder.Build(281, PartidoJujuy.Tilcara),
                datosEntidadBuilder.Build(282, PartidoJujuy.Tumbaya),
                datosEntidadBuilder.Build(283, PartidoJujuy.ValleGrande),
                datosEntidadBuilder.Build(284, PartidoJujuy.Yavi)
            });
        }
    }
}
