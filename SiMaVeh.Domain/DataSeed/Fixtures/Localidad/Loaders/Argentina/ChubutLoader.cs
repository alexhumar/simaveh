using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class ChubutLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public ChubutLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Biedma).Value.Key, new Dictionary<long, string>
            {
                { 1187, LocalidadChubut.PuertoMadryn },
                { 1188, LocalidadChubut.PuertoPiramides },
                { 1189, LocalidadChubut.QuintaElMirador },
                { 1190, LocalidadChubut.PuntaDelgada },
                { 1191, LocalidadChubut.MinaGuanacache },
                { 1192, LocalidadChubut.ArroyoVerde },
                { 1193, LocalidadChubut.PuertoLobos },
                { 1194, LocalidadChubut.RiachoSanJose },
                { 1195, LocalidadChubut.PlayaElDoradillo },
                { 1196, LocalidadChubut.PuertoGalvan },
                { 1197, LocalidadChubut.ElDesempeno },
                { 1198, LocalidadChubut.PuertoSanJose }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Cushamen).Value.Key, new Dictionary<long, string>
            {
                { 1199, LocalidadChubut.BuenosAiresChico },
                { 1200, LocalidadChubut.Cholila },
                { 1201, LocalidadChubut.Cushamen },
                { 1202, LocalidadChubut.ElHoyo },
                { 1203, LocalidadChubut.ElMaiten },
                { 1204, LocalidadChubut.Epuyen },
                { 1205, LocalidadChubut.Gualjaina },
                { 1206, LocalidadChubut.LagoEpuyen },
                { 1207, LocalidadChubut.LagoPuelo },
                { 1208, LocalidadChubut.Leleque }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Escalante).Value.Key, new Dictionary<long, string>
            {
                { 1209, LocalidadChubut.ComodoroRivadavia },
                { 1210, LocalidadChubut.AccesoNorte },
                { 1211, LocalidadChubut.BarrioMilitarAeropuerto },
                { 1212, LocalidadChubut.CaletaCordova },
                { 1213, LocalidadChubut.CaletaOlivares },
                { 1214, LocalidadChubut.Castelli },
                { 1215, LocalidadChubut.Ciudadela },
                { 1216, LocalidadChubut.Cuarteles },
                { 1217, LocalidadChubut.DonBosco },
                { 1218, LocalidadChubut.GeneralMosconi },
                { 1219, LocalidadChubut.GasDelEstado },
                { 1220, LocalidadChubut.Guemes },
                { 1221, LocalidadChubut.Laprida },
                { 1222, LocalidadChubut.ManantialRosales },
                { 1223, LocalidadChubut.ProsperoPalazzo },
                { 1224, LocalidadChubut.PresidenteOrtiz },
                { 1225, LocalidadChubut.RadaTilly },
                { 1226, LocalidadChubut.RestingaAli },
                { 1227, LocalidadChubut.RodriguezPena },
                { 1228, LocalidadChubut.Saavedra },
                { 1229, LocalidadChubut.Sarmiento },
                { 1230, LocalidadChubut.VeinticincoDeMayo },
                { 1231, LocalidadChubut.VillaSUPE },
                { 1232, LocalidadChubut.Astra },
                { 1233, LocalidadChubut.DiademaArgentina },
                { 1234, LocalidadChubut.PampaSalamanca },
                { 1235, LocalidadChubut.PicoSalamanca },
                { 1236, LocalidadChubut.BahiaBustamante }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.FlorentinoAmeghino).Value.Key, new Dictionary<long, string>
            {
                { 1237, LocalidadChubut.Camarones },
                { 1238, LocalidadChubut.Garayalde }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Futaleufu).Value.Key, new Dictionary<long, string>
            {
                { 1239, LocalidadChubut.Esquel },
                { 1240, LocalidadChubut.Trevelin },
                { 1241, LocalidadChubut.Corcovado },
                { 1242, LocalidadChubut.LagoRosario },
                { 1243, LocalidadChubut.LosCipreses },
                { 1244, LocalidadChubut.VillaFutalaufquen }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Gaiman).Value.Key, new Dictionary<long, string>
            {
                { 1245, LocalidadChubut.VillaDiqueFlorentinoAmeghino },
                { 1246, LocalidadChubut.Dolavon },
                { 1247, LocalidadChubut.Gaiman },
                { 1248, LocalidadChubut.VeintiochoDeJulio }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Gastre).Value.Key, new Dictionary<long, string>
            {
                { 1249, LocalidadChubut.Gastre },
                { 1250, LocalidadChubut.LagunitaSalada },
                { 1251, LocalidadChubut.Blancuntre },
                { 1252, LocalidadChubut.ElEscorial },
                { 1253, LocalidadChubut.YalaLaubat }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Languineo).Value.Key, new Dictionary<long, string>
            {
                { 1254, LocalidadChubut.Tecka },
                { 1255, LocalidadChubut.PasoDelSapo },
                { 1256, LocalidadChubut.Carrenleufu },
                { 1257, LocalidadChubut.ColanConhue },
                { 1258, LocalidadChubut.AldeaEpulef }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Martires).Value.Key, new Dictionary<long, string>
            {
                { 1259, LocalidadChubut.LasPlumas },
                { 1260, LocalidadChubut.ElMirasol }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.PasoDeIndios).Value.Key, new Dictionary<long, string>
            {
                { 1261, LocalidadChubut.LosAltares },
                { 1262, LocalidadChubut.CerroCondor },
                { 1263, LocalidadChubut.PasoDeIndios },
                { 1264, LocalidadChubut.ElSombrero }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Rawson).Value.Key, new Dictionary<long, string>
            {
                { 1265, LocalidadChubut.PlayaUnion },
                { 1266, LocalidadChubut.PuertoRawson },
                { 1267, LocalidadChubut.Rawson },
                { 1268, LocalidadChubut.Trelew },
                { 1269, LocalidadChubut.PlayaMagagna }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.RioSenguer).Value.Key, new Dictionary<long, string>
            {
                { 1270, LocalidadChubut.RioMayo },
                { 1271, LocalidadChubut.AltoRioSenguer },
                { 1272, LocalidadChubut.DoctorRicardoRojas },
                { 1273, LocalidadChubut.LagoBlanco },
                { 1274, LocalidadChubut.AldeaBeleiro },
                { 1275, LocalidadChubut.Facundo },
                { 1276, LocalidadChubut.AldeaApeleg }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Sarmiento).Value.Key, new Dictionary<long, string>
            {
                { 1277, LocalidadChubut.BuenPasto },
                { 1278, LocalidadChubut.Sarmiento }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Tehuelches).Value.Key, new Dictionary<long, string>
            {
                { 1279, LocalidadChubut.GobernadorCosta },
                { 1280, LocalidadChubut.JoseDeSanMartin },
                { 1281, LocalidadChubut.RioPico },
                { 1282, LocalidadChubut.DoctorAtilioOscarViglione }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoChubut.Telsen).Value.Key, new Dictionary<long, string>
            {
                { 1283, LocalidadChubut.GanGan },
                { 1284, LocalidadChubut.Telsen }
            });
        }
    }
}
