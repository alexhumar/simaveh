using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    public class LocalidadSaltaFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadSaltaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Anta).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3041, LocalidadSalta.ApolinarioSaravia),
                datosEntidadBuilder.Build(3042, LocalidadSalta.ElQuebrachal),
                datosEntidadBuilder.Build(3043, LocalidadSalta.GeneralPizarro),
                datosEntidadBuilder.Build(3044, LocalidadSalta.JoaquinVictorGonzalez),
                datosEntidadBuilder.Build(3045, LocalidadSalta.LasLajitas),
                datosEntidadBuilder.Build(3046, LocalidadSalta.Vinalito),
                datosEntidadBuilder.Build(3047, LocalidadSalta.Tolloche),
                datosEntidadBuilder.Build(3048, LocalidadSalta.NuestraSenoraDeTalavera),
                datosEntidadBuilder.Build(3049, LocalidadSalta.Macapillo),
                datosEntidadBuilder.Build(3050, LocalidadSalta.Gaona),
                datosEntidadBuilder.Build(3051, LocalidadSalta.Ceibalito),
                datosEntidadBuilder.Build(3052, LocalidadSalta.Chorroarin),
                datosEntidadBuilder.Build(3053, LocalidadSalta.Ebro),
                datosEntidadBuilder.Build(3054, LocalidadSalta.CurvaDelTurco),
                datosEntidadBuilder.Build(3055, LocalidadSalta.SantoDomingo),
                datosEntidadBuilder.Build(3056, LocalidadSalta.LasFlores),
                datosEntidadBuilder.Build(3057, LocalidadSalta.LasFlacas),
                datosEntidadBuilder.Build(3058, LocalidadSalta.LuisBurella),
                datosEntidadBuilder.Build(3059, LocalidadSalta.CoronelMollinedo),
                datosEntidadBuilder.Build(3060, LocalidadSalta.Palermo),
                datosEntidadBuilder.Build(3061, LocalidadSalta.RioDelValle),
                datosEntidadBuilder.Build(3062, LocalidadSalta.Centro25DeJunio),
                datosEntidadBuilder.Build(3063, LocalidadSalta.CoronelOlleros),
                datosEntidadBuilder.Build(3064, LocalidadSalta.PiqueteCabado)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Cachi).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3065, LocalidadSalta.Cachi),
                datosEntidadBuilder.Build(3066, LocalidadSalta.Payogasta),
                datosEntidadBuilder.Build(3067, LocalidadSalta.ElVallecito),
                datosEntidadBuilder.Build(3068, LocalidadSalta.Escalchi),
                datosEntidadBuilder.Build(3069, LocalidadSalta.SanJoseDeEscalchi),
                datosEntidadBuilder.Build(3070, LocalidadSalta.CachiAdentro),
                datosEntidadBuilder.Build(3071, LocalidadSalta.LaPaya)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Cafayate).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3072, LocalidadSalta.Cafayate),
                datosEntidadBuilder.Build(3073, LocalidadSalta.Tolombon),
                datosEntidadBuilder.Build(3074, LocalidadSalta.LasConchas),
                datosEntidadBuilder.Build(3075, LocalidadSalta.SantaBarbara)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3076, LocalidadSalta.Salta)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Cerrillos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3077, LocalidadSalta.Cerrillos),
                datosEntidadBuilder.Build(3078, LocalidadSalta.LaMerced),
                datosEntidadBuilder.Build(3079, LocalidadSalta.SanAgustin),
                datosEntidadBuilder.Build(3080, LocalidadSalta.VillaLosAlamos),
                datosEntidadBuilder.Build(3081, LocalidadSalta.Sumalao),
                datosEntidadBuilder.Build(3082, LocalidadSalta.LasPalmas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Chicoana).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3083, LocalidadSalta.Chicoana),
                datosEntidadBuilder.Build(3084, LocalidadSalta.ElCarril),
                datosEntidadBuilder.Build(3085, LocalidadSalta.Escoipe),
                datosEntidadBuilder.Build(3086, LocalidadSalta.Vinaco),
                datosEntidadBuilder.Build(3087, LocalidadSalta.Calvimonte),
                datosEntidadBuilder.Build(3088, LocalidadSalta.AguaNegra),
                datosEntidadBuilder.Build(3089, LocalidadSalta.ElMaray),
                datosEntidadBuilder.Build(3090, LocalidadSalta.ElNogalar),
                datosEntidadBuilder.Build(3091, LocalidadSalta.LaZanja),
                datosEntidadBuilder.Build(3092, LocalidadSalta.Pulares),
                datosEntidadBuilder.Build(3093, LocalidadSalta.SanFernandoDeEscoipe),
                datosEntidadBuilder.Build(3094, LocalidadSalta.SanMartin),
                datosEntidadBuilder.Build(3095, LocalidadSalta.Chivilme),
                datosEntidadBuilder.Build(3096, LocalidadSalta.BellaVista),
                datosEntidadBuilder.Build(3097, LocalidadSalta.Penaflor),
                datosEntidadBuilder.Build(3098, LocalidadSalta.PotreroDeDiaz),
                datosEntidadBuilder.Build(3099, LocalidadSalta.Simbolar),
                datosEntidadBuilder.Build(3100, LocalidadSalta.Maroma)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.GeneralGuemes).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3101, LocalidadSalta.CampoSanto),
                datosEntidadBuilder.Build(3102, LocalidadSalta.ElBordo),
                datosEntidadBuilder.Build(3103, LocalidadSalta.GeneralGuemes),
                datosEntidadBuilder.Build(3104, LocalidadSalta.Cobos),
                datosEntidadBuilder.Build(3105, LocalidadSalta.CabezaDeBuey),
                datosEntidadBuilder.Build(3106, LocalidadSalta.Palomitas),
                datosEntidadBuilder.Build(3107, LocalidadSalta.Betania),
                datosEntidadBuilder.Build(3108, LocalidadSalta.CruzQuemada),
                datosEntidadBuilder.Build(3109, LocalidadSalta.ElSalto),
                datosEntidadBuilder.Build(3110, LocalidadSalta.Km1094),
                datosEntidadBuilder.Build(3111, LocalidadSalta.LasMesitas),
                datosEntidadBuilder.Build(3112, LocalidadSalta.VirgilioTedin),
                datosEntidadBuilder.Build(3113, LocalidadSalta.LosSauces)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.GeneralJoseDeSanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3114, LocalidadSalta.Tartagal),
                datosEntidadBuilder.Build(3115, LocalidadSalta.Embarcacion),
                datosEntidadBuilder.Build(3116, LocalidadSalta.SalvadorMazza),
                datosEntidadBuilder.Build(3117, LocalidadSalta.GeneralMosconi),
                datosEntidadBuilder.Build(3118, LocalidadSalta.Aguaray),
                datosEntidadBuilder.Build(3119, LocalidadSalta.CoronelCornejo),
                datosEntidadBuilder.Build(3120, LocalidadSalta.CampamentoVespucio),
                datosEntidadBuilder.Build(3121, LocalidadSalta.GeneralBallivian),
                datosEntidadBuilder.Build(3122, LocalidadSalta.Dragones),
                datosEntidadBuilder.Build(3123, LocalidadSalta.Yacuy),
                datosEntidadBuilder.Build(3124, LocalidadSalta.MisionChaquena),
                datosEntidadBuilder.Build(3125, LocalidadSalta.MisionKilometro6),
                datosEntidadBuilder.Build(3126, LocalidadSalta.Hickman),
                datosEntidadBuilder.Build(3127, LocalidadSalta.CampoDuran),
                datosEntidadBuilder.Build(3128, LocalidadSalta.MisionTierrasFiscales),
                datosEntidadBuilder.Build(3129, LocalidadSalta.Piquirenda),
                datosEntidadBuilder.Build(3130, LocalidadSalta.Tranquitas),
                datosEntidadBuilder.Build(3131, LocalidadSalta.Capiazuti),
                datosEntidadBuilder.Build(3132, LocalidadSalta.PadreLozano),
                datosEntidadBuilder.Build(3133, LocalidadSalta.Tobantirenda),
                datosEntidadBuilder.Build(3134, LocalidadSalta.Carboncito),
                datosEntidadBuilder.Build(3135, LocalidadSalta.Campichuelo),
                datosEntidadBuilder.Build(3136, LocalidadSalta.Pacara),
                datosEntidadBuilder.Build(3137, LocalidadSalta.Recaredo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Guachipas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3138, LocalidadSalta.Guachipas),
                datosEntidadBuilder.Build(3139, LocalidadSalta.Alemania),
                datosEntidadBuilder.Build(3140, LocalidadSalta.Cebilar),
                datosEntidadBuilder.Build(3141, LocalidadSalta.PampaGrande),
                datosEntidadBuilder.Build(3142, LocalidadSalta.LasJuntas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Iruya).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3143, LocalidadSalta.Colanzuli),
                datosEntidadBuilder.Build(3144, LocalidadSalta.Chiyayoc),
                datosEntidadBuilder.Build(3145, LocalidadSalta.RodeoColorado),
                datosEntidadBuilder.Build(3146, LocalidadSalta.SanJuan),
                datosEntidadBuilder.Build(3147, LocalidadSalta.VolcanHigueras)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.LaCaldera).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3148, LocalidadSalta.LaCaldera),
                datosEntidadBuilder.Build(3149, LocalidadSalta.Vaqueros),
                datosEntidadBuilder.Build(3150, LocalidadSalta.LaCalderilla),
                datosEntidadBuilder.Build(3151, LocalidadSalta.LosYacones),
                datosEntidadBuilder.Build(3152, LocalidadSalta.PotreroDeCastilla)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.LaCandelaria).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3153, LocalidadSalta.ElJardin),
                datosEntidadBuilder.Build(3154, LocalidadSalta.ElTala),
                datosEntidadBuilder.Build(3155, LocalidadSalta.LaCandelaria)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.LaPoma).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3156, LocalidadSalta.EsquinaDeGuardia),
                datosEntidadBuilder.Build(3157, LocalidadSalta.LaPoma),
                datosEntidadBuilder.Build(3158, LocalidadSalta.Cobres),
                datosEntidadBuilder.Build(3159, LocalidadSalta.ElSaladillo),
                datosEntidadBuilder.Build(3160, LocalidadSalta.ElTrigal),
                datosEntidadBuilder.Build(3161, LocalidadSalta.ElVolcan),
                datosEntidadBuilder.Build(3162, LocalidadSalta.Munano),
                datosEntidadBuilder.Build(3163, LocalidadSalta.Potrerillos),
                datosEntidadBuilder.Build(3164, LocalidadSalta.Tipan),
                datosEntidadBuilder.Build(3165, LocalidadSalta.CerroNegro),
                datosEntidadBuilder.Build(3166, LocalidadSalta.ElRodeo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.LaVina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3167, LocalidadSalta.CoronelMoldes),
                datosEntidadBuilder.Build(3168, LocalidadSalta.LaVina),
                datosEntidadBuilder.Build(3169, LocalidadSalta.Ampascachi),
                datosEntidadBuilder.Build(3170, LocalidadSalta.Talapampa),
                datosEntidadBuilder.Build(3171, LocalidadSalta.CabraCorral),
                datosEntidadBuilder.Build(3172, LocalidadSalta.ElCarmen),
                datosEntidadBuilder.Build(3173, LocalidadSalta.Osma),
                datosEntidadBuilder.Build(3174, LocalidadSalta.VeinteDeFebrero),
                datosEntidadBuilder.Build(3175, LocalidadSalta.Saladillo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.LosAndes).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3176, LocalidadSalta.SanAntonioDeLosCobres),
                datosEntidadBuilder.Build(3177, LocalidadSalta.Olacapato),
                datosEntidadBuilder.Build(3178, LocalidadSalta.SantaRosaDeLosPastosGrandes),
                datosEntidadBuilder.Build(3179, LocalidadSalta.TolarGrande),
                datosEntidadBuilder.Build(3180, LocalidadSalta.Caipe),
                datosEntidadBuilder.Build(3181, LocalidadSalta.Chuculaqui),
                datosEntidadBuilder.Build(3182, LocalidadSalta.LagunaSeca),
                datosEntidadBuilder.Build(3183, LocalidadSalta.LosPatos),
                datosEntidadBuilder.Build(3184, LocalidadSalta.MinaLaCasualidad),
                datosEntidadBuilder.Build(3185, LocalidadSalta.MinaTincalado),
                datosEntidadBuilder.Build(3186, LocalidadSalta.QuebradaDelAgua),
                datosEntidadBuilder.Build(3187, LocalidadSalta.SalarDePocitos),
                datosEntidadBuilder.Build(3188, LocalidadSalta.Socompa),
                datosEntidadBuilder.Build(3189, LocalidadSalta.TacaTaca),
                datosEntidadBuilder.Build(3190, LocalidadSalta.Unquillar),
                datosEntidadBuilder.Build(3191, LocalidadSalta.VegaDeArizaro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Metan).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3192, LocalidadSalta.SanJoseDeMetan),
                datosEntidadBuilder.Build(3193, LocalidadSalta.ElGalpon),
                datosEntidadBuilder.Build(3194, LocalidadSalta.RioPiedras),
                datosEntidadBuilder.Build(3195, LocalidadSalta.ElTunal),
                datosEntidadBuilder.Build(3196, LocalidadSalta.Lumbreras),
                datosEntidadBuilder.Build(3197, LocalidadSalta.LosRosales),
                datosEntidadBuilder.Build(3198, LocalidadSalta.MetanViejo),
                datosEntidadBuilder.Build(3199, LocalidadSalta.SanJoseDeLaOrquera),
                datosEntidadBuilder.Build(3200, LocalidadSalta.PresaElTunal)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Molinos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3201, LocalidadSalta.Molinos),
                datosEntidadBuilder.Build(3202, LocalidadSalta.Seclantas),
                datosEntidadBuilder.Build(3203, LocalidadSalta.LaPuerta),
                datosEntidadBuilder.Build(3204, LocalidadSalta.Colome),
                datosEntidadBuilder.Build(3205, LocalidadSalta.Luracatao),
                datosEntidadBuilder.Build(3206, LocalidadSalta.Brealito),
                datosEntidadBuilder.Build(3207, LocalidadSalta.SeclantasAdentro),
                datosEntidadBuilder.Build(3208, LocalidadSalta.Tacuil),
                datosEntidadBuilder.Build(3209, LocalidadSalta.ElChurcal),
                datosEntidadBuilder.Build(3210, LocalidadSalta.LaAguadita),
                datosEntidadBuilder.Build(3211, LocalidadSalta.Amaicha),
                datosEntidadBuilder.Build(3212, LocalidadSalta.ElRefugio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Oran).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3213, LocalidadSalta.SanRamonDeLaNuevaOran),
                datosEntidadBuilder.Build(3214, LocalidadSalta.Pichanal),
                datosEntidadBuilder.Build(3215, LocalidadSalta.ColoniaSantaRosa),
                datosEntidadBuilder.Build(3216, LocalidadSalta.HipolitoYrigoyen),
                datosEntidadBuilder.Build(3217, LocalidadSalta.Urundel),
                datosEntidadBuilder.Build(3218, LocalidadSalta.AguasBlancas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.Rivadavia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3219, LocalidadSalta.CoronelJuanSola),
                datosEntidadBuilder.Build(3220, LocalidadSalta.Rivadavia),
                datosEntidadBuilder.Build(3221, LocalidadSalta.SantaVictoriaEste),
                datosEntidadBuilder.Build(3222, LocalidadSalta.LaUnion),
                datosEntidadBuilder.Build(3223, LocalidadSalta.LosBlancos),
                datosEntidadBuilder.Build(3224, LocalidadSalta.SantaMaria),
                datosEntidadBuilder.Build(3225, LocalidadSalta.AltoDeLaSierra),
                datosEntidadBuilder.Build(3226, LocalidadSalta.SantaRosa),
                datosEntidadBuilder.Build(3227, LocalidadSalta.CapitanJuanPage),
                datosEntidadBuilder.Build(3228, LocalidadSalta.PlumaDePato)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.RosarioDeLaFrontera).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3229, LocalidadSalta.RosarioDeLaFrontera),
                datosEntidadBuilder.Build(3230, LocalidadSalta.Antilla),
                datosEntidadBuilder.Build(3231, LocalidadSalta.CopoQuile),
                datosEntidadBuilder.Build(3232, LocalidadSalta.ElPotrero),
                datosEntidadBuilder.Build(3233, LocalidadSalta.ElNaranjo),
                datosEntidadBuilder.Build(3234, LocalidadSalta.SanFelipe)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.RosarioDeLerma).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3235, LocalidadSalta.CampoQuijano),
                datosEntidadBuilder.Build(3236, LocalidadSalta.RosarioDeLerma),
                datosEntidadBuilder.Build(3237, LocalidadSalta.LaSilleta),
                datosEntidadBuilder.Build(3238, LocalidadSalta.PuertaTastil),
                datosEntidadBuilder.Build(3239, LocalidadSalta.SantaRosaDeTastil)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.SanCarlos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3240, LocalidadSalta.Angastaco),
                datosEntidadBuilder.Build(3241, LocalidadSalta.Animana),
                datosEntidadBuilder.Build(3242, LocalidadSalta.SanCarlos),
                datosEntidadBuilder.Build(3243, LocalidadSalta.ElBarrial),
                datosEntidadBuilder.Build(3244, LocalidadSalta.Jasimana),
                datosEntidadBuilder.Build(3245, LocalidadSalta.LaAngostura),
                datosEntidadBuilder.Build(3246, LocalidadSalta.MinaDonOtto),
                datosEntidadBuilder.Build(3247, LocalidadSalta.Monteverde),
                datosEntidadBuilder.Build(3248, LocalidadSalta.Pucara),
                datosEntidadBuilder.Build(3249, LocalidadSalta.SantaRosa),
                datosEntidadBuilder.Build(3250, LocalidadSalta.Amblayo),
                datosEntidadBuilder.Build(3251, LocalidadSalta.ParajeCorralito),
                datosEntidadBuilder.Build(3252, LocalidadSalta.ParajeSanAntonio),
                datosEntidadBuilder.Build(3253, LocalidadSalta.Payogastilla)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSalta.SantaVictoria).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3254, LocalidadSalta.SantaVictoriaOeste),
                datosEntidadBuilder.Build(3255, LocalidadSalta.LosToldos),
                datosEntidadBuilder.Build(3256, LocalidadSalta.Nazareno),
                datosEntidadBuilder.Build(3257, LocalidadSalta.Poscaya),
                datosEntidadBuilder.Build(3258, LocalidadSalta.CampoLaCruz),
                datosEntidadBuilder.Build(3259, LocalidadSalta.SanMarcos),
                datosEntidadBuilder.Build(3260, LocalidadSalta.Acoyte)
            });
        }
    }
}
