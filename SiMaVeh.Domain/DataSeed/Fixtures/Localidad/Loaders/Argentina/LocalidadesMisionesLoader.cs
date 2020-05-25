using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesMisionesLoader : LocalidadesLoader
    {
        public LocalidadesMisionesLoader(IPartidosLoader<long, long, string> partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Apostoles).Key, new Dictionary<long, string>
            {
                { 2755, LocalidadMisiones.Apostoles },
                { 2756, LocalidadMisiones.Azara },
                { 2757, LocalidadMisiones.SanJose },
                { 2758, LocalidadMisiones.TresCapones }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Cainguas).Key, new Dictionary<long, string>
            {
                { 2759, LocalidadMisiones.AristobuloDelValle },
                { 2760, LocalidadMisiones.DosDeMayo },
                { 2761, LocalidadMisiones.CampoGrande }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Candelaria).Key, new Dictionary<long, string>
            {
                { 2762, LocalidadMisiones.Bonpland },
                { 2763, LocalidadMisiones.Candelaria },
                { 2764, LocalidadMisiones.CerroCora },
                { 2765, LocalidadMisiones.Loreto },
                { 2766, LocalidadMisiones.Martires },
                { 2767, LocalidadMisiones.Profundidad },
                { 2768, LocalidadMisiones.SantaAna }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Capital).Key, new Dictionary<long, string>
            {
                { 2769, LocalidadMisiones.Posadas },
                { 2770, LocalidadMisiones.Garupa },
                { 2771, LocalidadMisiones.Fachinal }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Concepcion).Key, new Dictionary<long, string>
            {
                { 2772, LocalidadMisiones.ConcepcionDeLaSierra },
                { 2773, LocalidadMisiones.SantaMaria }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Eldorado).Key, new Dictionary<long, string>
            {
                { 2774, LocalidadMisiones.ColoniaDelicia },
                { 2775, LocalidadMisiones.ColoniaVictoria },
                { 2776, LocalidadMisiones.Eldorado },
                { 2777, LocalidadMisiones.NueveDeJulio },
                { 2778, LocalidadMisiones.SantiagoDeLiniers }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.GeneralManuelBelgrano).Key, new Dictionary<long, string>
            {
                { 2779, LocalidadMisiones.BernardoDeIrigoyen },
                { 2780, LocalidadMisiones.ComandanteAndresito },
                { 2781, LocalidadMisiones.SanAntonio }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Guarani).Key, new Dictionary<long, string>
            {
                { 2782, LocalidadMisiones.ElSoberbio },
                { 2783, LocalidadMisiones.SanVicente }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Iguazu).Key, new Dictionary<long, string>
            {
                { 2784, LocalidadMisiones.Wanda },
                { 2785, LocalidadMisiones.PuertoEsperanza },
                { 2786, LocalidadMisiones.PuertoIguazu },
                { 2787, LocalidadMisiones.PuertoLibertad }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.LeandroNAlem).Key, new Dictionary<long, string>
            {
                { 2788, LocalidadMisiones.Almafuerte },
                { 2789, LocalidadMisiones.ArroyoDelMedio },
                { 2790, LocalidadMisiones.CaaYari },
                { 2791, LocalidadMisiones.CerroAzul },
                { 2792, LocalidadMisiones.DosArroyos },
                { 2793, LocalidadMisiones.GobernadorLopez },
                { 2794, LocalidadMisiones.LeandroNAlem },
                { 2795, LocalidadMisiones.OlegarioVictorAndrade }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.LibertadorGeneralSanMartin).Key, new Dictionary<long, string>
            {
                { 2796, LocalidadMisiones.Capiovi },
                { 2797, LocalidadMisiones.ElAlcazar },
                { 2798, LocalidadMisiones.Garuhape },
                { 2799, LocalidadMisiones.PuertoLeoni },
                { 2800, LocalidadMisiones.PuertoRico },
                { 2801, LocalidadMisiones.RuizDeMontoya }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Montecarlo).Key, new Dictionary<long, string>
            {
                { 2802, LocalidadMisiones.Caraguatay },
                { 2803, LocalidadMisiones.Montecarlo },
                { 2804, LocalidadMisiones.PuertoPiray }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.Obera).Key, new Dictionary<long, string>
            {
                { 2805, LocalidadMisiones.CampoRamon },
                { 2806, LocalidadMisiones.CampoViera },
                { 2807, LocalidadMisiones.ColoniaAlberdi },
                { 2808, LocalidadMisiones.GeneralAlvear },
                { 2809, LocalidadMisiones.Guarani },
                { 2810, LocalidadMisiones.LosHelechos },
                { 2811, LocalidadMisiones.Obera },
                { 2812, LocalidadMisiones.Panambi },
                { 2813, LocalidadMisiones.SanMartin }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.SanIgnacio).Key, new Dictionary<long, string>
            {
                { 2814, LocalidadMisiones.ColoniaPolana },
                { 2815, LocalidadMisiones.Corpus },
                { 2816, LocalidadMisiones.GeneralUrquiza },
                { 2817, LocalidadMisiones.GobernadorRoca },
                { 2818, LocalidadMisiones.HipolitoYrigoyen },
                { 2819, LocalidadMisiones.JardinAmerica },
                { 2820, LocalidadMisiones.SanIgnacio },
                { 2821, LocalidadMisiones.SantoPipo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.SanJavier).Key, new Dictionary<long, string>
            {
                { 2822, LocalidadMisiones.FlorentinoAmeghino },
                { 2823, LocalidadMisiones.Itacaruare },
                { 2824, LocalidadMisiones.MojonGrande },
                { 2825, LocalidadMisiones.SanJavier }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.SanPedro).Key, new Dictionary<long, string>
            {
                { 2826, LocalidadMisiones.SanPedro }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoMisiones.VeinticincoDeMayo).Key, new Dictionary<long, string>
            {
                { 2827, LocalidadMisiones.AlbaPosse },
                { 2828, LocalidadMisiones.ColoniaAurora },
                { 2829, LocalidadMisiones.VeinticincoDeMayo }
            });
        }
    }
}
