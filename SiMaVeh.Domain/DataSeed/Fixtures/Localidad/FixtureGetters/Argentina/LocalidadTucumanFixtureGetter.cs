using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    class LocalidadTucumanFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadTucumanFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
            : base(partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Burruyacu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4166, LocalidadTucuman.SietaDeAbril),
                datosEntidadBuilder.Build(4167, LocalidadTucuman.BarrioSanJorge),
                datosEntidadBuilder.Build(4168, LocalidadTucuman.ElChanar),
                datosEntidadBuilder.Build(4169, LocalidadTucuman.ElNaranjo),
                datosEntidadBuilder.Build(4170, LocalidadTucuman.GobernadorGarmendia),
                datosEntidadBuilder.Build(4171, LocalidadTucuman.LaRamada),
                datosEntidadBuilder.Build(4172, LocalidadTucuman.SanJoseDeMacomitas),
                datosEntidadBuilder.Build(4173, LocalidadTucuman.Piedrabuena),
                datosEntidadBuilder.Build(4174, LocalidadTucuman.VillaPadreMonti),
                datosEntidadBuilder.Build(4175, LocalidadTucuman.VillaBenjaminAraoz),
                datosEntidadBuilder.Build(4176, LocalidadTucuman.Burruyacu)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4177, LocalidadTucuman.SanMiguelDeTucuman)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Chicligasta).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4178, LocalidadTucuman.Concepcion),
                datosEntidadBuilder.Build(4179, LocalidadTucuman.AlpachiriYElMolino),
                datosEntidadBuilder.Build(4180, LocalidadTucuman.AltoVerdeYLosGucheas),
                datosEntidadBuilder.Build(4181, LocalidadTucuman.Arcadia),
                datosEntidadBuilder.Build(4182, LocalidadTucuman.GastonaYBelicha),
                datosEntidadBuilder.Build(4183, LocalidadTucuman.IngenioLaTrinidad),
                datosEntidadBuilder.Build(4184, LocalidadTucuman.Medinas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.CruzAlta).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4185, LocalidadTucuman.BandaDelRioSali),
                datosEntidadBuilder.Build(4186, LocalidadTucuman.Alderetes),
                datosEntidadBuilder.Build(4187, LocalidadTucuman.Colombres),
                datosEntidadBuilder.Build(4188, LocalidadTucuman.DelfinGallo),
                datosEntidadBuilder.Build(4189, LocalidadTucuman.ElBrachoYElCevilar),
                datosEntidadBuilder.Build(4190, LocalidadTucuman.ElNaranjito),
                datosEntidadBuilder.Build(4191, LocalidadTucuman.LaFloridaYLuisiana),
                datosEntidadBuilder.Build(4192, LocalidadTucuman.LasCejas),
                datosEntidadBuilder.Build(4193, LocalidadTucuman.LosBulacioYLosVillagra),
                datosEntidadBuilder.Build(4194, LocalidadTucuman.LosPereyras),
                datosEntidadBuilder.Build(4195, LocalidadTucuman.LosPerez),
                datosEntidadBuilder.Build(4196, LocalidadTucuman.LosRalos),
                datosEntidadBuilder.Build(4197, LocalidadTucuman.RanchillosYSanMiguel),
                datosEntidadBuilder.Build(4198, LocalidadTucuman.SanAndres)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Famailla).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4199, LocalidadTucuman.Famailla)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Graneros).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4200, LocalidadTucuman.Graneros),
                datosEntidadBuilder.Build(4201, LocalidadTucuman.Lamadrid),
                datosEntidadBuilder.Build(4202, LocalidadTucuman.TacoRalo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.JuanBautistaAlberdi).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4203, LocalidadTucuman.JuanBautistaAlberdi),
                datosEntidadBuilder.Build(4204, LocalidadTucuman.CiudadAlberdi),
                datosEntidadBuilder.Build(4205, LocalidadTucuman.Escaba),
                datosEntidadBuilder.Build(4206, LocalidadTucuman.VillaBelgrano)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.LaCocha).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4207, LocalidadTucuman.LaCocha),
                datosEntidadBuilder.Build(4208, LocalidadTucuman.ElSacrificio),
                datosEntidadBuilder.Build(4209, LocalidadTucuman.HuasaPampa),
                datosEntidadBuilder.Build(4210, LocalidadTucuman.RumiPunco),
                datosEntidadBuilder.Build(4211, LocalidadTucuman.SanIgnacio),
                datosEntidadBuilder.Build(4212, LocalidadTucuman.SanJoseDeLaCocha),
                datosEntidadBuilder.Build(4213, LocalidadTucuman.Yanima)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Leales).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4214, LocalidadTucuman.BellaVista),
                datosEntidadBuilder.Build(4215, LocalidadTucuman.AguaDulceYLaSoledad),
                datosEntidadBuilder.Build(4216, LocalidadTucuman.ElMojon),
                datosEntidadBuilder.Build(4217, LocalidadTucuman.EsquinaYMancopa),
                datosEntidadBuilder.Build(4218, LocalidadTucuman.EstacionAraoz),
                datosEntidadBuilder.Build(4219, LocalidadTucuman.Tacanas),
                datosEntidadBuilder.Build(4220, LocalidadTucuman.LasTalas),
                datosEntidadBuilder.Build(4221, LocalidadTucuman.LosGomez),
                datosEntidadBuilder.Build(4222, LocalidadTucuman.LosPuestos),
                datosEntidadBuilder.Build(4223, LocalidadTucuman.ManuelGarciaFernandez),
                datosEntidadBuilder.Build(4224, LocalidadTucuman.QuilmesYLosSueldos),
                datosEntidadBuilder.Build(4225, LocalidadTucuman.RioColorado),
                datosEntidadBuilder.Build(4226, LocalidadTucuman.SantaRosaDeLeales),
                datosEntidadBuilder.Build(4227, LocalidadTucuman.VillaDeLeales)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Lules).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4228, LocalidadTucuman.Lules),
                datosEntidadBuilder.Build(4229, LocalidadTucuman.ElManantial),
                datosEntidadBuilder.Build(4230, LocalidadTucuman.SanFelipe),
                datosEntidadBuilder.Build(4231, LocalidadTucuman.SantaBarbara),
                datosEntidadBuilder.Build(4232, LocalidadTucuman.SanPablo),
                datosEntidadBuilder.Build(4233, LocalidadTucuman.VillaNougues)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Monteros).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4234, LocalidadTucuman.Monteros),
                datosEntidadBuilder.Build(4235, LocalidadTucuman.Acheral),
                datosEntidadBuilder.Build(4236, LocalidadTucuman.Amberes),
                datosEntidadBuilder.Build(4237, LocalidadTucuman.CapitanCaceres),
                datosEntidadBuilder.Build(4238, LocalidadTucuman.ElCercado),
                datosEntidadBuilder.Build(4239, LocalidadTucuman.LosSosas),
                datosEntidadBuilder.Build(4240, LocalidadTucuman.RioSeco),
                datosEntidadBuilder.Build(4241, LocalidadTucuman.SantaLucia),
                datosEntidadBuilder.Build(4242, LocalidadTucuman.SantaRosaYLosRojo),
                datosEntidadBuilder.Build(4243, LocalidadTucuman.SargentoMoya),
                datosEntidadBuilder.Build(4244, LocalidadTucuman.SoldadoMaldonado),
                datosEntidadBuilder.Build(4245, LocalidadTucuman.TenienteBerdina),
                datosEntidadBuilder.Build(4246, LocalidadTucuman.VillaQuinteros)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.RioChico).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4247, LocalidadTucuman.Aguilares),
                datosEntidadBuilder.Build(4248, LocalidadTucuman.IngenioSantaBarbara),
                datosEntidadBuilder.Build(4249, LocalidadTucuman.LosSarmientos),
                datosEntidadBuilder.Build(4250, LocalidadTucuman.RioChico),
                datosEntidadBuilder.Build(4251, LocalidadTucuman.SantaAna),
                datosEntidadBuilder.Build(4252, LocalidadTucuman.VillaClodomiroHileret)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Simoca).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4253, LocalidadTucuman.Simoca),
                datosEntidadBuilder.Build(4254, LocalidadTucuman.Atahona),
                datosEntidadBuilder.Build(4255, LocalidadTucuman.BuenaVista),
                datosEntidadBuilder.Build(4256, LocalidadTucuman.Ciudacita),
                datosEntidadBuilder.Build(4257, LocalidadTucuman.ManuelaPedraza),
                datosEntidadBuilder.Build(4258, LocalidadTucuman.Monteagudo),
                datosEntidadBuilder.Build(4259, LocalidadTucuman.PampaMayo),
                datosEntidadBuilder.Build(4260, LocalidadTucuman.RioChicoYNuevaTrinidad),
                datosEntidadBuilder.Build(4261, LocalidadTucuman.SanPedroYSanAntonio),
                datosEntidadBuilder.Build(4262, LocalidadTucuman.SantaCruzYLaTuna),
                datosEntidadBuilder.Build(4263, LocalidadTucuman.VillaChicligasta),
                datosEntidadBuilder.Build(4264, LocalidadTucuman.YerbaBuena)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.TafiDelValle).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4265, LocalidadTucuman.TafiDelValle),
                datosEntidadBuilder.Build(4266, LocalidadTucuman.AmaichaDelValle),
                datosEntidadBuilder.Build(4267, LocalidadTucuman.ColalaoDelValle),
                datosEntidadBuilder.Build(4268, LocalidadTucuman.ElMollar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.TafiViejo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4269, LocalidadTucuman.TafiViejo),
                datosEntidadBuilder.Build(4270, LocalidadTucuman.LasTalitas),
                datosEntidadBuilder.Build(4271, LocalidadTucuman.AncaJuli),
                datosEntidadBuilder.Build(4272, LocalidadTucuman.ElCadillal),
                datosEntidadBuilder.Build(4273, LocalidadTucuman.LaEsperanza),
                datosEntidadBuilder.Build(4274, LocalidadTucuman.LosNogales),
                datosEntidadBuilder.Build(4275, LocalidadTucuman.Raco),
                datosEntidadBuilder.Build(4276, LocalidadTucuman.LosPocitos),
                datosEntidadBuilder.Build(4277, LocalidadTucuman.LomasDeTafi)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.Trancas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4278, LocalidadTucuman.Trancas),
                datosEntidadBuilder.Build(4279, LocalidadTucuman.Choromoro),
                datosEntidadBuilder.Build(4280, LocalidadTucuman.SanPedroDeColalao),
                datosEntidadBuilder.Build(4281, LocalidadTucuman.Tapia)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoTucuman.YerbaBuena).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4282, LocalidadTucuman.YerbaBuena),
                datosEntidadBuilder.Build(4283, LocalidadTucuman.SanJavier),
                datosEntidadBuilder.Build(4284, LocalidadTucuman.CebilRedondo)
            });
        }
    }
}
