using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    public class LocalidadTierraDelFuegoFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadTierraDelFuegoFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.AntartidaArgentina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4153, LocalidadTierraDelFuego.AntartidaArgentina)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.IslasDelAtlanticoSur).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4154, LocalidadTierraDelFuego.IslasMalvinas),
                datosEntidadBuilder.Build(4155, LocalidadTierraDelFuego.IslasGeorgiasDelSur),
                datosEntidadBuilder.Build(4156, LocalidadTierraDelFuego.IslasSandwichDelSur)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.RioGrande).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4157, LocalidadTierraDelFuego.RioGrande),
                datosEntidadBuilder.Build(4158, LocalidadTierraDelFuego.SanSebastian)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.Ushuaia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4159, LocalidadTierraDelFuego.Ushuaia),
                datosEntidadBuilder.Build(4160, LocalidadTierraDelFuego.PuertoAlmanza),
                datosEntidadBuilder.Build(4161, LocalidadTierraDelFuego.PuntaParana),
                datosEntidadBuilder.Build(4162, LocalidadTierraDelFuego.PuertoParry)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTierraDelFuego.Tolhuin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4163, LocalidadTierraDelFuego.Tolhuin),
                datosEntidadBuilder.Build(4164, LocalidadTierraDelFuego.Sarmiento),
                datosEntidadBuilder.Build(4165, LocalidadTierraDelFuego.LagoEscondido)
            });
        }
    }
}
