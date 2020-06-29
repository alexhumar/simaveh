using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    internal class LocalidadSanLuisFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadSanLuisFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanLuis.Ayacucho).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3374, LocalidadSanLuis.Candelaria),
                datosEntidadBuilder.Build(3375, LocalidadSanLuis.Lujan),
                datosEntidadBuilder.Build(3376, LocalidadSanLuis.Quines),
                datosEntidadBuilder.Build(3377, LocalidadSanLuis.SanFranciscoDelMonteDeOro),
                datosEntidadBuilder.Build(3378, LocalidadSanLuis.LeandroNAlem)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanLuis.Belgrano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3379, LocalidadSanLuis.VillaGeneralRoca),
                datosEntidadBuilder.Build(3380, LocalidadSanLuis.LaCalera),
                datosEntidadBuilder.Build(3381, LocalidadSanLuis.Nogoli),
                datosEntidadBuilder.Build(3382, LocalidadSanLuis.VillaDeLaQuebrada)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanLuis.Chacabuco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3383, LocalidadSanLuis.Concaran),
                datosEntidadBuilder.Build(3384, LocalidadSanLuis.Naschel),
                datosEntidadBuilder.Build(3385, LocalidadSanLuis.Tilisarao),
                datosEntidadBuilder.Build(3386, LocalidadSanLuis.Cortaderas),
                datosEntidadBuilder.Build(3387, LocalidadSanLuis.Papagayos),
                datosEntidadBuilder.Build(3388, LocalidadSanLuis.Renca),
                datosEntidadBuilder.Build(3389, LocalidadSanLuis.SanPablo),
                datosEntidadBuilder.Build(3390, LocalidadSanLuis.VillaDelCarmen),
                datosEntidadBuilder.Build(3391, LocalidadSanLuis.VillaLarca)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanLuis.CoronelPringles).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3392, LocalidadSanLuis.LaToma),
                datosEntidadBuilder.Build(3393, LocalidadSanLuis.Carolina),
                datosEntidadBuilder.Build(3394, LocalidadSanLuis.ElTrapiche),
                datosEntidadBuilder.Build(3395, LocalidadSanLuis.EstanciaGrande)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanLuis.GeneralPedernera).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3396, LocalidadSanLuis.VillaMercedes),
                datosEntidadBuilder.Build(3397, LocalidadSanLuis.JustoDaract),
                datosEntidadBuilder.Build(3398, LocalidadSanLuis.SanJoseDelMorro),
                datosEntidadBuilder.Build(3399, LocalidadSanLuis.JuanJorba),
                datosEntidadBuilder.Build(3400, LocalidadSanLuis.JuanLlerena),
                datosEntidadBuilder.Build(3401, LocalidadSanLuis.LaPunilla),
                datosEntidadBuilder.Build(3402, LocalidadSanLuis.Lavaisse),
                datosEntidadBuilder.Build(3403, LocalidadSanLuis.VillaReynolds)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanLuis.GobernadorDupuy).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3404, LocalidadSanLuis.BuenaEsperanza),
                datosEntidadBuilder.Build(3405, LocalidadSanLuis.Union),
                datosEntidadBuilder.Build(3406, LocalidadSanLuis.Anchorena),
                datosEntidadBuilder.Build(3407, LocalidadSanLuis.Arizona),
                datosEntidadBuilder.Build(3408, LocalidadSanLuis.Bagual),
                datosEntidadBuilder.Build(3409, LocalidadSanLuis.Batavia),
                datosEntidadBuilder.Build(3410, LocalidadSanLuis.FortinElPatria),
                datosEntidadBuilder.Build(3411, LocalidadSanLuis.Fortuna),
                datosEntidadBuilder.Build(3412, LocalidadSanLuis.Navia),
                datosEntidadBuilder.Build(3413, LocalidadSanLuis.NuevaGalia)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanLuis.Junin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3414, LocalidadSanLuis.Merlo),
                datosEntidadBuilder.Build(3415, LocalidadSanLuis.SantaRosaDeConlara),
                datosEntidadBuilder.Build(3416, LocalidadSanLuis.Carpinteria),
                datosEntidadBuilder.Build(3417, LocalidadSanLuis.Lafinur),
                datosEntidadBuilder.Build(3418, LocalidadSanLuis.LosMolles),
                datosEntidadBuilder.Build(3419, LocalidadSanLuis.Talita)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanLuis.JuanMartinDePueyrredon).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3420, LocalidadSanLuis.SanLuis),
                datosEntidadBuilder.Build(3421, LocalidadSanLuis.JuanaKoslay),
                datosEntidadBuilder.Build(3422, LocalidadSanLuis.AltoPelado),
                datosEntidadBuilder.Build(3423, LocalidadSanLuis.AltoPencoso),
                datosEntidadBuilder.Build(3424, LocalidadSanLuis.Balde),
                datosEntidadBuilder.Build(3425, LocalidadSanLuis.Beazley),
                datosEntidadBuilder.Build(3426, LocalidadSanLuis.ElVolcan),
                datosEntidadBuilder.Build(3427, LocalidadSanLuis.LaPunta),
                datosEntidadBuilder.Build(3428, LocalidadSanLuis.PotreroDeLosFunes),
                datosEntidadBuilder.Build(3429, LocalidadSanLuis.SanGeronimo),
                datosEntidadBuilder.Build(3430, LocalidadSanLuis.Zanjitas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanLuis.LibertadorGeneralSanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3431, LocalidadSanLuis.SanMartin),
                datosEntidadBuilder.Build(3432, LocalidadSanLuis.LasAguadas),
                datosEntidadBuilder.Build(3433, LocalidadSanLuis.LasChacras),
                datosEntidadBuilder.Build(3434, LocalidadSanLuis.LasLagunas),
                datosEntidadBuilder.Build(3435, LocalidadSanLuis.LasVertientes),
                datosEntidadBuilder.Build(3436, LocalidadSanLuis.PasoGrande),
                datosEntidadBuilder.Build(3437, LocalidadSanLuis.VillaDePraga)
            });
        }
    }
}
