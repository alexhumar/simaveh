using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesChacoLoader : LocalidadFixtureGetter
    {
        public LocalidadesChacoLoader(IPartidoFixtureGetter partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.AlmiranteBrown).Key, new Dictionary<long, string>
            {
                { 1118, LocalidadChaco.ConcepcionDelBermejo },
                { 1119, LocalidadChaco.LosFrentones },
                { 1120, LocalidadChaco.PampaDelInfierno },
                { 1121, LocalidadChaco.TacoPozo }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Bermejo).Key, new Dictionary<long, string>
            {
                { 1122, LocalidadChaco.GeneralVedia },
                { 1123, LocalidadChaco.IslaDelCerrito },
                { 1124, LocalidadChaco.LaLeonesa },
                { 1125, LocalidadChaco.LasPalmas },
                { 1126, LocalidadChaco.PuertoBermejo },
                { 1127, LocalidadChaco.PuertoEvaPeron }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Chacabuco).Key, new Dictionary<long, string>
            {
                { 1128, LocalidadChaco.Charata }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.ComandanteFernandez).Key, new Dictionary<long, string>
            {
                { 1129, LocalidadChaco.PresidenciaRoqueSaenzPena }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.DoceDeOctubre).Key, new Dictionary<long, string>
            {
                { 1130, LocalidadChaco.Gancedo },
                { 1131, LocalidadChaco.GeneralCapdevila },
                { 1132, LocalidadChaco.GeneralPinedo }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.DosDeAbril).Key, new Dictionary<long, string>
            {
                { 1133, LocalidadChaco.HermosoCampo }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.FrayJustoSantaMariaDeOro).Key, new Dictionary<long, string>
            {
                { 1134, LocalidadChaco.Chorotis },
                { 1135, LocalidadChaco.SantaSylvina }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.GeneralBelgrano).Key, new Dictionary<long, string>
            {
                { 1136, LocalidadChaco.Corzuela }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.GeneralDonovan).Key, new Dictionary<long, string>
            {
                { 1137, LocalidadChaco.LaEscondida },
                { 1138, LocalidadChaco.LaVerde },
                { 1139, LocalidadChaco.Lapachito },
                { 1140, LocalidadChaco.Makalle }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.GeneralGuemes).Key, new Dictionary<long, string>
            {
                { 1141, LocalidadChaco.ElEspinillo },
                { 1142, LocalidadChaco.ElSauzalito },
                { 1143, LocalidadChaco.FuerteEsperanza },
                { 1144, LocalidadChaco.JuanJoseCastelli },
                { 1145, LocalidadChaco.Miraflores },
                { 1146, LocalidadChaco.MisionNuevaPompeya },
                { 1147, LocalidadChaco.VillaRioBermejito }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Independencia).Key, new Dictionary<long, string>
            {
                { 1148, LocalidadChaco.AviaTerai },
                { 1149, LocalidadChaco.CampoLargo },
                { 1150, LocalidadChaco.Napenay }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Libertad).Key, new Dictionary<long, string>
            {
                { 1151, LocalidadChaco.ColoniaPopular },
                { 1152, LocalidadChaco.LagunaBlanca },
                { 1153, LocalidadChaco.PuertoTirol }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.LibertadorGeneralSanMartin).Key, new Dictionary<long, string>
            {
                { 1154, LocalidadChaco.CiervoPetiso },
                { 1155, LocalidadChaco.GeneralJoseDeSanMartin },
                { 1156, LocalidadChaco.LaEduvigis },
                { 1157, LocalidadChaco.LagunaLimpia },
                { 1158, LocalidadChaco.PampaAlmiron },
                { 1159, LocalidadChaco.PampaDelIndio },
                { 1160, LocalidadChaco.PresidenciaRoca }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Maipu).Key, new Dictionary<long, string>
            {
                { 1161, LocalidadChaco.TresIsletas }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.MayorLuisJorgeFontana).Key, new Dictionary<long, string>
            {
                { 1162, LocalidadChaco.CoronelDuGraty },
                { 1163, LocalidadChaco.EnriqueUrien },
                { 1164, LocalidadChaco.VillaAngela }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.NueveDeJulio).Key, new Dictionary<long, string>
            {
                { 1165, LocalidadChaco.LasBrenas }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.OHiggins).Key, new Dictionary<long, string>
            {
                { 1166, LocalidadChaco.LaClotilde },
                { 1167, LocalidadChaco.LaTigra },
                { 1168, LocalidadChaco.SanBernardo }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.PresidenciaDeLaPlaza).Key, new Dictionary<long, string>
            {
                { 1169, LocalidadChaco.PresidenciaDeLaPlaza }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.PrimeroDeMayo).Key, new Dictionary<long, string>
            {
                { 1170, LocalidadChaco.MargaritaBelen },
                { 1171, LocalidadChaco.ColoniaBenitez }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Quitilipi).Key, new Dictionary<long, string>
            {
                { 1172, LocalidadChaco.Quitilipi }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.SanFernando).Key, new Dictionary<long, string>
            {
                { 1173, LocalidadChaco.Resistencia },
                { 1174, LocalidadChaco.Barranqueras },
                { 1175, LocalidadChaco.Basail },
                { 1176, LocalidadChaco.Fontana },
                { 1177, LocalidadChaco.PuertoVilelas }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.SanLorenzo).Key, new Dictionary<long, string>
            {
                { 1178, LocalidadChaco.VillaBerthet },
                { 1179, LocalidadChaco.Samuhu }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.SargentoCabral).Key, new Dictionary<long, string>
            {
                { 1180, LocalidadChaco.CapitanSolari },
                { 1181, LocalidadChaco.ColoniaElisa },
                { 1182, LocalidadChaco.ColoniasUnidas },
                { 1183, LocalidadChaco.LasGarcitas }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.Tapenaga).Key, new Dictionary<long, string>
            {
                { 1184, LocalidadChaco.Charadai },
                { 1185, LocalidadChaco.CoteLai }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChaco.VeinticincoDeMayo).Key, new Dictionary<long, string>
            {
                { 1186, LocalidadChaco.Machagai }
            });
        }
    }
}
