using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoCorrientesFixtureGetter : PartidoFixtureGetter
    {
        public PartidoCorrientesFixtureGetter(IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Corrientes).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(218, PartidoCorrientes.BellaVista),
                datosEntidadBuilder.Build(219, PartidoCorrientes.BeronDeAstrada),
                datosEntidadBuilder.Build(220, PartidoCorrientes.Capital),
                datosEntidadBuilder.Build(221, PartidoCorrientes.Concepcion),
                datosEntidadBuilder.Build(222, PartidoCorrientes.CuruzuCuatia),
                datosEntidadBuilder.Build(223, PartidoCorrientes.Empedrado),
                datosEntidadBuilder.Build(224, PartidoCorrientes.Esquina),
                datosEntidadBuilder.Build(225, PartidoCorrientes.GeneralAlvear),
                datosEntidadBuilder.Build(226, PartidoCorrientes.GeneralPaz),
                datosEntidadBuilder.Build(227, PartidoCorrientes.Goya),
                datosEntidadBuilder.Build(228, PartidoCorrientes.Itati),
                datosEntidadBuilder.Build(229, PartidoCorrientes.Ituzaingo),
                datosEntidadBuilder.Build(230, PartidoCorrientes.Lavalle),
                datosEntidadBuilder.Build(231, PartidoCorrientes.Mburucuya),
                datosEntidadBuilder.Build(232, PartidoCorrientes.Mercedes),
                datosEntidadBuilder.Build(233, PartidoCorrientes.MonteCaseros),
                datosEntidadBuilder.Build(234, PartidoCorrientes.PasoDeLosLibres),
                datosEntidadBuilder.Build(235, PartidoCorrientes.Saladas),
                datosEntidadBuilder.Build(236, PartidoCorrientes.SanCosme),
                datosEntidadBuilder.Build(237, PartidoCorrientes.SanLuisDelPalmar),
                datosEntidadBuilder.Build(238, PartidoCorrientes.SanMartin),
                datosEntidadBuilder.Build(239, PartidoCorrientes.SanMiguel),
                datosEntidadBuilder.Build(240, PartidoCorrientes.SanRoque),
                datosEntidadBuilder.Build(241, PartidoCorrientes.SantoTome),
                datosEntidadBuilder.Build(242, PartidoCorrientes.Sauce)
            });
        }
    }
}
