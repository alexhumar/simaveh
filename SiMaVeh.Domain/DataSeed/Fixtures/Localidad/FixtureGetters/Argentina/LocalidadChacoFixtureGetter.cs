using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    internal class LocalidadChacoFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadChacoFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.AlmiranteBrown).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1118, LocalidadChaco.ConcepcionDelBermejo),
                datosEntidadBuilder.Build(1119, LocalidadChaco.LosFrentones),
                datosEntidadBuilder.Build(1120, LocalidadChaco.PampaDelInfierno),
                datosEntidadBuilder.Build(1121, LocalidadChaco.TacoPozo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Bermejo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1122, LocalidadChaco.GeneralVedia),
                datosEntidadBuilder.Build(1123, LocalidadChaco.IslaDelCerrito),
                datosEntidadBuilder.Build(1124, LocalidadChaco.LaLeonesa),
                datosEntidadBuilder.Build(1125, LocalidadChaco.LasPalmas),
                datosEntidadBuilder.Build(1126, LocalidadChaco.PuertoBermejo),
                datosEntidadBuilder.Build(1127, LocalidadChaco.PuertoEvaPeron)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Chacabuco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1128, LocalidadChaco.Charata)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.ComandanteFernandez).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1129, LocalidadChaco.PresidenciaRoqueSaenzPena)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.DoceDeOctubre).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1130, LocalidadChaco.Gancedo),
                datosEntidadBuilder.Build(1131, LocalidadChaco.GeneralCapdevila),
                datosEntidadBuilder.Build(1132, LocalidadChaco.GeneralPinedo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.DosDeAbril).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1133, LocalidadChaco.HermosoCampo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.FrayJustoSantaMariaDeOro).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1134, LocalidadChaco.Chorotis),
                datosEntidadBuilder.Build(1135, LocalidadChaco.SantaSylvina)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.GeneralBelgrano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1136, LocalidadChaco.Corzuela)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.GeneralDonovan).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1137, LocalidadChaco.LaEscondida),
                datosEntidadBuilder.Build(1138, LocalidadChaco.LaVerde),
                datosEntidadBuilder.Build(1139, LocalidadChaco.Lapachito),
                datosEntidadBuilder.Build(1140, LocalidadChaco.Makalle)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.GeneralGuemes).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1141, LocalidadChaco.ElEspinillo),
                datosEntidadBuilder.Build(1142, LocalidadChaco.ElSauzalito),
                datosEntidadBuilder.Build(1143, LocalidadChaco.FuerteEsperanza),
                datosEntidadBuilder.Build(1144, LocalidadChaco.JuanJoseCastelli),
                datosEntidadBuilder.Build(1145, LocalidadChaco.Miraflores),
                datosEntidadBuilder.Build(1146, LocalidadChaco.MisionNuevaPompeya),
                datosEntidadBuilder.Build(1147, LocalidadChaco.VillaRioBermejito)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Independencia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1148, LocalidadChaco.AviaTerai),
                datosEntidadBuilder.Build(1149, LocalidadChaco.CampoLargo),
                datosEntidadBuilder.Build(1150, LocalidadChaco.Napenay)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Libertad).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1151, LocalidadChaco.ColoniaPopular),
                datosEntidadBuilder.Build(1152, LocalidadChaco.LagunaBlanca),
                datosEntidadBuilder.Build(1153, LocalidadChaco.PuertoTirol)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.LibertadorGeneralSanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1154, LocalidadChaco.CiervoPetiso),
                datosEntidadBuilder.Build(1155, LocalidadChaco.GeneralJoseDeSanMartin),
                datosEntidadBuilder.Build(1156, LocalidadChaco.LaEduvigis),
                datosEntidadBuilder.Build(1157, LocalidadChaco.LagunaLimpia),
                datosEntidadBuilder.Build(1158, LocalidadChaco.PampaAlmiron),
                datosEntidadBuilder.Build(1159, LocalidadChaco.PampaDelIndio),
                datosEntidadBuilder.Build(1160, LocalidadChaco.PresidenciaRoca)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Maipu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1161, LocalidadChaco.TresIsletas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.MayorLuisJorgeFontana).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1162, LocalidadChaco.CoronelDuGraty),
                datosEntidadBuilder.Build(1163, LocalidadChaco.EnriqueUrien),
                datosEntidadBuilder.Build(1164, LocalidadChaco.VillaAngela)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.NueveDeJulio).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1165, LocalidadChaco.LasBrenas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.OHiggins).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1166, LocalidadChaco.LaClotilde),
                datosEntidadBuilder.Build(1167, LocalidadChaco.LaTigra),
                datosEntidadBuilder.Build(1168, LocalidadChaco.SanBernardo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.PresidenciaDeLaPlaza).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1169, LocalidadChaco.PresidenciaDeLaPlaza)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.PrimeroDeMayo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1170, LocalidadChaco.MargaritaBelen),
                datosEntidadBuilder.Build(1171, LocalidadChaco.ColoniaBenitez)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Quitilipi).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1172, LocalidadChaco.Quitilipi)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.SanFernando).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1173, LocalidadChaco.Resistencia),
                datosEntidadBuilder.Build(1174, LocalidadChaco.Barranqueras),
                datosEntidadBuilder.Build(1175, LocalidadChaco.Basail),
                datosEntidadBuilder.Build(1176, LocalidadChaco.Fontana),
                datosEntidadBuilder.Build(1177, LocalidadChaco.PuertoVilelas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.SanLorenzo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1178, LocalidadChaco.VillaBerthet),
                datosEntidadBuilder.Build(1179, LocalidadChaco.Samuhu)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.SargentoCabral).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1180, LocalidadChaco.CapitanSolari),
                datosEntidadBuilder.Build(1181, LocalidadChaco.ColoniaElisa),
                datosEntidadBuilder.Build(1182, LocalidadChaco.ColoniasUnidas),
                datosEntidadBuilder.Build(1183, LocalidadChaco.LasGarcitas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Tapenaga).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1184, LocalidadChaco.Charadai),
                datosEntidadBuilder.Build(1185, LocalidadChaco.CoteLai)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.VeinticincoDeMayo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1186, LocalidadChaco.Machagai)
            });
        }
    }
}
