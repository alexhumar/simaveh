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

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Corrientes).Value.Key, new Dictionary<long, string>
            {
                { 218, PartidoCorrientes.BellaVista },
                { 219, PartidoCorrientes.BeronDeAstrada },
                { 220, PartidoCorrientes.Capital },
                { 221, PartidoCorrientes.Concepcion },
                { 222, PartidoCorrientes.CuruzuCuatia },
                { 223, PartidoCorrientes.Empedrado },
                { 224, PartidoCorrientes.Esquina },
                { 225, PartidoCorrientes.GeneralAlvear },
                { 226, PartidoCorrientes.GeneralPaz },
                { 227, PartidoCorrientes.Goya },
                { 228, PartidoCorrientes.Itati },
                { 229, PartidoCorrientes.Ituzaingo },
                { 230, PartidoCorrientes.Lavalle },
                { 231, PartidoCorrientes.Mburucuya },
                { 232, PartidoCorrientes.Mercedes },
                { 233, PartidoCorrientes.MonteCaseros },
                { 234, PartidoCorrientes.PasoDeLosLibres },
                { 235, PartidoCorrientes.Saladas },
                { 236, PartidoCorrientes.SanCosme },
                { 237, PartidoCorrientes.SanLuisDelPalmar },
                { 238, PartidoCorrientes.SanMartin },
                { 239, PartidoCorrientes.SanMiguel },
                { 240, PartidoCorrientes.SanRoque },
                { 241, PartidoCorrientes.SantoTome },
                { 242, PartidoCorrientes.Sauce }
            });
        }
    }
}
