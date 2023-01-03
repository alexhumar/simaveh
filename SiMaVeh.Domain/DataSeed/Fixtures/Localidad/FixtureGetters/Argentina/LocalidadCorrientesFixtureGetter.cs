using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    public class LocalidadCorrientesFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadCorrientesFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.BellaVista).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1726, LocalidadCorrientes.BellaVista),
                datosEntidadBuilder.Build(1727, LocalidadCorrientes.TresDeAbril)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.BeronDeAstrada).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1728, LocalidadCorrientes.BeronDeAstrada)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1729, LocalidadCorrientes.Corrientes),
                datosEntidadBuilder.Build(1730, LocalidadCorrientes.Riachuelo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Concepcion).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1731, LocalidadCorrientes.Concepcion),
                datosEntidadBuilder.Build(1732, LocalidadCorrientes.SantaRosa),
                datosEntidadBuilder.Build(1733, LocalidadCorrientes.Tabay),
                datosEntidadBuilder.Build(1734, LocalidadCorrientes.Tatacua)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.CuruzuCuatia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1735, LocalidadCorrientes.CuruzuCuatia),
                datosEntidadBuilder.Build(1736, LocalidadCorrientes.Perugorria),
                datosEntidadBuilder.Build(1737, LocalidadCorrientes.CazadoresCorrentinos)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Empedrado).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1738, LocalidadCorrientes.Empedrado),
                datosEntidadBuilder.Build(1739, LocalidadCorrientes.ElSombrero)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Esquina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1740, LocalidadCorrientes.Esquina),
                datosEntidadBuilder.Build(1741, LocalidadCorrientes.PuebloLibertador)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.GeneralAlvear).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1742, LocalidadCorrientes.Alvear),
                datosEntidadBuilder.Build(1743, LocalidadCorrientes.EstacionTorrent)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.GeneralPaz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1744, LocalidadCorrientes.ItaIbate),
                datosEntidadBuilder.Build(1745, LocalidadCorrientes.LomasDeVallejos),
                datosEntidadBuilder.Build(1746, LocalidadCorrientes.NuestraSenoraDelRosarioDeCaaCati),
                datosEntidadBuilder.Build(1747, LocalidadCorrientes.PalmarGrande)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Goya).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1748, LocalidadCorrientes.Goya),
                datosEntidadBuilder.Build(1749, LocalidadCorrientes.ColoniaCarolina),
                datosEntidadBuilder.Build(1750, LocalidadCorrientes.SanIsidro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Itati).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1751, LocalidadCorrientes.Itati),
                datosEntidadBuilder.Build(1752, LocalidadCorrientes.RamadaPaso)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Ituzaingo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1753, LocalidadCorrientes.ColoniaLiebigs),
                datosEntidadBuilder.Build(1754, LocalidadCorrientes.Ituzaingo),
                datosEntidadBuilder.Build(1755, LocalidadCorrientes.SanAntonio),
                datosEntidadBuilder.Build(1756, LocalidadCorrientes.SanCarlos),
                datosEntidadBuilder.Build(1757, LocalidadCorrientes.VillaOlivari)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Lavalle).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1758, LocalidadCorrientes.CruzDeLosMilagros),
                datosEntidadBuilder.Build(1759, LocalidadCorrientes.GobernadorJuanEMartinez),
                datosEntidadBuilder.Build(1760, LocalidadCorrientes.Lavalle),
                datosEntidadBuilder.Build(1761, LocalidadCorrientes.SantaLucia),
                datosEntidadBuilder.Build(1762, LocalidadCorrientes.YataytiCalle),
                datosEntidadBuilder.Build(1763, LocalidadCorrientes.CecilioEcheverria)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Mburucuya).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1764, LocalidadCorrientes.Mburucuya)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Mercedes).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1765, LocalidadCorrientes.FelipeYofre),
                datosEntidadBuilder.Build(1766, LocalidadCorrientes.MarianoILoza),
                datosEntidadBuilder.Build(1767, LocalidadCorrientes.Mercedes)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.MonteCaseros).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1768, LocalidadCorrientes.ColoniaLibertad),
                datosEntidadBuilder.Build(1769, LocalidadCorrientes.JuanPujol),
                datosEntidadBuilder.Build(1770, LocalidadCorrientes.Mocoreta),
                datosEntidadBuilder.Build(1771, LocalidadCorrientes.MonteCaseros)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.PasoDeLosLibres).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1772, LocalidadCorrientes.ParadaPucheta),
                datosEntidadBuilder.Build(1773, LocalidadCorrientes.PasoDeLosLibres),
                datosEntidadBuilder.Build(1774, LocalidadCorrientes.Tapebicua)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Saladas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1775, LocalidadCorrientes.Saladas),
                datosEntidadBuilder.Build(1776, LocalidadCorrientes.SanLorenzo),
                datosEntidadBuilder.Build(1777, LocalidadCorrientes.PagoDeLosDeseos)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanCosme).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1778, LocalidadCorrientes.PasoDeLaPatria),
                datosEntidadBuilder.Build(1779, LocalidadCorrientes.SanCosme),
                datosEntidadBuilder.Build(1780, LocalidadCorrientes.SantaAnaDeLosGuacaras)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanLuisDelPalmar).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1781, LocalidadCorrientes.Herlitzka),
                datosEntidadBuilder.Build(1782, LocalidadCorrientes.SanLuisDelPalmar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1783, LocalidadCorrientes.ColoniaCarlosPellegrini),
                datosEntidadBuilder.Build(1784, LocalidadCorrientes.Guaviravi),
                datosEntidadBuilder.Build(1785, LocalidadCorrientes.LaCruz),
                datosEntidadBuilder.Build(1786, LocalidadCorrientes.Yapeyu)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanMiguel).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1787, LocalidadCorrientes.Loreto),
                datosEntidadBuilder.Build(1788, LocalidadCorrientes.SanMiguel)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SanRoque).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1789, LocalidadCorrientes.Chavarria),
                datosEntidadBuilder.Build(1790, LocalidadCorrientes.ColoniaPando1​),
                datosEntidadBuilder.Build(1791, LocalidadCorrientes.NueveDeJulio),
                datosEntidadBuilder.Build(1792, LocalidadCorrientes.PedroRFernandez),
                datosEntidadBuilder.Build(1793, LocalidadCorrientes.SanRoque)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.SantoTome).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1794, LocalidadCorrientes.Garruchos),
                datosEntidadBuilder.Build(1795, LocalidadCorrientes.GobernadorVirasoro),
                datosEntidadBuilder.Build(1796, LocalidadCorrientes.Garavi),
                datosEntidadBuilder.Build(1797, LocalidadCorrientes.SantoTome)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoCorrientes.Sauce).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1798, LocalidadCorrientes.Sauce)
            });
        }
    }
}
