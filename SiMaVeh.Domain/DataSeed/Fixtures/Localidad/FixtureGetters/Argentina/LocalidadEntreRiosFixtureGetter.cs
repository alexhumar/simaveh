using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    class LocalidadEntreRiosFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadEntreRiosFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
            : base(partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Colon).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1799, LocalidadEntreRios.Colon),
                datosEntidadBuilder.Build(1800, LocalidadEntreRios.SanJose),
                datosEntidadBuilder.Build(1801, LocalidadEntreRios.Ubajay),
                datosEntidadBuilder.Build(1802, LocalidadEntreRios.VillaElisa),
                datosEntidadBuilder.Build(1803, LocalidadEntreRios.PuebloLiebig),
                datosEntidadBuilder.Build(1804, LocalidadEntreRios.ArroyoBaru),
                datosEntidadBuilder.Build(1805, LocalidadEntreRios.LaClarita),
                datosEntidadBuilder.Build(1806, LocalidadEntreRios.PuebloCazes),
                datosEntidadBuilder.Build(1807, LocalidadEntreRios.SanMiguel),
                datosEntidadBuilder.Build(1808, LocalidadEntreRios.ColoniaHocker),
                datosEntidadBuilder.Build(1809, LocalidadEntreRios.ColoniaSanAnselmoYAledanas),
                datosEntidadBuilder.Build(1810, LocalidadEntreRios.Hambis)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Concordia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1811, LocalidadEntreRios.Concordia),
                datosEntidadBuilder.Build(1812, LocalidadEntreRios.ColoniaAyui),
                datosEntidadBuilder.Build(1813, LocalidadEntreRios.EstanciaGrande),
                datosEntidadBuilder.Build(1814, LocalidadEntreRios.LaCriolla),
                datosEntidadBuilder.Build(1815, LocalidadEntreRios.LosCharruas),
                datosEntidadBuilder.Build(1816, LocalidadEntreRios.PuertoYerua),
                datosEntidadBuilder.Build(1817, LocalidadEntreRios.ColoniaGeneralRoca),
                datosEntidadBuilder.Build(1818, LocalidadEntreRios.NuevaEscocia),
                datosEntidadBuilder.Build(1819, LocalidadEntreRios.Pedernal),
                datosEntidadBuilder.Build(1820, LocalidadEntreRios.EstacionYerua),
                datosEntidadBuilder.Build(1821, LocalidadEntreRios.EstacionYuqueri),
                datosEntidadBuilder.Build(1822, LocalidadEntreRios.ClodomiroLedesma),
                datosEntidadBuilder.Build(1823, LocalidadEntreRios.ElRedomon),
                datosEntidadBuilder.Build(1824, LocalidadEntreRios.ColoniaSanJusto)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Diamante).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1825, LocalidadEntreRios.Diamante),
                datosEntidadBuilder.Build(1826, LocalidadEntreRios.GeneralRamirez),
                datosEntidadBuilder.Build(1827, LocalidadEntreRios.AldeaValleMaria),
                datosEntidadBuilder.Build(1828, LocalidadEntreRios.LibertadorSanMartin),
                datosEntidadBuilder.Build(1829, LocalidadEntreRios.AldeaBrasilera),
                datosEntidadBuilder.Build(1830, LocalidadEntreRios.AldeaProtestante),
                datosEntidadBuilder.Build(1831, LocalidadEntreRios.AldeaSpatzenkutter),
                datosEntidadBuilder.Build(1832, LocalidadEntreRios.ColoniaEnsayo),
                datosEntidadBuilder.Build(1833, LocalidadEntreRios.EstacionRacedo),
                datosEntidadBuilder.Build(1834, LocalidadEntreRios.LasCuevas),
                datosEntidadBuilder.Build(1835, LocalidadEntreRios.CostaGrande),
                datosEntidadBuilder.Build(1836, LocalidadEntreRios.GeneralAlvear),
                datosEntidadBuilder.Build(1837, LocalidadEntreRios.Isletas),
                datosEntidadBuilder.Build(1838, LocalidadEntreRios.AldeaSalto),
                datosEntidadBuilder.Build(1839, LocalidadEntreRios.EstacionCamps),
                datosEntidadBuilder.Build(1840, LocalidadEntreRios.AldeaGrapschental)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Federacion).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1841, LocalidadEntreRios.Chajari),
                datosEntidadBuilder.Build(1842, LocalidadEntreRios.Federacion),
                datosEntidadBuilder.Build(1843, LocalidadEntreRios.LosConquistadores),
                datosEntidadBuilder.Build(1844, LocalidadEntreRios.SanJaimeDeLaFrontera),
                datosEntidadBuilder.Build(1845, LocalidadEntreRios.SantaAna),
                datosEntidadBuilder.Build(1846, LocalidadEntreRios.VillaDelRosario),
                datosEntidadBuilder.Build(1847, LocalidadEntreRios.ColoniaLaArgentina),
                datosEntidadBuilder.Build(1848, LocalidadEntreRios.SanPedro),
                datosEntidadBuilder.Build(1849, LocalidadEntreRios.SanRamon),
                datosEntidadBuilder.Build(1850, LocalidadEntreRios.ColoniaAlemana),
                datosEntidadBuilder.Build(1851, LocalidadEntreRios.ColoniaDeSantaMaria),
                datosEntidadBuilder.Build(1852, LocalidadEntreRios.ColoniaDeLasMargaritas),
                datosEntidadBuilder.Build(1853, LocalidadEntreRios.LaFlorida),
                datosEntidadBuilder.Build(1854, LocalidadEntreRios.LaFraternidadYSantaJuana),
                datosEntidadBuilder.Build(1855, LocalidadEntreRios.ParajeGuayaquil),
                datosEntidadBuilder.Build(1856, LocalidadEntreRios.ColoniaTunas),
                datosEntidadBuilder.Build(1857, LocalidadEntreRios.Gualeguaycito),
                datosEntidadBuilder.Build(1858, LocalidadEntreRios.SanRoque)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Federal).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1859, LocalidadEntreRios.Achiras),
                datosEntidadBuilder.Build(1860, LocalidadEntreRios.Banderas),
                datosEntidadBuilder.Build(1861, LocalidadEntreRios.Chanar),
                datosEntidadBuilder.Build(1862, LocalidadEntreRios.DiegoLopez),
                datosEntidadBuilder.Build(1863, LocalidadEntreRios.FranciscoRamirez),
                datosEntidadBuilder.Build(1864, LocalidadEntreRios.SauceDeLuna),
                datosEntidadBuilder.Build(1865, LocalidadEntreRios.Federal),
                datosEntidadBuilder.Build(1866, LocalidadEntreRios.ConscriptoBernardi),
                datosEntidadBuilder.Build(1867, LocalidadEntreRios.SauceDeLuna),
                datosEntidadBuilder.Build(1868, LocalidadEntreRios.ElCimarron),
                datosEntidadBuilder.Build(1869, LocalidadEntreRios.NuevaVizcaya),
                datosEntidadBuilder.Build(1870, LocalidadEntreRios.PasoDuarte),
                datosEntidadBuilder.Build(1871, LocalidadEntreRios.Banderas),
                datosEntidadBuilder.Build(1872, LocalidadEntreRios.SantaLucia),
                datosEntidadBuilder.Build(1873, LocalidadEntreRios.ArroyoDelMedio),
                datosEntidadBuilder.Build(1874, LocalidadEntreRios.ArroyoLasTunas),
                datosEntidadBuilder.Build(1875, LocalidadEntreRios.DistritoDiegoLopez),
                datosEntidadBuilder.Build(1876, LocalidadEntreRios.ElGatoLomaLimpia),
                datosEntidadBuilder.Build(1877, LocalidadEntreRios.ElGramiyal)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Feliciano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1878, LocalidadEntreRios.SanJoseDeFeliciano),
                datosEntidadBuilder.Build(1879, LocalidadEntreRios.SanVictor),
                datosEntidadBuilder.Build(1880, LocalidadEntreRios.DistritoChanar),
                datosEntidadBuilder.Build(1881, LocalidadEntreRios.LaVerbena),
                datosEntidadBuilder.Build(1882, LocalidadEntreRios.LagunaBenitez),
                datosEntidadBuilder.Build(1883, LocalidadEntreRios.LaEsmeralda),
                datosEntidadBuilder.Build(1884, LocalidadEntreRios.LasMulitas),
                datosEntidadBuilder.Build(1885, LocalidadEntreRios.LasHierras),
                datosEntidadBuilder.Build(1886, LocalidadEntreRios.MulasGrandes)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Gualeguay).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1887, LocalidadEntreRios.Gualeguay),
                datosEntidadBuilder.Build(1888, LocalidadEntreRios.GeneralGalarza),
                datosEntidadBuilder.Build(1889, LocalidadEntreRios.AldeaAsuncion),
                datosEntidadBuilder.Build(1890, LocalidadEntreRios.DistritoSextoCostaDeNogoya),
                datosEntidadBuilder.Build(1891, LocalidadEntreRios.QuintoDistrito),
                datosEntidadBuilder.Build(1892, LocalidadEntreRios.IslasLasLechiguanas),
                datosEntidadBuilder.Build(1893, LocalidadEntreRios.PrimerDistritoCuchilla),
                datosEntidadBuilder.Build(1894, LocalidadEntreRios.DistritoCuarto),
                datosEntidadBuilder.Build(1895, LocalidadEntreRios.EstacionLazo),
                datosEntidadBuilder.Build(1896, LocalidadEntreRios.GonzalezCalderon),
                datosEntidadBuilder.Build(1897, LocalidadEntreRios.MonteRedondo),
                datosEntidadBuilder.Build(1898, LocalidadEntreRios.PuntaDelMonte)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Gualeguaychu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1899, LocalidadEntreRios.Gualeguaychu),
                datosEntidadBuilder.Build(1900, LocalidadEntreRios.Larroque),
                datosEntidadBuilder.Build(1901, LocalidadEntreRios.Urdinarrain),
                datosEntidadBuilder.Build(1902, LocalidadEntreRios.Gilbert),
                datosEntidadBuilder.Build(1903, LocalidadEntreRios.PuebloGeneralBelgrano),
                datosEntidadBuilder.Build(1904, LocalidadEntreRios.EnriqueCarbo),
                datosEntidadBuilder.Build(1905, LocalidadEntreRios.AldeaSanJuan),
                datosEntidadBuilder.Build(1906, LocalidadEntreRios.Irazusta),
                datosEntidadBuilder.Build(1907, LocalidadEntreRios.CostaUruguayNorte),
                datosEntidadBuilder.Build(1908, LocalidadEntreRios.FaustinoMParera),
                datosEntidadBuilder.Build(1909, LocalidadEntreRios.GeneralAlmada),
                datosEntidadBuilder.Build(1910, LocalidadEntreRios.LasMercedes),
                datosEntidadBuilder.Build(1911, LocalidadEntreRios.CostaDeSanAntonio),
                datosEntidadBuilder.Build(1912, LocalidadEntreRios.CostaUruguaySur),
                datosEntidadBuilder.Build(1913, LocalidadEntreRios.CuchillaRedonda),
                datosEntidadBuilder.Build(1914, LocalidadEntreRios.DistritoTalitas),
                datosEntidadBuilder.Build(1915, LocalidadEntreRios.EstacionEscrina),
                datosEntidadBuilder.Build(1916, LocalidadEntreRios.PastorBritos),
                datosEntidadBuilder.Build(1917, LocalidadEntreRios.Perdices),
                datosEntidadBuilder.Build(1918, LocalidadEntreRios.RinconDelCinto),
                datosEntidadBuilder.Build(1919, LocalidadEntreRios.RinconDelGato)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.IslasDelIbicuy).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1920, LocalidadEntreRios.Ceibas),
                datosEntidadBuilder.Build(1921, LocalidadEntreRios.PuertoIbicuy),
                datosEntidadBuilder.Build(1922, LocalidadEntreRios.VillaParanacito),
                datosEntidadBuilder.Build(1923, LocalidadEntreRios.Medanos),
                datosEntidadBuilder.Build(1924, LocalidadEntreRios.Nancay)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.LaPaz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1925, LocalidadEntreRios.Bovril),
                datosEntidadBuilder.Build(1926, LocalidadEntreRios.LaPaz),
                datosEntidadBuilder.Build(1927, LocalidadEntreRios.SantaElena),
                datosEntidadBuilder.Build(1928, LocalidadEntreRios.PiedrasBlancas),
                datosEntidadBuilder.Build(1929, LocalidadEntreRios.SanGustavo),
                datosEntidadBuilder.Build(1930, LocalidadEntreRios.VillaAlcaraz),
                datosEntidadBuilder.Build(1931, LocalidadEntreRios.ColoniaAvigdor),
                datosEntidadBuilder.Build(1932, LocalidadEntreRios.ElSolar),
                datosEntidadBuilder.Build(1933, LocalidadEntreRios.Ombu),
                datosEntidadBuilder.Build(1934, LocalidadEntreRios.AlcarazNorte),
                datosEntidadBuilder.Build(1935, LocalidadEntreRios.AlcarazSur),
                datosEntidadBuilder.Build(1936, LocalidadEntreRios.YesoOeste),
                datosEntidadBuilder.Build(1937, LocalidadEntreRios.ColoniaCarrasco),
                datosEntidadBuilder.Build(1938, LocalidadEntreRios.ColoniaOficialN3),
                datosEntidadBuilder.Build(1939, LocalidadEntreRios.ColoniaOficialN14),
                datosEntidadBuilder.Build(1940, LocalidadEntreRios.ElQuebracho),
                datosEntidadBuilder.Build(1941, LocalidadEntreRios.LaProvidencia),
                datosEntidadBuilder.Build(1942, LocalidadEntreRios.PuertoAlgarrobo),
                datosEntidadBuilder.Build(1943, LocalidadEntreRios.SanRamirez),
                datosEntidadBuilder.Build(1944, LocalidadEntreRios.Saucecito),
                datosEntidadBuilder.Build(1945, LocalidadEntreRios.SirLeonard),
                datosEntidadBuilder.Build(1946, LocalidadEntreRios.TacuarasYacare),
                datosEntidadBuilder.Build(1947, LocalidadEntreRios.ColoniaOficialN13),
                datosEntidadBuilder.Build(1948, LocalidadEntreRios.ColoniaViraro),
                datosEntidadBuilder.Build(1949, LocalidadEntreRios.Estaquitas),
                datosEntidadBuilder.Build(1950, LocalidadEntreRios.LasToscas),
                datosEntidadBuilder.Build(1951, LocalidadEntreRios.PicadaBeron)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Nogoya).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1952, LocalidadEntreRios.LucasGonzalez),
                datosEntidadBuilder.Build(1953, LocalidadEntreRios.Nogoya),
                datosEntidadBuilder.Build(1954, LocalidadEntreRios.Aranguren),
                datosEntidadBuilder.Build(1955, LocalidadEntreRios.Hernandez),
                datosEntidadBuilder.Build(1956, LocalidadEntreRios.DonCristobalSegundo),
                datosEntidadBuilder.Build(1957, LocalidadEntreRios.Febre),
                datosEntidadBuilder.Build(1958, LocalidadEntreRios.XXDeSetiembre),
                datosEntidadBuilder.Build(1959, LocalidadEntreRios.CrucesitasOctava),
                datosEntidadBuilder.Build(1960, LocalidadEntreRios.DistritoSauce),
                datosEntidadBuilder.Build(1961, LocalidadEntreRios.DonCristobalPrimero),
                datosEntidadBuilder.Build(1962, LocalidadEntreRios.JustoJoseDeUrquiza),
                datosEntidadBuilder.Build(1963, LocalidadEntreRios.AldeaSanMiguel),
                datosEntidadBuilder.Build(1964, LocalidadEntreRios.CrucecitasSeptima),
                datosEntidadBuilder.Build(1965, LocalidadEntreRios.CrucecitasTercera),
                datosEntidadBuilder.Build(1966, LocalidadEntreRios.Betbeder),
                datosEntidadBuilder.Build(1967, LocalidadEntreRios.DistritoChiqueros),
                datosEntidadBuilder.Build(1968, LocalidadEntreRios.Laurencena)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Parana).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1969, LocalidadEntreRios.Crespo),
                datosEntidadBuilder.Build(1970, LocalidadEntreRios.MariaGrande),
                datosEntidadBuilder.Build(1971, LocalidadEntreRios.Parana),
                datosEntidadBuilder.Build(1972, LocalidadEntreRios.SanBenito),
                datosEntidadBuilder.Build(1973, LocalidadEntreRios.Viale),
                datosEntidadBuilder.Build(1974, LocalidadEntreRios.VillaHernandarias),
                datosEntidadBuilder.Build(1975, LocalidadEntreRios.Cerrito),
                datosEntidadBuilder.Build(1976, LocalidadEntreRios.ColoniaAvellaneda),
                datosEntidadBuilder.Build(1977, LocalidadEntreRios.Hasenkamp),
                datosEntidadBuilder.Build(1978, LocalidadEntreRios.OroVerde),
                datosEntidadBuilder.Build(1979, LocalidadEntreRios.Segui),
                datosEntidadBuilder.Build(1980, LocalidadEntreRios.Tabossi),
                datosEntidadBuilder.Build(1981, LocalidadEntreRios.VillaUrquiza),
                datosEntidadBuilder.Build(1982, LocalidadEntreRios.AldeaMariaLuisa),
                datosEntidadBuilder.Build(1983, LocalidadEntreRios.ElPingo),
                datosEntidadBuilder.Build(1984, LocalidadEntreRios.PuebloBrugo),
                datosEntidadBuilder.Build(1985, LocalidadEntreRios.AldeaSantaMaria),
                datosEntidadBuilder.Build(1986, LocalidadEntreRios.PuertoCurtiembre),
                datosEntidadBuilder.Build(1987, LocalidadEntreRios.ElPalenque),
                datosEntidadBuilder.Build(1988, LocalidadEntreRios.LaPicada),
                datosEntidadBuilder.Build(1989, LocalidadEntreRios.LasTunas),
                datosEntidadBuilder.Build(1990, LocalidadEntreRios.SauceMontrull),
                datosEntidadBuilder.Build(1991, LocalidadEntreRios.Sosa),
                datosEntidadBuilder.Build(1992, LocalidadEntreRios.ColoniaCrespo),
                datosEntidadBuilder.Build(1993, LocalidadEntreRios.PuebloBellocq),
                datosEntidadBuilder.Build(1994, LocalidadEntreRios.SaucePinto),
                datosEntidadBuilder.Build(1995, LocalidadEntreRios.TezanosPinto),
                datosEntidadBuilder.Build(1996, LocalidadEntreRios.VillaFontana),
                datosEntidadBuilder.Build(1997, LocalidadEntreRios.VillaGobernadorEtchevehere),
                datosEntidadBuilder.Build(1998, LocalidadEntreRios.ArroyoBurgos),
                datosEntidadBuilder.Build(1999, LocalidadEntreRios.ArroyoCorralito),
                datosEntidadBuilder.Build(2000, LocalidadEntreRios.AldeaEigenfeld),
                datosEntidadBuilder.Build(2001, LocalidadEntreRios.AldeaSanAntonio),
                datosEntidadBuilder.Build(2002, LocalidadEntreRios.AldeaSanRafael),
                datosEntidadBuilder.Build(2003, LocalidadEntreRios.AldeaSantaRosa),
                datosEntidadBuilder.Build(2004, LocalidadEntreRios.AntonioTomas),
                datosEntidadBuilder.Build(2005, LocalidadEntreRios.ColoniaCelina),
                datosEntidadBuilder.Build(2006, LocalidadEntreRios.EspinilloNorte),
                datosEntidadBuilder.Build(2007, LocalidadEntreRios.MariaGrandeSegunda),
                datosEntidadBuilder.Build(2008, LocalidadEntreRios.PasoDeLaArena),
                datosEntidadBuilder.Build(2009, LocalidadEntreRios.PasoDeLaPiedra),
                datosEntidadBuilder.Build(2010, LocalidadEntreRios.SantaLuisa),
                datosEntidadBuilder.Build(2011, LocalidadEntreRios.ArroyoMaturrango),
                datosEntidadBuilder.Build(2012, LocalidadEntreRios.ArroyoPaloSeco),
                datosEntidadBuilder.Build(2013, LocalidadEntreRios.ColoniaCerrito),
                datosEntidadBuilder.Build(2014, LocalidadEntreRios.ColoniaMerou),
                datosEntidadBuilder.Build(2015, LocalidadEntreRios.ColoniaReffino),
                datosEntidadBuilder.Build(2016, LocalidadEntreRios.DistritoTala),
                datosEntidadBuilder.Build(2017, LocalidadEntreRios.Quebracho)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.SanSalvador).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2018, LocalidadEntreRios.SanSalvador),
                datosEntidadBuilder.Build(2019, LocalidadEntreRios.GeneralCampos),
                datosEntidadBuilder.Build(2020, LocalidadEntreRios.ColoniaBaylina),
                datosEntidadBuilder.Build(2021, LocalidadEntreRios.SanErnesto),
                datosEntidadBuilder.Build(2022, LocalidadEntreRios.ColoniaOficialN5),
                datosEntidadBuilder.Build(2023, LocalidadEntreRios.WalterMoss)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Tala).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2024, LocalidadEntreRios.Macia),
                datosEntidadBuilder.Build(2025, LocalidadEntreRios.RosarioDelTala),
                datosEntidadBuilder.Build(2026, LocalidadEntreRios.GobernadorMansilla),
                datosEntidadBuilder.Build(2027, LocalidadEntreRios.GobernadorSola),
                datosEntidadBuilder.Build(2028, LocalidadEntreRios.Durazno),
                datosEntidadBuilder.Build(2029, LocalidadEntreRios.GobernadorEchague),
                datosEntidadBuilder.Build(2030, LocalidadEntreRios.Guardamonte),
                datosEntidadBuilder.Build(2031, LocalidadEntreRios.AltamiranoSur),
                datosEntidadBuilder.Build(2032, LocalidadEntreRios.ArroyoCle),
                datosEntidadBuilder.Build(2033, LocalidadEntreRios.LasGuachas),
                datosEntidadBuilder.Build(2034, LocalidadEntreRios.SauceSur),
                datosEntidadBuilder.Build(2035, LocalidadEntreRios.LaOllita)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Uruguay).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2036, LocalidadEntreRios.Basavilbaso),
                datosEntidadBuilder.Build(2037, LocalidadEntreRios.ConcepcionDelUruguay),
                datosEntidadBuilder.Build(2038, LocalidadEntreRios.Caseros),
                datosEntidadBuilder.Build(2039, LocalidadEntreRios.ColoniaElia),
                datosEntidadBuilder.Build(2040, LocalidadEntreRios.Herrera),
                datosEntidadBuilder.Build(2041, LocalidadEntreRios.PrimeroDeMayo),
                datosEntidadBuilder.Build(2042, LocalidadEntreRios.Pronunciamiento),
                datosEntidadBuilder.Build(2043, LocalidadEntreRios.SanJusto),
                datosEntidadBuilder.Build(2044, LocalidadEntreRios.SantaAnita),
                datosEntidadBuilder.Build(2045, LocalidadEntreRios.VillaMantero),
                datosEntidadBuilder.Build(2046, LocalidadEntreRios.LasMoscas),
                datosEntidadBuilder.Build(2047, LocalidadEntreRios.SanCipriano),
                datosEntidadBuilder.Build(2048, LocalidadEntreRios.VillaSanMarcial),
                datosEntidadBuilder.Build(2049, LocalidadEntreRios.Tala),
                datosEntidadBuilder.Build(2050, LocalidadEntreRios.EstacionLibaros),
                datosEntidadBuilder.Build(2051, LocalidadEntreRios.Rocamora),
                datosEntidadBuilder.Build(2052, LocalidadEntreRios.ArroyoGena)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Victoria).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2053, LocalidadEntreRios.Victoria),
                datosEntidadBuilder.Build(2054, LocalidadEntreRios.RinconDeNogoya),
                datosEntidadBuilder.Build(2055, LocalidadEntreRios.RinconDelDoll),
                datosEntidadBuilder.Build(2056, LocalidadEntreRios.Antelo),
                datosEntidadBuilder.Build(2057, LocalidadEntreRios.MolinoDoll),
                datosEntidadBuilder.Build(2058, LocalidadEntreRios.Chilcas),
                datosEntidadBuilder.Build(2059, LocalidadEntreRios.DistritoPajonal),
                datosEntidadBuilder.Build(2060, LocalidadEntreRios.Hinojal),
                datosEntidadBuilder.Build(2061, LocalidadEntreRios.LagunaDelPescado),
                datosEntidadBuilder.Build(2062, LocalidadEntreRios.Montoya)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoEntreRios.Villaguay).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2063, LocalidadEntreRios.Villaguay),
                datosEntidadBuilder.Build(2064, LocalidadEntreRios.VillaClara),
                datosEntidadBuilder.Build(2065, LocalidadEntreRios.VillaDominguez),
                datosEntidadBuilder.Build(2066, LocalidadEntreRios.Jubileo),
                datosEntidadBuilder.Build(2067, LocalidadEntreRios.PasoDeLaLaguna),
                datosEntidadBuilder.Build(2068, LocalidadEntreRios.IngenieroSajaroff),
                datosEntidadBuilder.Build(2069, LocalidadEntreRios.LucasNorte),
                datosEntidadBuilder.Build(2070, LocalidadEntreRios.LucasSurSegundo),
                datosEntidadBuilder.Build(2071, LocalidadEntreRios.RaicesOeste),
                datosEntidadBuilder.Build(2072, LocalidadEntreRios.EstacionRaices),
                datosEntidadBuilder.Build(2073, LocalidadEntreRios.LucasSurPrimera),
                datosEntidadBuilder.Build(2074, LocalidadEntreRios.MojonesNorte),
                datosEntidadBuilder.Build(2075, LocalidadEntreRios.ParajeLosAlgarrobos),
                datosEntidadBuilder.Build(2076, LocalidadEntreRios.ColoniaAdivino),
                datosEntidadBuilder.Build(2077, LocalidadEntreRios.MojonesSud)
            });
        }
    }
}
