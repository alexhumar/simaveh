using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class TucumanLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public TucumanLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Burruyacu).Value.Key, new Dictionary<long, string>
            {
                { 4166, LocalidadTucuman.SietaDeAbril },
                { 4167, LocalidadTucuman.BarrioSanJorge },
                { 4168, LocalidadTucuman.ElChanar },
                { 4169, LocalidadTucuman.ElNaranjo },
                { 4170, LocalidadTucuman.GobernadorGarmendia },
                { 4171, LocalidadTucuman.LaRamada },
                { 4172, LocalidadTucuman.SanJoseDeMacomitas },
                { 4173, LocalidadTucuman.Piedrabuena },
                { 4174, LocalidadTucuman.VillaPadreMonti },
                { 4175, LocalidadTucuman.VillaBenjaminAraoz },
                { 4176, LocalidadTucuman.Burruyacu }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Capital).Value.Key, new Dictionary<long, string>
            {
                { 4177, LocalidadTucuman.SanMiguelDeTucuman }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Chicligasta).Value.Key, new Dictionary<long, string>
            {
                { 4178, LocalidadTucuman.Concepcion },
                { 4179, LocalidadTucuman.AlpachiriYElMolino },
                { 4180, LocalidadTucuman.AltoVerdeYLosGucheas },
                { 4181, LocalidadTucuman.Arcadia },
                { 4182, LocalidadTucuman.GastonaYBelicha },
                { 4183, LocalidadTucuman.IngenioLaTrinidad },
                { 4184, LocalidadTucuman.Medinas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.CruzAlta).Value.Key, new Dictionary<long, string>
            {
                { 4185, LocalidadTucuman.BandaDelRioSali },
                { 4186, LocalidadTucuman.Alderetes },
                { 4187, LocalidadTucuman.Colombres },
                { 4188, LocalidadTucuman.DelfinGallo },
                { 4189, LocalidadTucuman.ElBrachoYElCevilar },
                { 4190, LocalidadTucuman.ElNaranjito },
                { 4191, LocalidadTucuman.LaFloridaYLuisiana },
                { 4192, LocalidadTucuman.LasCejas },
                { 4193, LocalidadTucuman.LosBulacioYLosVillagra },
                { 4194, LocalidadTucuman.LosPereyras },
                { 4195, LocalidadTucuman.LosPerez },
                { 4196, LocalidadTucuman.LosRalos },
                { 4197, LocalidadTucuman.RanchillosYSanMiguel },
                { 4198, LocalidadTucuman.SanAndres }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Famailla).Value.Key, new Dictionary<long, string>
            {
                { 4199, LocalidadTucuman.Famailla }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Graneros).Value.Key, new Dictionary<long, string>
            {
                { 4200, LocalidadTucuman.Graneros },
                { 4201, LocalidadTucuman.Lamadrid },
                { 4202, LocalidadTucuman.TacoRalo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.JuanBautistaAlberdi).Value.Key, new Dictionary<long, string>
            {
                { 4203, LocalidadTucuman.JuanBautistaAlberdi },
                { 4204, LocalidadTucuman.CiudadAlberdi },
                { 4205, LocalidadTucuman.Escaba },
                { 4206, LocalidadTucuman.VillaBelgrano }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.LaCocha).Value.Key, new Dictionary<long, string>
            {
                { 4207, LocalidadTucuman.LaCocha },
                { 4208, LocalidadTucuman.ElSacrificio },
                { 4209, LocalidadTucuman.HuasaPampa },
                { 4210, LocalidadTucuman.RumiPunco },
                { 4211, LocalidadTucuman.SanIgnacio },
                { 4212, LocalidadTucuman.SanJoseDeLaCocha },
                { 4213, LocalidadTucuman.Yanima }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Leales).Value.Key, new Dictionary<long, string>
            {
                { 4214, LocalidadTucuman.BellaVista },
                { 4215, LocalidadTucuman.AguaDulceYLaSoledad },
                { 4216, LocalidadTucuman.ElMojon },
                { 4217, LocalidadTucuman.EsquinaYMancopa },
                { 4218, LocalidadTucuman.EstacionAraoz },
                { 4219, LocalidadTucuman.Tacanas },
                { 4220, LocalidadTucuman.LasTalas },
                { 4221, LocalidadTucuman.LosGomez },
                { 4222, LocalidadTucuman.LosPuestos },
                { 4223, LocalidadTucuman.ManuelGarciaFernandez },
                { 4224, LocalidadTucuman.QuilmesYLosSueldos },
                { 4225, LocalidadTucuman.RioColorado },
                { 4226, LocalidadTucuman.SantaRosaDeLeales },
                { 4227, LocalidadTucuman.VillaDeLeales }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Lules).Value.Key, new Dictionary<long, string>
            {
                { 4228, LocalidadTucuman.Lules },
                { 4229, LocalidadTucuman.ElManantial },
                { 4230, LocalidadTucuman.SanFelipe },
                { 4231, LocalidadTucuman.SantaBarbara },
                { 4232, LocalidadTucuman.SanPablo },
                { 4233, LocalidadTucuman.VillaNougues }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Monteros).Value.Key, new Dictionary<long, string>
            {
                { 4234, LocalidadTucuman.Monteros },
                { 4235, LocalidadTucuman.Acheral },
                { 4236, LocalidadTucuman.Amberes },
                { 4237, LocalidadTucuman.CapitanCaceres },
                { 4238, LocalidadTucuman.ElCercado },
                { 4239, LocalidadTucuman.LosSosas },
                { 4240, LocalidadTucuman.RioSeco },
                { 4241, LocalidadTucuman.SantaLucia },
                { 4242, LocalidadTucuman.SantaRosaYLosRojo },
                { 4243, LocalidadTucuman.SargentoMoya },
                { 4244, LocalidadTucuman.SoldadoMaldonado },
                { 4245, LocalidadTucuman.TenienteBerdina },
                { 4246, LocalidadTucuman.VillaQuinteros }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.RioChico).Value.Key, new Dictionary<long, string>
            {
                { 4247, LocalidadTucuman.Aguilares },
                { 4248, LocalidadTucuman.IngenioSantaBarbara },
                { 4249, LocalidadTucuman.LosSarmientos },
                { 4250, LocalidadTucuman.RioChico },
                { 4251, LocalidadTucuman.SantaAna },
                { 4252, LocalidadTucuman.VillaClodomiroHileret }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Simoca).Value.Key, new Dictionary<long, string>
            {
                { 4253, LocalidadTucuman.Simoca },
                { 4254, LocalidadTucuman.Atahona },
                { 4255, LocalidadTucuman.BuenaVista },
                { 4256, LocalidadTucuman.Ciudacita },
                { 4257, LocalidadTucuman.ManuelaPedraza },
                { 4258, LocalidadTucuman.Monteagudo },
                { 4259, LocalidadTucuman.PampaMayo },
                { 4260, LocalidadTucuman.RioChicoYNuevaTrinidad },
                { 4261, LocalidadTucuman.SanPedroYSanAntonio },
                { 4262, LocalidadTucuman.SantaCruzYLaTuna },
                { 4263, LocalidadTucuman.VillaChicligasta },
                { 4264, LocalidadTucuman.YerbaBuena }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.TafiDelValle).Value.Key, new Dictionary<long, string>
            {
                { 4265, LocalidadTucuman.TafiDelValle },
                { 4266, LocalidadTucuman.AmaichaDelValle },
                { 4267, LocalidadTucuman.ColalaoDelValle },
                { 4268, LocalidadTucuman.ElMollar }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.TafiViejo).Value.Key, new Dictionary<long, string>
            {
                { 4269, LocalidadTucuman.TafiViejo },
                { 4270, LocalidadTucuman.LasTalitas },
                { 4271, LocalidadTucuman.AncaJuli },
                { 4272, LocalidadTucuman.ElCadillal },
                { 4273, LocalidadTucuman.LaEsperanza },
                { 4274, LocalidadTucuman.LosNogales },
                { 4275, LocalidadTucuman.Raco },
                { 4276, LocalidadTucuman.LosPocitos },
                { 4277, LocalidadTucuman.LomasDeTafi }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.Trancas).Value.Key, new Dictionary<long, string>
            {
                { 4278, LocalidadTucuman.Trancas },
                { 4279, LocalidadTucuman.Choromoro },
                { 4280, LocalidadTucuman.SanPedroDeColalao },
                { 4281, LocalidadTucuman.Tapia }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoTucuman.YerbaBuena).Value.Key, new Dictionary<long, string>
            {
                { 4282, LocalidadTucuman.YerbaBuena },
                { 4283, LocalidadTucuman.SanJavier },
                { 4284, LocalidadTucuman.CebilRedondo }
            });
        }
    }
}
