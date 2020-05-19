using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class CorrientesLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public CorrientesLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Corrientes).Value.Key, new Dictionary<long, string>
            {
                { 217, PartidoCorientes.Capital },
                { 218, PartidoCorientes.Goya },
                { 219, PartidoCorientes.SantoTome },
                { 220, PartidoCorientes.PasoDeLosLibres },
                { 221, PartidoCorientes.CuruzuCuatia },
                { 222, PartidoCorientes.Mercedes },
                { 223, PartidoCorientes.BellaVista },
                { 224, PartidoCorientes.MonteCaseros },
                { 225, PartidoCorientes.Ituzaingo },
                { 226, PartidoCorientes.Esquina },
                { 227, PartidoCorientes.Lavalle },
                { 228, PartidoCorientes.Saladas },
                { 229, PartidoCorientes.Concepcion },
                { 230, PartidoCorientes.SanRoque },
                { 231, PartidoCorientes.SanLuisDelPalmar },
                { 232, PartidoCorientes.Empedrado },
                { 233, PartidoCorientes.GeneralPaz },
                { 234, PartidoCorientes.SanCosme },
                { 235, PartidoCorientes.SanMartin },
                { 236, PartidoCorientes.SanMiguel },
                { 237, PartidoCorientes.Mburucuya },
                { 238, PartidoCorientes.Itati },
                { 239, PartidoCorientes.Sauce },
                { 240, PartidoCorientes.GeneralAlvear },
                { 241, PartidoCorientes.BeronDeAstrada }
            });
        }
    }
}
