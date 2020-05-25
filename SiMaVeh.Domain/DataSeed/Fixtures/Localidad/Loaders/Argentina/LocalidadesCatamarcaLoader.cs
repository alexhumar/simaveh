using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesCatamarcaLoader : LocalidadesLoader
    {
        public LocalidadesCatamarcaLoader(IPartidosLoader<long, long, string> partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.Ambato).Key, new Dictionary<long, string>
            {
                { 932, LocalidadCatamarca.Chuchucaruana },
                { 933, LocalidadCatamarca.Colpes },
                { 934, LocalidadCatamarca.ElBolson },
                { 935, LocalidadCatamarca.ElRodeo },
                { 936, LocalidadCatamarca.Huaycama },
                { 937, LocalidadCatamarca.LaPuerta },
                { 938, LocalidadCatamarca.LasChacritas },
                { 939, LocalidadCatamarca.LasJuntas },
                { 940, LocalidadCatamarca.LosCastillos },
                { 941, LocalidadCatamarca.LosTalas },
                { 942, LocalidadCatamarca.LosVarela },
                { 943, LocalidadCatamarca.Singuil }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.Ancasti).Key, new Dictionary<long, string>
            {
                { 944, LocalidadCatamarca.VillaDeAncasti },
                { 945, LocalidadCatamarca.Anquincila },
                { 946, LocalidadCatamarca.LaCandelaria },
                { 947, LocalidadCatamarca.LaMajada }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.Andalgala).Key, new Dictionary<long, string>
            {
                { 948, LocalidadCatamarca.Aconquija },
                { 949, LocalidadCatamarca.AltoDeLasJuntas },
                { 950, LocalidadCatamarca.Andalgala },
                { 951, LocalidadCatamarca.Amanao },
                { 952, LocalidadCatamarca.BuenaVista },
                { 953, LocalidadCatamarca.Chaquiago },
                { 954, LocalidadCatamarca.Choya },
                { 955, LocalidadCatamarca.ElAlamito },
                { 956, LocalidadCatamarca.ElLindero },
                { 957, LocalidadCatamarca.ElPotrero },
                { 958, LocalidadCatamarca.LaAguada },
                { 959, LocalidadCatamarca.LaMesada },
                { 960, LocalidadCatamarca.MinasCapillitas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.AntofagastaDeLaSierra).Key, new Dictionary<long, string>
            {
                { 961, LocalidadCatamarca.AntofagastaDeLaSierra },
                { 962, LocalidadCatamarca.ElPenon },
                { 963, LocalidadCatamarca.LosNacimientos },
                { 964, LocalidadCatamarca.Antofalla }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.Belen).Key, new Dictionary<long, string>
            {
                { 965, LocalidadCatamarca.BarrancaLarga },
                { 966, LocalidadCatamarca.Belen },
                { 967, LocalidadCatamarca.CondorHuasi },
                { 968, LocalidadCatamarca.CorralQuemado },
                { 969, LocalidadCatamarca.ElDurazno },
                { 970, LocalidadCatamarca.FarallonNegro },
                { 971, LocalidadCatamarca.Hualfin },
                { 972, LocalidadCatamarca.Jacipunco },
                { 973, LocalidadCatamarca.LaPuntilla },
                { 974, LocalidadCatamarca.LasJuntas },
                { 975, LocalidadCatamarca.Londres },
                { 976, LocalidadCatamarca.LosNacimientos },
                { 977, LocalidadCatamarca.PozoDeLaPiedra },
                { 978, LocalidadCatamarca.PuertaDeCorralQuemado },
                { 979, LocalidadCatamarca.PuertaDeSanJose },
                { 980, LocalidadCatamarca.VillaVil }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.Capayan).Key, new Dictionary<long, string>
            {
                { 981, LocalidadCatamarca.AdolfoECarranza },
                { 982, LocalidadCatamarca.BaldeDeLaPunta },
                { 983, LocalidadCatamarca.Capayan },
                { 984, LocalidadCatamarca.Chumbicha },
                { 985, LocalidadCatamarca.ColoniaDelValle },
                { 986, LocalidadCatamarca.ColoniaNuevaConeta },
                { 987, LocalidadCatamarca.Concepcion },
                { 988, LocalidadCatamarca.Coneta },
                { 989, LocalidadCatamarca.ElBanado },
                { 990, LocalidadCatamarca.Huillapima },
                { 991, LocalidadCatamarca.LosAngeles },
                { 992, LocalidadCatamarca.Miraflores },
                { 993, LocalidadCatamarca.MonteRedondo },
                { 994, LocalidadCatamarca.SanMartin },
                { 995, LocalidadCatamarca.SanPablo },
                { 996, LocalidadCatamarca.SanPedro }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.Capital).Key, new Dictionary<long, string>
            {
                { 997, LocalidadCatamarca.BarrioBancario },
                { 998, LocalidadCatamarca.SanFernandoDelValleDeCatamarca },
                { 999, LocalidadCatamarca.ElPantanillo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.ElAlto).Key, new Dictionary<long, string>
            {
                { 1000, LocalidadCatamarca.ElAlto },
                { 1001, LocalidadCatamarca.Guayamba },
                { 1002, LocalidadCatamarca.Infanzon },
                { 1003, LocalidadCatamarca.LosCorrales },
                { 1004, LocalidadCatamarca.Tapso },
                { 1005, LocalidadCatamarca.Vilisman }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.FrayMamertoEsquiu).Key, new Dictionary<long, string>
            {
                { 1006, LocalidadCatamarca.Collagasta },
                { 1007, LocalidadCatamarca.LaCarrera },
                { 1008, LocalidadCatamarca.ElHueco },
                { 1009, LocalidadCatamarca.LaFaldaDeSanAntonio },
                { 1010, LocalidadCatamarca.LaTercena },
                { 1011, LocalidadCatamarca.PomancilloEste },
                { 1012, LocalidadCatamarca.PomancilloOeste },
                { 1013, LocalidadCatamarca.SanAntonio },
                { 1014, LocalidadCatamarca.SanJoseDePiedraBlanca },
                { 1015, LocalidadCatamarca.VillaLasPirquitas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.LaPaz).Key, new Dictionary<long, string>
            {
                { 1016, LocalidadCatamarca.CasaDePiedra },
                { 1017, LocalidadCatamarca.ElAybal },
                { 1018, LocalidadCatamarca.ElBanado },
                { 1019, LocalidadCatamarca.ElDivisadero },
                { 1020, LocalidadCatamarca.ElQuimilo },
                { 1021, LocalidadCatamarca.Esquiu },
                { 1022, LocalidadCatamarca.Icano },
                { 1023, LocalidadCatamarca.LaDorada },
                { 1024, LocalidadCatamarca.LasEsquinas },
                { 1025, LocalidadCatamarca.LaGuardia },
                { 1026, LocalidadCatamarca.LasPalmitas },
                { 1027, LocalidadCatamarca.Quiros },
                { 1028, LocalidadCatamarca.Ramblones },
                { 1029, LocalidadCatamarca.Recreo },
                { 1030, LocalidadCatamarca.SanAntonio }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.Paclin).Key, new Dictionary<long, string>
            {
                { 1031, LocalidadCatamarca.Amadores },
                { 1032, LocalidadCatamarca.ElRosario },
                { 1033, LocalidadCatamarca.LaBajada },
                { 1034, LocalidadCatamarca.LaHiguera },
                { 1035, LocalidadCatamarca.LaMerced },
                { 1036, LocalidadCatamarca.LaVina },
                { 1037, LocalidadCatamarca.LasLajas },
                { 1038, LocalidadCatamarca.MontePotrero },
                { 1039, LocalidadCatamarca.PaloLabrado },
                { 1040, LocalidadCatamarca.SanAntonio },
                { 1041, LocalidadCatamarca.VillaDeBalcozna }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.Poman).Key, new Dictionary<long, string>
            {
                { 1042, LocalidadCatamarca.Saujil },
                { 1043, LocalidadCatamarca.Colpes },
                { 1044, LocalidadCatamarca.SanJose },
                { 1045, LocalidadCatamarca.Joyango },
                { 1046, LocalidadCatamarca.SanMiguel },
                { 1047, LocalidadCatamarca.LasCasitas },
                { 1048, LocalidadCatamarca.Rincon },
                { 1049, LocalidadCatamarca.Michango },
                { 1050, LocalidadCatamarca.Sijan },
                { 1051, LocalidadCatamarca.Mutquin },
                { 1052, LocalidadCatamarca.Apoyaco },
                { 1053, LocalidadCatamarca.VillaDePoman },
                { 1054, LocalidadCatamarca.RosarioDeColana },
                { 1055, LocalidadCatamarca.RetiroDeColana },
                { 1056, LocalidadCatamarca.ElPajonal }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.SantaMaria).Key, new Dictionary<long, string>
            {
                { 1057, LocalidadCatamarca.Andalhuala },
                { 1058, LocalidadCatamarca.CasaDePiedra },
                { 1059, LocalidadCatamarca.Caspichango },
                { 1060, LocalidadCatamarca.ChanarPunco },
                { 1061, LocalidadCatamarca.ElCajon },
                { 1062, LocalidadCatamarca.ElCerrito },
                { 1063, LocalidadCatamarca.ElDesmonte },
                { 1064, LocalidadCatamarca.ElPuesto },
                { 1065, LocalidadCatamarca.Famatanca },
                { 1066, LocalidadCatamarca.FuerteQuemado },
                { 1067, LocalidadCatamarca.LaHoyada },
                { 1068, LocalidadCatamarca.LaLoma },
                { 1069, LocalidadCatamarca.LaPuntilla },
                { 1070, LocalidadCatamarca.Lampacito },
                { 1071, LocalidadCatamarca.LasMojarras },
                { 1072, LocalidadCatamarca.LoroHuasi },
                { 1073, LocalidadCatamarca.Medanitos },
                { 1074, LocalidadCatamarca.Ovejeria },
                { 1075, LocalidadCatamarca.PaloSeco },
                { 1076, LocalidadCatamarca.PuntaDeBalasto },
                { 1077, LocalidadCatamarca.SanJose },
                { 1078, LocalidadCatamarca.SanJoseBanda },
                { 1079, LocalidadCatamarca.SanJoseNorte },
                { 1080, LocalidadCatamarca.SanJoseVilla },
                { 1081, LocalidadCatamarca.SantaMaria },
                { 1082, LocalidadCatamarca.Yapes }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.SantaRosa).Key, new Dictionary<long, string>
            {
                { 1083, LocalidadCatamarca.Alijilan },
                { 1084, LocalidadCatamarca.BanadoDeOvanta },
                { 1085, LocalidadCatamarca.LasCanas },
                { 1086, LocalidadCatamarca.Lavalle },
                { 1087, LocalidadCatamarca.LosAltos },
                { 1088, LocalidadCatamarca.Manantiales },
                { 1089, LocalidadCatamarca.MonteRedondo },
                { 1090, LocalidadCatamarca.SanPedro }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.Tinogasta).Key, new Dictionary<long, string>
            {
                { 1091, LocalidadCatamarca.Anillaco },
                { 1092, LocalidadCatamarca.Antinaco },
                { 1093, LocalidadCatamarca.BandaDeLucero },
                { 1094, LocalidadCatamarca.CerroNegro },
                { 1095, LocalidadCatamarca.Copacabana },
                { 1096, LocalidadCatamarca.Cordobita },
                { 1097, LocalidadCatamarca.CostaDeReyes },
                { 1098, LocalidadCatamarca.ElPueblito },
                { 1099, LocalidadCatamarca.ElPuesto },
                { 1100, LocalidadCatamarca.ElSalado },
                { 1101, LocalidadCatamarca.Fiambala },
                { 1102, LocalidadCatamarca.LaPuntilla },
                { 1103, LocalidadCatamarca.LaRamadita },
                { 1104, LocalidadCatamarca.LosBalverdi },
                { 1105, LocalidadCatamarca.Medanitos },
                { 1106, LocalidadCatamarca.PaloBlanco },
                { 1107, LocalidadCatamarca.PampaBlanca },
                { 1108, LocalidadCatamarca.PuntaDelAgua },
                { 1109, LocalidadCatamarca.SantaRosa },
                { 1110, LocalidadCatamarca.Saujil },
                { 1111, LocalidadCatamarca.Taton },
                { 1112, LocalidadCatamarca.Tinogasta }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoCatamarca.ValleViejo).Key, new Dictionary<long, string>
            {
                { 1113, LocalidadCatamarca.ElPortezuelo },
                { 1114, LocalidadCatamarca.Huaycama },
                { 1115, LocalidadCatamarca.LasTejas },
                { 1116, LocalidadCatamarca.SanIsidro },
                { 1117, LocalidadCatamarca.SantaCruz }
            });
        }
    }
}
