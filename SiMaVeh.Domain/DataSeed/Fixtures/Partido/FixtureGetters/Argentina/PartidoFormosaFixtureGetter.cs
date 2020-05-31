using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    internal class PartidoFormosaFixtureGetter : PartidoFixtureGetter
    {
        public PartidoFormosaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Formosa).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(260, PartidoFormosa.Bermejo),
                datosEntidadBuilder.Build(261, PartidoFormosa.Formosa),
                datosEntidadBuilder.Build(262, PartidoFormosa.Laishi),
                datosEntidadBuilder.Build(263, PartidoFormosa.Matacos),
                datosEntidadBuilder.Build(264, PartidoFormosa.Patino),
                datosEntidadBuilder.Build(265, PartidoFormosa.Pilagas),
                datosEntidadBuilder.Build(266, PartidoFormosa.Pilcomayo),
                datosEntidadBuilder.Build(267, PartidoFormosa.Pirane),
                datosEntidadBuilder.Build(268, PartidoFormosa.RamonLista)
            });
        }
    }
}
