using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class CorrientesLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public CorrientesLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.BellaVista).Value.Key, new Dictionary<long, string>
            {
                { 1726, LocalidadCorrientes.BellaVista },
                { 1727, LocalidadCorrientes.TresDeAbril }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.BeronDeAstrada).Value.Key, new Dictionary<long, string>
            {
                { 1728, LocalidadCorrientes.BeronDeAstrada }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Capital).Value.Key, new Dictionary<long, string>
            {
                { 1729, LocalidadCorrientes.Corrientes },
                { 1730, LocalidadCorrientes.Riachuelo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Concepcion).Value.Key, new Dictionary<long, string>
            {
                { 1731, LocalidadCorrientes.Concepcion },
                { 1732, LocalidadCorrientes.SantaRosa },
                { 1733, LocalidadCorrientes.Tabay },
                { 1734, LocalidadCorrientes.Tatacua }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.CuruzuCuatia).Value.Key, new Dictionary<long, string>
            {
                { 1735, LocalidadCorrientes.CuruzuCuatia },
                { 1736, LocalidadCorrientes.Perugorria },
                { 1737, LocalidadCorrientes.CazadoresCorrentinos }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Empedrado).Value.Key, new Dictionary<long, string>
            {
                { 1738, LocalidadCorrientes.Empedrado },
                { 1739, LocalidadCorrientes.ElSombrero }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Esquina).Value.Key, new Dictionary<long, string>
            {
                { 1740, LocalidadCorrientes.Esquina },
                { 1741, LocalidadCorrientes.PuebloLibertador }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.GeneralAlvear).Value.Key, new Dictionary<long, string>
            {
                { 1742, LocalidadCorrientes.Alvear },
                { 1743, LocalidadCorrientes.EstacionTorrent }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.GeneralPaz).Value.Key, new Dictionary<long, string>
            {
                { 1744, LocalidadCorrientes.ItaIbate },
                { 1745, LocalidadCorrientes.LomasDeVallejos },
                { 1746, LocalidadCorrientes.NuestraSenoraDelRosarioDeCaaCati },
                { 1747, LocalidadCorrientes.PalmarGrande }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Goya).Value.Key, new Dictionary<long, string>
            {
                { 1748, LocalidadCorrientes.Goya },
                { 1749, LocalidadCorrientes.ColoniaCarolina },
                { 1750, LocalidadCorrientes.SanIsidro }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Itati).Value.Key, new Dictionary<long, string>
            {
                { 1751, LocalidadCorrientes.Itati },
                { 1752, LocalidadCorrientes.RamadaPaso }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Ituzaingo).Value.Key, new Dictionary<long, string>
            {
                { 1753, LocalidadCorrientes.ColoniaLiebigs },
                { 1754, LocalidadCorrientes.Ituzaingo },
                { 1755, LocalidadCorrientes.SanAntonio },
                { 1756, LocalidadCorrientes.SanCarlos },
                { 1757, LocalidadCorrientes.VillaOlivari }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Lavalle).Value.Key, new Dictionary<long, string>
            {
                { 1758, LocalidadCorrientes.CruzDeLosMilagros },
                { 1759, LocalidadCorrientes.GobernadorJuanEMartinez },
                { 1760, LocalidadCorrientes.Lavalle },
                { 1761, LocalidadCorrientes.SantaLucia },
                { 1762, LocalidadCorrientes.YataytiCalle },
                { 1763, LocalidadCorrientes.CecilioEcheverria }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Mburucuya).Value.Key, new Dictionary<long, string>
            {
                { 1764, LocalidadCorrientes.Mburucuya }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Mercedes).Value.Key, new Dictionary<long, string>
            {
                { 1765, LocalidadCorrientes.FelipeYofre },
                { 1766, LocalidadCorrientes.MarianoILoza },
                { 1767, LocalidadCorrientes.Mercedes }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.MonteCaseros).Value.Key, new Dictionary<long, string>
            {
                { 1768, LocalidadCorrientes.ColoniaLibertad },
                { 1769, LocalidadCorrientes.JuanPujol },
                { 1770, LocalidadCorrientes.Mocoreta },
                { 1771, LocalidadCorrientes.MonteCaseros }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.PasoDeLosLibres).Value.Key, new Dictionary<long, string>
            {
                { 1772, LocalidadCorrientes.ParadaPucheta },
                { 1773, LocalidadCorrientes.PasoDeLosLibres },
                { 1774, LocalidadCorrientes.Tapebicua }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Saladas).Value.Key, new Dictionary<long, string>
            {
                { 1775, LocalidadCorrientes.Saladas },
                { 1776, LocalidadCorrientes.SanLorenzo },
                { 1777, LocalidadCorrientes.PagoDeLosDeseos }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.SanCosme).Value.Key, new Dictionary<long, string>
            {
                { 1778, LocalidadCorrientes.PasoDeLaPatria },
                { 1779, LocalidadCorrientes.SanCosme },
                { 1780, LocalidadCorrientes.SantaAnaDeLosGuacaras }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.SanLuisDelPalmar).Value.Key, new Dictionary<long, string>
            {
                { 1781, LocalidadCorrientes.Herlitzka },
                { 1782, LocalidadCorrientes.SanLuisDelPalmar }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.SanMartin).Value.Key, new Dictionary<long, string>
            {
                { 1783, LocalidadCorrientes.ColoniaCarlosPellegrini },
                { 1784, LocalidadCorrientes.Guaviravi },
                { 1785, LocalidadCorrientes.LaCruz },
                { 1786, LocalidadCorrientes.Yapeyu }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.SanMiguel).Value.Key, new Dictionary<long, string>
            {
                { 1787, LocalidadCorrientes.Loreto },
                { 1788, LocalidadCorrientes.SanMiguel }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.SanRoque).Value.Key, new Dictionary<long, string>
            {
                { 1789, LocalidadCorrientes.Chavarria },
                { 1790, LocalidadCorrientes.ColoniaPando1​ },
                { 1791, LocalidadCorrientes.NueveDeJulio },
                { 1792, LocalidadCorrientes.PedroRFernandez },
                { 1793, LocalidadCorrientes.SanRoque }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.SantoTome).Value.Key, new Dictionary<long, string>
            {
                { 1794, LocalidadCorrientes.Garruchos },
                { 1795, LocalidadCorrientes.GobernadorVirasoro },
                { 1796, LocalidadCorrientes.Garavi },
                { 1797, LocalidadCorrientes.SantoTome }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoCorrientes.Sauce).Value.Key, new Dictionary<long, string>
            {
                { 1798, LocalidadCorrientes.Sauce }
            });
        }
    }
}
