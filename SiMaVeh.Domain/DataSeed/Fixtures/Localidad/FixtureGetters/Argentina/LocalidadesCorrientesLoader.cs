using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesCorrientesLoader : LocalidadFixtureGetter
    {
        public LocalidadesCorrientesLoader(IPartidoFixtureGetter partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.BellaVista).Key, new Dictionary<long, string>
            {
                { 1726, LocalidadCorrientes.BellaVista },
                { 1727, LocalidadCorrientes.TresDeAbril }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.BeronDeAstrada).Key, new Dictionary<long, string>
            {
                { 1728, LocalidadCorrientes.BeronDeAstrada }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Capital).Key, new Dictionary<long, string>
            {
                { 1729, LocalidadCorrientes.Corrientes },
                { 1730, LocalidadCorrientes.Riachuelo }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Concepcion).Key, new Dictionary<long, string>
            {
                { 1731, LocalidadCorrientes.Concepcion },
                { 1732, LocalidadCorrientes.SantaRosa },
                { 1733, LocalidadCorrientes.Tabay },
                { 1734, LocalidadCorrientes.Tatacua }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.CuruzuCuatia).Key, new Dictionary<long, string>
            {
                { 1735, LocalidadCorrientes.CuruzuCuatia },
                { 1736, LocalidadCorrientes.Perugorria },
                { 1737, LocalidadCorrientes.CazadoresCorrentinos }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Empedrado).Key, new Dictionary<long, string>
            {
                { 1738, LocalidadCorrientes.Empedrado },
                { 1739, LocalidadCorrientes.ElSombrero }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Esquina).Key, new Dictionary<long, string>
            {
                { 1740, LocalidadCorrientes.Esquina },
                { 1741, LocalidadCorrientes.PuebloLibertador }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.GeneralAlvear).Key, new Dictionary<long, string>
            {
                { 1742, LocalidadCorrientes.Alvear },
                { 1743, LocalidadCorrientes.EstacionTorrent }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.GeneralPaz).Key, new Dictionary<long, string>
            {
                { 1744, LocalidadCorrientes.ItaIbate },
                { 1745, LocalidadCorrientes.LomasDeVallejos },
                { 1746, LocalidadCorrientes.NuestraSenoraDelRosarioDeCaaCati },
                { 1747, LocalidadCorrientes.PalmarGrande }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Goya).Key, new Dictionary<long, string>
            {
                { 1748, LocalidadCorrientes.Goya },
                { 1749, LocalidadCorrientes.ColoniaCarolina },
                { 1750, LocalidadCorrientes.SanIsidro }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Itati).Key, new Dictionary<long, string>
            {
                { 1751, LocalidadCorrientes.Itati },
                { 1752, LocalidadCorrientes.RamadaPaso }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Ituzaingo).Key, new Dictionary<long, string>
            {
                { 1753, LocalidadCorrientes.ColoniaLiebigs },
                { 1754, LocalidadCorrientes.Ituzaingo },
                { 1755, LocalidadCorrientes.SanAntonio },
                { 1756, LocalidadCorrientes.SanCarlos },
                { 1757, LocalidadCorrientes.VillaOlivari }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Lavalle).Key, new Dictionary<long, string>
            {
                { 1758, LocalidadCorrientes.CruzDeLosMilagros },
                { 1759, LocalidadCorrientes.GobernadorJuanEMartinez },
                { 1760, LocalidadCorrientes.Lavalle },
                { 1761, LocalidadCorrientes.SantaLucia },
                { 1762, LocalidadCorrientes.YataytiCalle },
                { 1763, LocalidadCorrientes.CecilioEcheverria }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Mburucuya).Key, new Dictionary<long, string>
            {
                { 1764, LocalidadCorrientes.Mburucuya }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Mercedes).Key, new Dictionary<long, string>
            {
                { 1765, LocalidadCorrientes.FelipeYofre },
                { 1766, LocalidadCorrientes.MarianoILoza },
                { 1767, LocalidadCorrientes.Mercedes }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.MonteCaseros).Key, new Dictionary<long, string>
            {
                { 1768, LocalidadCorrientes.ColoniaLibertad },
                { 1769, LocalidadCorrientes.JuanPujol },
                { 1770, LocalidadCorrientes.Mocoreta },
                { 1771, LocalidadCorrientes.MonteCaseros }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.PasoDeLosLibres).Key, new Dictionary<long, string>
            {
                { 1772, LocalidadCorrientes.ParadaPucheta },
                { 1773, LocalidadCorrientes.PasoDeLosLibres },
                { 1774, LocalidadCorrientes.Tapebicua }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Saladas).Key, new Dictionary<long, string>
            {
                { 1775, LocalidadCorrientes.Saladas },
                { 1776, LocalidadCorrientes.SanLorenzo },
                { 1777, LocalidadCorrientes.PagoDeLosDeseos }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanCosme).Key, new Dictionary<long, string>
            {
                { 1778, LocalidadCorrientes.PasoDeLaPatria },
                { 1779, LocalidadCorrientes.SanCosme },
                { 1780, LocalidadCorrientes.SantaAnaDeLosGuacaras }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanLuisDelPalmar).Key, new Dictionary<long, string>
            {
                { 1781, LocalidadCorrientes.Herlitzka },
                { 1782, LocalidadCorrientes.SanLuisDelPalmar }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanMartin).Key, new Dictionary<long, string>
            {
                { 1783, LocalidadCorrientes.ColoniaCarlosPellegrini },
                { 1784, LocalidadCorrientes.Guaviravi },
                { 1785, LocalidadCorrientes.LaCruz },
                { 1786, LocalidadCorrientes.Yapeyu }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanMiguel).Key, new Dictionary<long, string>
            {
                { 1787, LocalidadCorrientes.Loreto },
                { 1788, LocalidadCorrientes.SanMiguel }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanRoque).Key, new Dictionary<long, string>
            {
                { 1789, LocalidadCorrientes.Chavarria },
                { 1790, LocalidadCorrientes.ColoniaPando1​ },
                { 1791, LocalidadCorrientes.NueveDeJulio },
                { 1792, LocalidadCorrientes.PedroRFernandez },
                { 1793, LocalidadCorrientes.SanRoque }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SantoTome).Key, new Dictionary<long, string>
            {
                { 1794, LocalidadCorrientes.Garruchos },
                { 1795, LocalidadCorrientes.GobernadorVirasoro },
                { 1796, LocalidadCorrientes.Garavi },
                { 1797, LocalidadCorrientes.SantoTome }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Sauce).Key, new Dictionary<long, string>
            {
                { 1798, LocalidadCorrientes.Sauce }
            });
        }
    }
}
