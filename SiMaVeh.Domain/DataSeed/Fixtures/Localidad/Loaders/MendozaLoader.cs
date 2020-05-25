using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class MendozaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public MendozaLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.Capital).Value.Key, new Dictionary<long, string>
            {
                { 2542, LocalidadMendoza.Mendoza }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.GeneralAlvear).Value.Key, new Dictionary<long, string>
            {
                { 2543, LocalidadMendoza.Canalejas },
                { 2544, LocalidadMendoza.Carmensa },
                { 2545, LocalidadMendoza.Cochico },
                { 2546, LocalidadMendoza.CorralDeLorca },
                { 2547, LocalidadMendoza.ElCeibo },
                { 2548, LocalidadMendoza.ElJuncalito },
                { 2549, LocalidadMendoza.GeneralAlvear },
                { 2550, LocalidadMendoza.GasparCampos },
                { 2551, LocalidadMendoza.Goico },
                { 2552, LocalidadMendoza.LaEscandinava },
                { 2553, LocalidadMendoza.LaMora },
                { 2554, LocalidadMendoza.LineaDePoste },
                { 2555, LocalidadMendoza.LosCampamentos },
                { 2556, LocalidadMendoza.LosCompartos },
                { 2557, LocalidadMendoza.MediaLuna },
                { 2558, LocalidadMendoza.Ovejeria },
                { 2559, LocalidadMendoza.PampaDelTigre },
                { 2560, LocalidadMendoza.PosteDeHierro },
                { 2561, LocalidadMendoza.ElNevado },
                { 2562, LocalidadMendoza.ElDesvio },
                { 2563, LocalidadMendoza.Bowen }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.GodoyCruz).Value.Key, new Dictionary<long, string>
            {
                { 2564, LocalidadMendoza.GobernadorBenegas },
                { 2565, LocalidadMendoza.GodoyCruz },
                { 2566, LocalidadMendoza.LasTortugas },
                { 2567, LocalidadMendoza.PresidenteSarmiento },
                { 2568, LocalidadMendoza.SanFranciscoDelMonte },
                { 2569, LocalidadMendoza.SanVicente }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.Guaymallen).Value.Key, new Dictionary<long, string>
            {
                { 2570, LocalidadMendoza.Belgrano },
                { 2571, LocalidadMendoza.ElBermejo },
                { 2572, LocalidadMendoza.BuenaNueva },
                { 2573, LocalidadMendoza.CapillaDelRosario },
                { 2574, LocalidadMendoza.ColoniaMolina },
                { 2575, LocalidadMendoza.ColoniaSegovia },
                { 2576, LocalidadMendoza.Dorrego },
                { 2577, LocalidadMendoza.ElSauce },
                { 2578, LocalidadMendoza.Guaymallen },
                { 2579, LocalidadMendoza.JesusNazareno },
                { 2580, LocalidadMendoza.Kilometro8 },
                { 2581, LocalidadMendoza.Kilometro11 },
                { 2582, LocalidadMendoza.LaPrimavera },
                { 2583, LocalidadMendoza.LasCanas },
                { 2584, LocalidadMendoza.LosCorralitos },
                { 2585, LocalidadMendoza.NuevaCiudad },
                { 2586, LocalidadMendoza.PedroMolina },
                { 2587, LocalidadMendoza.PuenteDeHierro },
                { 2588, LocalidadMendoza.RodeoDeLaCruz },
                { 2589, LocalidadMendoza.SanFranciscoDelMonte },
                { 2590, LocalidadMendoza.SanJose },
                { 2591, LocalidadMendoza.VillaNueva }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.Junin).Value.Key, new Dictionary<long, string>
            {
                { 2592, LocalidadMendoza.AlgarroboGrande },
                { 2593, LocalidadMendoza.AltoVerde },
                { 2594, LocalidadMendoza.Ciudad },
                { 2595, LocalidadMendoza.IngenieroGiagnoni },
                { 2596, LocalidadMendoza.LaColonia },
                { 2597, LocalidadMendoza.LosBarriales },
                { 2598, LocalidadMendoza.Medrano },
                { 2599, LocalidadMendoza.MundoNuevo },
                { 2600, LocalidadMendoza.Phillips },
                { 2601, LocalidadMendoza.RodriguezPena }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.LaPaz).Value.Key, new Dictionary<long, string>
            {
                { 2602, LocalidadMendoza.Desaguadero },
                { 2603, LocalidadMendoza.LaPazNorte },
                { 2604, LocalidadMendoza.LaPazSur },
                { 2605, LocalidadMendoza.VillaAntigua },
                { 2606, LocalidadMendoza.VillaCabecera }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.LasHeras).Value.Key, new Dictionary<long, string>
            {
                { 2607, LocalidadMendoza.Capdevilla },
                { 2608, LocalidadMendoza.LaCieneguita },
                { 2609, LocalidadMendoza.ElAlgarrobal },
                { 2610, LocalidadMendoza.ElBorbollon },
                { 2611, LocalidadMendoza.ElChallao },
                { 2612, LocalidadMendoza.ElPastal },
                { 2613, LocalidadMendoza.ElPlumerillo },
                { 2614, LocalidadMendoza.ElResguardo },
                { 2615, LocalidadMendoza.ElZapallar },
                { 2616, LocalidadMendoza.LasCuevas },
                { 2617, LocalidadMendoza.LasHeras },
                { 2618, LocalidadMendoza.Panquehua },
                { 2619, LocalidadMendoza.UspallataYAltaMontana }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.Lavalle).Value.Key, new Dictionary<long, string>
            {
                { 2620, LocalidadMendoza.CostaDeAraujo },
                { 2621, LocalidadMendoza.ElCarmen },
                { 2622, LocalidadMendoza.ElChilcal },
                { 2623, LocalidadMendoza.ElPlumero },
                { 2624, LocalidadMendoza.ElVergel },
                { 2625, LocalidadMendoza.GustavoAndre },
                { 2626, LocalidadMendoza.Jocoli },
                { 2627, LocalidadMendoza.JocoliViejo },
                { 2628, LocalidadMendoza.LaAsuncion },
                { 2629, LocalidadMendoza.LaHolanda },
                { 2630, LocalidadMendoza.LaPalmera },
                { 2631, LocalidadMendoza.LaPega },
                { 2632, LocalidadMendoza.LasVioletas },
                { 2633, LocalidadMendoza.LagunasDelRosario },
                { 2634, LocalidadMendoza.Paramillo },
                { 2635, LocalidadMendoza.SanFrancisco },
                { 2636, LocalidadMendoza.SanJose },
                { 2637, LocalidadMendoza.SanMiguel },
                { 2638, LocalidadMendoza.TresDeMayo },
                { 2639, LocalidadMendoza.VillaTulumaya },
                { 2640, LocalidadMendoza.OscarMendoza }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.LujanDeCuyo).Value.Key, new Dictionary<long, string>
            {
                { 2641, LocalidadMendoza.Agrelo },
                { 2642, LocalidadMendoza.Cacheuta },
                { 2643, LocalidadMendoza.Carrodilla },
                { 2644, LocalidadMendoza.ChacrasDeCoria },
                { 2645, LocalidadMendoza.ElCarrizal },
                { 2646, LocalidadMendoza.Industrial },
                { 2647, LocalidadMendoza.LaPuntilla },
                { 2648, LocalidadMendoza.LasCompuertas },
                { 2649, LocalidadMendoza.LujanDeCuyo },
                { 2650, LocalidadMendoza.MayorDrummond },
                { 2651, LocalidadMendoza.Perdriel },
                { 2652, LocalidadMendoza.Potrerillos },
                { 2653, LocalidadMendoza.Ugarteche },
                { 2654, LocalidadMendoza.Vistalba },
                { 2655, LocalidadMendoza.VertientesDelPedemonte }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.Maipu).Value.Key, new Dictionary<long, string>
            {
                { 2656, LocalidadMendoza.Coquimbito },
                { 2657, LocalidadMendoza.CruzDePiedra },
                { 2658, LocalidadMendoza.FrayLuisBeltran },
                { 2659, LocalidadMendoza.GeneralGutierrez },
                { 2660, LocalidadMendoza.GeneralOrtega },
                { 2661, LocalidadMendoza.Barrancas },
                { 2662, LocalidadMendoza.Lunlunta },
                { 2663, LocalidadMendoza.Luzuriaga },
                { 2664, LocalidadMendoza.Maipu },
                { 2665, LocalidadMendoza.RodeoDelMedio },
                { 2666, LocalidadMendoza.Russell },
                { 2667, LocalidadMendoza.SanRoque }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.Malargue).Value.Key, new Dictionary<long, string>
            {
                { 2668, LocalidadMendoza.AguaEscondida },
                { 2669, LocalidadMendoza.Malargue },
                { 2670, LocalidadMendoza.RioBarrancas },
                { 2671, LocalidadMendoza.RioGrande }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.Rivadavia).Value.Key, new Dictionary<long, string>
            {
                { 2672, LocalidadMendoza.Andrade },
                { 2673, LocalidadMendoza.ElMirador },
                { 2674, LocalidadMendoza.LaCentral },
                { 2675, LocalidadMendoza.LaLibertad },
                { 2676, LocalidadMendoza.LosArboles },
                { 2677, LocalidadMendoza.LosCampamentos },
                { 2678, LocalidadMendoza.LosHuarpes },
                { 2679, LocalidadMendoza.Medrano },
                { 2680, LocalidadMendoza.MundoNuevo },
                { 2681, LocalidadMendoza.Reduccion },
                { 2682, LocalidadMendoza.Rivadavia },
                { 2683, LocalidadMendoza.SantaMariaDeOro },
                { 2684, LocalidadMendoza.SanIsidro }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.SanCarlos).Value.Key, new Dictionary<long, string>
            {
                { 2685, LocalidadMendoza.Chilecito },
                { 2686, LocalidadMendoza.EugenioBustos },
                { 2687, LocalidadMendoza.LaConsulta },
                { 2688, LocalidadMendoza.Pareditas },
                { 2689, LocalidadMendoza.TresEsquinas },
                { 2690, LocalidadMendoza.VillaDeSanCarlos }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.GeneralSanMartin).Value.Key, new Dictionary<long, string>
            {
                { 2691, LocalidadMendoza.AltoSalvador },
                { 2692, LocalidadMendoza.AltoVerde },
                { 2693, LocalidadMendoza.BuenOrden },
                { 2694, LocalidadMendoza.Chapanay },
                { 2695, LocalidadMendoza.Chivilcoy },
                { 2696, LocalidadMendoza.ElCentral },
                { 2697, LocalidadMendoza.ElDivisadero },
                { 2698, LocalidadMendoza.ElEspino },
                { 2699, LocalidadMendoza.ElRamblon },
                { 2700, LocalidadMendoza.IngenieroGiagnoni },
                { 2701, LocalidadMendoza.LasChimbas },
                { 2702, LocalidadMendoza.Montecaseros },
                { 2703, LocalidadMendoza.NuevaCalifornia },
                { 2704, LocalidadMendoza.Palmira },
                { 2705, LocalidadMendoza.SanMartin },
                { 2706, LocalidadMendoza.TresPortenas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.SanRafael).Value.Key, new Dictionary<long, string>
            {
                { 2707, LocalidadMendoza.CanadaSeca },
                { 2708, LocalidadMendoza.CuadroBenegas },
                { 2709, LocalidadMendoza.CuadroNacional },
                { 2710, LocalidadMendoza.ElCerrito },
                { 2711, LocalidadMendoza.ElSosneado },
                { 2712, LocalidadMendoza.ElNihuil },
                { 2713, LocalidadMendoza.Goudge },
                { 2714, LocalidadMendoza.JaimePrats },
                { 2715, LocalidadMendoza.LaLlave },
                { 2716, LocalidadMendoza.LasMalvinas },
                { 2717, LocalidadMendoza.LasParedes },
                { 2718, LocalidadMendoza.MonteComan },
                { 2719, LocalidadMendoza.PuntaDelAgua },
                { 2720, LocalidadMendoza.RamaCaida },
                { 2721, LocalidadMendoza.RealDelPadre },
                { 2722, LocalidadMendoza.SanRafael },
                { 2723, LocalidadMendoza.VillaVeinticincoDeMayo },
                { 2724, LocalidadMendoza.VillaAtuel }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.SantaRosa).Value.Key, new Dictionary<long, string>
            {
                { 2725, LocalidadMendoza.DoceDeOctubre },
                { 2726, LocalidadMendoza.LaDormida },
                { 2727, LocalidadMendoza.LasCatitas },
                { 2728, LocalidadMendoza.Nacunan },
                { 2729, LocalidadMendoza.SantaRosa }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.Tunuyan).Value.Key, new Dictionary<long, string>
            {
                { 2730, LocalidadMendoza.CampoDeLosAndes },
                { 2731, LocalidadMendoza.ColoniaLasRosas },
                { 2732, LocalidadMendoza.ElAlgarrobo },
                { 2733, LocalidadMendoza.ElTotoral },
                { 2734, LocalidadMendoza.LaPrimavera },
                { 2735, LocalidadMendoza.LasPintadas },
                { 2736, LocalidadMendoza.LosArboles },
                { 2737, LocalidadMendoza.LosChacayes },
                { 2738, LocalidadMendoza.LosSauces },
                { 2739, LocalidadMendoza.Tunuyan },
                { 2740, LocalidadMendoza.VillaSeca },
                { 2741, LocalidadMendoza.VistaFlores }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMendoza.Tupungato).Value.Key, new Dictionary<long, string>
            {
                { 2742, LocalidadMendoza.Anchoris },
                { 2743, LocalidadMendoza.CordonDelPlata },
                { 2744, LocalidadMendoza.ElPeral },
                { 2745, LocalidadMendoza.ElZampal },
                { 2746, LocalidadMendoza.ElZampalito },
                { 2747, LocalidadMendoza.Gualtallary },
                { 2748, LocalidadMendoza.LaArboleda },
                { 2749, LocalidadMendoza.LaCarrera },
                { 2750, LocalidadMendoza.SanJose },
                { 2751, LocalidadMendoza.SantaClara },
                { 2752, LocalidadMendoza.Tupungato },
                { 2753, LocalidadMendoza.VillaBastias },
                { 2754, LocalidadMendoza.Zapata }
            });
        }
    }
}
