using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    class LocalidadChubutFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadChubutFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
            : base(partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Biedma).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1187, LocalidadChubut.PuertoMadryn),
                datosEntidadBuilder.Build(1188, LocalidadChubut.PuertoPiramides),
                datosEntidadBuilder.Build(1189, LocalidadChubut.QuintaElMirador),
                datosEntidadBuilder.Build(1190, LocalidadChubut.PuntaDelgada),
                datosEntidadBuilder.Build(1191, LocalidadChubut.MinaGuanacache),
                datosEntidadBuilder.Build(1192, LocalidadChubut.ArroyoVerde),
                datosEntidadBuilder.Build(1193, LocalidadChubut.PuertoLobos),
                datosEntidadBuilder.Build(1194, LocalidadChubut.RiachoSanJose),
                datosEntidadBuilder.Build(1195, LocalidadChubut.PlayaElDoradillo),
                datosEntidadBuilder.Build(1196, LocalidadChubut.PuertoGalvan),
                datosEntidadBuilder.Build(1197, LocalidadChubut.ElDesempeno),
                datosEntidadBuilder.Build(1198, LocalidadChubut.PuertoSanJose)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Cushamen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1199, LocalidadChubut.BuenosAiresChico),
                datosEntidadBuilder.Build(1200, LocalidadChubut.Cholila),
                datosEntidadBuilder.Build(1201, LocalidadChubut.Cushamen),
                datosEntidadBuilder.Build(1202, LocalidadChubut.ElHoyo),
                datosEntidadBuilder.Build(1203, LocalidadChubut.ElMaiten),
                datosEntidadBuilder.Build(1204, LocalidadChubut.Epuyen),
                datosEntidadBuilder.Build(1205, LocalidadChubut.Gualjaina),
                datosEntidadBuilder.Build(1206, LocalidadChubut.LagoEpuyen),
                datosEntidadBuilder.Build(1207, LocalidadChubut.LagoPuelo),
                datosEntidadBuilder.Build(1208, LocalidadChubut.Leleque)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Escalante).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1209, LocalidadChubut.ComodoroRivadavia),
                datosEntidadBuilder.Build(1210, LocalidadChubut.AccesoNorte),
                datosEntidadBuilder.Build(1211, LocalidadChubut.BarrioMilitarAeropuerto),
                datosEntidadBuilder.Build(1212, LocalidadChubut.CaletaCordova),
                datosEntidadBuilder.Build(1213, LocalidadChubut.CaletaOlivares),
                datosEntidadBuilder.Build(1214, LocalidadChubut.Castelli),
                datosEntidadBuilder.Build(1215, LocalidadChubut.Ciudadela),
                datosEntidadBuilder.Build(1216, LocalidadChubut.Cuarteles),
                datosEntidadBuilder.Build(1217, LocalidadChubut.DonBosco),
                datosEntidadBuilder.Build(1218, LocalidadChubut.GeneralMosconi),
                datosEntidadBuilder.Build(1219, LocalidadChubut.GasDelEstado),
                datosEntidadBuilder.Build(1220, LocalidadChubut.Guemes),
                datosEntidadBuilder.Build(1221, LocalidadChubut.Laprida),
                datosEntidadBuilder.Build(1222, LocalidadChubut.ManantialRosales),
                datosEntidadBuilder.Build(1223, LocalidadChubut.ProsperoPalazzo),
                datosEntidadBuilder.Build(1224, LocalidadChubut.PresidenteOrtiz),
                datosEntidadBuilder.Build(1225, LocalidadChubut.RadaTilly),
                datosEntidadBuilder.Build(1226, LocalidadChubut.RestingaAli),
                datosEntidadBuilder.Build(1227, LocalidadChubut.RodriguezPena),
                datosEntidadBuilder.Build(1228, LocalidadChubut.Saavedra),
                datosEntidadBuilder.Build(1229, LocalidadChubut.Sarmiento),
                datosEntidadBuilder.Build(1230, LocalidadChubut.VeinticincoDeMayo),
                datosEntidadBuilder.Build(1231, LocalidadChubut.VillaSUPE),
                datosEntidadBuilder.Build(1232, LocalidadChubut.Astra),
                datosEntidadBuilder.Build(1233, LocalidadChubut.DiademaArgentina),
                datosEntidadBuilder.Build(1234, LocalidadChubut.PampaSalamanca),
                datosEntidadBuilder.Build(1235, LocalidadChubut.PicoSalamanca),
                datosEntidadBuilder.Build(1236, LocalidadChubut.BahiaBustamante)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.FlorentinoAmeghino).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1237, LocalidadChubut.Camarones),
                datosEntidadBuilder.Build(1238, LocalidadChubut.Garayalde)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Futaleufu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1239, LocalidadChubut.Esquel),
                datosEntidadBuilder.Build(1240, LocalidadChubut.Trevelin),
                datosEntidadBuilder.Build(1241, LocalidadChubut.Corcovado),
                datosEntidadBuilder.Build(1242, LocalidadChubut.LagoRosario),
                datosEntidadBuilder.Build(1243, LocalidadChubut.LosCipreses),
                datosEntidadBuilder.Build(1244, LocalidadChubut.VillaFutalaufquen)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Gaiman).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1245, LocalidadChubut.VillaDiqueFlorentinoAmeghino),
                datosEntidadBuilder.Build(1246, LocalidadChubut.Dolavon),
                datosEntidadBuilder.Build(1247, LocalidadChubut.Gaiman),
                datosEntidadBuilder.Build(1248, LocalidadChubut.VeintiochoDeJulio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Gastre).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1249, LocalidadChubut.Gastre),
                datosEntidadBuilder.Build(1250, LocalidadChubut.LagunitaSalada),
                datosEntidadBuilder.Build(1251, LocalidadChubut.Blancuntre),
                datosEntidadBuilder.Build(1252, LocalidadChubut.ElEscorial),
                datosEntidadBuilder.Build(1253, LocalidadChubut.YalaLaubat)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Languineo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1254, LocalidadChubut.Tecka),
                datosEntidadBuilder.Build(1255, LocalidadChubut.PasoDelSapo),
                datosEntidadBuilder.Build(1256, LocalidadChubut.Carrenleufu),
                datosEntidadBuilder.Build(1257, LocalidadChubut.ColanConhue),
                datosEntidadBuilder.Build(1258, LocalidadChubut.AldeaEpulef)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Martires).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1259, LocalidadChubut.LasPlumas),
                datosEntidadBuilder.Build(1260, LocalidadChubut.ElMirasol)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.PasoDeIndios).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1261, LocalidadChubut.LosAltares),
                datosEntidadBuilder.Build(1262, LocalidadChubut.CerroCondor),
                datosEntidadBuilder.Build(1263, LocalidadChubut.PasoDeIndios),
                datosEntidadBuilder.Build(1264, LocalidadChubut.ElSombrero)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Rawson).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1265, LocalidadChubut.PlayaUnion),
                datosEntidadBuilder.Build(1266, LocalidadChubut.PuertoRawson),
                datosEntidadBuilder.Build(1267, LocalidadChubut.Rawson),
                datosEntidadBuilder.Build(1268, LocalidadChubut.Trelew),
                datosEntidadBuilder.Build(1269, LocalidadChubut.PlayaMagagna)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.RioSenguer).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1270, LocalidadChubut.RioMayo),
                datosEntidadBuilder.Build(1271, LocalidadChubut.AltoRioSenguer),
                datosEntidadBuilder.Build(1272, LocalidadChubut.DoctorRicardoRojas),
                datosEntidadBuilder.Build(1273, LocalidadChubut.LagoBlanco),
                datosEntidadBuilder.Build(1274, LocalidadChubut.AldeaBeleiro),
                datosEntidadBuilder.Build(1275, LocalidadChubut.Facundo),
                datosEntidadBuilder.Build(1276, LocalidadChubut.AldeaApeleg)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Sarmiento).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1277, LocalidadChubut.BuenPasto),
                datosEntidadBuilder.Build(1278, LocalidadChubut.Sarmiento)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Tehuelches).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1279, LocalidadChubut.GobernadorCosta),
                datosEntidadBuilder.Build(1280, LocalidadChubut.JoseDeSanMartin),
                datosEntidadBuilder.Build(1281, LocalidadChubut.RioPico),
                datosEntidadBuilder.Build(1282, LocalidadChubut.DoctorAtilioOscarViglione)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoChubut.Telsen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1283, LocalidadChubut.GanGan),
                datosEntidadBuilder.Build(1284, LocalidadChubut.Telsen)
            });
        }
    }
}
