using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class LaRiojaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public LaRiojaLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.Arauco).Value.Key, new Dictionary<long, string>
            {
                { 2361, LocalidadLaRioja.Aimogasta },
                { 2362, LocalidadLaRioja.Arauco },
                { 2363, LocalidadLaRioja.BanadoDeLosPantanos },
                { 2364, LocalidadLaRioja.EstacionMazan },
                { 2365, LocalidadLaRioja.Machigasta },
                { 2366, LocalidadLaRioja.TermasDeSantaTeresita },
                { 2367, LocalidadLaRioja.VillaMazan },
                { 2368, LocalidadLaRioja.Udpinango }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.Capital).Value.Key, new Dictionary<long, string>
            {
                { 2369, LocalidadLaRioja.LaRioja }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.CastroBarros).Value.Key, new Dictionary<long, string>
            {
                { 2370, LocalidadLaRioja.AguaBlanca },
                { 2371, LocalidadLaRioja.Aminga },
                { 2372, LocalidadLaRioja.Anillaco },
                { 2373, LocalidadLaRioja.Anjullon },
                { 2374, LocalidadLaRioja.Chuquis },
                { 2375, LocalidadLaRioja.LasPenas },
                { 2376, LocalidadLaRioja.LosMolinos },
                { 2377, LocalidadLaRioja.Pinchas },
                { 2378, LocalidadLaRioja.SanPedro },
                { 2379, LocalidadLaRioja.SantaVeraCruz }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.Chamical).Value.Key, new Dictionary<long, string>
            {
                { 2380, LocalidadLaRioja.Chamical },
                { 2381, LocalidadLaRioja.Polco },
                { 2382, LocalidadLaRioja.BellaVista },
                { 2383, LocalidadLaRioja.ElRetamo },
                { 2384, LocalidadLaRioja.EsperanzaDeLosCerrillos },
                { 2385, LocalidadLaRioja.EsquinaDelNorte },
                { 2386, LocalidadLaRioja.LaAguadita },
                { 2387, LocalidadLaRioja.SantaBarbara },
                { 2388, LocalidadLaRioja.SantaRitaDeLaZanja }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.Chilecito).Value.Key, new Dictionary<long, string>
            {
                { 2389, LocalidadLaRioja.Chilecito },
                { 2390, LocalidadLaRioja.Anguinan },
                { 2391, LocalidadLaRioja.LosSarmientos },
                { 2392, LocalidadLaRioja.SanMiguel },
                { 2393, LocalidadLaRioja.LaPuntilla },
                { 2394, LocalidadLaRioja.Nonogasta },
                { 2395, LocalidadLaRioja.Vichigasta },
                { 2396, LocalidadLaRioja.Sanogasta },
                { 2397, LocalidadLaRioja.Malligasta },
                { 2398, LocalidadLaRioja.ColoniaMalligasta },
                { 2399, LocalidadLaRioja.Tilimuqui },
                { 2400, LocalidadLaRioja.ColoniaVichigasta },
                { 2401, LocalidadLaRioja.Miranda },
                { 2402, LocalidadLaRioja.Guanchin },
                { 2403, LocalidadLaRioja.ColoniaAnguinan },
                { 2404, LocalidadLaRioja.SanNicolas },
                { 2405, LocalidadLaRioja.SantaFlorentina },
                { 2406, LocalidadLaRioja.ColoniaCatinzaco },
                { 2407, LocalidadLaRioja.Catinzaco },
                { 2408, LocalidadLaRioja.LaMejicanita }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.CoronelFelipeVarela).Value.Key, new Dictionary<long, string>
            {
                { 2409, LocalidadLaRioja.Aicuna },
                { 2410, LocalidadLaRioja.BandaFlorida },
                { 2411, LocalidadLaRioja.Guandacol },
                { 2412, LocalidadLaRioja.LosPalacios },
                { 2413, LocalidadLaRioja.LosTambillos },
                { 2414, LocalidadLaRioja.Pagancillo },
                { 2415, LocalidadLaRioja.PuertoAlegre },
                { 2416, LocalidadLaRioja.SantaClara },
                { 2417, LocalidadLaRioja.VillaUnion }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.Famatina).Value.Key, new Dictionary<long, string>
            {
                { 2418, LocalidadLaRioja.Famatina },
                { 2419, LocalidadLaRioja.AltoCarrizal },
                { 2420, LocalidadLaRioja.Angulos },
                { 2421, LocalidadLaRioja.Antinaco },
                { 2422, LocalidadLaRioja.BajoCarrizal },
                { 2423, LocalidadLaRioja.Campanas },
                { 2424, LocalidadLaRioja.Chanarmuyo },
                { 2425, LocalidadLaRioja.ElPotrerillo },
                { 2426, LocalidadLaRioja.LaCuadra },
                { 2427, LocalidadLaRioja.Pituil },
                { 2428, LocalidadLaRioja.PlazaVieja },
                { 2429, LocalidadLaRioja.SantaCruz },
                { 2430, LocalidadLaRioja.SantoDomingo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.GeneralAngelVPenaloza).Value.Key, new Dictionary<long, string>
            {
                { 2431, LocalidadLaRioja.Alcazar },
                { 2432, LocalidadLaRioja.Carrizal },
                { 2433, LocalidadLaRioja.Chila },
                { 2434, LocalidadLaRioja.Pacatala },
                { 2435, LocalidadLaRioja.Km38 },
                { 2436, LocalidadLaRioja.PuestoSantaCruz },
                { 2437, LocalidadLaRioja.PuntaDeLosLlanos },
                { 2438, LocalidadLaRioja.Tama },
                { 2439, LocalidadLaRioja.Tuizon }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.GeneralBelgrano).Value.Key, new Dictionary<long, string>
            {
                { 2440, LocalidadLaRioja.Olta },
                { 2441, LocalidadLaRioja.CastroBarros },
                { 2442, LocalidadLaRioja.Chanar },
                { 2443, LocalidadLaRioja.LomaBlanca },
                { 2444, LocalidadLaRioja.Talva },
                { 2445, LocalidadLaRioja.Cortaderas },
                { 2446, LocalidadLaRioja.Miraflores },
                { 2447, LocalidadLaRioja.MonteGrande },
                { 2448, LocalidadLaRioja.SanRamon },
                { 2449, LocalidadLaRioja.Simbolar },
                { 2450, LocalidadLaRioja.ElCardonal }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.GeneralJuanFacundoQuiroga).Value.Key, new Dictionary<long, string>
            {
                { 2451, LocalidadLaRioja.Portezuelo },
                { 2452, LocalidadLaRioja.Malanzan },
                { 2453, LocalidadLaRioja.Nacate },
                { 2454, LocalidadLaRioja.SanAntonio },
                { 2455, LocalidadLaRioja.LaChimenea },
                { 2456, LocalidadLaRioja.Solca },
                { 2457, LocalidadLaRioja.ElRetamal },
                { 2458, LocalidadLaRioja.Puluchan },
                { 2459, LocalidadLaRioja.Atiles },
                { 2460, LocalidadLaRioja.LomaLarga },
                { 2461, LocalidadLaRioja.Mascasin },
                { 2462, LocalidadLaRioja.TresCruces },
                { 2463, LocalidadLaRioja.Salana },
                { 2464, LocalidadLaRioja.Tuani },
                { 2465, LocalidadLaRioja.Huaja }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.GeneralLamadrid).Value.Key, new Dictionary<long, string>
            {
                { 2466, LocalidadLaRioja.VillaCastelli },
                { 2467, LocalidadLaRioja.Aguaditas },
                { 2468, LocalidadLaRioja.ElCondado },
                { 2469, LocalidadLaRioja.LaBanda },
                { 2470, LocalidadLaRioja.LosMoraditos },
                { 2471, LocalidadLaRioja.PastosLargos },
                { 2472, LocalidadLaRioja.Rivadavia },
                { 2473, LocalidadLaRioja.Tiaguas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.GeneralOcampo).Value.Key, new Dictionary<long, string>
            {
                { 2474, LocalidadLaRioja.Ambil },
                { 2475, LocalidadLaRioja.ColoniaOrtizDeOcampo },
                { 2476, LocalidadLaRioja.Milagro },
                { 2477, LocalidadLaRioja.Olpas },
                { 2478, LocalidadLaRioja.VillaSantaRitaDeCatuna },
                { 2479, LocalidadLaRioja.ComandanteLeal },
                { 2480, LocalidadLaRioja.ElFraile },
                { 2481, LocalidadLaRioja.LosAguirres },
                { 2482, LocalidadLaRioja.LosAlanices },
                { 2483, LocalidadLaRioja.EsquinaChica }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.GeneralSanMartin).Value.Key, new Dictionary<long, string>
            {
                { 2484, LocalidadLaRioja.Ulapes },
                { 2485, LocalidadLaRioja.Aguayo },
                { 2486, LocalidadLaRioja.BajoHondo },
                { 2487, LocalidadLaRioja.CorralDeIsaac },
                { 2488, LocalidadLaRioja.CuatroEsquinas },
                { 2489, LocalidadLaRioja.ElCalden },
                { 2490, LocalidadLaRioja.ElCadillo },
                { 2491, LocalidadLaRioja.SanSolano },
                { 2492, LocalidadLaRioja.VillaNidia },
                { 2493, LocalidadLaRioja.ElAbra },
                { 2494, LocalidadLaRioja.LaRepresa },
                { 2495, LocalidadLaRioja.LaRepresita },
                { 2496, LocalidadLaRioja.LasVentanitas },
                { 2497, LocalidadLaRioja.VillaNidia },
                { 2498, LocalidadLaRioja.PozoDePiedra }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.Independencia).Value.Key, new Dictionary<long, string>
            {
                { 2499, LocalidadLaRioja.Amana },
                { 2500, LocalidadLaRioja.LosColorados },
                { 2501, LocalidadLaRioja.Paganzo },
                { 2502, LocalidadLaRioja.Patquia },
                { 2503, LocalidadLaRioja.PatquiaViejo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.RosarioVeraPenaloza).Value.Key, new Dictionary<long, string>
            {
                { 2504, LocalidadLaRioja.Chepes },
                { 2505, LocalidadLaRioja.DesiderioTello },
                { 2506, LocalidadLaRioja.ElTotoral },
                { 2507, LocalidadLaRioja.VillaCasana },
                { 2508, LocalidadLaRioja.Mascasin },
                { 2509, LocalidadLaRioja.Noqueve },
                { 2510, LocalidadLaRioja.LaCalera },
                { 2511, LocalidadLaRioja.Chelcos },
                { 2512, LocalidadLaRioja.PotrerilloDeLosFlores },
                { 2513, LocalidadLaRioja.ElTala },
                { 2514, LocalidadLaRioja.ValleHermoso },
                { 2515, LocalidadLaRioja.LasToscas },
                { 2516, LocalidadLaRioja.SanIsidro },
                { 2517, LocalidadLaRioja.AguaBlanca },
                { 2518, LocalidadLaRioja.LasJarillas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.SanBlasDeLosSauces).Value.Key, new Dictionary<long, string>
            {
                { 2519, LocalidadLaRioja.LasPirguas },
                { 2520, LocalidadLaRioja.ElRetiro },
                { 2521, LocalidadLaRioja.Alpasinche },
                { 2522, LocalidadLaRioja.Chaupihuasi },
                { 2523, LocalidadLaRioja.Salicas },
                { 2524, LocalidadLaRioja.SanBlas },
                { 2525, LocalidadLaRioja.LosRobles },
                { 2526, LocalidadLaRioja.LosTalas },
                { 2527, LocalidadLaRioja.Cuipan },
                { 2528, LocalidadLaRioja.Schaqui },
                { 2529, LocalidadLaRioja.Andolucas },
                { 2530, LocalidadLaRioja.Suriyaco },
                { 2531, LocalidadLaRioja.Maican },
                { 2532, LocalidadLaRioja.Amuschina },
                { 2533, LocalidadLaRioja.Tuyubil }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.Sanagasta).Value.Key, new Dictionary<long, string>
            {
                { 2534, LocalidadLaRioja.VillaSanagasta },
                { 2535, LocalidadLaRioja.AltaGracia },
                { 2536, LocalidadLaRioja.Huaco }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaRioja.Vinchina).Value.Key, new Dictionary<long, string>
            {
                { 2537, LocalidadLaRioja.VillaSanJoseDeVinchina },
                { 2538, LocalidadLaRioja.Jague },
                { 2539, LocalidadLaRioja.PotreroGrande },
                { 2540, LocalidadLaRioja.ValleHermoso },
                { 2541, LocalidadLaRioja.PuntaDeAgua }
            });
        }
    }
}
