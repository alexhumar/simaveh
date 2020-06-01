using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    internal class LocalidadBuenosAiresFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadBuenosAiresFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.AdolfoAlsina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1, LocalidadBuenosAires.Carhue),
                datosEntidadBuilder.Build(2, LocalidadBuenosAires.Rivera),
                datosEntidadBuilder.Build(3, LocalidadBuenosAires.VillaMaza),
                datosEntidadBuilder.Build(4, LocalidadBuenosAires.SanMiguelArcangel),
                datosEntidadBuilder.Build(5, LocalidadBuenosAires.EstebanAgustinGascon),
                datosEntidadBuilder.Build(6, LocalidadBuenosAires.DelfinHuergo),
                datosEntidadBuilder.Build(7, LocalidadBuenosAires.LaPala),
                datosEntidadBuilder.Build(8, LocalidadBuenosAires.Thames),
                datosEntidadBuilder.Build(9, LocalidadBuenosAires.Yutuyaco)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.AdolfoGonzalesChaves).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(10, LocalidadBuenosAires.GonzalesChaves),
                datosEntidadBuilder.Build(11, LocalidadBuenosAires.DeLaGarma),
                datosEntidadBuilder.Build(12, LocalidadBuenosAires.JuanEulogioBarra),
                datosEntidadBuilder.Build(13, LocalidadBuenosAires.Vasquez)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Alberti).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(14, LocalidadBuenosAires.Alberti),
                datosEntidadBuilder.Build(15, LocalidadBuenosAires.Mechita),
                datosEntidadBuilder.Build(16, LocalidadBuenosAires.VillaOrtiz),
                datosEntidadBuilder.Build(17, LocalidadBuenosAires.Pla),
                datosEntidadBuilder.Build(18, LocalidadBuenosAires.CoronelSegui),
                datosEntidadBuilder.Build(19, LocalidadBuenosAires.VillaGrisolia),
                datosEntidadBuilder.Build(20, LocalidadBuenosAires.VillaMaria),
                datosEntidadBuilder.Build(21, LocalidadBuenosAires.GobernadorUgarte)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.AlmiranteBrown).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(22, LocalidadBuenosAires.Adrogue),
                datosEntidadBuilder.Build(23, LocalidadBuenosAires.Burzaco),
                datosEntidadBuilder.Build(24, LocalidadBuenosAires.Glew),
                datosEntidadBuilder.Build(25, LocalidadBuenosAires.Claypole),
                datosEntidadBuilder.Build(26, LocalidadBuenosAires.RafaelCalzada),
                datosEntidadBuilder.Build(27, LocalidadBuenosAires.Longchamps),
                datosEntidadBuilder.Build(28, LocalidadBuenosAires.JoseMarmol),
                datosEntidadBuilder.Build(29, LocalidadBuenosAires.MinistroRivadavia),
                datosEntidadBuilder.Build(30, LocalidadBuenosAires.MalvinasArgentinas),
                datosEntidadBuilder.Build(31, LocalidadBuenosAires.SanFranciscoDeAsis),
                datosEntidadBuilder.Build(32, LocalidadBuenosAires.SanJose),
                datosEntidadBuilder.Build(33, LocalidadBuenosAires.SanFranciscoSolano)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Arrecifes).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(34, LocalidadBuenosAires.Arrecifes),
                datosEntidadBuilder.Build(35, LocalidadBuenosAires.Todd),
                datosEntidadBuilder.Build(36, LocalidadBuenosAires.Vina)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Avellaneda).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(37, LocalidadBuenosAires.AvellanedaCentro),
                datosEntidadBuilder.Build(38, LocalidadBuenosAires.DockSud),
                datosEntidadBuilder.Build(39, LocalidadBuenosAires.Gerli),
                datosEntidadBuilder.Build(40, LocalidadBuenosAires.Pineyro),
                datosEntidadBuilder.Build(41, LocalidadBuenosAires.Sarandi),
                datosEntidadBuilder.Build(42, LocalidadBuenosAires.VillaDominico),
                datosEntidadBuilder.Build(43, LocalidadBuenosAires.Wilde)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Ayacucho).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(44, LocalidadBuenosAires.Ayacucho),
                datosEntidadBuilder.Build(45, LocalidadBuenosAires.Udaquiola),
                datosEntidadBuilder.Build(46, LocalidadBuenosAires.LaConstancia),
                datosEntidadBuilder.Build(47, LocalidadBuenosAires.Solanet),
                datosEntidadBuilder.Build(48, LocalidadBuenosAires.ParajeCangallo),
                datosEntidadBuilder.Build(49, LocalidadBuenosAires.ParajeLangueyu),
                datosEntidadBuilder.Build(50, LocalidadBuenosAires.ParajeFair),
                datosEntidadBuilder.Build(51, LocalidadBuenosAires.ParajeSanIgnacio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Azul).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(52, LocalidadBuenosAires.Azul),
                datosEntidadBuilder.Build(53, LocalidadBuenosAires.Chillar),
                datosEntidadBuilder.Build(54, LocalidadBuenosAires.Cachari),
                datosEntidadBuilder.Build(55, LocalidadBuenosAires.DieciseisDeJulio),
                datosEntidadBuilder.Build(56, LocalidadBuenosAires.Ariel)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.BahiaBlanca).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(57, LocalidadBuenosAires.BahiaBlanca),
                datosEntidadBuilder.Build(58, LocalidadBuenosAires.IngenieroWhite),
                datosEntidadBuilder.Build(59, LocalidadBuenosAires.GeneralDanielCerri),
                datosEntidadBuilder.Build(60, LocalidadBuenosAires.Grunbein),
                datosEntidadBuilder.Build(61, LocalidadBuenosAires.Cabildo),
                datosEntidadBuilder.Build(62, LocalidadBuenosAires.VillaEspora),
                datosEntidadBuilder.Build(63, LocalidadBuenosAires.VillaBordeu),
                datosEntidadBuilder.Build(64, LocalidadBuenosAires.LaViticola)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Balcarce).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(65, LocalidadBuenosAires.Balcarce),
                datosEntidadBuilder.Build(66, LocalidadBuenosAires.SanAgustin),
                datosEntidadBuilder.Build(67, LocalidadBuenosAires.Napaleofu),
                datosEntidadBuilder.Build(68, LocalidadBuenosAires.LosPinos),
                datosEntidadBuilder.Build(69, LocalidadBuenosAires.VillaLagunaLaBrava),
                datosEntidadBuilder.Build(70, LocalidadBuenosAires.RamosOtero)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Baradero).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(71, LocalidadBuenosAires.Baradero),
                datosEntidadBuilder.Build(72, LocalidadBuenosAires.VillaAlsina),
                datosEntidadBuilder.Build(73, LocalidadBuenosAires.IreneoPortela),
                datosEntidadBuilder.Build(74, LocalidadBuenosAires.SantaColoma)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.BenitoJuarez).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(75, LocalidadBuenosAires.BenitoJuarez),
                datosEntidadBuilder.Build(76, LocalidadBuenosAires.VillaCacique),
                datosEntidadBuilder.Build(77, LocalidadBuenosAires.Barker),
                datosEntidadBuilder.Build(78, LocalidadBuenosAires.EstacionLopez),
                datosEntidadBuilder.Build(79, LocalidadBuenosAires.TedinUriburu)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Berazategui).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(80, LocalidadBuenosAires.Berazategui),
                datosEntidadBuilder.Build(81, LocalidadBuenosAires.Hudson),
                datosEntidadBuilder.Build(82, LocalidadBuenosAires.JuanMariaGutierrez),
                datosEntidadBuilder.Build(83, LocalidadBuenosAires.Ranelagh),
                datosEntidadBuilder.Build(84, LocalidadBuenosAires.Sourigues),
                datosEntidadBuilder.Build(85, LocalidadBuenosAires.Pereyra),
                datosEntidadBuilder.Build(86, LocalidadBuenosAires.Platanos),
                datosEntidadBuilder.Build(87, LocalidadBuenosAires.VillaEspana),
                datosEntidadBuilder.Build(88, LocalidadBuenosAires.ElPato)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Berisso).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(89, LocalidadBuenosAires.Berisso),
                datosEntidadBuilder.Build(90, LocalidadBuenosAires.VillaProgreso),
                datosEntidadBuilder.Build(91, LocalidadBuenosAires.VillaSanCarlos),
                datosEntidadBuilder.Build(92, LocalidadBuenosAires.VillaIndependencia),
                datosEntidadBuilder.Build(93, LocalidadBuenosAires.BarrioElCarmenEste),
                datosEntidadBuilder.Build(94, LocalidadBuenosAires.VillaDolores),
                datosEntidadBuilder.Build(95, LocalidadBuenosAires.VillaArguello),
                datosEntidadBuilder.Build(96, LocalidadBuenosAires.VillaZula),
                datosEntidadBuilder.Build(97, LocalidadBuenosAires.BarrioBancoProvincia),
                datosEntidadBuilder.Build(98, LocalidadBuenosAires.VillaNueva),
                datosEntidadBuilder.Build(99, LocalidadBuenosAires.BarrioUniversitario),
                datosEntidadBuilder.Build(100, LocalidadBuenosAires.LosTalas),
                datosEntidadBuilder.Build(101, LocalidadBuenosAires.PaloBlanco),
                datosEntidadBuilder.Build(102, LocalidadBuenosAires.VillaBancoConstructor),
                datosEntidadBuilder.Build(103, LocalidadBuenosAires.LosCatorce),
                datosEntidadBuilder.Build(104, LocalidadBuenosAires.VillaEspana),
                datosEntidadBuilder.Build(105, LocalidadBuenosAires.LaBalandra),
                datosEntidadBuilder.Build(106, LocalidadBuenosAires.JuanBJusto),
                datosEntidadBuilder.Build(107, LocalidadBuenosAires.BarrioObrero),
                datosEntidadBuilder.Build(108, LocalidadBuenosAires.BarrioSantaTeresita)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Bolivar).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(109, LocalidadBuenosAires.SanCarlosDeBolivar),
                datosEntidadBuilder.Build(110, LocalidadBuenosAires.Urdampilleta),
                datosEntidadBuilder.Build(111, LocalidadBuenosAires.Pirovano),
                datosEntidadBuilder.Build(112, LocalidadBuenosAires.Hale),
                datosEntidadBuilder.Build(113, LocalidadBuenosAires.JuanFIbarra),
                datosEntidadBuilder.Build(114, LocalidadBuenosAires.Paula),
                datosEntidadBuilder.Build(115, LocalidadBuenosAires.MarianoUnzue),
                datosEntidadBuilder.Build(116, LocalidadBuenosAires.VillaLynchPueyrredon),
                datosEntidadBuilder.Build(117, LocalidadBuenosAires.ParajeVallimanca),
                datosEntidadBuilder.Build(118, LocalidadBuenosAires.ParajeVillaSanz)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Bragado).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(119, LocalidadBuenosAires.Bragado),
                datosEntidadBuilder.Build(120, LocalidadBuenosAires.EduardoObrien),
                datosEntidadBuilder.Build(121, LocalidadBuenosAires.Mechita),
                datosEntidadBuilder.Build(122, LocalidadBuenosAires.ComodoroPy),
                datosEntidadBuilder.Build(123, LocalidadBuenosAires.Warnes),
                datosEntidadBuilder.Build(124, LocalidadBuenosAires.Irala),
                datosEntidadBuilder.Build(125, LocalidadBuenosAires.Olascoaga),
                datosEntidadBuilder.Build(126, LocalidadBuenosAires.MaximoFernandez),
                datosEntidadBuilder.Build(127, LocalidadBuenosAires.LaLimpia),
                datosEntidadBuilder.Build(128, LocalidadBuenosAires.Asamblea)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Brandsen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(129, LocalidadBuenosAires.Brandsen),
                datosEntidadBuilder.Build(130, LocalidadBuenosAires.Jeppener),
                datosEntidadBuilder.Build(131, LocalidadBuenosAires.Gomez),
                datosEntidadBuilder.Build(132, LocalidadBuenosAires.Altamirano),
                datosEntidadBuilder.Build(133, LocalidadBuenosAires.Samborombon),
                datosEntidadBuilder.Build(134, LocalidadBuenosAires.Oliden)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Campana).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(135, LocalidadBuenosAires.Campana),
                datosEntidadBuilder.Build(136, LocalidadBuenosAires.AltoLosCardales),
                datosEntidadBuilder.Build(137, LocalidadBuenosAires.LomasDelRioLujan),
                datosEntidadBuilder.Build(138, LocalidadBuenosAires.IngenieroRomuloOtamendi)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Canuelas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(139, LocalidadBuenosAires.Canuelas),
                datosEntidadBuilder.Build(140, LocalidadBuenosAires.SantaRosa),
                datosEntidadBuilder.Build(141, LocalidadBuenosAires.AlejandroPetion),
                datosEntidadBuilder.Build(142, LocalidadBuenosAires.MaximoPaz),
                datosEntidadBuilder.Build(143, LocalidadBuenosAires.Uribelarrea),
                datosEntidadBuilder.Build(144, LocalidadBuenosAires.VicenteCasares),
                datosEntidadBuilder.Build(145, LocalidadBuenosAires.GobernadorUdaondo),
                datosEntidadBuilder.Build(146, LocalidadBuenosAires.ElTaladro),
                datosEntidadBuilder.Build(147, LocalidadBuenosAires.SantaAnita)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.CapitanSarmiento).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(148, LocalidadBuenosAires.CapitanSarmiento),
                datosEntidadBuilder.Build(149, LocalidadBuenosAires.LaLuisa)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.CarlosCasares).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(150, LocalidadBuenosAires.CarlosCasares),
                datosEntidadBuilder.Build(151, LocalidadBuenosAires.Smith),
                datosEntidadBuilder.Build(152, LocalidadBuenosAires.Bellocq),
                datosEntidadBuilder.Build(153, LocalidadBuenosAires.Moctezuma),
                datosEntidadBuilder.Build(154, LocalidadBuenosAires.Cadret),
                datosEntidadBuilder.Build(155, LocalidadBuenosAires.Hortensia),
                datosEntidadBuilder.Build(156, LocalidadBuenosAires.Ordoqui),
                datosEntidadBuilder.Build(157, LocalidadBuenosAires.MauricioHirsch),
                datosEntidadBuilder.Build(158, LocalidadBuenosAires.ColoniaMauricio),
                datosEntidadBuilder.Build(159, LocalidadBuenosAires.LaSofia)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.CarlosTejedor).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(160, LocalidadBuenosAires.CarlosTejedor),
                datosEntidadBuilder.Build(161, LocalidadBuenosAires.TresAlgarrobos),
                datosEntidadBuilder.Build(162, LocalidadBuenosAires.ColoniaSere),
                datosEntidadBuilder.Build(163, LocalidadBuenosAires.Timote),
                datosEntidadBuilder.Build(164, LocalidadBuenosAires.Curaru)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.CarmenDeAreco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(165, LocalidadBuenosAires.CarmenDeAreco),
                datosEntidadBuilder.Build(166, LocalidadBuenosAires.TresSargentos),
                datosEntidadBuilder.Build(167, LocalidadBuenosAires.PuebloGouin)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Castelli).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(168, LocalidadBuenosAires.Castelli),
                datosEntidadBuilder.Build(169, LocalidadBuenosAires.CentroGuerrero),
                datosEntidadBuilder.Build(170, LocalidadBuenosAires.CerroDeLaGloria)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Chacabuco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(171, LocalidadBuenosAires.Chacabuco),
                datosEntidadBuilder.Build(172, LocalidadBuenosAires.Rawson),
                datosEntidadBuilder.Build(173, LocalidadBuenosAires.Ohiggins),
                datosEntidadBuilder.Build(174, LocalidadBuenosAires.Castilla),
                datosEntidadBuilder.Build(175, LocalidadBuenosAires.LosAngeles)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Chascomus).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(176, LocalidadBuenosAires.Chascomus)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Chivilcoy).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(177, LocalidadBuenosAires.Chivilcoy),
                datosEntidadBuilder.Build(178, LocalidadBuenosAires.Moquehua),
                datosEntidadBuilder.Build(179, LocalidadBuenosAires.Gorostiaga),
                datosEntidadBuilder.Build(180, LocalidadBuenosAires.EmilioAyarza),
                datosEntidadBuilder.Build(181, LocalidadBuenosAires.LaRica),
                datosEntidadBuilder.Build(182, LocalidadBuenosAires.SanSebastian),
                datosEntidadBuilder.Build(183, LocalidadBuenosAires.Benitez),
                datosEntidadBuilder.Build(184, LocalidadBuenosAires.HenryBell),
                datosEntidadBuilder.Build(185, LocalidadBuenosAires.Indacochea),
                datosEntidadBuilder.Build(186, LocalidadBuenosAires.PalemonHuergo),
                datosEntidadBuilder.Build(187, LocalidadBuenosAires.RamonBiaus)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Colon).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(188, LocalidadBuenosAires.Colon),
                datosEntidadBuilder.Build(189, LocalidadBuenosAires.Pearson),
                datosEntidadBuilder.Build(190, LocalidadBuenosAires.Sarasa),
                datosEntidadBuilder.Build(191, LocalidadBuenosAires.ElArbolito)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.CoronelDorrego).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(192, LocalidadBuenosAires.CoronelDorrego),
                datosEntidadBuilder.Build(193, LocalidadBuenosAires.Oriente),
                datosEntidadBuilder.Build(194, LocalidadBuenosAires.ElPerdido),
                datosEntidadBuilder.Build(195, LocalidadBuenosAires.Aparicio),
                datosEntidadBuilder.Build(196, LocalidadBuenosAires.SanRoman),
                datosEntidadBuilder.Build(197, LocalidadBuenosAires.BalnearioMarisol),
                datosEntidadBuilder.Build(198, LocalidadBuenosAires.Irene),
                datosEntidadBuilder.Build(199, LocalidadBuenosAires.Faro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.CoronelPringles).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(200, LocalidadBuenosAires.CoronelPringles),
                datosEntidadBuilder.Build(201, LocalidadBuenosAires.IndioRico),
                datosEntidadBuilder.Build(202, LocalidadBuenosAires.Lartigau),
                datosEntidadBuilder.Build(203, LocalidadBuenosAires.ElPensamiento),
                datosEntidadBuilder.Build(204, LocalidadBuenosAires.ElDivisorio),
                datosEntidadBuilder.Build(205, LocalidadBuenosAires.Frapal)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.CoronelRosales).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(206, LocalidadBuenosAires.PuntaAlta),
                datosEntidadBuilder.Build(207, LocalidadBuenosAires.VillaGeneralArias),
                datosEntidadBuilder.Build(208, LocalidadBuenosAires.BalnearioPehuenCo),
                datosEntidadBuilder.Build(209, LocalidadBuenosAires.VillaDelMar),
                datosEntidadBuilder.Build(210, LocalidadBuenosAires.BajoHondo),
                datosEntidadBuilder.Build(211, LocalidadBuenosAires.Calderon),
                datosEntidadBuilder.Build(212, LocalidadBuenosAires.PuertoRosales),
                datosEntidadBuilder.Build(213, LocalidadBuenosAires.BaseNavalPuertoBelgrano),
                datosEntidadBuilder.Build(214, LocalidadBuenosAires.ArroyoPareja),
                datosEntidadBuilder.Build(215, LocalidadBuenosAires.PuntaAncla),
                datosEntidadBuilder.Build(216, LocalidadBuenosAires.BaseDeInfanteriaDeMarinaBaterias)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.CoronelSuarez).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(217, LocalidadBuenosAires.CoronelSuarez),
                datosEntidadBuilder.Build(218, LocalidadBuenosAires.Huanguelen),
                datosEntidadBuilder.Build(219, LocalidadBuenosAires.SanJose),
                datosEntidadBuilder.Build(220, LocalidadBuenosAires.SantaMaria),
                datosEntidadBuilder.Build(221, LocalidadBuenosAires.SantaTrinidad),
                datosEntidadBuilder.Build(222, LocalidadBuenosAires.VillaArcadia),
                datosEntidadBuilder.Build(223, LocalidadBuenosAires.Pasman),
                datosEntidadBuilder.Build(224, LocalidadBuenosAires.CuraMalal),
                datosEntidadBuilder.Build(225, LocalidadBuenosAires.EstacionPineyro),
                datosEntidadBuilder.Build(226, LocalidadBuenosAires.Dorbigny),
                datosEntidadBuilder.Build(227, LocalidadBuenosAires.Cascada)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Daireaux).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(228, LocalidadBuenosAires.Daireaux),
                datosEntidadBuilder.Build(229, LocalidadBuenosAires.SalazarMouras),
                datosEntidadBuilder.Build(230, LocalidadBuenosAires.Arboledas),
                datosEntidadBuilder.Build(231, LocalidadBuenosAires.LaCopeta),
                datosEntidadBuilder.Build(232, LocalidadBuenosAires.LaLarga),
                datosEntidadBuilder.Build(233, LocalidadBuenosAires.LaManuela),
                datosEntidadBuilder.Build(234, LocalidadBuenosAires.Luro),
                datosEntidadBuilder.Build(235, LocalidadBuenosAires.Andant),
                datosEntidadBuilder.Build(236, LocalidadBuenosAires.EnriqueLavalleFreyre)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Dolores).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(237, LocalidadBuenosAires.Dolores),
                datosEntidadBuilder.Build(238, LocalidadBuenosAires.Sevigne)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Ensenada).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(239, LocalidadBuenosAires.Ensenada),
                datosEntidadBuilder.Build(240, LocalidadBuenosAires.PuntaLara),
                datosEntidadBuilder.Build(241, LocalidadBuenosAires.VillaCatella),
                datosEntidadBuilder.Build(242, LocalidadBuenosAires.DiqueN1),
                datosEntidadBuilder.Build(243, LocalidadBuenosAires.IslaSantiagoOeste)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Escobar).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(244, LocalidadBuenosAires.BelenDeEscobar),
                datosEntidadBuilder.Build(245, LocalidadBuenosAires.Garin),
                datosEntidadBuilder.Build(246, LocalidadBuenosAires.IngenieroMaschwitz),
                datosEntidadBuilder.Build(247, LocalidadBuenosAires.Matheu),
                datosEntidadBuilder.Build(248, LocalidadBuenosAires.MaquinistaFSavio),
                datosEntidadBuilder.Build(249, LocalidadBuenosAires.PuertoParana),
                datosEntidadBuilder.Build(250, LocalidadBuenosAires.LomaVerde)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.EstebanEcheverria).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(251, LocalidadBuenosAires.NueveDeAbril),
                datosEntidadBuilder.Build(252, LocalidadBuenosAires.CanningOriental),
                datosEntidadBuilder.Build(253, LocalidadBuenosAires.ElJaguel),
                datosEntidadBuilder.Build(254, LocalidadBuenosAires.LuisGuillon),
                datosEntidadBuilder.Build(255, LocalidadBuenosAires.MonteGrande)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.ExaltacionDeLaCruz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(256, LocalidadBuenosAires.CapillaDelSenor),
                datosEntidadBuilder.Build(257, LocalidadBuenosAires.LosCardales),
                datosEntidadBuilder.Build(258, LocalidadBuenosAires.Pavon),
                datosEntidadBuilder.Build(259, LocalidadBuenosAires.ArroyoDeLaCruz),
                datosEntidadBuilder.Build(260, LocalidadBuenosAires.ParadaOrlando),
                datosEntidadBuilder.Build(261, LocalidadBuenosAires.ParadaRobles),
                datosEntidadBuilder.Build(262, LocalidadBuenosAires.ElRemanso),
                datosEntidadBuilder.Build(263, LocalidadBuenosAires.Etchegoyen),
                datosEntidadBuilder.Build(264, LocalidadBuenosAires.ParadaLaLataLaLoma),
                datosEntidadBuilder.Build(265, LocalidadBuenosAires.DiegoGaynor),
                datosEntidadBuilder.Build(266, LocalidadBuenosAires.GobernadorAndonaegui),
                datosEntidadBuilder.Build(267, LocalidadBuenosAires.Chenaut)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Ezeiza).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(268, LocalidadBuenosAires.AeropuertoInternacionalEzeiza),
                datosEntidadBuilder.Build(269, LocalidadBuenosAires.CanningOccidental),
                datosEntidadBuilder.Build(270, LocalidadBuenosAires.CarlosSpegazzini),
                datosEntidadBuilder.Build(271, LocalidadBuenosAires.Ezeiza),
                datosEntidadBuilder.Build(272, LocalidadBuenosAires.LaUnion),
                datosEntidadBuilder.Build(273, LocalidadBuenosAires.TristanSuarez)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.FlorencioVarela).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(274, LocalidadBuenosAires.CiudadDeBosques),
                datosEntidadBuilder.Build(275, LocalidadBuenosAires.CiudadDeFlorencioVarela),
                datosEntidadBuilder.Build(276, LocalidadBuenosAires.EstanislaoSeveroZeballos),
                datosEntidadBuilder.Build(277, LocalidadBuenosAires.GobernadorJulioACosta),
                datosEntidadBuilder.Build(278, LocalidadBuenosAires.IngenieroJuanAllan),
                datosEntidadBuilder.Build(279, LocalidadBuenosAires.LaCapilla),
                datosEntidadBuilder.Build(280, LocalidadBuenosAires.VillaBrown),
                datosEntidadBuilder.Build(281, LocalidadBuenosAires.VillaSanLuis),
                datosEntidadBuilder.Build(282, LocalidadBuenosAires.VillaSantaRosa),
                datosEntidadBuilder.Build(283, LocalidadBuenosAires.VillaVatteone)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.FlorentinoAmeghino).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(284, LocalidadBuenosAires.FlorentinoAmeghino),
                datosEntidadBuilder.Build(285, LocalidadBuenosAires.Blaquier),
                datosEntidadBuilder.Build(286, LocalidadBuenosAires.Porvenir),
                datosEntidadBuilder.Build(287, LocalidadBuenosAires.ParajeNuevaSuiza),
                datosEntidadBuilder.Build(288, LocalidadBuenosAires.ParajePorvenir)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralAlvarado).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(289, LocalidadBuenosAires.Miramar),
                datosEntidadBuilder.Build(290, LocalidadBuenosAires.MarDelSur),
                datosEntidadBuilder.Build(291, LocalidadBuenosAires.ComandanteNicanorOtamendi),
                datosEntidadBuilder.Build(292, LocalidadBuenosAires.Mechongue),
                datosEntidadBuilder.Build(293, LocalidadBuenosAires.CentinelaDelMar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralAlvear).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(294, LocalidadBuenosAires.GeneralAlvear)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralArenales).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(295, LocalidadBuenosAires.GeneralArenales),
                datosEntidadBuilder.Build(296, LocalidadBuenosAires.Arribenos),
                datosEntidadBuilder.Build(297, LocalidadBuenosAires.Ascension),
                datosEntidadBuilder.Build(298, LocalidadBuenosAires.EstacionArenales),
                datosEntidadBuilder.Build(299, LocalidadBuenosAires.Ferre),
                datosEntidadBuilder.Build(300, LocalidadBuenosAires.LaAngelita),
                datosEntidadBuilder.Build(301, LocalidadBuenosAires.LaTrinidad)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralBelgrano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(302, LocalidadBuenosAires.GeneralBelgrano),
                datosEntidadBuilder.Build(303, LocalidadBuenosAires.Gorchs)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralGuido).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(304, LocalidadBuenosAires.GeneralGuido),
                datosEntidadBuilder.Build(305, LocalidadBuenosAires.Labarden)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralJuanMadariaga).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(306, LocalidadBuenosAires.GeneralMadariaga)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralLaMadrid).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(307, LocalidadBuenosAires.GeneralLaMadrid),
                datosEntidadBuilder.Build(308, LocalidadBuenosAires.LaColina),
                datosEntidadBuilder.Build(309, LocalidadBuenosAires.Libano),
                datosEntidadBuilder.Build(310, LocalidadBuenosAires.LasMartinetas),
                datosEntidadBuilder.Build(311, LocalidadBuenosAires.Pontaut),
                datosEntidadBuilder.Build(312, LocalidadBuenosAires.Lastra),
                datosEntidadBuilder.Build(313, LocalidadBuenosAires.Quilco)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralLasHeras).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(314, LocalidadBuenosAires.GeneralLasHeras),
                datosEntidadBuilder.Build(315, LocalidadBuenosAires.Villars),
                datosEntidadBuilder.Build(316, LocalidadBuenosAires.GeneralHornos),
                datosEntidadBuilder.Build(317, LocalidadBuenosAires.Plomer),
                datosEntidadBuilder.Build(318, LocalidadBuenosAires.LaChoza),
                datosEntidadBuilder.Build(319, LocalidadBuenosAires.Lozano),
                datosEntidadBuilder.Build(320, LocalidadBuenosAires.EnriqueFynn)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralLavalle).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(321, LocalidadBuenosAires.GeneralLavalle),
                datosEntidadBuilder.Build(322, LocalidadBuenosAires.Pavon),
                datosEntidadBuilder.Build(323, LocalidadBuenosAires.LasChacras),
                datosEntidadBuilder.Build(324, LocalidadBuenosAires.LasTijeras)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralPaz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(325, LocalidadBuenosAires.Ranchos),
                datosEntidadBuilder.Build(326, LocalidadBuenosAires.LomaVerde),
                datosEntidadBuilder.Build(327, LocalidadBuenosAires.Villanueva),
                datosEntidadBuilder.Build(328, LocalidadBuenosAires.BarrioRioSalado),
                datosEntidadBuilder.Build(329, LocalidadBuenosAires.Alegre)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralPinto).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(330, LocalidadBuenosAires.GeneralPinto),
                datosEntidadBuilder.Build(331, LocalidadBuenosAires.Germania),
                datosEntidadBuilder.Build(332, LocalidadBuenosAires.VillaFrancia),
                datosEntidadBuilder.Build(333, LocalidadBuenosAires.ColoniaSanRicardo),
                datosEntidadBuilder.Build(334, LocalidadBuenosAires.VillaRoth)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralPueyrredon).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(335, LocalidadBuenosAires.MarDelPlata),
                datosEntidadBuilder.Build(336, LocalidadBuenosAires.LasQuintas),
                datosEntidadBuilder.Build(337, LocalidadBuenosAires.LosZorzales),
                datosEntidadBuilder.Build(338, LocalidadBuenosAires.ElSosiego),
                datosEntidadBuilder.Build(339, LocalidadBuenosAires.EstacionCamet),
                datosEntidadBuilder.Build(340, LocalidadBuenosAires.SantaAngela),
                datosEntidadBuilder.Build(341, LocalidadBuenosAires.Barrio2DeAbril),
                datosEntidadBuilder.Build(342, LocalidadBuenosAires.LaAdela),
                datosEntidadBuilder.Build(343, LocalidadBuenosAires.LasMargaritas),
                datosEntidadBuilder.Build(344, LocalidadBuenosAires.ElDorado),
                datosEntidadBuilder.Build(345, LocalidadBuenosAires.ColinasVerdes),
                datosEntidadBuilder.Build(346, LocalidadBuenosAires.BarrioLaGloriaDeLaPeregrina),
                datosEntidadBuilder.Build(347, LocalidadBuenosAires.SierraDeLosPadres),
                datosEntidadBuilder.Build(348, LocalidadBuenosAires.ElCoyunco),
                datosEntidadBuilder.Build(349, LocalidadBuenosAires.LagunaDeLosPadres),
                datosEntidadBuilder.Build(350, LocalidadBuenosAires.SantaPaula),
                datosEntidadBuilder.Build(351, LocalidadBuenosAires.Batan),
                datosEntidadBuilder.Build(352, LocalidadBuenosAires.BarrioEstacionChapadmalal),
                datosEntidadBuilder.Build(353, LocalidadBuenosAires.BarrioFelixUCamet),
                datosEntidadBuilder.Build(354, LocalidadBuenosAires.BarrioLosAcantilados),
                datosEntidadBuilder.Build(355, LocalidadBuenosAires.BarrioChapadmalal),
                datosEntidadBuilder.Build(356, LocalidadBuenosAires.BarrioSanEduardoDelMar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralRodriguez).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(357, LocalidadBuenosAires.GeneralRodriguez)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralSanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(358, LocalidadBuenosAires.Billinghurst),
                datosEntidadBuilder.Build(359, LocalidadBuenosAires.LomaHermosa),
                datosEntidadBuilder.Build(360, LocalidadBuenosAires.JoseLeonSuarez),
                datosEntidadBuilder.Build(361, LocalidadBuenosAires.SanAndres),
                datosEntidadBuilder.Build(362, LocalidadBuenosAires.SanMartin),
                datosEntidadBuilder.Build(363, LocalidadBuenosAires.VillaAyacucho),
                datosEntidadBuilder.Build(364, LocalidadBuenosAires.VillaChacabuco),
                datosEntidadBuilder.Build(365, LocalidadBuenosAires.VillaBallester),
                datosEntidadBuilder.Build(366, LocalidadBuenosAires.VillaLynch),
                datosEntidadBuilder.Build(367, LocalidadBuenosAires.VillaMaipu)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralViamonte).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(368, LocalidadBuenosAires.LosToldos),
                datosEntidadBuilder.Build(369, LocalidadBuenosAires.Baigorrita),
                datosEntidadBuilder.Build(370, LocalidadBuenosAires.Zavalia),
                datosEntidadBuilder.Build(371, LocalidadBuenosAires.SanEmilio),
                datosEntidadBuilder.Build(372, LocalidadBuenosAires.LaDelfina)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.GeneralVillegas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(373, LocalidadBuenosAires.GeneralVillegas),
                datosEntidadBuilder.Build(374, LocalidadBuenosAires.Piedritas),
                datosEntidadBuilder.Build(375, LocalidadBuenosAires.EmilioVBunge),
                datosEntidadBuilder.Build(376, LocalidadBuenosAires.CoronelCharlone),
                datosEntidadBuilder.Build(377, LocalidadBuenosAires.Banderalo),
                datosEntidadBuilder.Build(378, LocalidadBuenosAires.CanadaSeca),
                datosEntidadBuilder.Build(379, LocalidadBuenosAires.VillaSauze),
                datosEntidadBuilder.Build(380, LocalidadBuenosAires.SantaRegina),
                datosEntidadBuilder.Build(381, LocalidadBuenosAires.VillaSaboya),
                datosEntidadBuilder.Build(382, LocalidadBuenosAires.SantaEleodora),
                datosEntidadBuilder.Build(383, LocalidadBuenosAires.MasseyEstElordi),
                datosEntidadBuilder.Build(384, LocalidadBuenosAires.Pichincha)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Guamini).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(385, LocalidadBuenosAires.LagunaAlsina),
                datosEntidadBuilder.Build(386, LocalidadBuenosAires.Casbas),
                datosEntidadBuilder.Build(387, LocalidadBuenosAires.Guamini),
                datosEntidadBuilder.Build(388, LocalidadBuenosAires.VictorinoDeLaPlaza),
                datosEntidadBuilder.Build(389, LocalidadBuenosAires.Garre),
                datosEntidadBuilder.Build(390, LocalidadBuenosAires.ArroyoVenado),
                datosEntidadBuilder.Build(391, LocalidadBuenosAires.Huanguelen)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.HipolitoYrigoyen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(392, LocalidadBuenosAires.Henderson),
                datosEntidadBuilder.Build(393, LocalidadBuenosAires.HerreraVegas),
                datosEntidadBuilder.Build(394, LocalidadBuenosAires.MariaLucila),
                datosEntidadBuilder.Build(395, LocalidadBuenosAires.Coraceros)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Hurlingham).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(396, LocalidadBuenosAires.Hurlingham),
                datosEntidadBuilder.Build(397, LocalidadBuenosAires.VillaTesei),
                datosEntidadBuilder.Build(398, LocalidadBuenosAires.WilliamCMorris)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Ituzaingo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(399, LocalidadBuenosAires.Ituzaingo),
                datosEntidadBuilder.Build(400, LocalidadBuenosAires.VillaUdaondo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.JoseCPaz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(401, LocalidadBuenosAires.JoseCPaz)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Junin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(402, LocalidadBuenosAires.Junin),
                datosEntidadBuilder.Build(403, LocalidadBuenosAires.Morse),
                datosEntidadBuilder.Build(404, LocalidadBuenosAires.AgustinRoca),
                datosEntidadBuilder.Build(405, LocalidadBuenosAires.FortinTiburcio),
                datosEntidadBuilder.Build(406, LocalidadBuenosAires.Saforcada),
                datosEntidadBuilder.Build(407, LocalidadBuenosAires.Agustina),
                datosEntidadBuilder.Build(408, LocalidadBuenosAires.Laplacette),
                datosEntidadBuilder.Build(409, LocalidadBuenosAires.BalnearioLagunaDeGomez)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.LaCosta).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(410, LocalidadBuenosAires.SanClementeDelTuyu),
                datosEntidadBuilder.Build(411, LocalidadBuenosAires.LasToninas),
                datosEntidadBuilder.Build(412, LocalidadBuenosAires.CostaChica),
                datosEntidadBuilder.Build(413, LocalidadBuenosAires.SantaTeresita),
                datosEntidadBuilder.Build(414, LocalidadBuenosAires.MarDelTuyu),
                datosEntidadBuilder.Build(415, LocalidadBuenosAires.CostaDelEste),
                datosEntidadBuilder.Build(416, LocalidadBuenosAires.AguasVerdes),
                datosEntidadBuilder.Build(417, LocalidadBuenosAires.LaLucilaDelMar),
                datosEntidadBuilder.Build(418, LocalidadBuenosAires.CostaAzul),
                datosEntidadBuilder.Build(419, LocalidadBuenosAires.SanBernardoDelTuyu),
                datosEntidadBuilder.Build(420, LocalidadBuenosAires.MarDeAjo),
                datosEntidadBuilder.Build(421, LocalidadBuenosAires.NuevaAtlantis),
                datosEntidadBuilder.Build(422, LocalidadBuenosAires.PuntaMedanos),
                datosEntidadBuilder.Build(423, LocalidadBuenosAires.PinarDelSol),
                datosEntidadBuilder.Build(424, LocalidadBuenosAires.CostaEsmeralda)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.LaMatanza).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(425, LocalidadBuenosAires.SanJusto),
                datosEntidadBuilder.Build(426, LocalidadBuenosAires.VeinteDeJunio),
                datosEntidadBuilder.Build(427, LocalidadBuenosAires.AldoBonzi),
                datosEntidadBuilder.Build(428, LocalidadBuenosAires.CiudadCelina),
                datosEntidadBuilder.Build(429, LocalidadBuenosAires.CiudadEvita),
                datosEntidadBuilder.Build(430, LocalidadBuenosAires.GonzalezCatan),
                datosEntidadBuilder.Build(431, LocalidadBuenosAires.GregorioDeLaferrere),
                datosEntidadBuilder.Build(432, LocalidadBuenosAires.IsidroCasanova),
                datosEntidadBuilder.Build(433, LocalidadBuenosAires.LaTablada),
                datosEntidadBuilder.Build(434, LocalidadBuenosAires.LomasDelMirador),
                datosEntidadBuilder.Build(435, LocalidadBuenosAires.RafaelCastillo),
                datosEntidadBuilder.Build(436, LocalidadBuenosAires.RamosMejia),
                datosEntidadBuilder.Build(437, LocalidadBuenosAires.Tapiales),
                datosEntidadBuilder.Build(438, LocalidadBuenosAires.VillaLuzuriaga),
                datosEntidadBuilder.Build(439, LocalidadBuenosAires.VillaMadero),
                datosEntidadBuilder.Build(440, LocalidadBuenosAires.VirreyDelPino)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.LaPlata).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(441, LocalidadBuenosAires.CountryClubElRodeo),
                datosEntidadBuilder.Build(442, LocalidadBuenosAires.BarrioRutaSol),
                datosEntidadBuilder.Build(443, LocalidadBuenosAires.Abasto),
                datosEntidadBuilder.Build(444, LocalidadBuenosAires.AngelEtcheverry),
                datosEntidadBuilder.Build(445, LocalidadBuenosAires.Arana),
                datosEntidadBuilder.Build(446, LocalidadBuenosAires.ArturoSegui),
                datosEntidadBuilder.Build(447, LocalidadBuenosAires.BarrioElCarmen),
                datosEntidadBuilder.Build(448, LocalidadBuenosAires.BarrioGambier),
                datosEntidadBuilder.Build(449, LocalidadBuenosAires.BarrioLasMalvinas),
                datosEntidadBuilder.Build(450, LocalidadBuenosAires.BarrioLasQuintas),
                datosEntidadBuilder.Build(451, LocalidadBuenosAires.CityBell),
                datosEntidadBuilder.Build(452, LocalidadBuenosAires.ElRetiro),
                datosEntidadBuilder.Build(453, LocalidadBuenosAires.JoaquinGorina),
                datosEntidadBuilder.Build(454, LocalidadBuenosAires.JoseHernandez),
                datosEntidadBuilder.Build(455, LocalidadBuenosAires.JoseMelchorRomero),
                datosEntidadBuilder.Build(456, LocalidadBuenosAires.LaCumbre),
                datosEntidadBuilder.Build(457, LocalidadBuenosAires.CascoUrbano),
                datosEntidadBuilder.Build(458, LocalidadBuenosAires.LisandroOlmos),
                datosEntidadBuilder.Build(459, LocalidadBuenosAires.LosHornos),
                datosEntidadBuilder.Build(460, LocalidadBuenosAires.ManuelBGonnet),
                datosEntidadBuilder.Build(461, LocalidadBuenosAires.Ringuelet),
                datosEntidadBuilder.Build(462, LocalidadBuenosAires.AltosDeSanLorenzo),
                datosEntidadBuilder.Build(463, LocalidadBuenosAires.Tolosa),
                datosEntidadBuilder.Build(464, LocalidadBuenosAires.Transradio),
                datosEntidadBuilder.Build(465, LocalidadBuenosAires.VillaElisa),
                datosEntidadBuilder.Build(466, LocalidadBuenosAires.VillaElvira),
                datosEntidadBuilder.Build(467, LocalidadBuenosAires.VillaGaribaldi),
                datosEntidadBuilder.Build(468, LocalidadBuenosAires.VillaMontoro),
                datosEntidadBuilder.Build(469, LocalidadBuenosAires.VillaParqueSicardi),
                datosEntidadBuilder.Build(470, LocalidadBuenosAires.IgnacioCorreas),
                datosEntidadBuilder.Build(471, LocalidadBuenosAires.LomasDeCopello)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Lanus).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(472, LocalidadBuenosAires.LanusOeste),
                datosEntidadBuilder.Build(473, LocalidadBuenosAires.LanusEste),
                datosEntidadBuilder.Build(474, LocalidadBuenosAires.RemediosDeEscalada),
                datosEntidadBuilder.Build(475, LocalidadBuenosAires.Gerli),
                datosEntidadBuilder.Build(476, LocalidadBuenosAires.ValentinAlsina),
                datosEntidadBuilder.Build(477, LocalidadBuenosAires.MonteChingolo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Laprida).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(478, LocalidadBuenosAires.Laprida),
                datosEntidadBuilder.Build(479, LocalidadBuenosAires.PuebloSanJorge),
                datosEntidadBuilder.Build(480, LocalidadBuenosAires.PuebloNuevo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.LasFlores).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(481, LocalidadBuenosAires.LasFlores),
                datosEntidadBuilder.Build(482, LocalidadBuenosAires.Pardo),
                datosEntidadBuilder.Build(483, LocalidadBuenosAires.ElTrigo),
                datosEntidadBuilder.Build(484, LocalidadBuenosAires.CoronelBoerr),
                datosEntidadBuilder.Build(485, LocalidadBuenosAires.Rosas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.LeandroNAlem).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(486, LocalidadBuenosAires.Vedia),
                datosEntidadBuilder.Build(487, LocalidadBuenosAires.JuanBautistaAlberdi),
                datosEntidadBuilder.Build(488, LocalidadBuenosAires.LeandroNAlem),
                datosEntidadBuilder.Build(489, LocalidadBuenosAires.AlberdiViejo),
                datosEntidadBuilder.Build(490, LocalidadBuenosAires.ElDorado),
                datosEntidadBuilder.Build(491, LocalidadBuenosAires.FortinAcha)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Lezama).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(492, LocalidadBuenosAires.Lezama)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Lincoln).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(493, LocalidadBuenosAires.Lincoln),
                datosEntidadBuilder.Build(494, LocalidadBuenosAires.Roberts),
                datosEntidadBuilder.Build(495, LocalidadBuenosAires.Pasteur),
                datosEntidadBuilder.Build(496, LocalidadBuenosAires.ElTriunfo),
                datosEntidadBuilder.Build(497, LocalidadBuenosAires.Arenaza),
                datosEntidadBuilder.Build(498, LocalidadBuenosAires.CoronelMartinezDeHoz),
                datosEntidadBuilder.Build(499, LocalidadBuenosAires.Bayauca),
                datosEntidadBuilder.Build(500, LocalidadBuenosAires.LasToscas),
                datosEntidadBuilder.Build(501, LocalidadBuenosAires.CarlosSalas),
                datosEntidadBuilder.Build(502, LocalidadBuenosAires.Triunvirato)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Loberia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(503, LocalidadBuenosAires.Loberia),
                datosEntidadBuilder.Build(504, LocalidadBuenosAires.SanManuel),
                datosEntidadBuilder.Build(505, LocalidadBuenosAires.Tamangueyu),
                datosEntidadBuilder.Build(506, LocalidadBuenosAires.LicenciadoMatienzo),
                datosEntidadBuilder.Build(507, LocalidadBuenosAires.Pieres),
                datosEntidadBuilder.Build(508, LocalidadBuenosAires.ArenasVerdes)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Lobos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(509, LocalidadBuenosAires.AntonioCarboni),
                datosEntidadBuilder.Build(510, LocalidadBuenosAires.Elvira),
                datosEntidadBuilder.Build(511, LocalidadBuenosAires.JoseSantosArevalo),
                datosEntidadBuilder.Build(512, LocalidadBuenosAires.Lobos),
                datosEntidadBuilder.Build(513, LocalidadBuenosAires.EmpalmeLobos),
                datosEntidadBuilder.Build(514, LocalidadBuenosAires.LasChacras),
                datosEntidadBuilder.Build(515, LocalidadBuenosAires.SalvadorMaria),
                datosEntidadBuilder.Build(516, LocalidadBuenosAires.VillaLoguercio),
                datosEntidadBuilder.Build(517, LocalidadBuenosAires.Zapiola)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.LomasDeZamora).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(518, LocalidadBuenosAires.LomasDeZamora),
                datosEntidadBuilder.Build(519, LocalidadBuenosAires.Banfield),
                datosEntidadBuilder.Build(520, LocalidadBuenosAires.Temperley),
                datosEntidadBuilder.Build(521, LocalidadBuenosAires.Llavallol),
                datosEntidadBuilder.Build(522, LocalidadBuenosAires.Turdera),
                datosEntidadBuilder.Build(523, LocalidadBuenosAires.VillaCentenario),
                datosEntidadBuilder.Build(524, LocalidadBuenosAires.VillaFiorito),
                datosEntidadBuilder.Build(525, LocalidadBuenosAires.IngenieroBudge),
                datosEntidadBuilder.Build(526, LocalidadBuenosAires.VillaAlbertina),
                datosEntidadBuilder.Build(527, LocalidadBuenosAires.SanJose)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Lujan).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(528, LocalidadBuenosAires.CarlosKeen),
                datosEntidadBuilder.Build(529, LocalidadBuenosAires.Cortines),
                datosEntidadBuilder.Build(530, LocalidadBuenosAires.JoseMariaJauregui),
                datosEntidadBuilder.Build(531, LocalidadBuenosAires.Lujan),
                datosEntidadBuilder.Build(532, LocalidadBuenosAires.Olivera),
                datosEntidadBuilder.Build(533, LocalidadBuenosAires.OpenDoor),
                datosEntidadBuilder.Build(534, LocalidadBuenosAires.Torres),
                datosEntidadBuilder.Build(535, LocalidadBuenosAires.LezicaYTorrezuri)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Magdalena).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(536, LocalidadBuenosAires.Magdalena),
                datosEntidadBuilder.Build(537, LocalidadBuenosAires.GeneralMansilla),
                datosEntidadBuilder.Build(538, LocalidadBuenosAires.Atalaya),
                datosEntidadBuilder.Build(539, LocalidadBuenosAires.Vieytes),
                datosEntidadBuilder.Build(540, LocalidadBuenosAires.RobertoJPayro),
                datosEntidadBuilder.Build(541, LocalidadBuenosAires.LosNaranjos)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Maipu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(542, LocalidadBuenosAires.Maipu),
                datosEntidadBuilder.Build(543, LocalidadBuenosAires.LasArmas),
                datosEntidadBuilder.Build(544, LocalidadBuenosAires.SantoDomingo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.MalvinasArgentinas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(545, LocalidadBuenosAires.AreaDePromocionElTriangulo),
                datosEntidadBuilder.Build(546, LocalidadBuenosAires.GrandBourg),
                datosEntidadBuilder.Build(547, LocalidadBuenosAires.IngenieroAdolfoSourdeaux),
                datosEntidadBuilder.Build(548, LocalidadBuenosAires.IngenieroPabloNogues),
                datosEntidadBuilder.Build(549, LocalidadBuenosAires.LosPolvorines),
                datosEntidadBuilder.Build(550, LocalidadBuenosAires.Tortuguitas),
                datosEntidadBuilder.Build(551, LocalidadBuenosAires.VillaDeMayo),
                datosEntidadBuilder.Build(552, LocalidadBuenosAires.TierrasAltas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.MarChiquita).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(553, LocalidadBuenosAires.CoronelVidal),
                datosEntidadBuilder.Build(554, LocalidadBuenosAires.GeneralPiran),
                datosEntidadBuilder.Build(555, LocalidadBuenosAires.LaArmonia),
                datosEntidadBuilder.Build(556, LocalidadBuenosAires.MarChiquita),
                datosEntidadBuilder.Build(557, LocalidadBuenosAires.MarDeCobo),
                datosEntidadBuilder.Build(558, LocalidadBuenosAires.LaBaliza),
                datosEntidadBuilder.Build(559, LocalidadBuenosAires.LaCaleta),
                datosEntidadBuilder.Build(560, LocalidadBuenosAires.MarDeCobo),
                datosEntidadBuilder.Build(561, LocalidadBuenosAires.SantaClaraDelMar),
                datosEntidadBuilder.Build(562, LocalidadBuenosAires.Atlantida),
                datosEntidadBuilder.Build(563, LocalidadBuenosAires.CametNorte),
                datosEntidadBuilder.Build(564, LocalidadBuenosAires.FrenteMar),
                datosEntidadBuilder.Build(565, LocalidadBuenosAires.PlayaDorada),
                datosEntidadBuilder.Build(566, LocalidadBuenosAires.SantaClaraDelMar),
                datosEntidadBuilder.Build(567, LocalidadBuenosAires.SantaElena),
                datosEntidadBuilder.Build(568, LocalidadBuenosAires.Vivorata)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.MarcosPaz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(569, LocalidadBuenosAires.MarcosPaz),
                datosEntidadBuilder.Build(570, LocalidadBuenosAires.EliasRomero),
                datosEntidadBuilder.Build(571, LocalidadBuenosAires.SantaRosa),
                datosEntidadBuilder.Build(572, LocalidadBuenosAires.LisandroDeLaTorre),
                datosEntidadBuilder.Build(573, LocalidadBuenosAires.SantaMarta)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Mercedes).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(574, LocalidadBuenosAires.Agote),
                datosEntidadBuilder.Build(575, LocalidadBuenosAires.Altamira),
                datosEntidadBuilder.Build(576, LocalidadBuenosAires.Goldney),
                datosEntidadBuilder.Build(577, LocalidadBuenosAires.Gowland),
                datosEntidadBuilder.Build(578, LocalidadBuenosAires.JMGarcia),
                datosEntidadBuilder.Build(579, LocalidadBuenosAires.LaVerde),
                datosEntidadBuilder.Build(580, LocalidadBuenosAires.Mercedes),
                datosEntidadBuilder.Build(581, LocalidadBuenosAires.TomasJofre)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Merlo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(582, LocalidadBuenosAires.Merlo),
                datosEntidadBuilder.Build(583, LocalidadBuenosAires.SanAntonioDePadua),
                datosEntidadBuilder.Build(584, LocalidadBuenosAires.Libertad),
                datosEntidadBuilder.Build(585, LocalidadBuenosAires.MarianoAcosta),
                datosEntidadBuilder.Build(586, LocalidadBuenosAires.ParqueSanMartin),
                datosEntidadBuilder.Build(587, LocalidadBuenosAires.Pontevedra)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Monte).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(588, LocalidadBuenosAires.SanMiguelDelMonte),
                datosEntidadBuilder.Build(589, LocalidadBuenosAires.Abbott),
                datosEntidadBuilder.Build(590, LocalidadBuenosAires.ZenonVidelaDorna)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.MonteHermoso).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(591, LocalidadBuenosAires.MonteHermoso),
                datosEntidadBuilder.Build(592, LocalidadBuenosAires.BalnearioSauceGrande)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Moreno).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(593, LocalidadBuenosAires.Moreno),
                datosEntidadBuilder.Build(594, LocalidadBuenosAires.LaReja),
                datosEntidadBuilder.Build(595, LocalidadBuenosAires.FranciscoAlvarez),
                datosEntidadBuilder.Build(596, LocalidadBuenosAires.CuartelV),
                datosEntidadBuilder.Build(597, LocalidadBuenosAires.Trujui),
                datosEntidadBuilder.Build(598, LocalidadBuenosAires.PasoDelRey)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Moron).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(599, LocalidadBuenosAires.Moron),
                datosEntidadBuilder.Build(600, LocalidadBuenosAires.Castelar),
                datosEntidadBuilder.Build(601, LocalidadBuenosAires.ElPalomar),
                datosEntidadBuilder.Build(602, LocalidadBuenosAires.Haedo),
                datosEntidadBuilder.Build(603, LocalidadBuenosAires.VillaSarmiento)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Navarro).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(604, LocalidadBuenosAires.Navarro),
                datosEntidadBuilder.Build(605, LocalidadBuenosAires.VillaMoll),
                datosEntidadBuilder.Build(606, LocalidadBuenosAires.LasMarianas),
                datosEntidadBuilder.Build(607, LocalidadBuenosAires.JoseJuanAlmeyra)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Necochea).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(608, LocalidadBuenosAires.Necochea),
                datosEntidadBuilder.Build(609, LocalidadBuenosAires.Quequen),
                datosEntidadBuilder.Build(610, LocalidadBuenosAires.JuanNepomucenoFernandez),
                datosEntidadBuilder.Build(611, LocalidadBuenosAires.LaDulce)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.NueveDeJulio).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(612, LocalidadBuenosAires.NueveDeJulio),
                datosEntidadBuilder.Build(613, LocalidadBuenosAires.Dudignac),
                datosEntidadBuilder.Build(614, LocalidadBuenosAires.AlfredoDemarchi),
                datosEntidadBuilder.Build(615, LocalidadBuenosAires.ManuelBGonnet),
                datosEntidadBuilder.Build(616, LocalidadBuenosAires.Patricios),
                datosEntidadBuilder.Build(617, LocalidadBuenosAires.LaAurora),
                datosEntidadBuilder.Build(618, LocalidadBuenosAires.CarlosMariaNaon),
                datosEntidadBuilder.Build(619, LocalidadBuenosAires.VillaGeneralFournier),
                datosEntidadBuilder.Build(620, LocalidadBuenosAires.Morea),
                datosEntidadBuilder.Build(621, LocalidadBuenosAires.DoceDeOctubre),
                datosEntidadBuilder.Build(622, LocalidadBuenosAires.MarcelinoUgarte),
                datosEntidadBuilder.Build(623, LocalidadBuenosAires.Norumbega)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Olavarria).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(624, LocalidadBuenosAires.SierrasBayas),
                datosEntidadBuilder.Build(625, LocalidadBuenosAires.LomaNegra),
                datosEntidadBuilder.Build(626, LocalidadBuenosAires.SierraChica),
                datosEntidadBuilder.Build(627, LocalidadBuenosAires.Hinojo),
                datosEntidadBuilder.Build(628, LocalidadBuenosAires.ColoniaHinojo),
                datosEntidadBuilder.Build(629, LocalidadBuenosAires.ColoniaSanMiguel),
                datosEntidadBuilder.Build(630, LocalidadBuenosAires.Espigas),
                datosEntidadBuilder.Build(631, LocalidadBuenosAires.Recalde),
                datosEntidadBuilder.Build(632, LocalidadBuenosAires.VillaLaSerrania),
                datosEntidadBuilder.Build(633, LocalidadBuenosAires.SantaLuisa),
                datosEntidadBuilder.Build(634, LocalidadBuenosAires.BlancaGrande),
                datosEntidadBuilder.Build(635, LocalidadBuenosAires.ColoniaNievas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Patagones).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(636, LocalidadBuenosAires.CarmenDePatagones),
                datosEntidadBuilder.Build(637, LocalidadBuenosAires.Villalonga),
                datosEntidadBuilder.Build(638, LocalidadBuenosAires.Stroeder),
                datosEntidadBuilder.Build(639, LocalidadBuenosAires.BahiaSanBlas),
                datosEntidadBuilder.Build(640, LocalidadBuenosAires.JuanAPradere),
                datosEntidadBuilder.Build(641, LocalidadBuenosAires.CardenalCagliero),
                datosEntidadBuilder.Build(642, LocalidadBuenosAires.JoseBCasas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Pehuajo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(643, LocalidadBuenosAires.Pehuajo),
                datosEntidadBuilder.Build(644, LocalidadBuenosAires.JuanJosePaso),
                datosEntidadBuilder.Build(645, LocalidadBuenosAires.MonesCazon),
                datosEntidadBuilder.Build(646, LocalidadBuenosAires.FranciscoMadero),
                datosEntidadBuilder.Build(647, LocalidadBuenosAires.SanBernardoDePehuajo),
                datosEntidadBuilder.Build(648, LocalidadBuenosAires.Magdala),
                datosEntidadBuilder.Build(649, LocalidadBuenosAires.NuevaPlata),
                datosEntidadBuilder.Build(650, LocalidadBuenosAires.Chiclana),
                datosEntidadBuilder.Build(651, LocalidadBuenosAires.CapitanCastro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Pellegrini).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(652, LocalidadBuenosAires.Pellegrini),
                datosEntidadBuilder.Build(653, LocalidadBuenosAires.Bocayuva),
                datosEntidadBuilder.Build(654, LocalidadBuenosAires.DeBary)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Pergamino).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(655, LocalidadBuenosAires.Pergamino),
                datosEntidadBuilder.Build(656, LocalidadBuenosAires.Acevedo),
                datosEntidadBuilder.Build(657, LocalidadBuenosAires.ManuelOcampo),
                datosEntidadBuilder.Build(658, LocalidadBuenosAires.VillaAngelica),
                datosEntidadBuilder.Build(659, LocalidadBuenosAires.JuanAnchorena),
                datosEntidadBuilder.Build(660, LocalidadBuenosAires.LaVioleta),
                datosEntidadBuilder.Build(661, LocalidadBuenosAires.MarianoHAlfonzo),
                datosEntidadBuilder.Build(662, LocalidadBuenosAires.Guerrico),
                datosEntidadBuilder.Build(663, LocalidadBuenosAires.Rancagua),
                datosEntidadBuilder.Build(664, LocalidadBuenosAires.Pinzon),
                datosEntidadBuilder.Build(665, LocalidadBuenosAires.Fontezuela),
                datosEntidadBuilder.Build(666, LocalidadBuenosAires.JADeLaPena),
                datosEntidadBuilder.Build(667, LocalidadBuenosAires.MarianoBenitez),
                datosEntidadBuilder.Build(668, LocalidadBuenosAires.VillaSanJose)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Pila).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(669, LocalidadBuenosAires.Pila),
                datosEntidadBuilder.Build(670, LocalidadBuenosAires.Casalins)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Pilar).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(671, LocalidadBuenosAires.DelViso),
                datosEntidadBuilder.Build(672, LocalidadBuenosAires.Fatima),
                datosEntidadBuilder.Build(673, LocalidadBuenosAires.LaLonja),
                datosEntidadBuilder.Build(674, LocalidadBuenosAires.Manzanares),
                datosEntidadBuilder.Build(675, LocalidadBuenosAires.DelPilar),
                datosEntidadBuilder.Build(676, LocalidadBuenosAires.PilarSur),
                datosEntidadBuilder.Build(677, LocalidadBuenosAires.Champagnat),
                datosEntidadBuilder.Build(678, LocalidadBuenosAires.SanFrancisco),
                datosEntidadBuilder.Build(679, LocalidadBuenosAires.PresidenteDerqui),
                datosEntidadBuilder.Build(680, LocalidadBuenosAires.VillaAstolfi),
                datosEntidadBuilder.Build(681, LocalidadBuenosAires.Manzone),
                datosEntidadBuilder.Build(682, LocalidadBuenosAires.ManuelAlberti),
                datosEntidadBuilder.Build(683, LocalidadBuenosAires.Lagomarsino),
                datosEntidadBuilder.Build(684, LocalidadBuenosAires.VillaRosa),
                datosEntidadBuilder.Build(685, LocalidadBuenosAires.Zelaya)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Pinamar).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(686, LocalidadBuenosAires.Montecarlo),
                datosEntidadBuilder.Build(687, LocalidadBuenosAires.Pinamar),
                datosEntidadBuilder.Build(688, LocalidadBuenosAires.MarDeOstende),
                datosEntidadBuilder.Build(689, LocalidadBuenosAires.Ostende),
                datosEntidadBuilder.Build(690, LocalidadBuenosAires.ValeriaDelMar),
                datosEntidadBuilder.Build(691, LocalidadBuenosAires.Carilo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.PresidentePeron).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(692, LocalidadBuenosAires.Guernica)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Puan).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(693, LocalidadBuenosAires.Azopardo),
                datosEntidadBuilder.Build(694, LocalidadBuenosAires.Bordenave),
                datosEntidadBuilder.Build(695, LocalidadBuenosAires.Darregueira),
                datosEntidadBuilder.Build(696, LocalidadBuenosAires.Estela),
                datosEntidadBuilder.Build(697, LocalidadBuenosAires.FelipeSola),
                datosEntidadBuilder.Build(698, LocalidadBuenosAires.LopezLecube),
                datosEntidadBuilder.Build(699, LocalidadBuenosAires.Puan),
                datosEntidadBuilder.Build(700, LocalidadBuenosAires.SanGerman),
                datosEntidadBuilder.Build(701, LocalidadBuenosAires.TresCuervos),
                datosEntidadBuilder.Build(702, LocalidadBuenosAires.Viboras),
                datosEntidadBuilder.Build(703, LocalidadBuenosAires.VillaCastelar),
                datosEntidadBuilder.Build(704, LocalidadBuenosAires.VillaDurcudoy),
                datosEntidadBuilder.Build(705, LocalidadBuenosAires.VillaIris)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.PuntaIndio).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(706, LocalidadBuenosAires.Veronica),
                datosEntidadBuilder.Build(707, LocalidadBuenosAires.Pipinas),
                datosEntidadBuilder.Build(708, LocalidadBuenosAires.PuntaDelIndio),
                datosEntidadBuilder.Build(709, LocalidadBuenosAires.AlvarezJonte),
                datosEntidadBuilder.Build(710, LocalidadBuenosAires.LasTahonas),
                datosEntidadBuilder.Build(711, LocalidadBuenosAires.MonteVeloz)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Quilmes).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(712, LocalidadBuenosAires.BernalEste),
                datosEntidadBuilder.Build(713, LocalidadBuenosAires.BernalOeste),
                datosEntidadBuilder.Build(714, LocalidadBuenosAires.DonBosco),
                datosEntidadBuilder.Build(715, LocalidadBuenosAires.Ezpeleta),
                datosEntidadBuilder.Build(716, LocalidadBuenosAires.EzpeletaOeste),
                datosEntidadBuilder.Build(717, LocalidadBuenosAires.Quilmes),
                datosEntidadBuilder.Build(718, LocalidadBuenosAires.QuilmesOeste),
                datosEntidadBuilder.Build(719, LocalidadBuenosAires.SanFranciscoSolano),
                datosEntidadBuilder.Build(720, LocalidadBuenosAires.VillaLaFlorida)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Ramallo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(721, LocalidadBuenosAires.Ramallo),
                datosEntidadBuilder.Build(722, LocalidadBuenosAires.ElParaiso),
                datosEntidadBuilder.Build(723, LocalidadBuenosAires.PerezMillan),
                datosEntidadBuilder.Build(724, LocalidadBuenosAires.VillaRamallo),
                datosEntidadBuilder.Build(725, LocalidadBuenosAires.VillaGeneralSavio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Rauch).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(726, LocalidadBuenosAires.Rauch)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Rivadavia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(727, LocalidadBuenosAires.America),
                datosEntidadBuilder.Build(728, LocalidadBuenosAires.GonzalezMoreno),
                datosEntidadBuilder.Build(729, LocalidadBuenosAires.FortinOlavarria),
                datosEntidadBuilder.Build(730, LocalidadBuenosAires.Sansinena),
                datosEntidadBuilder.Build(731, LocalidadBuenosAires.Roosevelt),
                datosEntidadBuilder.Build(732, LocalidadBuenosAires.Sundblad),
                datosEntidadBuilder.Build(733, LocalidadBuenosAires.MiraPampa),
                datosEntidadBuilder.Build(734, LocalidadBuenosAires.SanMauricio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Rojas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(735, LocalidadBuenosAires.Rojas),
                datosEntidadBuilder.Build(736, LocalidadBuenosAires.LasCarabelas),
                datosEntidadBuilder.Build(737, LocalidadBuenosAires.RafaelObligado),
                datosEntidadBuilder.Build(738, LocalidadBuenosAires.LosIndios),
                datosEntidadBuilder.Build(739, LocalidadBuenosAires.VillaManuelPomar),
                datosEntidadBuilder.Build(740, LocalidadBuenosAires.LaBeba),
                datosEntidadBuilder.Build(741, LocalidadBuenosAires.VillaParqueCecir),
                datosEntidadBuilder.Build(742, LocalidadBuenosAires.RobertoCano),
                datosEntidadBuilder.Build(743, LocalidadBuenosAires.SolDeMayo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.RoquePerez).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(744, LocalidadBuenosAires.RoquePerez),
                datosEntidadBuilder.Build(745, LocalidadBuenosAires.CarlosBeguerie),
                datosEntidadBuilder.Build(746, LocalidadBuenosAires.SantiagoLarre),
                datosEntidadBuilder.Build(747, LocalidadBuenosAires.LaReforma),
                datosEntidadBuilder.Build(748, LocalidadBuenosAires.JuanTronconi),
                datosEntidadBuilder.Build(749, LocalidadBuenosAires.LaPaz),
                datosEntidadBuilder.Build(750, LocalidadBuenosAires.LaPazChica),
                datosEntidadBuilder.Build(751, LocalidadBuenosAires.Atucha)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Saavedra).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(752, LocalidadBuenosAires.Pigue),
                datosEntidadBuilder.Build(753, LocalidadBuenosAires.Saavedra),
                datosEntidadBuilder.Build(754, LocalidadBuenosAires.Espartillar),
                datosEntidadBuilder.Build(755, LocalidadBuenosAires.Goyena),
                datosEntidadBuilder.Build(756, LocalidadBuenosAires.ArroyoCorto),
                datosEntidadBuilder.Build(757, LocalidadBuenosAires.Dufaur),
                datosEntidadBuilder.Build(758, LocalidadBuenosAires.ColoniaSanMartin)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Saladillo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(759, LocalidadBuenosAires.Saladillo),
                datosEntidadBuilder.Build(760, LocalidadBuenosAires.DelCarril),
                datosEntidadBuilder.Build(761, LocalidadBuenosAires.Polvaredas),
                datosEntidadBuilder.Build(762, LocalidadBuenosAires.Cazon),
                datosEntidadBuilder.Build(763, LocalidadBuenosAires.AlvarezDeToledo),
                datosEntidadBuilder.Build(764, LocalidadBuenosAires.JuanJoseBlaquier)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Salliquelo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(765, LocalidadBuenosAires.Salliquelo),
                datosEntidadBuilder.Build(766, LocalidadBuenosAires.Quenuma)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Salto).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(767, LocalidadBuenosAires.Salto),
                datosEntidadBuilder.Build(768, LocalidadBuenosAires.ArroyoDulce),
                datosEntidadBuilder.Build(769, LocalidadBuenosAires.InesIndart),
                datosEntidadBuilder.Build(770, LocalidadBuenosAires.Gahan),
                datosEntidadBuilder.Build(771, LocalidadBuenosAires.Berdier),
                datosEntidadBuilder.Build(772, LocalidadBuenosAires.LaInvencible)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.SanAndresDeGiles).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(773, LocalidadBuenosAires.SanAndresDeGiles),
                datosEntidadBuilder.Build(774, LocalidadBuenosAires.Solis),
                datosEntidadBuilder.Build(775, LocalidadBuenosAires.VillaRuiz),
                datosEntidadBuilder.Build(776, LocalidadBuenosAires.Cucullu),
                datosEntidadBuilder.Build(777, LocalidadBuenosAires.Azcuenaga),
                datosEntidadBuilder.Build(778, LocalidadBuenosAires.VillaEspil),
                datosEntidadBuilder.Build(779, LocalidadBuenosAires.Franklin)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.SanAntonioDeAreco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(780, LocalidadBuenosAires.SanAntonioDeAreco),
                datosEntidadBuilder.Build(781, LocalidadBuenosAires.VillaLia),
                datosEntidadBuilder.Build(782, LocalidadBuenosAires.Duggan),
                datosEntidadBuilder.Build(783, LocalidadBuenosAires.Vagues)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.SanCayetano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(784, LocalidadBuenosAires.SanCayetano),
                datosEntidadBuilder.Build(785, LocalidadBuenosAires.Ochandio),
                datosEntidadBuilder.Build(786, LocalidadBuenosAires.BalnearioSanCayetano)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.SanFernando).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(787, LocalidadBuenosAires.SanFernando),
                datosEntidadBuilder.Build(788, LocalidadBuenosAires.Victoria),
                datosEntidadBuilder.Build(789, LocalidadBuenosAires.Virreyes),
                datosEntidadBuilder.Build(790, LocalidadBuenosAires.Islas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.SanIsidro).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(791, LocalidadBuenosAires.VillaAdelina),
                datosEntidadBuilder.Build(792, LocalidadBuenosAires.BoulogneSurMer),
                datosEntidadBuilder.Build(793, LocalidadBuenosAires.Martinez),
                datosEntidadBuilder.Build(794, LocalidadBuenosAires.Acassuso),
                datosEntidadBuilder.Build(795, LocalidadBuenosAires.SanIsidro),
                datosEntidadBuilder.Build(796, LocalidadBuenosAires.Beccar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.SanMiguel).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(797, LocalidadBuenosAires.SanMiguel),
                datosEntidadBuilder.Build(798, LocalidadBuenosAires.BellaVista),
                datosEntidadBuilder.Build(799, LocalidadBuenosAires.CampoDeMayo),
                datosEntidadBuilder.Build(800, LocalidadBuenosAires.Muniz),
                datosEntidadBuilder.Build(801, LocalidadBuenosAires.SantaMaria)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.SanNicolas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(802, LocalidadBuenosAires.CamposSalles),
                datosEntidadBuilder.Build(803, LocalidadBuenosAires.Conesa),
                datosEntidadBuilder.Build(804, LocalidadBuenosAires.Erezcano),
                datosEntidadBuilder.Build(805, LocalidadBuenosAires.GeneralRojo),
                datosEntidadBuilder.Build(806, LocalidadBuenosAires.LaEmilia),
                datosEntidadBuilder.Build(807, LocalidadBuenosAires.SanNicolasDeLosArroyos),
                datosEntidadBuilder.Build(808, LocalidadBuenosAires.VillaCampi),
                datosEntidadBuilder.Build(809, LocalidadBuenosAires.VillaCanto),
                datosEntidadBuilder.Build(810, LocalidadBuenosAires.VillaEsperanza),
                datosEntidadBuilder.Build(811, LocalidadBuenosAires.VillaHermosa),
                datosEntidadBuilder.Build(812, LocalidadBuenosAires.VillaRiccio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.SanPedro).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(813, LocalidadBuenosAires.SanPedro),
                datosEntidadBuilder.Build(814, LocalidadBuenosAires.GobernadorCastro),
                datosEntidadBuilder.Build(815, LocalidadBuenosAires.SantaLucia),
                datosEntidadBuilder.Build(816, LocalidadBuenosAires.RioTala),
                datosEntidadBuilder.Build(817, LocalidadBuenosAires.PuebloDoyle),
                datosEntidadBuilder.Build(818, LocalidadBuenosAires.Obligado)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.SanVicente).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(819, LocalidadBuenosAires.SanVicente),
                datosEntidadBuilder.Build(820, LocalidadBuenosAires.AlejandroKorn),
                datosEntidadBuilder.Build(821, LocalidadBuenosAires.Domselaar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Suipacha).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(822, LocalidadBuenosAires.Suipacha),
                datosEntidadBuilder.Build(823, LocalidadBuenosAires.GeneralRivas),
                datosEntidadBuilder.Build(824, LocalidadBuenosAires.RomanBaez)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Tandil).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(825, LocalidadBuenosAires.Tandil),
                datosEntidadBuilder.Build(826, LocalidadBuenosAires.MariaIgnacia),
                datosEntidadBuilder.Build(827, LocalidadBuenosAires.Gardey),
                datosEntidadBuilder.Build(828, LocalidadBuenosAires.DeLaCanal),
                datosEntidadBuilder.Build(829, LocalidadBuenosAires.DesvioAguirre)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Tapalque).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(830, LocalidadBuenosAires.Tapalque),
                datosEntidadBuilder.Build(831, LocalidadBuenosAires.Altona),
                datosEntidadBuilder.Build(832, LocalidadBuenosAires.Crotto),
                datosEntidadBuilder.Build(833, LocalidadBuenosAires.EufemioUballes),
                datosEntidadBuilder.Build(834, LocalidadBuenosAires.Yerbas),
                datosEntidadBuilder.Build(835, LocalidadBuenosAires.SanBernardo),
                datosEntidadBuilder.Build(836, LocalidadBuenosAires.Covello),
                datosEntidadBuilder.Build(837, LocalidadBuenosAires.Velloso),
                datosEntidadBuilder.Build(838, LocalidadBuenosAires.LaPaloma)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Tigre).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(839, LocalidadBuenosAires.Tigre),
                datosEntidadBuilder.Build(840, LocalidadBuenosAires.DonTorcuato),
                datosEntidadBuilder.Build(841, LocalidadBuenosAires.GeneralPacheco),
                datosEntidadBuilder.Build(842, LocalidadBuenosAires.ElTalar),
                datosEntidadBuilder.Build(843, LocalidadBuenosAires.TroncosDelTalar),
                datosEntidadBuilder.Build(844, LocalidadBuenosAires.Benavidez),
                datosEntidadBuilder.Build(845, LocalidadBuenosAires.DiqueLujan),
                datosEntidadBuilder.Build(846, LocalidadBuenosAires.RicardoRojas),
                datosEntidadBuilder.Build(847, LocalidadBuenosAires.RinconDeMilberg),
                datosEntidadBuilder.Build(848, LocalidadBuenosAires.Nordelta),
                datosEntidadBuilder.Build(849, LocalidadBuenosAires.DeltaDelTigre)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Tordillo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(850, LocalidadBuenosAires.GeneralConesa),
                datosEntidadBuilder.Build(851, LocalidadBuenosAires.VillaRoch)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Tornquist).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(852, LocalidadBuenosAires.Tornquist),
                datosEntidadBuilder.Build(853, LocalidadBuenosAires.SierraDeLaVentana),
                datosEntidadBuilder.Build(854, LocalidadBuenosAires.Saldungaray),
                datosEntidadBuilder.Build(855, LocalidadBuenosAires.VillaVentana),
                datosEntidadBuilder.Build(856, LocalidadBuenosAires.Chasico),
                datosEntidadBuilder.Build(857, LocalidadBuenosAires.TresPicos),
                datosEntidadBuilder.Build(858, LocalidadBuenosAires.VillaSerranaLaGruta)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.TrenqueLauquen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(859, LocalidadBuenosAires.TrenqueLauquen),
                datosEntidadBuilder.Build(860, LocalidadBuenosAires.TreintaDeAgosto),
                datosEntidadBuilder.Build(861, LocalidadBuenosAires.Beruti),
                datosEntidadBuilder.Build(862, LocalidadBuenosAires.Girodias),
                datosEntidadBuilder.Build(863, LocalidadBuenosAires.LaCarreta),
                datosEntidadBuilder.Build(864, LocalidadBuenosAires.Garre)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.TresArroyos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(865, LocalidadBuenosAires.TresArroyos),
                datosEntidadBuilder.Build(866, LocalidadBuenosAires.Claromeco),
                datosEntidadBuilder.Build(867, LocalidadBuenosAires.Orense),
                datosEntidadBuilder.Build(868, LocalidadBuenosAires.Copetonas),
                datosEntidadBuilder.Build(869, LocalidadBuenosAires.MicaelaCascallares),
                datosEntidadBuilder.Build(870, LocalidadBuenosAires.SanFranciscoDeBellocq),
                datosEntidadBuilder.Build(871, LocalidadBuenosAires.Reta),
                datosEntidadBuilder.Build(872, LocalidadBuenosAires.BalnearioOrense),
                datosEntidadBuilder.Build(873, LocalidadBuenosAires.SanMayol),
                datosEntidadBuilder.Build(874, LocalidadBuenosAires.LinCalel),
                datosEntidadBuilder.Build(875, LocalidadBuenosAires.Barrow)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.TresDeFebrero).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(876, LocalidadBuenosAires.Caseros),
                datosEntidadBuilder.Build(877, LocalidadBuenosAires.Churruca),
                datosEntidadBuilder.Build(878, LocalidadBuenosAires.CiudadJardinLomasDelPalomar),
                datosEntidadBuilder.Build(879, LocalidadBuenosAires.Ciudadela),
                datosEntidadBuilder.Build(880, LocalidadBuenosAires.ElLibertador),
                datosEntidadBuilder.Build(881, LocalidadBuenosAires.JoseIngenieros),
                datosEntidadBuilder.Build(882, LocalidadBuenosAires.LomaHermosa),
                datosEntidadBuilder.Build(883, LocalidadBuenosAires.MartinCoronado),
                datosEntidadBuilder.Build(884, LocalidadBuenosAires.OnceDeSeptiembre),
                datosEntidadBuilder.Build(885, LocalidadBuenosAires.PabloPodesta),
                datosEntidadBuilder.Build(886, LocalidadBuenosAires.RemediosDeEscalada),
                datosEntidadBuilder.Build(887, LocalidadBuenosAires.SaenzPena),
                datosEntidadBuilder.Build(888, LocalidadBuenosAires.SantosLugares),
                datosEntidadBuilder.Build(889, LocalidadBuenosAires.VillaBosch),
                datosEntidadBuilder.Build(890, LocalidadBuenosAires.VillaRaffo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.TresLomas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(891, LocalidadBuenosAires.TresLomas),
                datosEntidadBuilder.Build(892, LocalidadBuenosAires.IngenieroThompson)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.VeinticincoDeMayo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(893, LocalidadBuenosAires.VeinticincoDeMayo),
                datosEntidadBuilder.Build(894, LocalidadBuenosAires.NorbertoDeLaRiestra),
                datosEntidadBuilder.Build(895, LocalidadBuenosAires.Pedernales),
                datosEntidadBuilder.Build(896, LocalidadBuenosAires.DelValle),
                datosEntidadBuilder.Build(897, LocalidadBuenosAires.GobernadorUgarte),
                datosEntidadBuilder.Build(898, LocalidadBuenosAires.Valdes),
                datosEntidadBuilder.Build(899, LocalidadBuenosAires.SanEnrique),
                datosEntidadBuilder.Build(900, LocalidadBuenosAires.AgustinMosconi),
                datosEntidadBuilder.Build(901, LocalidadBuenosAires.Ernestina),
                datosEntidadBuilder.Build(902, LocalidadBuenosAires.LucasMonteverde)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.VicenteLopez).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(903, LocalidadBuenosAires.VicenteLopez),
                datosEntidadBuilder.Build(904, LocalidadBuenosAires.Olivos),
                datosEntidadBuilder.Build(905, LocalidadBuenosAires.Florida),
                datosEntidadBuilder.Build(906, LocalidadBuenosAires.LaLucila),
                datosEntidadBuilder.Build(907, LocalidadBuenosAires.VillaMartelli),
                datosEntidadBuilder.Build(908, LocalidadBuenosAires.FloridaOeste),
                datosEntidadBuilder.Build(909, LocalidadBuenosAires.Munro),
                datosEntidadBuilder.Build(910, LocalidadBuenosAires.Carapachay),
                datosEntidadBuilder.Build(911, LocalidadBuenosAires.VillaAdelina)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.VillaGesell).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(912, LocalidadBuenosAires.LasGaviotas),
                datosEntidadBuilder.Build(913, LocalidadBuenosAires.MarAzul),
                datosEntidadBuilder.Build(914, LocalidadBuenosAires.MarDeLasPampas),
                datosEntidadBuilder.Build(915, LocalidadBuenosAires.VillaGesell)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Villarino).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(916, LocalidadBuenosAires.PedroLuro),
                datosEntidadBuilder.Build(917, LocalidadBuenosAires.MayorBuratovich),
                datosEntidadBuilder.Build(918, LocalidadBuenosAires.Medanos),
                datosEntidadBuilder.Build(919, LocalidadBuenosAires.JuanCouste),
                datosEntidadBuilder.Build(920, LocalidadBuenosAires.HilarioAscasubi),
                datosEntidadBuilder.Build(921, LocalidadBuenosAires.TenienteOrigone),
                datosEntidadBuilder.Build(922, LocalidadBuenosAires.ColoniaSanAdolfo),
                datosEntidadBuilder.Build(923, LocalidadBuenosAires.Argerich),
                datosEntidadBuilder.Build(924, LocalidadBuenosAires.LagunaChasico),
                datosEntidadBuilder.Build(925, LocalidadBuenosAires.BalnearioLaChiquita)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoBuenosAires.Zarate).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(926, LocalidadBuenosAires.Zarate),
                datosEntidadBuilder.Build(927, LocalidadBuenosAires.Lima),
                datosEntidadBuilder.Build(928, LocalidadBuenosAires.BarrioSaavedra),
                datosEntidadBuilder.Build(929, LocalidadBuenosAires.CountryClubElCasco),
                datosEntidadBuilder.Build(930, LocalidadBuenosAires.Escalada),
                datosEntidadBuilder.Build(931, LocalidadBuenosAires.ParajeOrtiz)
            });
        }
    }
}
