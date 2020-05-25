using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class ChacoLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public ChacoLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.AlmiranteBrown).Value.Key, new Dictionary<long, string>
            {
                { 1118, LocalidadChaco.ConcepcionDelBermejo },
                { 1119, LocalidadChaco.LosFrentones },
                { 1120, LocalidadChaco.PampaDelInfierno },
                { 1121, LocalidadChaco.TacoPozo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.Bermejo).Value.Key, new Dictionary<long, string>
            {
                { 1122, LocalidadChaco.GeneralVedia },
                { 1123, LocalidadChaco.IslaDelCerrito },
                { 1124, LocalidadChaco.LaLeonesa },
                { 1125, LocalidadChaco.LasPalmas },
                { 1126, LocalidadChaco.PuertoBermejo },
                { 1127, LocalidadChaco.PuertoEvaPeron }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.Chacabuco).Value.Key, new Dictionary<long, string>
            {
                { 1128, LocalidadChaco.Charata }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.ComandanteFernandez).Value.Key, new Dictionary<long, string>
            {
                { 1129, LocalidadChaco.PresidenciaRoqueSaenzPena }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.DoceDeOctubre).Value.Key, new Dictionary<long, string>
            {
                { 1130, LocalidadChaco.Gancedo },
                { 1131, LocalidadChaco.GeneralCapdevila },
                { 1132, LocalidadChaco.GeneralPinedo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.DosDeAbril).Value.Key, new Dictionary<long, string>
            {
                { 1133, LocalidadChaco.HermosoCampo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.FrayJustoSantaMariaDeOro).Value.Key, new Dictionary<long, string>
            {
                { 1134, LocalidadChaco.Chorotis },
                { 1135, LocalidadChaco.SantaSylvina }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.GeneralBelgrano).Value.Key, new Dictionary<long, string>
            {
                { 1136, LocalidadChaco.Corzuela }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.GeneralDonovan).Value.Key, new Dictionary<long, string>
            {
                { 1137, LocalidadChaco.LaEscondida },
                { 1138, LocalidadChaco.LaVerde },
                { 1139, LocalidadChaco.Lapachito },
                { 1140, LocalidadChaco.Makalle }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.GeneralGuemes).Value.Key, new Dictionary<long, string>
            {
                { 1141, LocalidadChaco.ElEspinillo },
                { 1142, LocalidadChaco.ElSauzalito },
                { 1143, LocalidadChaco.FuerteEsperanza },
                { 1144, LocalidadChaco.JuanJoseCastelli },
                { 1145, LocalidadChaco.Miraflores },
                { 1146, LocalidadChaco.MisionNuevaPompeya },
                { 1147, LocalidadChaco.VillaRioBermejito }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.Independencia).Value.Key, new Dictionary<long, string>
            {
                { 1148, LocalidadChaco.AviaTerai },
                { 1149, LocalidadChaco.CampoLargo },
                { 1150, LocalidadChaco.Napenay }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.Libertad).Value.Key, new Dictionary<long, string>
            {
                { 1151, LocalidadChaco.ColoniaPopular },
                { 1152, LocalidadChaco.LagunaBlanca },
                { 1153, LocalidadChaco.PuertoTirol }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.LibertadorGeneralSanMartin).Value.Key, new Dictionary<long, string>
            {
                { 1154, LocalidadChaco.CiervoPetiso },
                { 1155, LocalidadChaco.GeneralJoseDeSanMartin },
                { 1156, LocalidadChaco.LaEduvigis },
                { 1157, LocalidadChaco.LagunaLimpia },
                { 1158, LocalidadChaco.PampaAlmiron },
                { 1159, LocalidadChaco.PampaDelIndio },
                { 1160, LocalidadChaco.PresidenciaRoca }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.Maipu).Value.Key, new Dictionary<long, string>
            {
                { 1161, LocalidadChaco.TresIsletas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.MayorLuisJorgeFontana).Value.Key, new Dictionary<long, string>
            {
                { 1162, LocalidadChaco.CoronelDuGraty },
                { 1163, LocalidadChaco.EnriqueUrien },
                { 1164, LocalidadChaco.VillaAngela }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.NueveDeJulio).Value.Key, new Dictionary<long, string>
            {
                { 1165, LocalidadChaco.LasBrenas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.OHiggins).Value.Key, new Dictionary<long, string>
            {
                { 1166, LocalidadChaco.LaClotilde },
                { 1167, LocalidadChaco.LaTigra },
                { 1168, LocalidadChaco.SanBernardo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.PresidenciaDeLaPlaza).Value.Key, new Dictionary<long, string>
            {
                { 1169, LocalidadChaco.PresidenciaDeLaPlaza }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.PrimeroDeMayo).Value.Key, new Dictionary<long, string>
            {
                { 1170, LocalidadChaco.MargaritaBelen },
                { 1171, LocalidadChaco.ColoniaBenitez }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.Quitilipi).Value.Key, new Dictionary<long, string>
            {
                { 1172, LocalidadChaco.Quitilipi }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.SanFernando).Value.Key, new Dictionary<long, string>
            {
                { 1173, LocalidadChaco.Resistencia },
                { 1174, LocalidadChaco.Barranqueras },
                { 1175, LocalidadChaco.Basail },
                { 1176, LocalidadChaco.Fontana },
                { 1177, LocalidadChaco.PuertoVilelas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.SanLorenzo).Value.Key, new Dictionary<long, string>
            {
                { 1178, LocalidadChaco.VillaBerthet },
                { 1179, LocalidadChaco.Samuhu }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.SargentoCabral).Value.Key, new Dictionary<long, string>
            {
                { 1180, LocalidadChaco.CapitanSolari },
                { 1181, LocalidadChaco.ColoniaElisa },
                { 1182, LocalidadChaco.ColoniasUnidas },
                { 1183, LocalidadChaco.LasGarcitas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.Tapenaga).Value.Key, new Dictionary<long, string>
            {
                { 1184, LocalidadChaco.Charadai },
                { 1185, LocalidadChaco.CoteLai }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChaco.VeinticincoDeMayo).Value.Key, new Dictionary<long, string>
            {
                { 1186, LocalidadChaco.Machagai }
            });
        }
    }
}
