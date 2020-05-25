using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class SanLuisLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public SanLuisLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanLuis.Ayacucho).Value.Key, new Dictionary<long, string>
            {
                { 3374, LocalidadSanLuis.Candelaria },
                { 3375, LocalidadSanLuis.Lujan },
                { 3376, LocalidadSanLuis.Quines },
                { 3377, LocalidadSanLuis.SanFranciscoDelMonteDeOro },
                { 3378, LocalidadSanLuis.LeandroNAlem }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanLuis.Belgrano).Value.Key, new Dictionary<long, string>
            {
                { 3379, LocalidadSanLuis.VillaGeneralRoca },
                { 3380, LocalidadSanLuis.LaCalera },
                { 3381, LocalidadSanLuis.Nogoli },
                { 3382, LocalidadSanLuis.VillaDeLaQuebrada }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanLuis.Chacabuco).Value.Key, new Dictionary<long, string>
            {
                { 3383, LocalidadSanLuis.Concaran },
                { 3384, LocalidadSanLuis.Naschel },
                { 3385, LocalidadSanLuis.Tilisarao },
                { 3386, LocalidadSanLuis.Cortaderas },
                { 3387, LocalidadSanLuis.Papagayos },
                { 3388, LocalidadSanLuis.Renca },
                { 3389, LocalidadSanLuis.SanPablo },
                { 3390, LocalidadSanLuis.VillaDelCarmen },
                { 3391, LocalidadSanLuis.VillaLarca }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanLuis.CoronelPringles).Value.Key, new Dictionary<long, string>
            {
                { 3392, LocalidadSanLuis.LaToma },
                { 3393, LocalidadSanLuis.Carolina },
                { 3394, LocalidadSanLuis.ElTrapiche },
                { 3395, LocalidadSanLuis.EstanciaGrande }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanLuis.GeneralPedernera).Value.Key, new Dictionary<long, string>
            {
                { 3396, LocalidadSanLuis.VillaMercedes },
                { 3397, LocalidadSanLuis.JustoDaract },
                { 3398, LocalidadSanLuis.SanJoseDelMorro },
                { 3399, LocalidadSanLuis.JuanJorba },
                { 3400, LocalidadSanLuis.JuanLlerena },
                { 3401, LocalidadSanLuis.LaPunilla },
                { 3402, LocalidadSanLuis.Lavaisse },
                { 3403, LocalidadSanLuis.VillaReynolds }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanLuis.GobernadorDupuy).Value.Key, new Dictionary<long, string>
            {
                { 3404, LocalidadSanLuis.BuenaEsperanza },
                { 3405, LocalidadSanLuis.Union },
                { 3406, LocalidadSanLuis.Anchorena },
                { 3407, LocalidadSanLuis.Arizona },
                { 3408, LocalidadSanLuis.Bagual },
                { 3409, LocalidadSanLuis.Batavia },
                { 3410, LocalidadSanLuis.FortinElPatria },
                { 3411, LocalidadSanLuis.Fortuna },
                { 3412, LocalidadSanLuis.Navia },
                { 3413, LocalidadSanLuis.NuevaGalia }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanLuis.Junin).Value.Key, new Dictionary<long, string>
            {
                { 3414, LocalidadSanLuis.Merlo },
                { 3415, LocalidadSanLuis.SantaRosaDeConlara },
                { 3416, LocalidadSanLuis.Carpinteria },
                { 3417, LocalidadSanLuis.Lafinur },
                { 3418, LocalidadSanLuis.LosMolles },
                { 3419, LocalidadSanLuis.Talita }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanLuis.JuanMartinDePueyrredon).Value.Key, new Dictionary<long, string>
            {
                { 3420, LocalidadSanLuis.SanLuis },
                { 3421, LocalidadSanLuis.JuanaKoslay },
                { 3422, LocalidadSanLuis.AltoPelado },
                { 3423, LocalidadSanLuis.AltoPencoso },
                { 3424, LocalidadSanLuis.Balde },
                { 3425, LocalidadSanLuis.Beazley },
                { 3426, LocalidadSanLuis.ElVolcan },
                { 3427, LocalidadSanLuis.LaPunta },
                { 3428, LocalidadSanLuis.PotreroDeLosFunes },
                { 3429, LocalidadSanLuis.SanGeronimo },
                { 3430, LocalidadSanLuis.Zanjitas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSanLuis.LibertadorGeneralSanMartin).Value.Key, new Dictionary<long, string>
            {
                { 3431, LocalidadSanLuis.SanMartin },
                { 3432, LocalidadSanLuis.LasAguadas },
                { 3433, LocalidadSanLuis.LasChacras },
                { 3434, LocalidadSanLuis.LasLagunas },
                { 3435, LocalidadSanLuis.LasVertientes },
                { 3436, LocalidadSanLuis.PasoGrande },
                { 3437, LocalidadSanLuis.VillaDePraga }
            });
        }
    }
}
