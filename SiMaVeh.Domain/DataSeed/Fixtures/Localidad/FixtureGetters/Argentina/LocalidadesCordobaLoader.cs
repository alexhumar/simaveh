using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesCordobaLoader : LocalidadFixtureGetter
    {
        public LocalidadesCordobaLoader(IPartidoFixtureGetter partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Calamuchita).Key, new Dictionary<long, string>
            {
                { 1285, LocalidadCordoba.Embalse },
                { 1286, LocalidadCordoba.LaCruz },
                { 1287, LocalidadCordoba.LosCondores },
                { 1288, LocalidadCordoba.LosMolinos },
                { 1289, LocalidadCordoba.LosReartes },
                { 1290, LocalidadCordoba.RioDeLosSauces },
                { 1291, LocalidadCordoba.SanAgustin },
                { 1292, LocalidadCordoba.SantaRosaDeCalamuchita },
                { 1293, LocalidadCordoba.VillaDelDique },
                { 1294, LocalidadCordoba.VillaGeneralBelgrano },
                { 1295, LocalidadCordoba.VillaRumipal },
                { 1296, LocalidadCordoba.VillaYacanto },
                { 1297, LocalidadCordoba.Amboy },
                { 1298, LocalidadCordoba.Calmayo },
                { 1299, LocalidadCordoba.CanadaDelSauce },
                { 1300, LocalidadCordoba.LaCumbrecita },
                { 1301, LocalidadCordoba.LasBajadas },
                { 1302, LocalidadCordoba.LasCaleras },
                { 1303, LocalidadCordoba.Lutti },
                { 1304, LocalidadCordoba.SanIgnacio },
                { 1305, LocalidadCordoba.SegundaUsina },
                { 1306, LocalidadCordoba.VillaAmancay },
                { 1307, LocalidadCordoba.VillaCiudadParqueLosReartes },
                { 1308, LocalidadCordoba.VillaQuillinzo }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Capital).Key, new Dictionary<long, string>
            {
                { 1309, LocalidadCordoba.Cordoba }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Colon).Key, new Dictionary<long, string>
            {
                { 1310, LocalidadCordoba.AguaDeOro },
                { 1311, LocalidadCordoba.ColoniaCaroya },
                { 1312, LocalidadCordoba.EstacionJuarezCelman },
                { 1313, LocalidadCordoba.JesusMaria },
                { 1314, LocalidadCordoba.LaCalera },
                { 1315, LocalidadCordoba.LaGranja },
                { 1316, LocalidadCordoba.MalvinasArgentinas },
                { 1317, LocalidadCordoba.Mendiolaza },
                { 1318, LocalidadCordoba.RioCeballos },
                { 1319, LocalidadCordoba.Saldan },
                { 1320, LocalidadCordoba.Salsipuedes },
                { 1321, LocalidadCordoba.Unquillo },
                { 1322, LocalidadCordoba.VillaAllende },
                { 1323, LocalidadCordoba.ColoniaTirolesa },
                { 1324, LocalidadCordoba.ColoniaVicenteAguero },
                { 1325, LocalidadCordoba.ElManzano },
                { 1326, LocalidadCordoba.EstacionGeneralPaz },
                { 1327, LocalidadCordoba.MiGranja },
                { 1328, LocalidadCordoba.Tinoco },
                { 1329, LocalidadCordoba.VillaCerroAzul }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.CruzDelEje).Key, new Dictionary<long, string>
            {
                { 1330, LocalidadCordoba.CruzDelEje },
                { 1331, LocalidadCordoba.SanMarcosSierras },
                { 1332, LocalidadCordoba.Serrezuela },
                { 1333, LocalidadCordoba.VillaDeSoto },
                { 1334, LocalidadCordoba.ElBrete },
                { 1335, LocalidadCordoba.AltoDeLosQuebrachos },
                { 1336, LocalidadCordoba.BanadoDeSoto },
                { 1337, LocalidadCordoba.CruzDeCana },
                { 1338, LocalidadCordoba.GuanacoMuerto },
                { 1339, LocalidadCordoba.LaBatea },
                { 1340, LocalidadCordoba.LaHiguera },
                { 1341, LocalidadCordoba.LasCanadas },
                { 1342, LocalidadCordoba.LosChanaritos },
                { 1343, LocalidadCordoba.LasPlayas },
                { 1344, LocalidadCordoba.MediaNaranja },
                { 1345, LocalidadCordoba.PasoViejo },
                { 1346, LocalidadCordoba.Tuclame }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.GeneralRoca).Key, new Dictionary<long, string>
            {
                { 1347, LocalidadCordoba.Buchardo },
                { 1348, LocalidadCordoba.DelCampillo },
                { 1349, LocalidadCordoba.HuincaRenanco },
                { 1350, LocalidadCordoba.Italo },
                { 1351, LocalidadCordoba.Jovita },
                { 1352, LocalidadCordoba.Mattaldi },
                { 1353, LocalidadCordoba.VillaHuidobro },
                { 1354, LocalidadCordoba.VillaSarmiento },
                { 1355, LocalidadCordoba.VillaValeria },
                { 1356, LocalidadCordoba.NicolasBruzzone },
                { 1357, LocalidadCordoba.Onagoity },
                { 1358, LocalidadCordoba.Pincen },
                { 1359, LocalidadCordoba.Ranqueles }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.GeneralSanMartin).Key, new Dictionary<long, string>
            {
                { 1360, LocalidadCordoba.ArroyoAlgodon },
                { 1361, LocalidadCordoba.ArroyoCabral },
                { 1362, LocalidadCordoba.Ausonia },
                { 1363, LocalidadCordoba.Chazon },
                { 1364, LocalidadCordoba.Etruria },
                { 1365, LocalidadCordoba.LaLaguna },
                { 1366, LocalidadCordoba.LaPalestina },
                { 1367, LocalidadCordoba.LaPlayosa },
                { 1368, LocalidadCordoba.Luca },
                { 1369, LocalidadCordoba.Pasco },
                { 1370, LocalidadCordoba.SilvioPellico },
                { 1371, LocalidadCordoba.Ticino },
                { 1372, LocalidadCordoba.TioPujio },
                { 1373, LocalidadCordoba.VillaMaria },
                { 1374, LocalidadCordoba.VillaNueva }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Ischilin).Key, new Dictionary<long, string>
            {
                { 1375, LocalidadCordoba.Avellaneda },
                { 1376, LocalidadCordoba.CanadaDeRioPinto },
                { 1377, LocalidadCordoba.Chuna },
                { 1378, LocalidadCordoba.Copacabana },
                { 1379, LocalidadCordoba.LosPozos },
                { 1380, LocalidadCordoba.OlivaresDeSanNicolas },
                { 1381, LocalidadCordoba.VillaGutierrez }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.JuarezCelman).Key, new Dictionary<long, string>
            {
                { 1382, LocalidadCordoba.AlejandroRoca },
                { 1383, LocalidadCordoba.Bengolea },
                { 1384, LocalidadCordoba.Carnerillo },
                { 1385, LocalidadCordoba.Charras },
                { 1386, LocalidadCordoba.GeneralCabrera },
                { 1387, LocalidadCordoba.GeneralDeheza },
                { 1388, LocalidadCordoba.Huanchillas },
                { 1389, LocalidadCordoba.LaCarlota },
                { 1390, LocalidadCordoba.LosCisnes },
                { 1391, LocalidadCordoba.Olaeta },
                { 1392, LocalidadCordoba.Reduccion },
                { 1393, LocalidadCordoba.SantaEufemia },
                { 1394, LocalidadCordoba.Ucacha },
                { 1395, LocalidadCordoba.Assunta },
                { 1396, LocalidadCordoba.ElRastreador },
                { 1397, LocalidadCordoba.PachecoDeMelo },
                { 1398, LocalidadCordoba.PasoDelDurazno }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.MarcosJuarez).Key, new Dictionary<long, string>
            {
                { 1399, LocalidadCordoba.AlejoLedesma },
                { 1400, LocalidadCordoba.Arias },
                { 1401, LocalidadCordoba.CamiloAldao },
                { 1402, LocalidadCordoba.CapitanGeneralBernardoOhiggins },
                { 1403, LocalidadCordoba.Cavanagh },
                { 1404, LocalidadCordoba.ColoniaItaliana },
                { 1405, LocalidadCordoba.CorralDeBustos },
                { 1406, LocalidadCordoba.CruzAlta },
                { 1407, LocalidadCordoba.GeneralBaldissera },
                { 1408, LocalidadCordoba.GeneralRoca },
                { 1409, LocalidadCordoba.Guatimozin },
                { 1410, LocalidadCordoba.Inriville },
                { 1411, LocalidadCordoba.IslaVerde },
                { 1412, LocalidadCordoba.Leones },
                { 1413, LocalidadCordoba.LosSurgentes },
                { 1414, LocalidadCordoba.MarcosJuarez },
                { 1415, LocalidadCordoba.MonteBuey },
                { 1416, LocalidadCordoba.Noetinger },
                { 1417, LocalidadCordoba.Saira },
                { 1418, LocalidadCordoba.ColoniaBarge },
                { 1419, LocalidadCordoba.Saladillo },
                { 1420, LocalidadCordoba.VillaElisa }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Minas).Key, new Dictionary<long, string>
            {
                { 1421, LocalidadCordoba.SanCarlosMinas },
                { 1422, LocalidadCordoba.CienagaDelCoro },
                { 1423, LocalidadCordoba.ElChacho },
                { 1424, LocalidadCordoba.EstanciaDeGuadalupe },
                { 1425, LocalidadCordoba.Guasapampa },
                { 1426, LocalidadCordoba.LaPlaya },
                { 1427, LocalidadCordoba.Talaini },
                { 1428, LocalidadCordoba.Tosno }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Pocho).Key, new Dictionary<long, string>
            {
                { 1429, LocalidadCordoba.Salsacate },
                { 1430, LocalidadCordoba.Chancani },
                { 1431, LocalidadCordoba.LasPalmas },
                { 1432, LocalidadCordoba.LosTalares },
                { 1433, LocalidadCordoba.SanGeronimo },
                { 1434, LocalidadCordoba.TalaCanada },
                { 1435, LocalidadCordoba.VillaDePocho }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.PresidenteRoqueSaenzPena).Key, new Dictionary<long, string>
            {
                { 1436, LocalidadCordoba.GeneralLevalle },
                { 1437, LocalidadCordoba.LaCesira },
                { 1438, LocalidadCordoba.Laboulaye },
                { 1439, LocalidadCordoba.Melo },
                { 1440, LocalidadCordoba.Rosales },
                { 1441, LocalidadCordoba.Serrano },
                { 1442, LocalidadCordoba.VillaRossi },
                { 1443, LocalidadCordoba.Leguizamon },
                { 1444, LocalidadCordoba.RioBamba },
                { 1445, LocalidadCordoba.SanJoaquin }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Punilla).Key, new Dictionary<long, string>
            {
                { 1446, LocalidadCordoba.BialetMasse },
                { 1447, LocalidadCordoba.CapillaDelMonte },
                { 1448, LocalidadCordoba.Cosquin },
                { 1449, LocalidadCordoba.HuertaGrande },
                { 1450, LocalidadCordoba.LaCumbre },
                { 1451, LocalidadCordoba.LaFalda },
                { 1452, LocalidadCordoba.LosCocos },
                { 1453, LocalidadCordoba.SanEsteban },
                { 1454, LocalidadCordoba.SantaMaria },
                { 1455, LocalidadCordoba.Tanti },
                { 1456, LocalidadCordoba.ValleHermoso },
                { 1457, LocalidadCordoba.VillaCarlosPaz },
                { 1458, LocalidadCordoba.VillaGiardino },
                { 1459, LocalidadCordoba.Cabalango },
                { 1460, LocalidadCordoba.CasaGrande },
                { 1461, LocalidadCordoba.Charbonier },
                { 1462, LocalidadCordoba.CuestaBlanca },
                { 1463, LocalidadCordoba.EstanciaVieja },
                { 1464, LocalidadCordoba.MayuSumaj },
                { 1465, LocalidadCordoba.Molinari },
                { 1466, LocalidadCordoba.SanAntonioDeArredondo },
                { 1467, LocalidadCordoba.SanRoque },
                { 1468, LocalidadCordoba.TalaHuasi },
                { 1469, LocalidadCordoba.VillaIchoCruz },
                { 1470, LocalidadCordoba.VillaParqueSiquiman },
                { 1471, LocalidadCordoba.VillaSantaCruzDelLago }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.RioCuarto).Key, new Dictionary<long, string>
            {
                { 1472, LocalidadCordoba.Achiras },
                { 1473, LocalidadCordoba.AdeliaMaria },
                { 1474, LocalidadCordoba.AlciraGigena },
                { 1475, LocalidadCordoba.AlpaCorral },
                { 1476, LocalidadCordoba.Berrotaran },
                { 1477, LocalidadCordoba.Bulnes },
                { 1478, LocalidadCordoba.Chajan },
                { 1479, LocalidadCordoba.Chucul },
                { 1480, LocalidadCordoba.CoronelBaigorria },
                { 1481, LocalidadCordoba.CoronelMoldes },
                { 1482, LocalidadCordoba.Elena },
                { 1483, LocalidadCordoba.LaCarolina },
                { 1484, LocalidadCordoba.LaCautiva },
                { 1485, LocalidadCordoba.LasAcequias },
                { 1486, LocalidadCordoba.LasAlbahacas },
                { 1487, LocalidadCordoba.LasHigueras },
                { 1488, LocalidadCordoba.LasPenasSud },
                { 1489, LocalidadCordoba.LasVertientes },
                { 1490, LocalidadCordoba.Malena },
                { 1491, LocalidadCordoba.MonteDeLosGauchos },
                { 1492, LocalidadCordoba.RioCuarto },
                { 1493, LocalidadCordoba.Sampacho },
                { 1494, LocalidadCordoba.SanBasilio },
                { 1495, LocalidadCordoba.SantaCatalina },
                { 1496, LocalidadCordoba.Suco },
                { 1497, LocalidadCordoba.Tosquita },
                { 1498, LocalidadCordoba.VicunaMackenna },
                { 1499, LocalidadCordoba.VillaElChacay },
                { 1500, LocalidadCordoba.Washington }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.RioPrimero).Key, new Dictionary<long, string>
            {
                { 1501, LocalidadCordoba.LaPara },
                { 1502, LocalidadCordoba.LaPuerta },
                { 1503, LocalidadCordoba.MonteCristo },
                { 1504, LocalidadCordoba.ObispoTrejo },
                { 1505, LocalidadCordoba.Piquillin },
                { 1506, LocalidadCordoba.RioPrimero },
                { 1507, LocalidadCordoba.SantaRosaDeRioPrimero },
                { 1508, LocalidadCordoba.VillaFontana },
                { 1509, LocalidadCordoba.Atahona },
                { 1510, LocalidadCordoba.CanadaDeMachado },
                { 1511, LocalidadCordoba.CapillaDeLosRemedios },
                { 1512, LocalidadCordoba.Chalacea },
                { 1513, LocalidadCordoba.ColoniaLasCuatroEsquinas },
                { 1514, LocalidadCordoba.Comechingones },
                { 1515, LocalidadCordoba.DiegoDeRojas },
                { 1516, LocalidadCordoba.ElCrispin },
                { 1517, LocalidadCordoba.Esquina },
                { 1518, LocalidadCordoba.Kilometro658 },
                { 1519, LocalidadCordoba.LaPosta },
                { 1520, LocalidadCordoba.LaQuinta },
                { 1521, LocalidadCordoba.LasGramillas },
                { 1522, LocalidadCordoba.LasSaladas },
                { 1523, LocalidadCordoba.MaquinistaGallini },
                { 1524, LocalidadCordoba.PlazaDeMercedes },
                { 1525, LocalidadCordoba.SagradaFamilia }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.RioSeco).Key, new Dictionary<long, string>
            {
                { 1526, LocalidadCordoba.SebastianElcano },
                { 1527, LocalidadCordoba.VillaDeMaria },
                { 1528, LocalidadCordoba.VillaCandelariaNorte },
                { 1529, LocalidadCordoba.CerroColorado },
                { 1530, LocalidadCordoba.ChanarViejo },
                { 1531, LocalidadCordoba.EufrasioLoza },
                { 1532, LocalidadCordoba.Gutemberg },
                { 1533, LocalidadCordoba.LaRinconada },
                { 1534, LocalidadCordoba.LosHoyos },
                { 1535, LocalidadCordoba.PuestoDeCastro },
                { 1536, LocalidadCordoba.RayoCortado },
                { 1537, LocalidadCordoba.SantaElena }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.RioSegundo).Key, new Dictionary<long, string>
            {
                { 1538, LocalidadCordoba.Calchin },
                { 1539, LocalidadCordoba.CalchinOeste },
                { 1540, LocalidadCordoba.CapillaDelCarmen },
                { 1541, LocalidadCordoba.Carrilobo },
                { 1542, LocalidadCordoba.Colazo },
                { 1543, LocalidadCordoba.CostaSacate },
                { 1544, LocalidadCordoba.LagunaLarga },
                { 1545, LocalidadCordoba.LasJunturas },
                { 1546, LocalidadCordoba.Luque },
                { 1547, LocalidadCordoba.Manfredi },
                { 1548, LocalidadCordoba.Matorrales },
                { 1549, LocalidadCordoba.Oncativo },
                { 1550, LocalidadCordoba.Pilar },
                { 1551, LocalidadCordoba.PozoDelMolle },
                { 1552, LocalidadCordoba.RioSegundo },
                { 1553, LocalidadCordoba.SantiagoTemple },
                { 1554, LocalidadCordoba.VillaDelRosario },
                { 1555, LocalidadCordoba.ColoniaVidela },
                { 1556, LocalidadCordoba.Impira },
                { 1557, LocalidadCordoba.LosChanaritos },
                { 1558, LocalidadCordoba.Rincon }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.SanAlberto).Key, new Dictionary<long, string>
            {
                { 1559, LocalidadCordoba.MinaClavero },
                { 1560, LocalidadCordoba.Nono },
                { 1561, LocalidadCordoba.SanPedro },
                { 1562, LocalidadCordoba.VillaCuraBrochero },
                { 1563, LocalidadCordoba.VillaSarmiento },
                { 1564, LocalidadCordoba.Ambul },
                { 1565, LocalidadCordoba.ArroyoDeLosPatos },
                { 1566, LocalidadCordoba.LasCalles },
                { 1567, LocalidadCordoba.LasRabonas },
                { 1568, LocalidadCordoba.Panaholma },
                { 1569, LocalidadCordoba.SanLorenzo },
                { 1570, LocalidadCordoba.SanVicente },
                { 1571, LocalidadCordoba.SauceArriba }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.SanJavier).Key, new Dictionary<long, string>
            {
                { 1572, LocalidadCordoba.LaPaz },
                { 1573, LocalidadCordoba.SanJavierYacanto },
                { 1574, LocalidadCordoba.SanJose },
                { 1575, LocalidadCordoba.VillaDeLasRosas },
                { 1576, LocalidadCordoba.VillaDolores },
                { 1577, LocalidadCordoba.Conlara },
                { 1578, LocalidadCordoba.LaPoblacion },
                { 1579, LocalidadCordoba.LasTapias },
                { 1580, LocalidadCordoba.LosCerrillos },
                { 1581, LocalidadCordoba.LosHornillos },
                { 1582, LocalidadCordoba.Luyaba }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.SanJusto).Key, new Dictionary<long, string>
            {
                { 1583, LocalidadCordoba.Alicia },
                { 1584, LocalidadCordoba.AltosDeChipion },
                { 1585, LocalidadCordoba.Arroyito },
                { 1586, LocalidadCordoba.Balnearia },
                { 1587, LocalidadCordoba.Brinkmann },
                { 1588, LocalidadCordoba.ColoniaMarina },
                { 1589, LocalidadCordoba.ColoniaProsperidad },
                { 1590, LocalidadCordoba.ColoniaSanBartolome },
                { 1591, LocalidadCordoba.ColoniaVignaud },
                { 1592, LocalidadCordoba.Devoto },
                { 1593, LocalidadCordoba.ElAranado },
                { 1594, LocalidadCordoba.ElFortin },
                { 1595, LocalidadCordoba.ElTio },
                { 1596, LocalidadCordoba.Freyre },
                { 1597, LocalidadCordoba.LaFrancia },
                { 1598, LocalidadCordoba.LaPaquita },
                { 1599, LocalidadCordoba.LaTordilla },
                { 1600, LocalidadCordoba.LasVaras },
                { 1601, LocalidadCordoba.LasVarillas },
                { 1602, LocalidadCordoba.Marull },
                { 1603, LocalidadCordoba.Miramar },
                { 1604, LocalidadCordoba.Morteros },
                { 1605, LocalidadCordoba.Portena },
                { 1606, LocalidadCordoba.QuebrachoHerrado },
                { 1607, LocalidadCordoba.Sacanta },
                { 1608, LocalidadCordoba.SanFrancisco },
                { 1609, LocalidadCordoba.SaturninoMariaLaspiur },
                { 1610, LocalidadCordoba.Seeber },
                { 1611, LocalidadCordoba.Transito },
                { 1612, LocalidadCordoba.VillaConcepcionDelTio },
                { 1613, LocalidadCordoba.ColoniaAnita },
                { 1614, LocalidadCordoba.ColoniaIturraspe },
                { 1615, LocalidadCordoba.ColoniaLasPichanas },
                { 1616, LocalidadCordoba.ColoniaSanPedro },
                { 1617, LocalidadCordoba.ColoniaValtelina },
                { 1618, LocalidadCordoba.PlazaLuxardo },
                { 1619, LocalidadCordoba.VillaSanEsteban },
                { 1620, LocalidadCordoba.ToroPujio }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.SantaMaria).Key, new Dictionary<long, string>
            {
                { 1621, LocalidadCordoba.AltaGracia },
                { 1622, LocalidadCordoba.Despenaderos },
                { 1623, LocalidadCordoba.Lozada },
                { 1624, LocalidadCordoba.Malagueno },
                { 1625, LocalidadCordoba.MonteRalo },
                { 1626, LocalidadCordoba.Toledo },
                { 1627, LocalidadCordoba.Anisacate },
                { 1628, LocalidadCordoba.Bouwer },
                { 1629, LocalidadCordoba.DiqueChico },
                { 1630, LocalidadCordoba.FaldaDelCarmen },
                { 1631, LocalidadCordoba.LaPaisanita },
                { 1632, LocalidadCordoba.LaRancherita },
                { 1633, LocalidadCordoba.LaSerranita },
                { 1634, LocalidadCordoba.LosCedros },
                { 1635, LocalidadCordoba.PotreroDeGaray },
                { 1636, LocalidadCordoba.RafaelGarcia },
                { 1637, LocalidadCordoba.SanClemente },
                { 1638, LocalidadCordoba.ValleDeAnisacate },
                { 1639, LocalidadCordoba.VillaCiudadDeAmerica },
                { 1640, LocalidadCordoba.VillaDelPrado },
                { 1641, LocalidadCordoba.VillaLaBolsa },
                { 1642, LocalidadCordoba.VillaLosAromos },
                { 1643, LocalidadCordoba.VillaParqueSantaAna },
                { 1644, LocalidadCordoba.VillaSanIsidro }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Sobremonte).Key, new Dictionary<long, string>
            {
                { 1645, LocalidadCordoba.AguadaDelMonte },
                { 1646, LocalidadCordoba.Caminiana },
                { 1647, LocalidadCordoba.Cerrillos },
                { 1648, LocalidadCordoba.ChunaHuasi },
                { 1649, LocalidadCordoba.SanFrancisco },
                { 1650, LocalidadCordoba.SanFranciscoDelChanar },
                { 1651, LocalidadCordoba.Caminiaga },
                { 1652, LocalidadCordoba.ChunaHuasi },
                { 1653, LocalidadCordoba.PozoNuevo }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.TerceroArriba).Key, new Dictionary<long, string>
            {
                { 1654, LocalidadCordoba.Almafuerte },
                { 1655, LocalidadCordoba.Corralito },
                { 1656, LocalidadCordoba.DalmacioVelezSarsfield },
                { 1657, LocalidadCordoba.Hernando },
                { 1658, LocalidadCordoba.JamesCraik },
                { 1659, LocalidadCordoba.LasPerdices },
                { 1660, LocalidadCordoba.LosZorros },
                { 1661, LocalidadCordoba.Oliva },
                { 1662, LocalidadCordoba.PampayastaSud },
                { 1663, LocalidadCordoba.PuntaDelAgua },
                { 1664, LocalidadCordoba.RioTercero },
                { 1665, LocalidadCordoba.Tancacha },
                { 1666, LocalidadCordoba.VillaAscasubi },
                { 1667, LocalidadCordoba.ColoniaAlmadaGeneralFotheringham },
                { 1668, LocalidadCordoba.LasIsletillas },
                { 1669, LocalidadCordoba.PampayastaNorte }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Totoral).Key, new Dictionary<long, string>
            {
                { 1670, LocalidadCordoba.Candelaria },
                { 1671, LocalidadCordoba.Macha },
                { 1672, LocalidadCordoba.RioPinto },
                { 1673, LocalidadCordoba.Sinsacate },
                { 1674, LocalidadCordoba.Totoral },
                { 1675, LocalidadCordoba.CanadaDeLuque },
                { 1676, LocalidadCordoba.Sarmiento },
                { 1677, LocalidadCordoba.Sinsacate },
                { 1678, LocalidadCordoba.VillaDelTotoral },
                { 1679, LocalidadCordoba.CandelariaSud },
                { 1680, LocalidadCordoba.CapillaDeSiton },
                { 1681, LocalidadCordoba.LaPampa },
                { 1682, LocalidadCordoba.LasPenas },
                { 1683, LocalidadCordoba.LosMistoles },
                { 1684, LocalidadCordoba.Simbolar }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Tulumba).Key, new Dictionary<long, string>
            {
                { 1685, LocalidadCordoba.Dormida },
                { 1686, LocalidadCordoba.Intihuasi },
                { 1687, LocalidadCordoba.Mercedes },
                { 1688, LocalidadCordoba.Parroquia },
                { 1689, LocalidadCordoba.SanPedroNorte },
                { 1690, LocalidadCordoba.LasArrias },
                { 1691, LocalidadCordoba.LucioVMansilla },
                { 1692, LocalidadCordoba.SanJoseDeLaDormida },
                { 1693, LocalidadCordoba.SanJoseDeLasSalinas },
                { 1694, LocalidadCordoba.SanPedroNorte },
                { 1695, LocalidadCordoba.VillaTulumba },
                { 1696, LocalidadCordoba.ChurquiCanada },
                { 1697, LocalidadCordoba.ElRodeo },
                { 1698, LocalidadCordoba.RosarioDelSaladillo }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCordoba.Union).Key, new Dictionary<long, string>
            {
                { 1699, LocalidadCordoba.AltoAlegre },
                { 1700, LocalidadCordoba.Ballesteros },
                { 1701, LocalidadCordoba.BallesterosSud },
                { 1702, LocalidadCordoba.BellVille },
                { 1703, LocalidadCordoba.Gould },
                { 1704, LocalidadCordoba.Canals },
                { 1705, LocalidadCordoba.Chilibroste },
                { 1706, LocalidadCordoba.Cintra },
                { 1707, LocalidadCordoba.ColoniaBismarck },
                { 1708, LocalidadCordoba.Idiazabal },
                { 1709, LocalidadCordoba.JustinianoPosse },
                { 1710, LocalidadCordoba.Laborde },
                { 1711, LocalidadCordoba.MonteLena },
                { 1712, LocalidadCordoba.MonteMaiz },
                { 1713, LocalidadCordoba.Morrison },
                { 1714, LocalidadCordoba.Noetinger },
                { 1715, LocalidadCordoba.Ordonez },
                { 1716, LocalidadCordoba.Pascanas },
                { 1717, LocalidadCordoba.PuebloItaliano },
                { 1718, LocalidadCordoba.SanAntonioDeLitin },
                { 1719, LocalidadCordoba.SanMarcosSud },
                { 1720, LocalidadCordoba.Viamonte },
                { 1721, LocalidadCordoba.WenceslaoEscalante },
                { 1722, LocalidadCordoba.AldeaSantaMaria },
                { 1723, LocalidadCordoba.AnaZumaran },
                { 1724, LocalidadCordoba.ColoniaBremen },
                { 1725, LocalidadCordoba.VillaLosPatos }
            });
        }
    }
}
