using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    class LocalidadRioNegroFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadRioNegroFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
            : base(partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.AdolfoAlsina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2920, LocalidadRioNegro.Viedma),
                datosEntidadBuilder.Build(2921, LocalidadRioNegro.BahiaCreek),
                datosEntidadBuilder.Build(2922, LocalidadRioNegro.BalnearioElCondor),
                datosEntidadBuilder.Build(2923, LocalidadRioNegro.ElJuncal),
                datosEntidadBuilder.Build(2924, LocalidadRioNegro.GuardiaMitre),
                datosEntidadBuilder.Build(2925, LocalidadRioNegro.LaLoberia),
                datosEntidadBuilder.Build(2926, LocalidadRioNegro.LoteoCostaDeRio),
                datosEntidadBuilder.Build(2927, LocalidadRioNegro.PozoSalado),
                datosEntidadBuilder.Build(2928, LocalidadRioNegro.SanJavier)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.Avellaneda).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2929, LocalidadRioNegro.ChoeleChoel),
                datosEntidadBuilder.Build(2930, LocalidadRioNegro.Lamarque),
                datosEntidadBuilder.Build(2931, LocalidadRioNegro.LuisBeltran),
                datosEntidadBuilder.Build(2932, LocalidadRioNegro.Chimpay),
                datosEntidadBuilder.Build(2933, LocalidadRioNegro.CoronelBelisle),
                datosEntidadBuilder.Build(2934, LocalidadRioNegro.Darwin),
                datosEntidadBuilder.Build(2935, LocalidadRioNegro.Pomona),
                datosEntidadBuilder.Build(2936, LocalidadRioNegro.BarrioUnion),
                datosEntidadBuilder.Build(2937, LocalidadRioNegro.Chelforo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.Bariloche).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2938, LocalidadRioNegro.ColoniaSuiza),
                datosEntidadBuilder.Build(2939, LocalidadRioNegro.ElBolson),
                datosEntidadBuilder.Build(2940, LocalidadRioNegro.ElFoyel),
                datosEntidadBuilder.Build(2941, LocalidadRioNegro.ElManso),
                datosEntidadBuilder.Build(2942, LocalidadRioNegro.RioVillegas),
                datosEntidadBuilder.Build(2943, LocalidadRioNegro.SanCarlosDeBariloche),
                datosEntidadBuilder.Build(2944, LocalidadRioNegro.VillaCampanario),
                datosEntidadBuilder.Build(2945, LocalidadRioNegro.VillaCerroCatedral),
                datosEntidadBuilder.Build(2946, LocalidadRioNegro.VillaLlaoLlao),
                datosEntidadBuilder.Build(2947, LocalidadRioNegro.VillaLosCoihues),
                datosEntidadBuilder.Build(2948, LocalidadRioNegro.VillaMascardi)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.Conesa).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2949, LocalidadRioNegro.GeneralConesa)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.ElCuy).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2950, LocalidadRioNegro.AguadaGuzman),
                datosEntidadBuilder.Build(2951, LocalidadRioNegro.CerroPolicia),
                datosEntidadBuilder.Build(2952, LocalidadRioNegro.ElCuy),
                datosEntidadBuilder.Build(2953, LocalidadRioNegro.LasPerlas),
                datosEntidadBuilder.Build(2954, LocalidadRioNegro.Mencue),
                datosEntidadBuilder.Build(2955, LocalidadRioNegro.NaupaHuen),
                datosEntidadBuilder.Build(2956, LocalidadRioNegro.ValleAzul)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.GeneralRoca).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2957, LocalidadRioNegro.Allen),
                datosEntidadBuilder.Build(2958, LocalidadRioNegro.BajoSanCayetano),
                datosEntidadBuilder.Build(2959, LocalidadRioNegro.BardaDelMedio),
                datosEntidadBuilder.Build(2960, LocalidadRioNegro.CampoGrande),
                datosEntidadBuilder.Build(2961, LocalidadRioNegro.Catriel),
                datosEntidadBuilder.Build(2962, LocalidadRioNegro.Cervantes),
                datosEntidadBuilder.Build(2963, LocalidadRioNegro.Chichinales),
                datosEntidadBuilder.Build(2964, LocalidadRioNegro.CincoSaltos),
                datosEntidadBuilder.Build(2965, LocalidadRioNegro.Cipolletti),
                datosEntidadBuilder.Build(2966, LocalidadRioNegro.ColoniaPenasBlancas),
                datosEntidadBuilder.Build(2967, LocalidadRioNegro.CoronelJuanJoseGomez),
                datosEntidadBuilder.Build(2968, LocalidadRioNegro.ContralmiranteCordero),
                datosEntidadBuilder.Build(2969, LocalidadRioNegro.ContralmiranteMartinGuerrico),
                datosEntidadBuilder.Build(2970, LocalidadRioNegro.Ferri),
                datosEntidadBuilder.Build(2971, LocalidadRioNegro.GeneralEnriqueGodoy),
                datosEntidadBuilder.Build(2972, LocalidadRioNegro.GeneralFernandezOro),
                datosEntidadBuilder.Build(2973, LocalidadRioNegro.GeneralRoca),
                datosEntidadBuilder.Build(2974, LocalidadRioNegro.IngenieroLuisAHuergo),
                datosEntidadBuilder.Build(2975, LocalidadRioNegro.IngenieroOttoKrause),
                datosEntidadBuilder.Build(2976, LocalidadRioNegro.LagoPellegrini),
                datosEntidadBuilder.Build(2977, LocalidadRioNegro.Mainque),
                datosEntidadBuilder.Build(2978, LocalidadRioNegro.PadreStefenelli),
                datosEntidadBuilder.Build(2979, LocalidadRioNegro.PasoCordoba),
                datosEntidadBuilder.Build(2980, LocalidadRioNegro.PeninsulaRucaCo),
                datosEntidadBuilder.Build(2981, LocalidadRioNegro.PenasBlancas),
                datosEntidadBuilder.Build(2982, LocalidadRioNegro.SargentoVidal),
                datosEntidadBuilder.Build(2983, LocalidadRioNegro.VillaAlberdi),
                datosEntidadBuilder.Build(2984, LocalidadRioNegro.VillaDelParque),
                datosEntidadBuilder.Build(2985, LocalidadRioNegro.VillaManzano),
                datosEntidadBuilder.Build(2986, LocalidadRioNegro.VillaRegina),
                datosEntidadBuilder.Build(2987, LocalidadRioNegro.VillaSanIsidro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.NueveDeJulio).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2988, LocalidadRioNegro.Comico),
                datosEntidadBuilder.Build(2989, LocalidadRioNegro.ConaNiyeu),
                datosEntidadBuilder.Build(2990, LocalidadRioNegro.MinistroRamosMexia),
                datosEntidadBuilder.Build(2991, LocalidadRioNegro.Prahuaniyeu),
                datosEntidadBuilder.Build(2992, LocalidadRioNegro.Treneta),
                datosEntidadBuilder.Build(2993, LocalidadRioNegro.SierraColorada),
                datosEntidadBuilder.Build(2994, LocalidadRioNegro.Yaminue)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.Norquinco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2995, LocalidadRioNegro.LasBayas),
                datosEntidadBuilder.Build(2996, LocalidadRioNegro.MamuelChoique),
                datosEntidadBuilder.Build(2997, LocalidadRioNegro.Norquinco),
                datosEntidadBuilder.Build(2998, LocalidadRioNegro.OjosDeAgua),
                datosEntidadBuilder.Build(2999, LocalidadRioNegro.RioChico)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.PichiMahuida).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3000, LocalidadRioNegro.ColoniaJuliaYEcharren),
                datosEntidadBuilder.Build(3001, LocalidadRioNegro.RioColorado)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.Pilcaniyeu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3002, LocalidadRioNegro.DinaHuapi),
                datosEntidadBuilder.Build(3003, LocalidadRioNegro.Comallo),
                datosEntidadBuilder.Build(3004, LocalidadRioNegro.LagunaBlanca),
                datosEntidadBuilder.Build(3005, LocalidadRioNegro.Nirihuau),
                datosEntidadBuilder.Build(3006, LocalidadRioNegro.PasoFlores),
                datosEntidadBuilder.Build(3007, LocalidadRioNegro.Pilcaniyeu),
                datosEntidadBuilder.Build(3008, LocalidadRioNegro.PilquiniyeuDelLimay),
                datosEntidadBuilder.Build(3009, LocalidadRioNegro.VillaLlanquin),
                datosEntidadBuilder.Build(3010, LocalidadRioNegro.CanadonChileno),
                datosEntidadBuilder.Build(3011, LocalidadRioNegro.AneconGrande),
                datosEntidadBuilder.Build(3012, LocalidadRioNegro.NeneoRuca),
                datosEntidadBuilder.Build(3013, LocalidadRioNegro.LosJuncos)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.SanAntonio).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3014, LocalidadRioNegro.LasGrutas),
                datosEntidadBuilder.Build(3015, LocalidadRioNegro.PlayasDoradas),
                datosEntidadBuilder.Build(3016, LocalidadRioNegro.PuntaColorada),
                datosEntidadBuilder.Build(3017, LocalidadRioNegro.SanAntonioEste),
                datosEntidadBuilder.Build(3018, LocalidadRioNegro.SanAntonioOeste),
                datosEntidadBuilder.Build(3019, LocalidadRioNegro.SierraGrande)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.Valcheta).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3020, LocalidadRioNegro.Valcheta),
                datosEntidadBuilder.Build(3021, LocalidadRioNegro.AguadaCecilio),
                datosEntidadBuilder.Build(3022, LocalidadRioNegro.ArroyoDeLaVentana),
                datosEntidadBuilder.Build(3023, LocalidadRioNegro.ArroyoLosBerros),
                datosEntidadBuilder.Build(3024, LocalidadRioNegro.NahuelNiyeu),
                datosEntidadBuilder.Build(3025, LocalidadRioNegro.SierraPaileman),
                datosEntidadBuilder.Build(3026, LocalidadRioNegro.Chipauquil),
                datosEntidadBuilder.Build(3027, LocalidadRioNegro.PajaAlta)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoRioNegro.VeinticincoDeMayo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3028, LocalidadRioNegro.AguadaDeGuerra),
                datosEntidadBuilder.Build(3029, LocalidadRioNegro.BarrilNiyeo),
                datosEntidadBuilder.Build(3030, LocalidadRioNegro.ClementeOnelli),
                datosEntidadBuilder.Build(3031, LocalidadRioNegro.ColanConhue),
                datosEntidadBuilder.Build(3032, LocalidadRioNegro.ElCain),
                datosEntidadBuilder.Build(3033, LocalidadRioNegro.IngenieroJacobacci),
                datosEntidadBuilder.Build(3034, LocalidadRioNegro.CorralChoique),
                datosEntidadBuilder.Build(3035, LocalidadRioNegro.LosMenucos),
                datosEntidadBuilder.Build(3036, LocalidadRioNegro.LlamaNiyeo),
                datosEntidadBuilder.Build(3037, LocalidadRioNegro.Maquinchao),
                datosEntidadBuilder.Build(3038, LocalidadRioNegro.MinaSantaTeresita),
                datosEntidadBuilder.Build(3039, LocalidadRioNegro.Pilquiniyeu),
                datosEntidadBuilder.Build(3040, LocalidadRioNegro.SanAntonioDelCuy)
            });
        }
    }
}
