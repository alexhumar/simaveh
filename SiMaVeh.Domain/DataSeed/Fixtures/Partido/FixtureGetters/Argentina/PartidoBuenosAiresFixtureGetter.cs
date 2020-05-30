﻿using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoBuenosAiresFixtureGetter : PartidoFixtureGetter
    {
        public PartidoBuenosAiresFixtureGetter(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.BuenosAires).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1, PartidoBuenosAires.AdolfoAlsina),
                datosEntidadBuilder.Build(2, PartidoBuenosAires.AdolfoGonzalesChaves),
                datosEntidadBuilder.Build(3, PartidoBuenosAires.Alberti),
                datosEntidadBuilder.Build(4, PartidoBuenosAires.AlmiranteBrown),
                datosEntidadBuilder.Build(5, PartidoBuenosAires.Arrecifes),
                datosEntidadBuilder.Build(6, PartidoBuenosAires.Avellaneda),
                datosEntidadBuilder.Build(7, PartidoBuenosAires.Ayacucho),
                datosEntidadBuilder.Build(8, PartidoBuenosAires.Azul),
                datosEntidadBuilder.Build(9, PartidoBuenosAires.BahiaBlanca),
                datosEntidadBuilder.Build(10, PartidoBuenosAires.Balcarce),
                datosEntidadBuilder.Build(11, PartidoBuenosAires.Baradero),
                datosEntidadBuilder.Build(12, PartidoBuenosAires.BenitoJuarez),
                datosEntidadBuilder.Build(13, PartidoBuenosAires.Berazategui),
                datosEntidadBuilder.Build(14, PartidoBuenosAires.Berisso),
                datosEntidadBuilder.Build(15, PartidoBuenosAires.Bolivar),
                datosEntidadBuilder.Build(16, PartidoBuenosAires.Bragado),
                datosEntidadBuilder.Build(17, PartidoBuenosAires.Brandsen),
                datosEntidadBuilder.Build(18, PartidoBuenosAires.Campana),
                datosEntidadBuilder.Build(19, PartidoBuenosAires.Canuelas),
                datosEntidadBuilder.Build(20, PartidoBuenosAires.CapitanSarmiento),
                datosEntidadBuilder.Build(21, PartidoBuenosAires.CarlosCasares),
                datosEntidadBuilder.Build(22, PartidoBuenosAires.CarlosTejedor),
                datosEntidadBuilder.Build(23, PartidoBuenosAires.CarmenDeAreco),
                datosEntidadBuilder.Build(24, PartidoBuenosAires.Castelli),
                datosEntidadBuilder.Build(25, PartidoBuenosAires.Chacabuco),
                datosEntidadBuilder.Build(26, PartidoBuenosAires.Chascomus),
                datosEntidadBuilder.Build(27, PartidoBuenosAires.Chivilcoy),
                datosEntidadBuilder.Build(28, PartidoBuenosAires.Colon),
                datosEntidadBuilder.Build(29, PartidoBuenosAires.CoronelDorrego),
                datosEntidadBuilder.Build(30, PartidoBuenosAires.CoronelPringles),
                datosEntidadBuilder.Build(31, PartidoBuenosAires.CoronelRosales),
                datosEntidadBuilder.Build(32, PartidoBuenosAires.CoronelSuarez),
                datosEntidadBuilder.Build(33, PartidoBuenosAires.Daireaux),
                datosEntidadBuilder.Build(34, PartidoBuenosAires.Dolores),
                datosEntidadBuilder.Build(35, PartidoBuenosAires.Ensenada),
                datosEntidadBuilder.Build(36, PartidoBuenosAires.Escobar),
                datosEntidadBuilder.Build(37, PartidoBuenosAires.EstebanEcheverria),
                datosEntidadBuilder.Build(38, PartidoBuenosAires.ExaltacionDeLaCruz),
                datosEntidadBuilder.Build(39, PartidoBuenosAires.Ezeiza),
                datosEntidadBuilder.Build(40, PartidoBuenosAires.FlorencioVarela),
                datosEntidadBuilder.Build(41, PartidoBuenosAires.FlorentinoAmeghino),
                datosEntidadBuilder.Build(42, PartidoBuenosAires.GeneralAlvarado),
                datosEntidadBuilder.Build(43, PartidoBuenosAires.GeneralAlvear),
                datosEntidadBuilder.Build(44, PartidoBuenosAires.GeneralArenales),
                datosEntidadBuilder.Build(45, PartidoBuenosAires.GeneralBelgrano),
                datosEntidadBuilder.Build(46, PartidoBuenosAires.GeneralGuido),
                datosEntidadBuilder.Build(47, PartidoBuenosAires.GeneralJuanMadariaga),
                datosEntidadBuilder.Build(48, PartidoBuenosAires.GeneralLaMadrid),
                datosEntidadBuilder.Build(49, PartidoBuenosAires.GeneralLasHeras),
                datosEntidadBuilder.Build(50, PartidoBuenosAires.GeneralLavalle),
                datosEntidadBuilder.Build(51, PartidoBuenosAires.GeneralPaz),
                datosEntidadBuilder.Build(52, PartidoBuenosAires.GeneralPinto),
                datosEntidadBuilder.Build(53, PartidoBuenosAires.GeneralPueyrredon),
                datosEntidadBuilder.Build(54, PartidoBuenosAires.GeneralRodriguez),
                datosEntidadBuilder.Build(55, PartidoBuenosAires.GeneralSanMartin),
                datosEntidadBuilder.Build(56, PartidoBuenosAires.GeneralViamonte),
                datosEntidadBuilder.Build(57, PartidoBuenosAires.GeneralVillegas),
                datosEntidadBuilder.Build(58, PartidoBuenosAires.Guamini),
                datosEntidadBuilder.Build(59, PartidoBuenosAires.HipolitoYrigoyen),
                datosEntidadBuilder.Build(60, PartidoBuenosAires.Hurlingham),
                datosEntidadBuilder.Build(61, PartidoBuenosAires.Ituzaingo),
                datosEntidadBuilder.Build(62, PartidoBuenosAires.JoseCPaz),
                datosEntidadBuilder.Build(63, PartidoBuenosAires.Junin),
                datosEntidadBuilder.Build(64, PartidoBuenosAires.LaCosta),
                datosEntidadBuilder.Build(65, PartidoBuenosAires.LaMatanza),
                datosEntidadBuilder.Build(66, PartidoBuenosAires.LaPlata),
                datosEntidadBuilder.Build(67, PartidoBuenosAires.Lanus),
                datosEntidadBuilder.Build(68, PartidoBuenosAires.Laprida),
                datosEntidadBuilder.Build(69, PartidoBuenosAires.LasFlores),
                datosEntidadBuilder.Build(70, PartidoBuenosAires.LeandroNAlem),
                datosEntidadBuilder.Build(71, PartidoBuenosAires.Lezama),
                datosEntidadBuilder.Build(72, PartidoBuenosAires.Lincoln),
                datosEntidadBuilder.Build(73, PartidoBuenosAires.Loberia),
                datosEntidadBuilder.Build(74, PartidoBuenosAires.Lobos),
                datosEntidadBuilder.Build(75, PartidoBuenosAires.LomasDeZamora),
                datosEntidadBuilder.Build(76, PartidoBuenosAires.Lujan),
                datosEntidadBuilder.Build(77, PartidoBuenosAires.Magdalena),
                datosEntidadBuilder.Build(78, PartidoBuenosAires.Maipu),
                datosEntidadBuilder.Build(79, PartidoBuenosAires.MalvinasArgentinas),
                datosEntidadBuilder.Build(80, PartidoBuenosAires.MarChiquita),
                datosEntidadBuilder.Build(81, PartidoBuenosAires.MarcosPaz),
                datosEntidadBuilder.Build(82, PartidoBuenosAires.Mercedes),
                datosEntidadBuilder.Build(83, PartidoBuenosAires.Merlo),
                datosEntidadBuilder.Build(84, PartidoBuenosAires.Monte),
                datosEntidadBuilder.Build(85, PartidoBuenosAires.MonteHermoso),
                datosEntidadBuilder.Build(86, PartidoBuenosAires.Moreno),
                datosEntidadBuilder.Build(87, PartidoBuenosAires.Moron),
                datosEntidadBuilder.Build(88, PartidoBuenosAires.Navarro),
                datosEntidadBuilder.Build(89, PartidoBuenosAires.Necochea),
                datosEntidadBuilder.Build(90, PartidoBuenosAires.NueveDeJulio),
                datosEntidadBuilder.Build(91, PartidoBuenosAires.Olavarria),
                datosEntidadBuilder.Build(92, PartidoBuenosAires.Patagones),
                datosEntidadBuilder.Build(93, PartidoBuenosAires.Pehuajo),
                datosEntidadBuilder.Build(94, PartidoBuenosAires.Pellegrini),
                datosEntidadBuilder.Build(95, PartidoBuenosAires.Pergamino),
                datosEntidadBuilder.Build(96, PartidoBuenosAires.Pila),
                datosEntidadBuilder.Build(97, PartidoBuenosAires.Pilar),
                datosEntidadBuilder.Build(98, PartidoBuenosAires.Pinamar),
                datosEntidadBuilder.Build(99, PartidoBuenosAires.PresidentePeron),
                datosEntidadBuilder.Build(100, PartidoBuenosAires.Puan),
                datosEntidadBuilder.Build(101, PartidoBuenosAires.PuntaIndio),
                datosEntidadBuilder.Build(102, PartidoBuenosAires.Quilmes),
                datosEntidadBuilder.Build(103, PartidoBuenosAires.Ramallo),
                datosEntidadBuilder.Build(104, PartidoBuenosAires.Rauch),
                datosEntidadBuilder.Build(105, PartidoBuenosAires.Rivadavia),
                datosEntidadBuilder.Build(106, PartidoBuenosAires.Rojas),
                datosEntidadBuilder.Build(107, PartidoBuenosAires.RoquePerez),
                datosEntidadBuilder.Build(108, PartidoBuenosAires.Saavedra),
                datosEntidadBuilder.Build(109, PartidoBuenosAires.Saladillo),
                datosEntidadBuilder.Build(110, PartidoBuenosAires.Salliquelo),
                datosEntidadBuilder.Build(111, PartidoBuenosAires.Salto),
                datosEntidadBuilder.Build(112, PartidoBuenosAires.SanAndresDeGiles),
                datosEntidadBuilder.Build(113, PartidoBuenosAires.SanAntonioDeAreco),
                datosEntidadBuilder.Build(114, PartidoBuenosAires.SanCayetano),
                datosEntidadBuilder.Build(115, PartidoBuenosAires.SanFernando),
                datosEntidadBuilder.Build(116, PartidoBuenosAires.SanIsidro),
                datosEntidadBuilder.Build(117, PartidoBuenosAires.SanMiguel),
                datosEntidadBuilder.Build(118, PartidoBuenosAires.SanNicolas),
                datosEntidadBuilder.Build(119, PartidoBuenosAires.SanPedro),
                datosEntidadBuilder.Build(120, PartidoBuenosAires.SanVicente),
                datosEntidadBuilder.Build(121, PartidoBuenosAires.Suipacha),
                datosEntidadBuilder.Build(122, PartidoBuenosAires.Tandil),
                datosEntidadBuilder.Build(123, PartidoBuenosAires.Tapalque),
                datosEntidadBuilder.Build(124, PartidoBuenosAires.Tigre),
                datosEntidadBuilder.Build(125, PartidoBuenosAires.Tordillo),
                datosEntidadBuilder.Build(126, PartidoBuenosAires.Tornquist),
                datosEntidadBuilder.Build(127, PartidoBuenosAires.TrenqueLauquen),
                datosEntidadBuilder.Build(128, PartidoBuenosAires.TresArroyos),
                datosEntidadBuilder.Build(129, PartidoBuenosAires.TresDeFebrero),
                datosEntidadBuilder.Build(130, PartidoBuenosAires.TresLomas),
                datosEntidadBuilder.Build(131, PartidoBuenosAires.VeinticincoDeMayo),
                datosEntidadBuilder.Build(132, PartidoBuenosAires.VicenteLopez),
                datosEntidadBuilder.Build(133, PartidoBuenosAires.VillaGesell),
                datosEntidadBuilder.Build(134, PartidoBuenosAires.Villarino),
                datosEntidadBuilder.Build(135, PartidoBuenosAires.Zarate)
            });
        }
    }
}
