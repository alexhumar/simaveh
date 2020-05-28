using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesChacoLoader : LocalidadesLoader
    {
        public LocalidadesChacoLoader(IPartidosLoader partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.AlmiranteBrown).Key, new Dictionary<long, string>
            {
                { 1118, LocalidadChaco.ConcepcionDelBermejo },
                { 1119, LocalidadChaco.LosFrentones },
                { 1120, LocalidadChaco.PampaDelInfierno },
                { 1121, LocalidadChaco.TacoPozo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.Bermejo).Key, new Dictionary<long, string>
            {
                { 1122, LocalidadChaco.GeneralVedia },
                { 1123, LocalidadChaco.IslaDelCerrito },
                { 1124, LocalidadChaco.LaLeonesa },
                { 1125, LocalidadChaco.LasPalmas },
                { 1126, LocalidadChaco.PuertoBermejo },
                { 1127, LocalidadChaco.PuertoEvaPeron }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.Chacabuco).Key, new Dictionary<long, string>
            {
                { 1128, LocalidadChaco.Charata }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.ComandanteFernandez).Key, new Dictionary<long, string>
            {
                { 1129, LocalidadChaco.PresidenciaRoqueSaenzPena }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.DoceDeOctubre).Key, new Dictionary<long, string>
            {
                { 1130, LocalidadChaco.Gancedo },
                { 1131, LocalidadChaco.GeneralCapdevila },
                { 1132, LocalidadChaco.GeneralPinedo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.DosDeAbril).Key, new Dictionary<long, string>
            {
                { 1133, LocalidadChaco.HermosoCampo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.FrayJustoSantaMariaDeOro).Key, new Dictionary<long, string>
            {
                { 1134, LocalidadChaco.Chorotis },
                { 1135, LocalidadChaco.SantaSylvina }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.GeneralBelgrano).Key, new Dictionary<long, string>
            {
                { 1136, LocalidadChaco.Corzuela }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.GeneralDonovan).Key, new Dictionary<long, string>
            {
                { 1137, LocalidadChaco.LaEscondida },
                { 1138, LocalidadChaco.LaVerde },
                { 1139, LocalidadChaco.Lapachito },
                { 1140, LocalidadChaco.Makalle }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.GeneralGuemes).Key, new Dictionary<long, string>
            {
                { 1141, LocalidadChaco.ElEspinillo },
                { 1142, LocalidadChaco.ElSauzalito },
                { 1143, LocalidadChaco.FuerteEsperanza },
                { 1144, LocalidadChaco.JuanJoseCastelli },
                { 1145, LocalidadChaco.Miraflores },
                { 1146, LocalidadChaco.MisionNuevaPompeya },
                { 1147, LocalidadChaco.VillaRioBermejito }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.Independencia).Key, new Dictionary<long, string>
            {
                { 1148, LocalidadChaco.AviaTerai },
                { 1149, LocalidadChaco.CampoLargo },
                { 1150, LocalidadChaco.Napenay }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.Libertad).Key, new Dictionary<long, string>
            {
                { 1151, LocalidadChaco.ColoniaPopular },
                { 1152, LocalidadChaco.LagunaBlanca },
                { 1153, LocalidadChaco.PuertoTirol }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.LibertadorGeneralSanMartin).Key, new Dictionary<long, string>
            {
                { 1154, LocalidadChaco.CiervoPetiso },
                { 1155, LocalidadChaco.GeneralJoseDeSanMartin },
                { 1156, LocalidadChaco.LaEduvigis },
                { 1157, LocalidadChaco.LagunaLimpia },
                { 1158, LocalidadChaco.PampaAlmiron },
                { 1159, LocalidadChaco.PampaDelIndio },
                { 1160, LocalidadChaco.PresidenciaRoca }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.Maipu).Key, new Dictionary<long, string>
            {
                { 1161, LocalidadChaco.TresIsletas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.MayorLuisJorgeFontana).Key, new Dictionary<long, string>
            {
                { 1162, LocalidadChaco.CoronelDuGraty },
                { 1163, LocalidadChaco.EnriqueUrien },
                { 1164, LocalidadChaco.VillaAngela }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.NueveDeJulio).Key, new Dictionary<long, string>
            {
                { 1165, LocalidadChaco.LasBrenas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.OHiggins).Key, new Dictionary<long, string>
            {
                { 1166, LocalidadChaco.LaClotilde },
                { 1167, LocalidadChaco.LaTigra },
                { 1168, LocalidadChaco.SanBernardo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.PresidenciaDeLaPlaza).Key, new Dictionary<long, string>
            {
                { 1169, LocalidadChaco.PresidenciaDeLaPlaza }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.PrimeroDeMayo).Key, new Dictionary<long, string>
            {
                { 1170, LocalidadChaco.MargaritaBelen },
                { 1171, LocalidadChaco.ColoniaBenitez }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.Quitilipi).Key, new Dictionary<long, string>
            {
                { 1172, LocalidadChaco.Quitilipi }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.SanFernando).Key, new Dictionary<long, string>
            {
                { 1173, LocalidadChaco.Resistencia },
                { 1174, LocalidadChaco.Barranqueras },
                { 1175, LocalidadChaco.Basail },
                { 1176, LocalidadChaco.Fontana },
                { 1177, LocalidadChaco.PuertoVilelas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.SanLorenzo).Key, new Dictionary<long, string>
            {
                { 1178, LocalidadChaco.VillaBerthet },
                { 1179, LocalidadChaco.Samuhu }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.SargentoCabral).Key, new Dictionary<long, string>
            {
                { 1180, LocalidadChaco.CapitanSolari },
                { 1181, LocalidadChaco.ColoniaElisa },
                { 1182, LocalidadChaco.ColoniasUnidas },
                { 1183, LocalidadChaco.LasGarcitas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.Tapenaga).Key, new Dictionary<long, string>
            {
                { 1184, LocalidadChaco.Charadai },
                { 1185, LocalidadChaco.CoteLai }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoChaco.VeinticincoDeMayo).Key, new Dictionary<long, string>
            {
                { 1186, LocalidadChaco.Machagai }
            });
        }
    }
}
