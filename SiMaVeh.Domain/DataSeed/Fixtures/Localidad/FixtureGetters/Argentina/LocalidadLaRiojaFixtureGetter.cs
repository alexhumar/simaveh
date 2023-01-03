using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    public class LocalidadLaRiojaFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadLaRiojaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.Arauco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2361, LocalidadLaRioja.Aimogasta),
                datosEntidadBuilder.Build(2362, LocalidadLaRioja.Arauco),
                datosEntidadBuilder.Build(2363, LocalidadLaRioja.BanadoDeLosPantanos),
                datosEntidadBuilder.Build(2364, LocalidadLaRioja.EstacionMazan),
                datosEntidadBuilder.Build(2365, LocalidadLaRioja.Machigasta),
                datosEntidadBuilder.Build(2366, LocalidadLaRioja.TermasDeSantaTeresita),
                datosEntidadBuilder.Build(2367, LocalidadLaRioja.VillaMazan),
                datosEntidadBuilder.Build(2368, LocalidadLaRioja.Udpinango)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2369, LocalidadLaRioja.LaRioja)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.CastroBarros).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2370, LocalidadLaRioja.AguaBlanca),
                datosEntidadBuilder.Build(2371, LocalidadLaRioja.Aminga),
                datosEntidadBuilder.Build(2372, LocalidadLaRioja.Anillaco),
                datosEntidadBuilder.Build(2373, LocalidadLaRioja.Anjullon),
                datosEntidadBuilder.Build(2374, LocalidadLaRioja.Chuquis),
                datosEntidadBuilder.Build(2375, LocalidadLaRioja.LasPenas),
                datosEntidadBuilder.Build(2376, LocalidadLaRioja.LosMolinos),
                datosEntidadBuilder.Build(2377, LocalidadLaRioja.Pinchas),
                datosEntidadBuilder.Build(2378, LocalidadLaRioja.SanPedro),
                datosEntidadBuilder.Build(2379, LocalidadLaRioja.SantaVeraCruz)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.Chamical).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2380, LocalidadLaRioja.Chamical),
                datosEntidadBuilder.Build(2381, LocalidadLaRioja.Polco),
                datosEntidadBuilder.Build(2382, LocalidadLaRioja.BellaVista),
                datosEntidadBuilder.Build(2383, LocalidadLaRioja.ElRetamo),
                datosEntidadBuilder.Build(2384, LocalidadLaRioja.EsperanzaDeLosCerrillos),
                datosEntidadBuilder.Build(2385, LocalidadLaRioja.EsquinaDelNorte),
                datosEntidadBuilder.Build(2386, LocalidadLaRioja.LaAguadita),
                datosEntidadBuilder.Build(2387, LocalidadLaRioja.SantaBarbara),
                datosEntidadBuilder.Build(2388, LocalidadLaRioja.SantaRitaDeLaZanja)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.Chilecito).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2389, LocalidadLaRioja.Chilecito),
                datosEntidadBuilder.Build(2390, LocalidadLaRioja.Anguinan),
                datosEntidadBuilder.Build(2391, LocalidadLaRioja.LosSarmientos),
                datosEntidadBuilder.Build(2392, LocalidadLaRioja.SanMiguel),
                datosEntidadBuilder.Build(2393, LocalidadLaRioja.LaPuntilla),
                datosEntidadBuilder.Build(2394, LocalidadLaRioja.Nonogasta),
                datosEntidadBuilder.Build(2395, LocalidadLaRioja.Vichigasta),
                datosEntidadBuilder.Build(2396, LocalidadLaRioja.Sanogasta),
                datosEntidadBuilder.Build(2397, LocalidadLaRioja.Malligasta),
                datosEntidadBuilder.Build(2398, LocalidadLaRioja.ColoniaMalligasta),
                datosEntidadBuilder.Build(2399, LocalidadLaRioja.Tilimuqui),
                datosEntidadBuilder.Build(2400, LocalidadLaRioja.ColoniaVichigasta),
                datosEntidadBuilder.Build(2401, LocalidadLaRioja.Miranda),
                datosEntidadBuilder.Build(2402, LocalidadLaRioja.Guanchin),
                datosEntidadBuilder.Build(2403, LocalidadLaRioja.ColoniaAnguinan),
                datosEntidadBuilder.Build(2404, LocalidadLaRioja.SanNicolas),
                datosEntidadBuilder.Build(2405, LocalidadLaRioja.SantaFlorentina),
                datosEntidadBuilder.Build(2406, LocalidadLaRioja.ColoniaCatinzaco),
                datosEntidadBuilder.Build(2407, LocalidadLaRioja.Catinzaco),
                datosEntidadBuilder.Build(2408, LocalidadLaRioja.LaMejicanita)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.CoronelFelipeVarela).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2409, LocalidadLaRioja.Aicuna),
                datosEntidadBuilder.Build(2410, LocalidadLaRioja.BandaFlorida),
                datosEntidadBuilder.Build(2411, LocalidadLaRioja.Guandacol),
                datosEntidadBuilder.Build(2412, LocalidadLaRioja.LosPalacios),
                datosEntidadBuilder.Build(2413, LocalidadLaRioja.LosTambillos),
                datosEntidadBuilder.Build(2414, LocalidadLaRioja.Pagancillo),
                datosEntidadBuilder.Build(2415, LocalidadLaRioja.PuertoAlegre),
                datosEntidadBuilder.Build(2416, LocalidadLaRioja.SantaClara),
                datosEntidadBuilder.Build(2417, LocalidadLaRioja.VillaUnion)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.Famatina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2418, LocalidadLaRioja.Famatina),
                datosEntidadBuilder.Build(2419, LocalidadLaRioja.AltoCarrizal),
                datosEntidadBuilder.Build(2420, LocalidadLaRioja.Angulos),
                datosEntidadBuilder.Build(2421, LocalidadLaRioja.Antinaco),
                datosEntidadBuilder.Build(2422, LocalidadLaRioja.BajoCarrizal),
                datosEntidadBuilder.Build(2423, LocalidadLaRioja.Campanas),
                datosEntidadBuilder.Build(2424, LocalidadLaRioja.Chanarmuyo),
                datosEntidadBuilder.Build(2425, LocalidadLaRioja.ElPotrerillo),
                datosEntidadBuilder.Build(2426, LocalidadLaRioja.LaCuadra),
                datosEntidadBuilder.Build(2427, LocalidadLaRioja.Pituil),
                datosEntidadBuilder.Build(2428, LocalidadLaRioja.PlazaVieja),
                datosEntidadBuilder.Build(2429, LocalidadLaRioja.SantaCruz),
                datosEntidadBuilder.Build(2430, LocalidadLaRioja.SantoDomingo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.GeneralAngelVPenaloza).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2431, LocalidadLaRioja.Alcazar),
                datosEntidadBuilder.Build(2432, LocalidadLaRioja.Carrizal),
                datosEntidadBuilder.Build(2433, LocalidadLaRioja.Chila),
                datosEntidadBuilder.Build(2434, LocalidadLaRioja.Pacatala),
                datosEntidadBuilder.Build(2435, LocalidadLaRioja.Km38),
                datosEntidadBuilder.Build(2436, LocalidadLaRioja.PuestoSantaCruz),
                datosEntidadBuilder.Build(2437, LocalidadLaRioja.PuntaDeLosLlanos),
                datosEntidadBuilder.Build(2438, LocalidadLaRioja.Tama),
                datosEntidadBuilder.Build(2439, LocalidadLaRioja.Tuizon)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.GeneralBelgrano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2440, LocalidadLaRioja.Olta),
                datosEntidadBuilder.Build(2441, LocalidadLaRioja.CastroBarros),
                datosEntidadBuilder.Build(2442, LocalidadLaRioja.Chanar),
                datosEntidadBuilder.Build(2443, LocalidadLaRioja.LomaBlanca),
                datosEntidadBuilder.Build(2444, LocalidadLaRioja.Talva),
                datosEntidadBuilder.Build(2445, LocalidadLaRioja.Cortaderas),
                datosEntidadBuilder.Build(2446, LocalidadLaRioja.Miraflores),
                datosEntidadBuilder.Build(2447, LocalidadLaRioja.MonteGrande),
                datosEntidadBuilder.Build(2448, LocalidadLaRioja.SanRamon),
                datosEntidadBuilder.Build(2449, LocalidadLaRioja.Simbolar),
                datosEntidadBuilder.Build(2450, LocalidadLaRioja.ElCardonal)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.GeneralJuanFacundoQuiroga).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2451, LocalidadLaRioja.Portezuelo),
                datosEntidadBuilder.Build(2452, LocalidadLaRioja.Malanzan),
                datosEntidadBuilder.Build(2453, LocalidadLaRioja.Nacate),
                datosEntidadBuilder.Build(2454, LocalidadLaRioja.SanAntonio),
                datosEntidadBuilder.Build(2455, LocalidadLaRioja.LaChimenea),
                datosEntidadBuilder.Build(2456, LocalidadLaRioja.Solca),
                datosEntidadBuilder.Build(2457, LocalidadLaRioja.ElRetamal),
                datosEntidadBuilder.Build(2458, LocalidadLaRioja.Puluchan),
                datosEntidadBuilder.Build(2459, LocalidadLaRioja.Atiles),
                datosEntidadBuilder.Build(2460, LocalidadLaRioja.LomaLarga),
                datosEntidadBuilder.Build(2461, LocalidadLaRioja.Mascasin),
                datosEntidadBuilder.Build(2462, LocalidadLaRioja.TresCruces),
                datosEntidadBuilder.Build(2463, LocalidadLaRioja.Salana),
                datosEntidadBuilder.Build(2464, LocalidadLaRioja.Tuani),
                datosEntidadBuilder.Build(2465, LocalidadLaRioja.Huaja)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.GeneralLamadrid).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2466, LocalidadLaRioja.VillaCastelli),
                datosEntidadBuilder.Build(2467, LocalidadLaRioja.Aguaditas),
                datosEntidadBuilder.Build(2468, LocalidadLaRioja.ElCondado),
                datosEntidadBuilder.Build(2469, LocalidadLaRioja.LaBanda),
                datosEntidadBuilder.Build(2470, LocalidadLaRioja.LosMoraditos),
                datosEntidadBuilder.Build(2471, LocalidadLaRioja.PastosLargos),
                datosEntidadBuilder.Build(2472, LocalidadLaRioja.Rivadavia),
                datosEntidadBuilder.Build(2473, LocalidadLaRioja.Tiaguas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.GeneralOcampo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2474, LocalidadLaRioja.Ambil),
                datosEntidadBuilder.Build(2475, LocalidadLaRioja.ColoniaOrtizDeOcampo),
                datosEntidadBuilder.Build(2476, LocalidadLaRioja.Milagro),
                datosEntidadBuilder.Build(2477, LocalidadLaRioja.Olpas),
                datosEntidadBuilder.Build(2478, LocalidadLaRioja.VillaSantaRitaDeCatuna),
                datosEntidadBuilder.Build(2479, LocalidadLaRioja.ComandanteLeal),
                datosEntidadBuilder.Build(2480, LocalidadLaRioja.ElFraile),
                datosEntidadBuilder.Build(2481, LocalidadLaRioja.LosAguirres),
                datosEntidadBuilder.Build(2482, LocalidadLaRioja.LosAlanices),
                datosEntidadBuilder.Build(2483, LocalidadLaRioja.EsquinaChica)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.GeneralSanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2484, LocalidadLaRioja.Ulapes),
                datosEntidadBuilder.Build(2485, LocalidadLaRioja.Aguayo),
                datosEntidadBuilder.Build(2486, LocalidadLaRioja.BajoHondo),
                datosEntidadBuilder.Build(2487, LocalidadLaRioja.CorralDeIsaac),
                datosEntidadBuilder.Build(2488, LocalidadLaRioja.CuatroEsquinas),
                datosEntidadBuilder.Build(2489, LocalidadLaRioja.ElCalden),
                datosEntidadBuilder.Build(2490, LocalidadLaRioja.ElCadillo),
                datosEntidadBuilder.Build(2491, LocalidadLaRioja.SanSolano),
                datosEntidadBuilder.Build(2492, LocalidadLaRioja.VillaNidia),
                datosEntidadBuilder.Build(2493, LocalidadLaRioja.ElAbra),
                datosEntidadBuilder.Build(2494, LocalidadLaRioja.LaRepresa),
                datosEntidadBuilder.Build(2495, LocalidadLaRioja.LaRepresita),
                datosEntidadBuilder.Build(2496, LocalidadLaRioja.LasVentanitas),
                datosEntidadBuilder.Build(2497, LocalidadLaRioja.VillaNidia),
                datosEntidadBuilder.Build(2498, LocalidadLaRioja.PozoDePiedra)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.Independencia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2499, LocalidadLaRioja.Amana),
                datosEntidadBuilder.Build(2500, LocalidadLaRioja.LosColorados),
                datosEntidadBuilder.Build(2501, LocalidadLaRioja.Paganzo),
                datosEntidadBuilder.Build(2502, LocalidadLaRioja.Patquia),
                datosEntidadBuilder.Build(2503, LocalidadLaRioja.PatquiaViejo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.RosarioVeraPenaloza).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2504, LocalidadLaRioja.Chepes),
                datosEntidadBuilder.Build(2505, LocalidadLaRioja.DesiderioTello),
                datosEntidadBuilder.Build(2506, LocalidadLaRioja.ElTotoral),
                datosEntidadBuilder.Build(2507, LocalidadLaRioja.VillaCasana),
                datosEntidadBuilder.Build(2508, LocalidadLaRioja.Mascasin),
                datosEntidadBuilder.Build(2509, LocalidadLaRioja.Noqueve),
                datosEntidadBuilder.Build(2510, LocalidadLaRioja.LaCalera),
                datosEntidadBuilder.Build(2511, LocalidadLaRioja.Chelcos),
                datosEntidadBuilder.Build(2512, LocalidadLaRioja.PotrerilloDeLosFlores),
                datosEntidadBuilder.Build(2513, LocalidadLaRioja.ElTala),
                datosEntidadBuilder.Build(2514, LocalidadLaRioja.ValleHermoso),
                datosEntidadBuilder.Build(2515, LocalidadLaRioja.LasToscas),
                datosEntidadBuilder.Build(2516, LocalidadLaRioja.SanIsidro),
                datosEntidadBuilder.Build(2517, LocalidadLaRioja.AguaBlanca),
                datosEntidadBuilder.Build(2518, LocalidadLaRioja.LasJarillas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.SanBlasDeLosSauces).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2519, LocalidadLaRioja.LasPirguas),
                datosEntidadBuilder.Build(2520, LocalidadLaRioja.ElRetiro),
                datosEntidadBuilder.Build(2521, LocalidadLaRioja.Alpasinche),
                datosEntidadBuilder.Build(2522, LocalidadLaRioja.Chaupihuasi),
                datosEntidadBuilder.Build(2523, LocalidadLaRioja.Salicas),
                datosEntidadBuilder.Build(2524, LocalidadLaRioja.SanBlas),
                datosEntidadBuilder.Build(2525, LocalidadLaRioja.LosRobles),
                datosEntidadBuilder.Build(2526, LocalidadLaRioja.LosTalas),
                datosEntidadBuilder.Build(2527, LocalidadLaRioja.Cuipan),
                datosEntidadBuilder.Build(2528, LocalidadLaRioja.Schaqui),
                datosEntidadBuilder.Build(2529, LocalidadLaRioja.Andolucas),
                datosEntidadBuilder.Build(2530, LocalidadLaRioja.Suriyaco),
                datosEntidadBuilder.Build(2531, LocalidadLaRioja.Maican),
                datosEntidadBuilder.Build(2532, LocalidadLaRioja.Amuschina),
                datosEntidadBuilder.Build(2533, LocalidadLaRioja.Tuyubil)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.Sanagasta).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2534, LocalidadLaRioja.VillaSanagasta),
                datosEntidadBuilder.Build(2535, LocalidadLaRioja.AltaGracia),
                datosEntidadBuilder.Build(2536, LocalidadLaRioja.Huaco)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaRioja.Vinchina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2537, LocalidadLaRioja.VillaSanJoseDeVinchina),
                datosEntidadBuilder.Build(2538, LocalidadLaRioja.Jague),
                datosEntidadBuilder.Build(2539, LocalidadLaRioja.PotreroGrande),
                datosEntidadBuilder.Build(2540, LocalidadLaRioja.ValleHermoso),
                datosEntidadBuilder.Build(2541, LocalidadLaRioja.PuntaDeAgua)
            });
        }
    }
}
