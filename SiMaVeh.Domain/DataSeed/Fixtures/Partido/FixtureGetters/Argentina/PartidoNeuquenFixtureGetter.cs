using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    public class PartidoNeuquenFixtureGetter : PartidoFixtureGetter
    {
        public PartidoNeuquenFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Neuquen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(360, PartidoNeuquen.Alumine),
                datosEntidadBuilder.Build(361, PartidoNeuquen.Anelo),
                datosEntidadBuilder.Build(362, PartidoNeuquen.CatanLil),
                datosEntidadBuilder.Build(363, PartidoNeuquen.ChosMalal),
                datosEntidadBuilder.Build(364, PartidoNeuquen.CollonCura),
                datosEntidadBuilder.Build(365, PartidoNeuquen.Confluencia),
                datosEntidadBuilder.Build(366, PartidoNeuquen.Huiliches),
                datosEntidadBuilder.Build(367, PartidoNeuquen.Lacar),
                datosEntidadBuilder.Build(368, PartidoNeuquen.Loncopue),
                datosEntidadBuilder.Build(369, PartidoNeuquen.LosLagos),
                datosEntidadBuilder.Build(370, PartidoNeuquen.Minas),
                datosEntidadBuilder.Build(371, PartidoNeuquen.Norquin),
                datosEntidadBuilder.Build(372, PartidoNeuquen.Pehuenches),
                datosEntidadBuilder.Build(373, PartidoNeuquen.PicunLeufu),
                datosEntidadBuilder.Build(374, PartidoNeuquen.Picunches),
                datosEntidadBuilder.Build(375, PartidoNeuquen.Zapala)
            });
        }
    }
}
