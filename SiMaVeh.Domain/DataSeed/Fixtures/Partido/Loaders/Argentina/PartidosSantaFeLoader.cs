using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosSantaFeLoader : PartidosLoader
    {
        public PartidosSantaFeLoader(IProvinciasLoader<long, long, string> provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.SantaFe).Key, new Dictionary<long, string>
            {
                { 447, PartidoSantaFe.Rosario },
                { 448, PartidoSantaFe.LaCapital },
                { 449, PartidoSantaFe.GeneralLopez },
                { 450, PartidoSantaFe.Castellanos },
                { 451, PartidoSantaFe.GeneralObligado },
                { 452, PartidoSantaFe.SanLorenzo },
                { 453, PartidoSantaFe.LasColonias },
                { 454, PartidoSantaFe.Constitucion },
                { 455, PartidoSantaFe.Caseros },
                { 456, PartidoSantaFe.SanJeronimo },
                { 457, PartidoSantaFe.SanCristobal },
                { 458, PartidoSantaFe.Iriondo },
                { 459, PartidoSantaFe.SanMartin },
                { 460, PartidoSantaFe.Vera },
                { 461, PartidoSantaFe.Belgrano },
                { 462, PartidoSantaFe.SanJusto },
                { 463, PartidoSantaFe.SanJavier },
                { 464, PartidoSantaFe.NueveDeJulio },
                { 465, PartidoSantaFe.Garay }
            });
        }
    }
}
