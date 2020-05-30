using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    class LocalidadCatamarcaFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadCatamarcaFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
            : base(partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.Ambato).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(932, LocalidadCatamarca.Chuchucaruana),
                datosEntidadBuilder.Build(933, LocalidadCatamarca.Colpes),
                datosEntidadBuilder.Build(934, LocalidadCatamarca.ElBolson),
                datosEntidadBuilder.Build(935, LocalidadCatamarca.ElRodeo),
                datosEntidadBuilder.Build(936, LocalidadCatamarca.Huaycama),
                datosEntidadBuilder.Build(937, LocalidadCatamarca.LaPuerta),
                datosEntidadBuilder.Build(938, LocalidadCatamarca.LasChacritas),
                datosEntidadBuilder.Build(939, LocalidadCatamarca.LasJuntas),
                datosEntidadBuilder.Build(940, LocalidadCatamarca.LosCastillos),
                datosEntidadBuilder.Build(941, LocalidadCatamarca.LosTalas),
                datosEntidadBuilder.Build(942, LocalidadCatamarca.LosVarela),
                datosEntidadBuilder.Build(943, LocalidadCatamarca.Singuil)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.Ancasti).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(944, LocalidadCatamarca.VillaDeAncasti),
                datosEntidadBuilder.Build(945, LocalidadCatamarca.Anquincila),
                datosEntidadBuilder.Build(946, LocalidadCatamarca.LaCandelaria),
                datosEntidadBuilder.Build(947, LocalidadCatamarca.LaMajada)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.Andalgala).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(948, LocalidadCatamarca.Aconquija),
                datosEntidadBuilder.Build(949, LocalidadCatamarca.AltoDeLasJuntas),
                datosEntidadBuilder.Build(950, LocalidadCatamarca.Andalgala),
                datosEntidadBuilder.Build(951, LocalidadCatamarca.Amanao),
                datosEntidadBuilder.Build(952, LocalidadCatamarca.BuenaVista),
                datosEntidadBuilder.Build(953, LocalidadCatamarca.Chaquiago),
                datosEntidadBuilder.Build(954, LocalidadCatamarca.Choya),
                datosEntidadBuilder.Build(955, LocalidadCatamarca.ElAlamito),
                datosEntidadBuilder.Build(956, LocalidadCatamarca.ElLindero),
                datosEntidadBuilder.Build(957, LocalidadCatamarca.ElPotrero),
                datosEntidadBuilder.Build(958, LocalidadCatamarca.LaAguada),
                datosEntidadBuilder.Build(959, LocalidadCatamarca.LaMesada),
                datosEntidadBuilder.Build(960, LocalidadCatamarca.MinasCapillitas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.AntofagastaDeLaSierra).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(961, LocalidadCatamarca.AntofagastaDeLaSierra),
                datosEntidadBuilder.Build(962, LocalidadCatamarca.ElPenon),
                datosEntidadBuilder.Build(963, LocalidadCatamarca.LosNacimientos),
                datosEntidadBuilder.Build(964, LocalidadCatamarca.Antofalla)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.Belen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(965, LocalidadCatamarca.BarrancaLarga),
                datosEntidadBuilder.Build(966, LocalidadCatamarca.Belen),
                datosEntidadBuilder.Build(967, LocalidadCatamarca.CondorHuasi),
                datosEntidadBuilder.Build(968, LocalidadCatamarca.CorralQuemado),
                datosEntidadBuilder.Build(969, LocalidadCatamarca.ElDurazno),
                datosEntidadBuilder.Build(970, LocalidadCatamarca.FarallonNegro),
                datosEntidadBuilder.Build(971, LocalidadCatamarca.Hualfin),
                datosEntidadBuilder.Build(972, LocalidadCatamarca.Jacipunco),
                datosEntidadBuilder.Build(973, LocalidadCatamarca.LaPuntilla),
                datosEntidadBuilder.Build(974, LocalidadCatamarca.LasJuntas),
                datosEntidadBuilder.Build(975, LocalidadCatamarca.Londres),
                datosEntidadBuilder.Build(976, LocalidadCatamarca.LosNacimientos),
                datosEntidadBuilder.Build(977, LocalidadCatamarca.PozoDeLaPiedra),
                datosEntidadBuilder.Build(978, LocalidadCatamarca.PuertaDeCorralQuemado),
                datosEntidadBuilder.Build(979, LocalidadCatamarca.PuertaDeSanJose),
                datosEntidadBuilder.Build(980, LocalidadCatamarca.VillaVil)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.Capayan).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(981, LocalidadCatamarca.AdolfoECarranza),
                datosEntidadBuilder.Build(982, LocalidadCatamarca.BaldeDeLaPunta),
                datosEntidadBuilder.Build(983, LocalidadCatamarca.Capayan),
                datosEntidadBuilder.Build(984, LocalidadCatamarca.Chumbicha),
                datosEntidadBuilder.Build(985, LocalidadCatamarca.ColoniaDelValle),
                datosEntidadBuilder.Build(986, LocalidadCatamarca.ColoniaNuevaConeta),
                datosEntidadBuilder.Build(987, LocalidadCatamarca.Concepcion),
                datosEntidadBuilder.Build(988, LocalidadCatamarca.Coneta),
                datosEntidadBuilder.Build(989, LocalidadCatamarca.ElBanado),
                datosEntidadBuilder.Build(990, LocalidadCatamarca.Huillapima),
                datosEntidadBuilder.Build(991, LocalidadCatamarca.LosAngeles),
                datosEntidadBuilder.Build(992, LocalidadCatamarca.Miraflores),
                datosEntidadBuilder.Build(993, LocalidadCatamarca.MonteRedondo),
                datosEntidadBuilder.Build(994, LocalidadCatamarca.SanMartin),
                datosEntidadBuilder.Build(995, LocalidadCatamarca.SanPablo),
                datosEntidadBuilder.Build(996, LocalidadCatamarca.SanPedro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(997, LocalidadCatamarca.BarrioBancario),
                datosEntidadBuilder.Build(998, LocalidadCatamarca.SanFernandoDelValleDeCatamarca),
                datosEntidadBuilder.Build(999, LocalidadCatamarca.ElPantanillo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.ElAlto).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1000, LocalidadCatamarca.ElAlto),
                datosEntidadBuilder.Build(1001, LocalidadCatamarca.Guayamba),
                datosEntidadBuilder.Build(1002, LocalidadCatamarca.Infanzon),
                datosEntidadBuilder.Build(1003, LocalidadCatamarca.LosCorrales),
                datosEntidadBuilder.Build(1004, LocalidadCatamarca.Tapso),
                datosEntidadBuilder.Build(1005, LocalidadCatamarca.Vilisman)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.FrayMamertoEsquiu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1006, LocalidadCatamarca.Collagasta),
                datosEntidadBuilder.Build(1007, LocalidadCatamarca.LaCarrera),
                datosEntidadBuilder.Build(1008, LocalidadCatamarca.ElHueco),
                datosEntidadBuilder.Build(1009, LocalidadCatamarca.LaFaldaDeSanAntonio),
                datosEntidadBuilder.Build(1010, LocalidadCatamarca.LaTercena),
                datosEntidadBuilder.Build(1011, LocalidadCatamarca.PomancilloEste),
                datosEntidadBuilder.Build(1012, LocalidadCatamarca.PomancilloOeste),
                datosEntidadBuilder.Build(1013, LocalidadCatamarca.SanAntonio),
                datosEntidadBuilder.Build(1014, LocalidadCatamarca.SanJoseDePiedraBlanca),
                datosEntidadBuilder.Build(1015, LocalidadCatamarca.VillaLasPirquitas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.LaPaz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1016, LocalidadCatamarca.CasaDePiedra),
                datosEntidadBuilder.Build(1017, LocalidadCatamarca.ElAybal),
                datosEntidadBuilder.Build(1018, LocalidadCatamarca.ElBanado),
                datosEntidadBuilder.Build(1019, LocalidadCatamarca.ElDivisadero),
                datosEntidadBuilder.Build(1020, LocalidadCatamarca.ElQuimilo),
                datosEntidadBuilder.Build(1021, LocalidadCatamarca.Esquiu),
                datosEntidadBuilder.Build(1022, LocalidadCatamarca.Icano),
                datosEntidadBuilder.Build(1023, LocalidadCatamarca.LaDorada),
                datosEntidadBuilder.Build(1024, LocalidadCatamarca.LasEsquinas),
                datosEntidadBuilder.Build(1025, LocalidadCatamarca.LaGuardia),
                datosEntidadBuilder.Build(1026, LocalidadCatamarca.LasPalmitas),
                datosEntidadBuilder.Build(1027, LocalidadCatamarca.Quiros),
                datosEntidadBuilder.Build(1028, LocalidadCatamarca.Ramblones),
                datosEntidadBuilder.Build(1029, LocalidadCatamarca.Recreo),
                datosEntidadBuilder.Build(1030, LocalidadCatamarca.SanAntonio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.Paclin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1031, LocalidadCatamarca.Amadores),
                datosEntidadBuilder.Build(1032, LocalidadCatamarca.ElRosario),
                datosEntidadBuilder.Build(1033, LocalidadCatamarca.LaBajada),
                datosEntidadBuilder.Build(1034, LocalidadCatamarca.LaHiguera),
                datosEntidadBuilder.Build(1035, LocalidadCatamarca.LaMerced),
                datosEntidadBuilder.Build(1036, LocalidadCatamarca.LaVina),
                datosEntidadBuilder.Build(1037, LocalidadCatamarca.LasLajas),
                datosEntidadBuilder.Build(1038, LocalidadCatamarca.MontePotrero),
                datosEntidadBuilder.Build(1039, LocalidadCatamarca.PaloLabrado),
                datosEntidadBuilder.Build(1040, LocalidadCatamarca.SanAntonio),
                datosEntidadBuilder.Build(1041, LocalidadCatamarca.VillaDeBalcozna)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.Poman).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1042, LocalidadCatamarca.Saujil),
                datosEntidadBuilder.Build(1043, LocalidadCatamarca.Colpes),
                datosEntidadBuilder.Build(1044, LocalidadCatamarca.SanJose),
                datosEntidadBuilder.Build(1045, LocalidadCatamarca.Joyango),
                datosEntidadBuilder.Build(1046, LocalidadCatamarca.SanMiguel),
                datosEntidadBuilder.Build(1047, LocalidadCatamarca.LasCasitas),
                datosEntidadBuilder.Build(1048, LocalidadCatamarca.Rincon),
                datosEntidadBuilder.Build(1049, LocalidadCatamarca.Michango),
                datosEntidadBuilder.Build(1050, LocalidadCatamarca.Sijan),
                datosEntidadBuilder.Build(1051, LocalidadCatamarca.Mutquin),
                datosEntidadBuilder.Build(1052, LocalidadCatamarca.Apoyaco),
                datosEntidadBuilder.Build(1053, LocalidadCatamarca.VillaDePoman),
                datosEntidadBuilder.Build(1054, LocalidadCatamarca.RosarioDeColana),
                datosEntidadBuilder.Build(1055, LocalidadCatamarca.RetiroDeColana),
                datosEntidadBuilder.Build(1056, LocalidadCatamarca.ElPajonal)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.SantaMaria).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1057, LocalidadCatamarca.Andalhuala),
                datosEntidadBuilder.Build(1058, LocalidadCatamarca.CasaDePiedra),
                datosEntidadBuilder.Build(1059, LocalidadCatamarca.Caspichango),
                datosEntidadBuilder.Build(1060, LocalidadCatamarca.ChanarPunco),
                datosEntidadBuilder.Build(1061, LocalidadCatamarca.ElCajon),
                datosEntidadBuilder.Build(1062, LocalidadCatamarca.ElCerrito),
                datosEntidadBuilder.Build(1063, LocalidadCatamarca.ElDesmonte),
                datosEntidadBuilder.Build(1064, LocalidadCatamarca.ElPuesto),
                datosEntidadBuilder.Build(1065, LocalidadCatamarca.Famatanca),
                datosEntidadBuilder.Build(1066, LocalidadCatamarca.FuerteQuemado),
                datosEntidadBuilder.Build(1067, LocalidadCatamarca.LaHoyada),
                datosEntidadBuilder.Build(1068, LocalidadCatamarca.LaLoma),
                datosEntidadBuilder.Build(1069, LocalidadCatamarca.LaPuntilla),
                datosEntidadBuilder.Build(1070, LocalidadCatamarca.Lampacito),
                datosEntidadBuilder.Build(1071, LocalidadCatamarca.LasMojarras),
                datosEntidadBuilder.Build(1072, LocalidadCatamarca.LoroHuasi),
                datosEntidadBuilder.Build(1073, LocalidadCatamarca.Medanitos),
                datosEntidadBuilder.Build(1074, LocalidadCatamarca.Ovejeria),
                datosEntidadBuilder.Build(1075, LocalidadCatamarca.PaloSeco),
                datosEntidadBuilder.Build(1076, LocalidadCatamarca.PuntaDeBalasto),
                datosEntidadBuilder.Build(1077, LocalidadCatamarca.SanJose),
                datosEntidadBuilder.Build(1078, LocalidadCatamarca.SanJoseBanda),
                datosEntidadBuilder.Build(1079, LocalidadCatamarca.SanJoseNorte),
                datosEntidadBuilder.Build(1080, LocalidadCatamarca.SanJoseVilla),
                datosEntidadBuilder.Build(1081, LocalidadCatamarca.SantaMaria),
                datosEntidadBuilder.Build(1082, LocalidadCatamarca.Yapes)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.SantaRosa).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1083, LocalidadCatamarca.Alijilan),
                datosEntidadBuilder.Build(1084, LocalidadCatamarca.BanadoDeOvanta),
                datosEntidadBuilder.Build(1085, LocalidadCatamarca.LasCanas),
                datosEntidadBuilder.Build(1086, LocalidadCatamarca.Lavalle),
                datosEntidadBuilder.Build(1087, LocalidadCatamarca.LosAltos),
                datosEntidadBuilder.Build(1088, LocalidadCatamarca.Manantiales),
                datosEntidadBuilder.Build(1089, LocalidadCatamarca.MonteRedondo),
                datosEntidadBuilder.Build(1090, LocalidadCatamarca.SanPedro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.Tinogasta).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1091, LocalidadCatamarca.Anillaco),
                datosEntidadBuilder.Build(1092, LocalidadCatamarca.Antinaco),
                datosEntidadBuilder.Build(1093, LocalidadCatamarca.BandaDeLucero),
                datosEntidadBuilder.Build(1094, LocalidadCatamarca.CerroNegro),
                datosEntidadBuilder.Build(1095, LocalidadCatamarca.Copacabana),
                datosEntidadBuilder.Build(1096, LocalidadCatamarca.Cordobita),
                datosEntidadBuilder.Build(1097, LocalidadCatamarca.CostaDeReyes),
                datosEntidadBuilder.Build(1098, LocalidadCatamarca.ElPueblito),
                datosEntidadBuilder.Build(1099, LocalidadCatamarca.ElPuesto),
                datosEntidadBuilder.Build(1100, LocalidadCatamarca.ElSalado),
                datosEntidadBuilder.Build(1101, LocalidadCatamarca.Fiambala),
                datosEntidadBuilder.Build(1102, LocalidadCatamarca.LaPuntilla),
                datosEntidadBuilder.Build(1103, LocalidadCatamarca.LaRamadita),
                datosEntidadBuilder.Build(1104, LocalidadCatamarca.LosBalverdi),
                datosEntidadBuilder.Build(1105, LocalidadCatamarca.Medanitos),
                datosEntidadBuilder.Build(1106, LocalidadCatamarca.PaloBlanco),
                datosEntidadBuilder.Build(1107, LocalidadCatamarca.PampaBlanca),
                datosEntidadBuilder.Build(1108, LocalidadCatamarca.PuntaDelAgua),
                datosEntidadBuilder.Build(1109, LocalidadCatamarca.SantaRosa),
                datosEntidadBuilder.Build(1110, LocalidadCatamarca.Saujil),
                datosEntidadBuilder.Build(1111, LocalidadCatamarca.Taton),
                datosEntidadBuilder.Build(1112, LocalidadCatamarca.Tinogasta)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCatamarca.ValleViejo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1113, LocalidadCatamarca.ElPortezuelo),
                datosEntidadBuilder.Build(1114, LocalidadCatamarca.Huaycama),
                datosEntidadBuilder.Build(1115, LocalidadCatamarca.LasTejas),
                datosEntidadBuilder.Build(1116, LocalidadCatamarca.SanIsidro),
                datosEntidadBuilder.Build(1117, LocalidadCatamarca.SantaCruz)
            });
        }
    }
}
