using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class RioNegroLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public RioNegroLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.AdolfoAlsina).Value.Key, new Dictionary<long, string>
            {
                { 2920, LocalidadRioNegro.Viedma },
                { 2921, LocalidadRioNegro.BahiaCreek },
                { 2922, LocalidadRioNegro.BalnearioElCondor },
                { 2923, LocalidadRioNegro.ElJuncal },
                { 2924, LocalidadRioNegro.GuardiaMitre },
                { 2925, LocalidadRioNegro.LaLoberia },
                { 2926, LocalidadRioNegro.LoteoCostaDeRio },
                { 2927, LocalidadRioNegro.PozoSalado },
                { 2928, LocalidadRioNegro.SanJavier }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.Avellaneda).Value.Key, new Dictionary<long, string>
            {
                { 2929, LocalidadRioNegro.ChoeleChoel },
                { 2930, LocalidadRioNegro.Lamarque },
                { 2931, LocalidadRioNegro.LuisBeltran },
                { 2932, LocalidadRioNegro.Chimpay },
                { 2933, LocalidadRioNegro.CoronelBelisle },
                { 2934, LocalidadRioNegro.Darwin },
                { 2935, LocalidadRioNegro.Pomona },
                { 2936, LocalidadRioNegro.BarrioUnion },
                { 2937, LocalidadRioNegro.Chelforo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.Bariloche).Value.Key, new Dictionary<long, string>
            {
                { 2938, LocalidadRioNegro.ColoniaSuiza },
                { 2939, LocalidadRioNegro.ElBolson },
                { 2940, LocalidadRioNegro.ElFoyel },
                { 2941, LocalidadRioNegro.ElManso },
                { 2942, LocalidadRioNegro.RioVillegas },
                { 2943, LocalidadRioNegro.SanCarlosDeBariloche },
                { 2944, LocalidadRioNegro.VillaCampanario },
                { 2945, LocalidadRioNegro.VillaCerroCatedral },
                { 2946, LocalidadRioNegro.VillaLlaoLlao },
                { 2947, LocalidadRioNegro.VillaLosCoihues },
                { 2948, LocalidadRioNegro.VillaMascardi }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.Conesa).Value.Key, new Dictionary<long, string>
            {
                { 2949, LocalidadRioNegro.GeneralConesa }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.ElCuy).Value.Key, new Dictionary<long, string>
            {
                { 2950, LocalidadRioNegro.AguadaGuzman },
                { 2951, LocalidadRioNegro.CerroPolicia },
                { 2952, LocalidadRioNegro.ElCuy },
                { 2953, LocalidadRioNegro.LasPerlas },
                { 2954, LocalidadRioNegro.Mencue },
                { 2955, LocalidadRioNegro.NaupaHuen },
                { 2956, LocalidadRioNegro.ValleAzul }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.GeneralRoca).Value.Key, new Dictionary<long, string>
            {
                { 2957, LocalidadRioNegro.Allen },
                { 2958, LocalidadRioNegro.BajoSanCayetano },
                { 2959, LocalidadRioNegro.BardaDelMedio },
                { 2960, LocalidadRioNegro.CampoGrande },
                { 2961, LocalidadRioNegro.Catriel },
                { 2962, LocalidadRioNegro.Cervantes },
                { 2963, LocalidadRioNegro.Chichinales },
                { 2964, LocalidadRioNegro.CincoSaltos },
                { 2965, LocalidadRioNegro.Cipolletti },
                { 2966, LocalidadRioNegro.ColoniaPenasBlancas },
                { 2967, LocalidadRioNegro.CoronelJuanJoseGomez },
                { 2968, LocalidadRioNegro.ContralmiranteCordero },
                { 2969, LocalidadRioNegro.ContralmiranteMartinGuerrico },
                { 2970, LocalidadRioNegro.Ferri },
                { 2971, LocalidadRioNegro.GeneralEnriqueGodoy },
                { 2972, LocalidadRioNegro.GeneralFernandezOro },
                { 2973, LocalidadRioNegro.GeneralRoca },
                { 2974, LocalidadRioNegro.IngenieroLuisAHuergo },
                { 2975, LocalidadRioNegro.IngenieroOttoKrause },
                { 2976, LocalidadRioNegro.LagoPellegrini },
                { 2977, LocalidadRioNegro.Mainque },
                { 2978, LocalidadRioNegro.PadreStefenelli },
                { 2979, LocalidadRioNegro.PasoCordoba },
                { 2980, LocalidadRioNegro.PeninsulaRucaCo },
                { 2981, LocalidadRioNegro.PenasBlancas },
                { 2982, LocalidadRioNegro.SargentoVidal },
                { 2983, LocalidadRioNegro.VillaAlberdi },
                { 2984, LocalidadRioNegro.VillaDelParque },
                { 2985, LocalidadRioNegro.VillaManzano },
                { 2986, LocalidadRioNegro.VillaRegina },
                { 2987, LocalidadRioNegro.VillaSanIsidro }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.NueveDeJulio).Value.Key, new Dictionary<long, string>
            {
                { 2988, LocalidadRioNegro.Comico },
                { 2989, LocalidadRioNegro.ConaNiyeu },
                { 2990, LocalidadRioNegro.MinistroRamosMexia },
                { 2991, LocalidadRioNegro.Prahuaniyeu },
                { 2992, LocalidadRioNegro.Treneta },
                { 2993, LocalidadRioNegro.SierraColorada },
                { 2994, LocalidadRioNegro.Yaminue }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.Norquinco).Value.Key, new Dictionary<long, string>
            {
                { 2995, LocalidadRioNegro.LasBayas },
                { 2996, LocalidadRioNegro.MamuelChoique },
                { 2997, LocalidadRioNegro.Norquinco },
                { 2998, LocalidadRioNegro.OjosDeAgua },
                { 2999, LocalidadRioNegro.RioChico }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.PichiMahuida).Value.Key, new Dictionary<long, string>
            {
                { 3000, LocalidadRioNegro.ColoniaJuliaYEcharren },
                { 3001, LocalidadRioNegro.RioColorado }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.Pilcaniyeu).Value.Key, new Dictionary<long, string>
            {
                { 3002, LocalidadRioNegro.DinaHuapi },
                { 3003, LocalidadRioNegro.Comallo },
                { 3004, LocalidadRioNegro.LagunaBlanca },
                { 3005, LocalidadRioNegro.Nirihuau },
                { 3006, LocalidadRioNegro.PasoFlores },
                { 3007, LocalidadRioNegro.Pilcaniyeu },
                { 3008, LocalidadRioNegro.PilquiniyeuDelLimay },
                { 3009, LocalidadRioNegro.VillaLlanquin },
                { 3010, LocalidadRioNegro.CanadonChileno },
                { 3011, LocalidadRioNegro.AneconGrande },
                { 3012, LocalidadRioNegro.NeneoRuca },
                { 3013, LocalidadRioNegro.LosJuncos }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.SanAntonio).Value.Key, new Dictionary<long, string>
            {
                { 3014, LocalidadRioNegro.LasGrutas },
                { 3015, LocalidadRioNegro.PlayasDoradas },
                { 3016, LocalidadRioNegro.PuntaColorada },
                { 3017, LocalidadRioNegro.SanAntonioEste },
                { 3018, LocalidadRioNegro.SanAntonioOeste },
                { 3019, LocalidadRioNegro.SierraGrande }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.Valcheta).Value.Key, new Dictionary<long, string>
            {
                { 3020, LocalidadRioNegro.Valcheta },
                { 3021, LocalidadRioNegro.AguadaCecilio },
                { 3022, LocalidadRioNegro.ArroyoDeLaVentana },
                { 3023, LocalidadRioNegro.ArroyoLosBerros },
                { 3024, LocalidadRioNegro.NahuelNiyeu },
                { 3025, LocalidadRioNegro.SierraPaileman },
                { 3026, LocalidadRioNegro.Chipauquil },
                { 3027, LocalidadRioNegro.PajaAlta }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoRioNegro.VeinticincoDeMayo).Value.Key, new Dictionary<long, string>
            {
                { 3028, LocalidadRioNegro.AguadaDeGuerra },
                { 3029, LocalidadRioNegro.BarrilNiyeo },
                { 3030, LocalidadRioNegro.ClementeOnelli },
                { 3031, LocalidadRioNegro.ColanConhue },
                { 3032, LocalidadRioNegro.ElCain },
                { 3033, LocalidadRioNegro.IngenieroJacobacci },
                { 3034, LocalidadRioNegro.CorralChoique },
                { 3035, LocalidadRioNegro.LosMenucos },
                { 3036, LocalidadRioNegro.LlamaNiyeo },
                { 3037, LocalidadRioNegro.Maquinchao },
                { 3038, LocalidadRioNegro.MinaSantaTeresita },
                { 3039, LocalidadRioNegro.Pilquiniyeu },
                { 3040, LocalidadRioNegro.SanAntonioDelCuy }
            });
        }
    }
}
