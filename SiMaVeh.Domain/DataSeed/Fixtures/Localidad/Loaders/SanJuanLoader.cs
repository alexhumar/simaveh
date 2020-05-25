using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class SanJuanLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public SanJuanLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Albardon).Value.Key, new Dictionary<long, string>
            {
                { 3261, LocalidadSanJuan.CampoAfuera },
                { 3262, LocalidadSanJuan.GeneralSanMartin },
                { 3263, LocalidadSanJuan.ElRincon },
                { 3264, LocalidadSanJuan.LaCanada },
                { 3265, LocalidadSanJuan.LasLomitas },
                { 3266, LocalidadSanJuan.VillaAmpacama }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Angaco).Value.Key, new Dictionary<long, string>
            {
                { 3267, LocalidadSanJuan.VillaDelSalvador },
                { 3268, LocalidadSanJuan.VillaSefairTalacasto },
                { 3269, LocalidadSanJuan.LasTapias }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Calingasta).Value.Key, new Dictionary<long, string>
            {
                { 3270, LocalidadSanJuan.Barreal },
                { 3271, LocalidadSanJuan.Calingasta },
                { 3272, LocalidadSanJuan.Tamberias },
                { 3273, LocalidadSanJuan.VillaPituil }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Capital).Value.Key, new Dictionary<long, string>
            {
                { 3274, LocalidadSanJuan.Concepcion },
                { 3275, LocalidadSanJuan.Desamparados },
                { 3276, LocalidadSanJuan.SanJuan },
                { 3277, LocalidadSanJuan.Trinidad }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Caucete).Value.Key, new Dictionary<long, string>
            {
                { 3278, LocalidadSanJuan.Bermejo },
                { 3279, LocalidadSanJuan.CiudadDeCaucete },
                { 3280, LocalidadSanJuan.ElRincon },
                { 3281, LocalidadSanJuan.Marayes },
                { 3282, LocalidadSanJuan.LasTalas },
                { 3283, LocalidadSanJuan.LosMedanos },
                { 3284, LocalidadSanJuan.PieDePalo },
                { 3285, LocalidadSanJuan.Vallecito },
                { 3286, LocalidadSanJuan.VillaIndependencia }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Chimbas).Value.Key, new Dictionary<long, string>
            {
                { 3287, LocalidadSanJuan.ElMogote },
                { 3288, LocalidadSanJuan.BarrioLosTamarindos },
                { 3289, LocalidadSanJuan.VillaObrera },
                { 3290, LocalidadSanJuan.VillaUnion },
                { 3291, LocalidadSanJuan.VillaPaulaAlbarracinDeSarmiento }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Iglesia).Value.Key, new Dictionary<long, string>
            {
                { 3292, LocalidadSanJuan.Angualasto },
                { 3293, LocalidadSanJuan.BellaVista },
                { 3294, LocalidadSanJuan.Colola },
                { 3295, LocalidadSanJuan.Iglesia },
                { 3296, LocalidadSanJuan.LasFlores },
                { 3297, LocalidadSanJuan.Pismanta },
                { 3298, LocalidadSanJuan.Rodeo },
                { 3299, LocalidadSanJuan.Tudcum }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Jachal).Value.Key, new Dictionary<long, string>
            {
                { 3300, LocalidadSanJuan.SanJoseDeJachal },
                { 3301, LocalidadSanJuan.ElFical },
                { 3302, LocalidadSanJuan.ElMedano },
                { 3303, LocalidadSanJuan.GranChina },
                { 3304, LocalidadSanJuan.Huaco },
                { 3305, LocalidadSanJuan.LaFalda },
                { 3306, LocalidadSanJuan.Mogna },
                { 3307, LocalidadSanJuan.Niquivil },
                { 3308, LocalidadSanJuan.PampaVieja },
                { 3309, LocalidadSanJuan.SanIsidro },
                { 3310, LocalidadSanJuan.Tamberias },
                { 3311, LocalidadSanJuan.VillaMalvinasArgentinas },
                { 3312, LocalidadSanJuan.VillaMercedes }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.NueveDeJulio).Value.Key, new Dictionary<long, string>
            {
                { 3313, LocalidadSanJuan.ColoniaFiorito },
                { 3314, LocalidadSanJuan.LasChacritas },
                { 3315, LocalidadSanJuan.NueveDeJulio },
                { 3316, LocalidadSanJuan.Dibella },
                { 3317, LocalidadSanJuan.JoseDolores },
                { 3318, LocalidadSanJuan.LaMajadita },
                { 3319, LocalidadSanJuan.TierraAdentro },
                { 3320, LocalidadSanJuan.AltoDeSierraEste },
                { 3321, LocalidadSanJuan.RinconCercado }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Pocito).Value.Key, new Dictionary<long, string>
            {
                { 3322, LocalidadSanJuan.BarrioRuta40 },
                { 3323, LocalidadSanJuan.Carpinteria },
                { 3324, LocalidadSanJuan.LaRinconada },
                { 3325, LocalidadSanJuan.QuintoCuartel },
                { 3326, LocalidadSanJuan.VillaAberastain },
                { 3327, LocalidadSanJuan.VillaBarboza },
                { 3328, LocalidadSanJuan.VillaCentenario },
                { 3329, LocalidadSanJuan.VillaNacusi }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Rawson).Value.Key, new Dictionary<long, string>
            {
                { 3330, LocalidadSanJuan.VillaKrause },
                { 3331, LocalidadSanJuan.Rawson },
                { 3332, LocalidadSanJuan.ElMedanito },
                { 3333, LocalidadSanJuan.VillaBolanos }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Rivadavia).Value.Key, new Dictionary<long, string>
            {
                { 3334, LocalidadSanJuan.Rivadavia },
                { 3335, LocalidadSanJuan.Marquesado },
                { 3336, LocalidadSanJuan.LaBebida }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.SanMartin).Value.Key, new Dictionary<long, string>
            {
                { 3337, LocalidadSanJuan.SanIsidro },
                { 3338, LocalidadSanJuan.DosAcequias },
                { 3339, LocalidadSanJuan.LaPuntilla }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.SantaLucia).Value.Key, new Dictionary<long, string>
            {
                { 3340, LocalidadSanJuan.AltoDeSierra },
                { 3341, LocalidadSanJuan.ColoniaGutierrez },
                { 3342, LocalidadSanJuan.SantaLucia },
                { 3343, LocalidadSanJuan.LaLegua },
                { 3344, LocalidadSanJuan.VillaMarini },
                { 3345, LocalidadSanJuan.ColoniaRichetYZapata },
                { 3346, LocalidadSanJuan.ColoniaGutierrez }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Sarmiento).Value.Key, new Dictionary<long, string>
            {
                { 3347, LocalidadSanJuan.CanadaHonda },
                { 3348, LocalidadSanJuan.Cienaguita },
                { 3349, LocalidadSanJuan.ColoniaFiscal },
                { 3350, LocalidadSanJuan.Divisadero },
                { 3351, LocalidadSanJuan.Guanacache },
                { 3352, LocalidadSanJuan.LasLagunas },
                { 3353, LocalidadSanJuan.LosBerros },
                { 3354, LocalidadSanJuan.Pedernal },
                { 3355, LocalidadSanJuan.PuntaDelMedano },
                { 3356, LocalidadSanJuan.MediaAgua }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Ullum).Value.Key, new Dictionary<long, string>
            {
                { 3357, LocalidadSanJuan.VillaAurora },
                { 3358, LocalidadSanJuan.VillaIbanez },
                { 3359, LocalidadSanJuan.ElChilote }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.ValleFertil).Value.Key, new Dictionary<long, string>
            {
                { 3360, LocalidadSanJuan.Astica },
                { 3361, LocalidadSanJuan.BaldesDelRosario },
                { 3362, LocalidadSanJuan.Chucuma },
                { 3363, LocalidadSanJuan.LosBaldecitos },
                { 3364, LocalidadSanJuan.Usno },
                { 3365, LocalidadSanJuan.VillaSanAgustin }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.VeinticincoDeMayo).Value.Key, new Dictionary<long, string>
            {
                { 3366, LocalidadSanJuan.ElEncon },
                { 3367, LocalidadSanJuan.LaChimbera },
                { 3368, LocalidadSanJuan.Tupeli },
                { 3369, LocalidadSanJuan.VillaBorjas },
                { 3370, LocalidadSanJuan.VillaElTango },
                { 3371, LocalidadSanJuan.SantaRosa }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanJuan.Zonda).Value.Key, new Dictionary<long, string>
            {
                { 3372, LocalidadSanJuan.VillaBasilioNievas },
                { 3373, LocalidadSanJuan.VillaTacu }
            });
        }
    }
}
