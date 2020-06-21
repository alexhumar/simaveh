using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    internal class LocalidadCordobaFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadCordobaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Calamuchita).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1285, LocalidadCordoba.Embalse),
                datosEntidadBuilder.Build(1286, LocalidadCordoba.LaCruz),
                datosEntidadBuilder.Build(1287, LocalidadCordoba.LosCondores),
                datosEntidadBuilder.Build(1288, LocalidadCordoba.LosMolinos),
                datosEntidadBuilder.Build(1289, LocalidadCordoba.LosReartes),
                datosEntidadBuilder.Build(1290, LocalidadCordoba.RioDeLosSauces),
                datosEntidadBuilder.Build(1291, LocalidadCordoba.SanAgustin),
                datosEntidadBuilder.Build(1292, LocalidadCordoba.SantaRosaDeCalamuchita),
                datosEntidadBuilder.Build(1293, LocalidadCordoba.VillaDelDique),
                datosEntidadBuilder.Build(1294, LocalidadCordoba.VillaGeneralBelgrano),
                datosEntidadBuilder.Build(1295, LocalidadCordoba.VillaRumipal),
                datosEntidadBuilder.Build(1296, LocalidadCordoba.VillaYacanto),
                datosEntidadBuilder.Build(1297, LocalidadCordoba.Amboy),
                datosEntidadBuilder.Build(1298, LocalidadCordoba.Calmayo),
                datosEntidadBuilder.Build(1299, LocalidadCordoba.CanadaDelSauce),
                datosEntidadBuilder.Build(1300, LocalidadCordoba.LaCumbrecita),
                datosEntidadBuilder.Build(1301, LocalidadCordoba.LasBajadas),
                datosEntidadBuilder.Build(1302, LocalidadCordoba.LasCaleras),
                datosEntidadBuilder.Build(1303, LocalidadCordoba.Lutti),
                datosEntidadBuilder.Build(1304, LocalidadCordoba.SanIgnacio),
                datosEntidadBuilder.Build(1305, LocalidadCordoba.SegundaUsina),
                datosEntidadBuilder.Build(1306, LocalidadCordoba.VillaAmancay),
                datosEntidadBuilder.Build(1307, LocalidadCordoba.VillaCiudadParqueLosReartes),
                datosEntidadBuilder.Build(1308, LocalidadCordoba.VillaQuillinzo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1309, LocalidadCordoba.Cordoba)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Colon).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1310, LocalidadCordoba.AguaDeOro),
                datosEntidadBuilder.Build(1311, LocalidadCordoba.ColoniaCaroya),
                datosEntidadBuilder.Build(1312, LocalidadCordoba.EstacionJuarezCelman),
                datosEntidadBuilder.Build(1313, LocalidadCordoba.JesusMaria),
                datosEntidadBuilder.Build(1314, LocalidadCordoba.LaCalera),
                datosEntidadBuilder.Build(1315, LocalidadCordoba.LaGranja),
                datosEntidadBuilder.Build(1316, LocalidadCordoba.MalvinasArgentinas),
                datosEntidadBuilder.Build(1317, LocalidadCordoba.Mendiolaza),
                datosEntidadBuilder.Build(1318, LocalidadCordoba.RioCeballos),
                datosEntidadBuilder.Build(1319, LocalidadCordoba.Saldan),
                datosEntidadBuilder.Build(1320, LocalidadCordoba.Salsipuedes),
                datosEntidadBuilder.Build(1321, LocalidadCordoba.Unquillo),
                datosEntidadBuilder.Build(1322, LocalidadCordoba.VillaAllende),
                datosEntidadBuilder.Build(1323, LocalidadCordoba.ColoniaTirolesa),
                datosEntidadBuilder.Build(1324, LocalidadCordoba.ColoniaVicenteAguero),
                datosEntidadBuilder.Build(1325, LocalidadCordoba.ElManzano),
                datosEntidadBuilder.Build(1326, LocalidadCordoba.EstacionGeneralPaz),
                datosEntidadBuilder.Build(1327, LocalidadCordoba.MiGranja),
                datosEntidadBuilder.Build(1328, LocalidadCordoba.Tinoco),
                datosEntidadBuilder.Build(1329, LocalidadCordoba.VillaCerroAzul)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.CruzDelEje).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1330, LocalidadCordoba.CruzDelEje),
                datosEntidadBuilder.Build(1331, LocalidadCordoba.SanMarcosSierras),
                datosEntidadBuilder.Build(1332, LocalidadCordoba.Serrezuela),
                datosEntidadBuilder.Build(1333, LocalidadCordoba.VillaDeSoto),
                datosEntidadBuilder.Build(1334, LocalidadCordoba.ElBrete),
                datosEntidadBuilder.Build(1335, LocalidadCordoba.AltoDeLosQuebrachos),
                datosEntidadBuilder.Build(1336, LocalidadCordoba.BanadoDeSoto),
                datosEntidadBuilder.Build(1337, LocalidadCordoba.CruzDeCana),
                datosEntidadBuilder.Build(1338, LocalidadCordoba.GuanacoMuerto),
                datosEntidadBuilder.Build(1339, LocalidadCordoba.LaBatea),
                datosEntidadBuilder.Build(1340, LocalidadCordoba.LaHiguera),
                datosEntidadBuilder.Build(1341, LocalidadCordoba.LasCanadas),
                datosEntidadBuilder.Build(1342, LocalidadCordoba.LosChanaritos),
                datosEntidadBuilder.Build(1343, LocalidadCordoba.LasPlayas),
                datosEntidadBuilder.Build(1344, LocalidadCordoba.MediaNaranja),
                datosEntidadBuilder.Build(1345, LocalidadCordoba.PasoViejo),
                datosEntidadBuilder.Build(1346, LocalidadCordoba.Tuclame)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.GeneralRoca).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1347, LocalidadCordoba.Buchardo),
                datosEntidadBuilder.Build(1348, LocalidadCordoba.DelCampillo),
                datosEntidadBuilder.Build(1349, LocalidadCordoba.HuincaRenanco),
                datosEntidadBuilder.Build(1350, LocalidadCordoba.Italo),
                datosEntidadBuilder.Build(1351, LocalidadCordoba.Jovita),
                datosEntidadBuilder.Build(1352, LocalidadCordoba.Mattaldi),
                datosEntidadBuilder.Build(1353, LocalidadCordoba.VillaHuidobro),
                datosEntidadBuilder.Build(1354, LocalidadCordoba.VillaSarmiento),
                datosEntidadBuilder.Build(1355, LocalidadCordoba.VillaValeria),
                datosEntidadBuilder.Build(1356, LocalidadCordoba.NicolasBruzzone),
                datosEntidadBuilder.Build(1357, LocalidadCordoba.Onagoity),
                datosEntidadBuilder.Build(1358, LocalidadCordoba.Pincen),
                datosEntidadBuilder.Build(1359, LocalidadCordoba.Ranqueles)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.GeneralSanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1360, LocalidadCordoba.ArroyoAlgodon),
                datosEntidadBuilder.Build(1361, LocalidadCordoba.ArroyoCabral),
                datosEntidadBuilder.Build(1362, LocalidadCordoba.Ausonia),
                datosEntidadBuilder.Build(1363, LocalidadCordoba.Chazon),
                datosEntidadBuilder.Build(1364, LocalidadCordoba.Etruria),
                datosEntidadBuilder.Build(1365, LocalidadCordoba.LaLaguna),
                datosEntidadBuilder.Build(1366, LocalidadCordoba.LaPalestina),
                datosEntidadBuilder.Build(1367, LocalidadCordoba.LaPlayosa),
                datosEntidadBuilder.Build(1368, LocalidadCordoba.Luca),
                datosEntidadBuilder.Build(1369, LocalidadCordoba.Pasco),
                datosEntidadBuilder.Build(1370, LocalidadCordoba.SilvioPellico),
                datosEntidadBuilder.Build(1371, LocalidadCordoba.Ticino),
                datosEntidadBuilder.Build(1372, LocalidadCordoba.TioPujio),
                datosEntidadBuilder.Build(1373, LocalidadCordoba.VillaMaria),
                datosEntidadBuilder.Build(1374, LocalidadCordoba.VillaNueva)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Ischilin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1375, LocalidadCordoba.Avellaneda),
                datosEntidadBuilder.Build(1376, LocalidadCordoba.CanadaDeRioPinto),
                datosEntidadBuilder.Build(1377, LocalidadCordoba.Chuna),
                datosEntidadBuilder.Build(1378, LocalidadCordoba.Copacabana),
                datosEntidadBuilder.Build(1379, LocalidadCordoba.LosPozos),
                datosEntidadBuilder.Build(1380, LocalidadCordoba.OlivaresDeSanNicolas),
                datosEntidadBuilder.Build(1381, LocalidadCordoba.VillaGutierrez)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.JuarezCelman).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1382, LocalidadCordoba.AlejandroRoca),
                datosEntidadBuilder.Build(1383, LocalidadCordoba.Bengolea),
                datosEntidadBuilder.Build(1384, LocalidadCordoba.Carnerillo),
                datosEntidadBuilder.Build(1385, LocalidadCordoba.Charras),
                datosEntidadBuilder.Build(1386, LocalidadCordoba.GeneralCabrera),
                datosEntidadBuilder.Build(1387, LocalidadCordoba.GeneralDeheza),
                datosEntidadBuilder.Build(1388, LocalidadCordoba.Huanchillas),
                datosEntidadBuilder.Build(1389, LocalidadCordoba.LaCarlota),
                datosEntidadBuilder.Build(1390, LocalidadCordoba.LosCisnes),
                datosEntidadBuilder.Build(1391, LocalidadCordoba.Olaeta),
                datosEntidadBuilder.Build(1392, LocalidadCordoba.Reduccion),
                datosEntidadBuilder.Build(1393, LocalidadCordoba.SantaEufemia),
                datosEntidadBuilder.Build(1394, LocalidadCordoba.Ucacha),
                datosEntidadBuilder.Build(1395, LocalidadCordoba.Assunta),
                datosEntidadBuilder.Build(1396, LocalidadCordoba.ElRastreador),
                datosEntidadBuilder.Build(1397, LocalidadCordoba.PachecoDeMelo),
                datosEntidadBuilder.Build(1398, LocalidadCordoba.PasoDelDurazno)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.MarcosJuarez).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1399, LocalidadCordoba.AlejoLedesma),
                datosEntidadBuilder.Build(1400, LocalidadCordoba.Arias),
                datosEntidadBuilder.Build(1401, LocalidadCordoba.CamiloAldao),
                datosEntidadBuilder.Build(1402, LocalidadCordoba.CapitanGeneralBernardoOhiggins),
                datosEntidadBuilder.Build(1403, LocalidadCordoba.Cavanagh),
                datosEntidadBuilder.Build(1404, LocalidadCordoba.ColoniaItaliana),
                datosEntidadBuilder.Build(1405, LocalidadCordoba.CorralDeBustos),
                datosEntidadBuilder.Build(1406, LocalidadCordoba.CruzAlta),
                datosEntidadBuilder.Build(1407, LocalidadCordoba.GeneralBaldissera),
                datosEntidadBuilder.Build(1408, LocalidadCordoba.GeneralRoca),
                datosEntidadBuilder.Build(1409, LocalidadCordoba.Guatimozin),
                datosEntidadBuilder.Build(1410, LocalidadCordoba.Inriville),
                datosEntidadBuilder.Build(1411, LocalidadCordoba.IslaVerde),
                datosEntidadBuilder.Build(1412, LocalidadCordoba.Leones),
                datosEntidadBuilder.Build(1413, LocalidadCordoba.LosSurgentes),
                datosEntidadBuilder.Build(1414, LocalidadCordoba.MarcosJuarez),
                datosEntidadBuilder.Build(1415, LocalidadCordoba.MonteBuey),
                datosEntidadBuilder.Build(1416, LocalidadCordoba.Noetinger),
                datosEntidadBuilder.Build(1417, LocalidadCordoba.Saira),
                datosEntidadBuilder.Build(1418, LocalidadCordoba.ColoniaBarge),
                datosEntidadBuilder.Build(1419, LocalidadCordoba.Saladillo),
                datosEntidadBuilder.Build(1420, LocalidadCordoba.VillaElisa)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Minas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1421, LocalidadCordoba.SanCarlosMinas),
                datosEntidadBuilder.Build(1422, LocalidadCordoba.CienagaDelCoro),
                datosEntidadBuilder.Build(1423, LocalidadCordoba.ElChacho),
                datosEntidadBuilder.Build(1424, LocalidadCordoba.EstanciaDeGuadalupe),
                datosEntidadBuilder.Build(1425, LocalidadCordoba.Guasapampa),
                datosEntidadBuilder.Build(1426, LocalidadCordoba.LaPlaya),
                datosEntidadBuilder.Build(1427, LocalidadCordoba.Talaini),
                datosEntidadBuilder.Build(1428, LocalidadCordoba.Tosno)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Pocho).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1429, LocalidadCordoba.Salsacate),
                datosEntidadBuilder.Build(1430, LocalidadCordoba.Chancani),
                datosEntidadBuilder.Build(1431, LocalidadCordoba.LasPalmas),
                datosEntidadBuilder.Build(1432, LocalidadCordoba.LosTalares),
                datosEntidadBuilder.Build(1433, LocalidadCordoba.SanGeronimo),
                datosEntidadBuilder.Build(1434, LocalidadCordoba.TalaCanada),
                datosEntidadBuilder.Build(1435, LocalidadCordoba.VillaDePocho)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.PresidenteRoqueSaenzPena).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1436, LocalidadCordoba.GeneralLevalle),
                datosEntidadBuilder.Build(1437, LocalidadCordoba.LaCesira),
                datosEntidadBuilder.Build(1438, LocalidadCordoba.Laboulaye),
                datosEntidadBuilder.Build(1439, LocalidadCordoba.Melo),
                datosEntidadBuilder.Build(1440, LocalidadCordoba.Rosales),
                datosEntidadBuilder.Build(1441, LocalidadCordoba.Serrano),
                datosEntidadBuilder.Build(1442, LocalidadCordoba.VillaRossi),
                datosEntidadBuilder.Build(1443, LocalidadCordoba.Leguizamon),
                datosEntidadBuilder.Build(1444, LocalidadCordoba.RioBamba),
                datosEntidadBuilder.Build(1445, LocalidadCordoba.SanJoaquin)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Punilla).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1446, LocalidadCordoba.BialetMasse),
                datosEntidadBuilder.Build(1447, LocalidadCordoba.CapillaDelMonte),
                datosEntidadBuilder.Build(1448, LocalidadCordoba.Cosquin),
                datosEntidadBuilder.Build(1449, LocalidadCordoba.HuertaGrande),
                datosEntidadBuilder.Build(1450, LocalidadCordoba.LaCumbre),
                datosEntidadBuilder.Build(1451, LocalidadCordoba.LaFalda),
                datosEntidadBuilder.Build(1452, LocalidadCordoba.LosCocos),
                datosEntidadBuilder.Build(1453, LocalidadCordoba.SanEsteban),
                datosEntidadBuilder.Build(1454, LocalidadCordoba.SantaMaria),
                datosEntidadBuilder.Build(1455, LocalidadCordoba.Tanti),
                datosEntidadBuilder.Build(1456, LocalidadCordoba.ValleHermoso),
                datosEntidadBuilder.Build(1457, LocalidadCordoba.VillaCarlosPaz),
                datosEntidadBuilder.Build(1458, LocalidadCordoba.VillaGiardino),
                datosEntidadBuilder.Build(1459, LocalidadCordoba.Cabalango),
                datosEntidadBuilder.Build(1460, LocalidadCordoba.CasaGrande),
                datosEntidadBuilder.Build(1461, LocalidadCordoba.Charbonier),
                datosEntidadBuilder.Build(1462, LocalidadCordoba.CuestaBlanca),
                datosEntidadBuilder.Build(1463, LocalidadCordoba.EstanciaVieja),
                datosEntidadBuilder.Build(1464, LocalidadCordoba.MayuSumaj),
                datosEntidadBuilder.Build(1465, LocalidadCordoba.Molinari),
                datosEntidadBuilder.Build(1466, LocalidadCordoba.SanAntonioDeArredondo),
                datosEntidadBuilder.Build(1467, LocalidadCordoba.SanRoque),
                datosEntidadBuilder.Build(1468, LocalidadCordoba.TalaHuasi),
                datosEntidadBuilder.Build(1469, LocalidadCordoba.VillaIchoCruz),
                datosEntidadBuilder.Build(1470, LocalidadCordoba.VillaParqueSiquiman),
                datosEntidadBuilder.Build(1471, LocalidadCordoba.VillaSantaCruzDelLago)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.RioCuarto).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1472, LocalidadCordoba.Achiras),
                datosEntidadBuilder.Build(1473, LocalidadCordoba.AdeliaMaria),
                datosEntidadBuilder.Build(1474, LocalidadCordoba.AlciraGigena),
                datosEntidadBuilder.Build(1475, LocalidadCordoba.AlpaCorral),
                datosEntidadBuilder.Build(1476, LocalidadCordoba.Berrotaran),
                datosEntidadBuilder.Build(1477, LocalidadCordoba.Bulnes),
                datosEntidadBuilder.Build(1478, LocalidadCordoba.Chajan),
                datosEntidadBuilder.Build(1479, LocalidadCordoba.Chucul),
                datosEntidadBuilder.Build(1480, LocalidadCordoba.CoronelBaigorria),
                datosEntidadBuilder.Build(1481, LocalidadCordoba.CoronelMoldes),
                datosEntidadBuilder.Build(1482, LocalidadCordoba.Elena),
                datosEntidadBuilder.Build(1483, LocalidadCordoba.LaCarolina),
                datosEntidadBuilder.Build(1484, LocalidadCordoba.LaCautiva),
                datosEntidadBuilder.Build(1485, LocalidadCordoba.LasAcequias),
                datosEntidadBuilder.Build(1486, LocalidadCordoba.LasAlbahacas),
                datosEntidadBuilder.Build(1487, LocalidadCordoba.LasHigueras),
                datosEntidadBuilder.Build(1488, LocalidadCordoba.LasPenasSud),
                datosEntidadBuilder.Build(1489, LocalidadCordoba.LasVertientes),
                datosEntidadBuilder.Build(1490, LocalidadCordoba.Malena),
                datosEntidadBuilder.Build(1491, LocalidadCordoba.MonteDeLosGauchos),
                datosEntidadBuilder.Build(1492, LocalidadCordoba.RioCuarto),
                datosEntidadBuilder.Build(1493, LocalidadCordoba.Sampacho),
                datosEntidadBuilder.Build(1494, LocalidadCordoba.SanBasilio),
                datosEntidadBuilder.Build(1495, LocalidadCordoba.SantaCatalina),
                datosEntidadBuilder.Build(1496, LocalidadCordoba.Suco),
                datosEntidadBuilder.Build(1497, LocalidadCordoba.Tosquita),
                datosEntidadBuilder.Build(1498, LocalidadCordoba.VicunaMackenna),
                datosEntidadBuilder.Build(1499, LocalidadCordoba.VillaElChacay),
                datosEntidadBuilder.Build(1500, LocalidadCordoba.Washington)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.RioPrimero).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1501, LocalidadCordoba.LaPara),
                datosEntidadBuilder.Build(1502, LocalidadCordoba.LaPuerta),
                datosEntidadBuilder.Build(1503, LocalidadCordoba.MonteCristo),
                datosEntidadBuilder.Build(1504, LocalidadCordoba.ObispoTrejo),
                datosEntidadBuilder.Build(1505, LocalidadCordoba.Piquillin),
                datosEntidadBuilder.Build(1506, LocalidadCordoba.RioPrimero),
                datosEntidadBuilder.Build(1507, LocalidadCordoba.SantaRosaDeRioPrimero),
                datosEntidadBuilder.Build(1508, LocalidadCordoba.VillaFontana),
                datosEntidadBuilder.Build(1509, LocalidadCordoba.Atahona),
                datosEntidadBuilder.Build(1510, LocalidadCordoba.CanadaDeMachado),
                datosEntidadBuilder.Build(1511, LocalidadCordoba.CapillaDeLosRemedios),
                datosEntidadBuilder.Build(1512, LocalidadCordoba.Chalacea),
                datosEntidadBuilder.Build(1513, LocalidadCordoba.ColoniaLasCuatroEsquinas),
                datosEntidadBuilder.Build(1514, LocalidadCordoba.Comechingones),
                datosEntidadBuilder.Build(1515, LocalidadCordoba.DiegoDeRojas),
                datosEntidadBuilder.Build(1516, LocalidadCordoba.ElCrispin),
                datosEntidadBuilder.Build(1517, LocalidadCordoba.Esquina),
                datosEntidadBuilder.Build(1518, LocalidadCordoba.Kilometro658),
                datosEntidadBuilder.Build(1519, LocalidadCordoba.LaPosta),
                datosEntidadBuilder.Build(1520, LocalidadCordoba.LaQuinta),
                datosEntidadBuilder.Build(1521, LocalidadCordoba.LasGramillas),
                datosEntidadBuilder.Build(1522, LocalidadCordoba.LasSaladas),
                datosEntidadBuilder.Build(1523, LocalidadCordoba.MaquinistaGallini),
                datosEntidadBuilder.Build(1524, LocalidadCordoba.PlazaDeMercedes),
                datosEntidadBuilder.Build(1525, LocalidadCordoba.SagradaFamilia)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.RioSeco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1526, LocalidadCordoba.SebastianElcano),
                datosEntidadBuilder.Build(1527, LocalidadCordoba.VillaDeMaria),
                datosEntidadBuilder.Build(1528, LocalidadCordoba.VillaCandelariaNorte),
                datosEntidadBuilder.Build(1529, LocalidadCordoba.CerroColorado),
                datosEntidadBuilder.Build(1530, LocalidadCordoba.ChanarViejo),
                datosEntidadBuilder.Build(1531, LocalidadCordoba.EufrasioLoza),
                datosEntidadBuilder.Build(1532, LocalidadCordoba.Gutemberg),
                datosEntidadBuilder.Build(1533, LocalidadCordoba.LaRinconada),
                datosEntidadBuilder.Build(1534, LocalidadCordoba.LosHoyos),
                datosEntidadBuilder.Build(1535, LocalidadCordoba.PuestoDeCastro),
                datosEntidadBuilder.Build(1536, LocalidadCordoba.RayoCortado),
                datosEntidadBuilder.Build(1537, LocalidadCordoba.SantaElena)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.RioSegundo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1538, LocalidadCordoba.Calchin),
                datosEntidadBuilder.Build(1539, LocalidadCordoba.CalchinOeste),
                datosEntidadBuilder.Build(1540, LocalidadCordoba.CapillaDelCarmen),
                datosEntidadBuilder.Build(1541, LocalidadCordoba.Carrilobo),
                datosEntidadBuilder.Build(1542, LocalidadCordoba.Colazo),
                datosEntidadBuilder.Build(1543, LocalidadCordoba.CostaSacate),
                datosEntidadBuilder.Build(1544, LocalidadCordoba.LagunaLarga),
                datosEntidadBuilder.Build(1545, LocalidadCordoba.LasJunturas),
                datosEntidadBuilder.Build(1546, LocalidadCordoba.Luque),
                datosEntidadBuilder.Build(1547, LocalidadCordoba.Manfredi),
                datosEntidadBuilder.Build(1548, LocalidadCordoba.Matorrales),
                datosEntidadBuilder.Build(1549, LocalidadCordoba.Oncativo),
                datosEntidadBuilder.Build(1550, LocalidadCordoba.Pilar),
                datosEntidadBuilder.Build(1551, LocalidadCordoba.PozoDelMolle),
                datosEntidadBuilder.Build(1552, LocalidadCordoba.RioSegundo),
                datosEntidadBuilder.Build(1553, LocalidadCordoba.SantiagoTemple),
                datosEntidadBuilder.Build(1554, LocalidadCordoba.VillaDelRosario),
                datosEntidadBuilder.Build(1555, LocalidadCordoba.ColoniaVidela),
                datosEntidadBuilder.Build(1556, LocalidadCordoba.Impira),
                datosEntidadBuilder.Build(1557, LocalidadCordoba.LosChanaritos),
                datosEntidadBuilder.Build(1558, LocalidadCordoba.Rincon)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.SanAlberto).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1559, LocalidadCordoba.MinaClavero),
                datosEntidadBuilder.Build(1560, LocalidadCordoba.Nono),
                datosEntidadBuilder.Build(1561, LocalidadCordoba.SanPedro),
                datosEntidadBuilder.Build(1562, LocalidadCordoba.VillaCuraBrochero),
                datosEntidadBuilder.Build(1563, LocalidadCordoba.VillaSarmiento),
                datosEntidadBuilder.Build(1564, LocalidadCordoba.Ambul),
                datosEntidadBuilder.Build(1565, LocalidadCordoba.ArroyoDeLosPatos),
                datosEntidadBuilder.Build(1566, LocalidadCordoba.LasCalles),
                datosEntidadBuilder.Build(1567, LocalidadCordoba.LasRabonas),
                datosEntidadBuilder.Build(1568, LocalidadCordoba.Panaholma),
                datosEntidadBuilder.Build(1569, LocalidadCordoba.SanLorenzo),
                datosEntidadBuilder.Build(1570, LocalidadCordoba.SanVicente),
                datosEntidadBuilder.Build(1571, LocalidadCordoba.SauceArriba)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.SanJavier).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1572, LocalidadCordoba.LaPaz),
                datosEntidadBuilder.Build(1573, LocalidadCordoba.SanJavierYacanto),
                datosEntidadBuilder.Build(1574, LocalidadCordoba.SanJose),
                datosEntidadBuilder.Build(1575, LocalidadCordoba.VillaDeLasRosas),
                datosEntidadBuilder.Build(1576, LocalidadCordoba.VillaDolores),
                datosEntidadBuilder.Build(1577, LocalidadCordoba.Conlara),
                datosEntidadBuilder.Build(1578, LocalidadCordoba.LaPoblacion),
                datosEntidadBuilder.Build(1579, LocalidadCordoba.LasTapias),
                datosEntidadBuilder.Build(1580, LocalidadCordoba.LosCerrillos),
                datosEntidadBuilder.Build(1581, LocalidadCordoba.LosHornillos),
                datosEntidadBuilder.Build(1582, LocalidadCordoba.Luyaba)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.SanJusto).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1583, LocalidadCordoba.Alicia),
                datosEntidadBuilder.Build(1584, LocalidadCordoba.AltosDeChipion),
                datosEntidadBuilder.Build(1585, LocalidadCordoba.Arroyito),
                datosEntidadBuilder.Build(1586, LocalidadCordoba.Balnearia),
                datosEntidadBuilder.Build(1587, LocalidadCordoba.Brinkmann),
                datosEntidadBuilder.Build(1588, LocalidadCordoba.ColoniaMarina),
                datosEntidadBuilder.Build(1589, LocalidadCordoba.ColoniaProsperidad),
                datosEntidadBuilder.Build(1590, LocalidadCordoba.ColoniaSanBartolome),
                datosEntidadBuilder.Build(1591, LocalidadCordoba.ColoniaVignaud),
                datosEntidadBuilder.Build(1592, LocalidadCordoba.Devoto),
                datosEntidadBuilder.Build(1593, LocalidadCordoba.ElAranado),
                datosEntidadBuilder.Build(1594, LocalidadCordoba.ElFortin),
                datosEntidadBuilder.Build(1595, LocalidadCordoba.ElTio),
                datosEntidadBuilder.Build(1596, LocalidadCordoba.Freyre),
                datosEntidadBuilder.Build(1597, LocalidadCordoba.LaFrancia),
                datosEntidadBuilder.Build(1598, LocalidadCordoba.LaPaquita),
                datosEntidadBuilder.Build(1599, LocalidadCordoba.LaTordilla),
                datosEntidadBuilder.Build(1600, LocalidadCordoba.LasVaras),
                datosEntidadBuilder.Build(1601, LocalidadCordoba.LasVarillas),
                datosEntidadBuilder.Build(1602, LocalidadCordoba.Marull),
                datosEntidadBuilder.Build(1603, LocalidadCordoba.Miramar),
                datosEntidadBuilder.Build(1604, LocalidadCordoba.Morteros),
                datosEntidadBuilder.Build(1605, LocalidadCordoba.Portena),
                datosEntidadBuilder.Build(1606, LocalidadCordoba.QuebrachoHerrado),
                datosEntidadBuilder.Build(1607, LocalidadCordoba.Sacanta),
                datosEntidadBuilder.Build(1608, LocalidadCordoba.SanFrancisco),
                datosEntidadBuilder.Build(1609, LocalidadCordoba.SaturninoMariaLaspiur),
                datosEntidadBuilder.Build(1610, LocalidadCordoba.Seeber),
                datosEntidadBuilder.Build(1611, LocalidadCordoba.Transito),
                datosEntidadBuilder.Build(1612, LocalidadCordoba.VillaConcepcionDelTio),
                datosEntidadBuilder.Build(1613, LocalidadCordoba.ColoniaAnita),
                datosEntidadBuilder.Build(1614, LocalidadCordoba.ColoniaIturraspe),
                datosEntidadBuilder.Build(1615, LocalidadCordoba.ColoniaLasPichanas),
                datosEntidadBuilder.Build(1616, LocalidadCordoba.ColoniaSanPedro),
                datosEntidadBuilder.Build(1617, LocalidadCordoba.ColoniaValtelina),
                datosEntidadBuilder.Build(1618, LocalidadCordoba.PlazaLuxardo),
                datosEntidadBuilder.Build(1619, LocalidadCordoba.VillaSanEsteban),
                datosEntidadBuilder.Build(1620, LocalidadCordoba.ToroPujio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.SantaMaria).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1621, LocalidadCordoba.AltaGracia),
                datosEntidadBuilder.Build(1622, LocalidadCordoba.Despenaderos),
                datosEntidadBuilder.Build(1623, LocalidadCordoba.Lozada),
                datosEntidadBuilder.Build(1624, LocalidadCordoba.Malagueno),
                datosEntidadBuilder.Build(1625, LocalidadCordoba.MonteRalo),
                datosEntidadBuilder.Build(1626, LocalidadCordoba.Toledo),
                datosEntidadBuilder.Build(1627, LocalidadCordoba.Anisacate),
                datosEntidadBuilder.Build(1628, LocalidadCordoba.Bouwer),
                datosEntidadBuilder.Build(1629, LocalidadCordoba.DiqueChico),
                datosEntidadBuilder.Build(1630, LocalidadCordoba.FaldaDelCarmen),
                datosEntidadBuilder.Build(1631, LocalidadCordoba.LaPaisanita),
                datosEntidadBuilder.Build(1632, LocalidadCordoba.LaRancherita),
                datosEntidadBuilder.Build(1633, LocalidadCordoba.LaSerranita),
                datosEntidadBuilder.Build(1634, LocalidadCordoba.LosCedros),
                datosEntidadBuilder.Build(1635, LocalidadCordoba.PotreroDeGaray),
                datosEntidadBuilder.Build(1636, LocalidadCordoba.RafaelGarcia),
                datosEntidadBuilder.Build(1637, LocalidadCordoba.SanClemente),
                datosEntidadBuilder.Build(1638, LocalidadCordoba.ValleDeAnisacate),
                datosEntidadBuilder.Build(1639, LocalidadCordoba.VillaCiudadDeAmerica),
                datosEntidadBuilder.Build(1640, LocalidadCordoba.VillaDelPrado),
                datosEntidadBuilder.Build(1641, LocalidadCordoba.VillaLaBolsa),
                datosEntidadBuilder.Build(1642, LocalidadCordoba.VillaLosAromos),
                datosEntidadBuilder.Build(1643, LocalidadCordoba.VillaParqueSantaAna),
                datosEntidadBuilder.Build(1644, LocalidadCordoba.VillaSanIsidro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Sobremonte).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1645, LocalidadCordoba.AguadaDelMonte),
                datosEntidadBuilder.Build(1646, LocalidadCordoba.Caminiana),
                datosEntidadBuilder.Build(1647, LocalidadCordoba.Cerrillos),
                datosEntidadBuilder.Build(1648, LocalidadCordoba.ChunaHuasi),
                datosEntidadBuilder.Build(1649, LocalidadCordoba.SanFrancisco),
                datosEntidadBuilder.Build(1650, LocalidadCordoba.SanFranciscoDelChanar),
                datosEntidadBuilder.Build(1651, LocalidadCordoba.Caminiaga),
                datosEntidadBuilder.Build(1652, LocalidadCordoba.ChunaHuasi),
                datosEntidadBuilder.Build(1653, LocalidadCordoba.PozoNuevo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.TerceroArriba).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1654, LocalidadCordoba.Almafuerte),
                datosEntidadBuilder.Build(1655, LocalidadCordoba.Corralito),
                datosEntidadBuilder.Build(1656, LocalidadCordoba.DalmacioVelezSarsfield),
                datosEntidadBuilder.Build(1657, LocalidadCordoba.Hernando),
                datosEntidadBuilder.Build(1658, LocalidadCordoba.JamesCraik),
                datosEntidadBuilder.Build(1659, LocalidadCordoba.LasPerdices),
                datosEntidadBuilder.Build(1660, LocalidadCordoba.LosZorros),
                datosEntidadBuilder.Build(1661, LocalidadCordoba.Oliva),
                datosEntidadBuilder.Build(1662, LocalidadCordoba.PampayastaSud),
                datosEntidadBuilder.Build(1663, LocalidadCordoba.PuntaDelAgua),
                datosEntidadBuilder.Build(1664, LocalidadCordoba.RioTercero),
                datosEntidadBuilder.Build(1665, LocalidadCordoba.Tancacha),
                datosEntidadBuilder.Build(1666, LocalidadCordoba.VillaAscasubi),
                datosEntidadBuilder.Build(1667, LocalidadCordoba.ColoniaAlmadaGeneralFotheringham),
                datosEntidadBuilder.Build(1668, LocalidadCordoba.LasIsletillas),
                datosEntidadBuilder.Build(1669, LocalidadCordoba.PampayastaNorte)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Totoral).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1670, LocalidadCordoba.Candelaria),
                datosEntidadBuilder.Build(1671, LocalidadCordoba.Macha),
                datosEntidadBuilder.Build(1672, LocalidadCordoba.RioPinto),
                datosEntidadBuilder.Build(1673, LocalidadCordoba.Sinsacate),
                datosEntidadBuilder.Build(1674, LocalidadCordoba.Totoral),
                datosEntidadBuilder.Build(1675, LocalidadCordoba.CanadaDeLuque),
                datosEntidadBuilder.Build(1676, LocalidadCordoba.Sarmiento),
                datosEntidadBuilder.Build(1677, LocalidadCordoba.Sinsacate),
                datosEntidadBuilder.Build(1678, LocalidadCordoba.VillaDelTotoral),
                datosEntidadBuilder.Build(1679, LocalidadCordoba.CandelariaSud),
                datosEntidadBuilder.Build(1680, LocalidadCordoba.CapillaDeSiton),
                datosEntidadBuilder.Build(1681, LocalidadCordoba.LaPampa),
                datosEntidadBuilder.Build(1682, LocalidadCordoba.LasPenas),
                datosEntidadBuilder.Build(1683, LocalidadCordoba.LosMistoles),
                datosEntidadBuilder.Build(1684, LocalidadCordoba.Simbolar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Tulumba).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1685, LocalidadCordoba.Dormida),
                datosEntidadBuilder.Build(1686, LocalidadCordoba.Intihuasi),
                datosEntidadBuilder.Build(1687, LocalidadCordoba.Mercedes),
                datosEntidadBuilder.Build(1688, LocalidadCordoba.Parroquia),
                datosEntidadBuilder.Build(1689, LocalidadCordoba.SanPedroNorte),
                datosEntidadBuilder.Build(1690, LocalidadCordoba.LasArrias),
                datosEntidadBuilder.Build(1691, LocalidadCordoba.LucioVMansilla),
                datosEntidadBuilder.Build(1692, LocalidadCordoba.SanJoseDeLaDormida),
                datosEntidadBuilder.Build(1693, LocalidadCordoba.SanJoseDeLasSalinas),
                datosEntidadBuilder.Build(1694, LocalidadCordoba.SanPedroNorte),
                datosEntidadBuilder.Build(1695, LocalidadCordoba.VillaTulumba),
                datosEntidadBuilder.Build(1696, LocalidadCordoba.ChurquiCanada),
                datosEntidadBuilder.Build(1697, LocalidadCordoba.ElRodeo),
                datosEntidadBuilder.Build(1698, LocalidadCordoba.RosarioDelSaladillo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Union).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1699, LocalidadCordoba.AltoAlegre),
                datosEntidadBuilder.Build(1700, LocalidadCordoba.Ballesteros),
                datosEntidadBuilder.Build(1701, LocalidadCordoba.BallesterosSud),
                datosEntidadBuilder.Build(1702, LocalidadCordoba.BellVille),
                datosEntidadBuilder.Build(1703, LocalidadCordoba.Gould),
                datosEntidadBuilder.Build(1704, LocalidadCordoba.Canals),
                datosEntidadBuilder.Build(1705, LocalidadCordoba.Chilibroste),
                datosEntidadBuilder.Build(1706, LocalidadCordoba.Cintra),
                datosEntidadBuilder.Build(1707, LocalidadCordoba.ColoniaBismarck),
                datosEntidadBuilder.Build(1708, LocalidadCordoba.Idiazabal),
                datosEntidadBuilder.Build(1709, LocalidadCordoba.JustinianoPosse),
                datosEntidadBuilder.Build(1710, LocalidadCordoba.Laborde),
                datosEntidadBuilder.Build(1711, LocalidadCordoba.MonteLena),
                datosEntidadBuilder.Build(1712, LocalidadCordoba.MonteMaiz),
                datosEntidadBuilder.Build(1713, LocalidadCordoba.Morrison),
                datosEntidadBuilder.Build(1714, LocalidadCordoba.Noetinger),
                datosEntidadBuilder.Build(1715, LocalidadCordoba.Ordonez),
                datosEntidadBuilder.Build(1716, LocalidadCordoba.Pascanas),
                datosEntidadBuilder.Build(1717, LocalidadCordoba.PuebloItaliano),
                datosEntidadBuilder.Build(1718, LocalidadCordoba.SanAntonioDeLitin),
                datosEntidadBuilder.Build(1719, LocalidadCordoba.SanMarcosSud),
                datosEntidadBuilder.Build(1720, LocalidadCordoba.Viamonte),
                datosEntidadBuilder.Build(1721, LocalidadCordoba.WenceslaoEscalante),
                datosEntidadBuilder.Build(1722, LocalidadCordoba.AldeaSantaMaria),
                datosEntidadBuilder.Build(1723, LocalidadCordoba.AnaZumaran),
                datosEntidadBuilder.Build(1724, LocalidadCordoba.ColoniaBremen),
                datosEntidadBuilder.Build(1725, LocalidadCordoba.VillaLosPatos)
            });
        }
    }
}
