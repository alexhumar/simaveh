using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesEntreRiosLoader : LocalidadesLoader
    {
        public LocalidadesEntreRiosLoader(IPartidosLoader partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Colon).Key, new Dictionary<long, string>
            {
                { 1799, LocalidadEntreRios.Colon },
                { 1800, LocalidadEntreRios.SanJose },
                { 1801, LocalidadEntreRios.Ubajay },
                { 1802, LocalidadEntreRios.VillaElisa },
                { 1803, LocalidadEntreRios.PuebloLiebig },
                { 1804, LocalidadEntreRios.ArroyoBaru },
                { 1805, LocalidadEntreRios.LaClarita },
                { 1806, LocalidadEntreRios.PuebloCazes },
                { 1807, LocalidadEntreRios.SanMiguel },
                { 1808, LocalidadEntreRios.ColoniaHocker },
                { 1809, LocalidadEntreRios.ColoniaSanAnselmoYAledanas },
                { 1810, LocalidadEntreRios.Hambis }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Concordia).Key, new Dictionary<long, string>
            {
                { 1811, LocalidadEntreRios.Concordia },
                { 1812, LocalidadEntreRios.ColoniaAyui },
                { 1813, LocalidadEntreRios.EstanciaGrande },
                { 1814, LocalidadEntreRios.LaCriolla },
                { 1815, LocalidadEntreRios.LosCharruas },
                { 1816, LocalidadEntreRios.PuertoYerua },
                { 1817, LocalidadEntreRios.ColoniaGeneralRoca },
                { 1818, LocalidadEntreRios.NuevaEscocia },
                { 1819, LocalidadEntreRios.Pedernal },
                { 1820, LocalidadEntreRios.EstacionYerua },
                { 1821, LocalidadEntreRios.EstacionYuqueri },
                { 1822, LocalidadEntreRios.ClodomiroLedesma },
                { 1823, LocalidadEntreRios.ElRedomon },
                { 1824, LocalidadEntreRios.ColoniaSanJusto }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Diamante).Key, new Dictionary<long, string>
            {
                { 1825, LocalidadEntreRios.Diamante },
                { 1826, LocalidadEntreRios.GeneralRamirez },
                { 1827, LocalidadEntreRios.AldeaValleMaria },
                { 1828, LocalidadEntreRios.LibertadorSanMartin },
                { 1829, LocalidadEntreRios.AldeaBrasilera },
                { 1830, LocalidadEntreRios.AldeaProtestante },
                { 1831, LocalidadEntreRios.AldeaSpatzenkutter },
                { 1832, LocalidadEntreRios.ColoniaEnsayo },
                { 1833, LocalidadEntreRios.EstacionRacedo },
                { 1834, LocalidadEntreRios.LasCuevas },
                { 1835, LocalidadEntreRios.CostaGrande },
                { 1836, LocalidadEntreRios.GeneralAlvear },
                { 1837, LocalidadEntreRios.Isletas },
                { 1838, LocalidadEntreRios.AldeaSalto },
                { 1839, LocalidadEntreRios.EstacionCamps },
                { 1840, LocalidadEntreRios.AldeaGrapschental }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Federacion).Key, new Dictionary<long, string>
            {
                { 1841, LocalidadEntreRios.Chajari },
                { 1842, LocalidadEntreRios.Federacion },
                { 1843, LocalidadEntreRios.LosConquistadores },
                { 1844, LocalidadEntreRios.SanJaimeDeLaFrontera },
                { 1845, LocalidadEntreRios.SantaAna },
                { 1846, LocalidadEntreRios.VillaDelRosario },
                { 1847, LocalidadEntreRios.ColoniaLaArgentina },
                { 1848, LocalidadEntreRios.SanPedro },
                { 1849, LocalidadEntreRios.SanRamon },
                { 1850, LocalidadEntreRios.ColoniaAlemana },
                { 1851, LocalidadEntreRios.ColoniaDeSantaMaria },
                { 1852, LocalidadEntreRios.ColoniaDeLasMargaritas },
                { 1853, LocalidadEntreRios.LaFlorida },
                { 1854, LocalidadEntreRios.LaFraternidadYSantaJuana },
                { 1855, LocalidadEntreRios.ParajeGuayaquil },
                { 1856, LocalidadEntreRios.ColoniaTunas },
                { 1857, LocalidadEntreRios.Gualeguaycito },
                { 1858, LocalidadEntreRios.SanRoque }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Federal).Key, new Dictionary<long, string>
            {
                { 1859, LocalidadEntreRios.Achiras },
                { 1860, LocalidadEntreRios.Banderas },
                { 1861, LocalidadEntreRios.Chanar },
                { 1862, LocalidadEntreRios.DiegoLopez },
                { 1863, LocalidadEntreRios.FranciscoRamirez },
                { 1864, LocalidadEntreRios.SauceDeLuna },
                { 1865, LocalidadEntreRios.Federal },
                { 1866, LocalidadEntreRios.ConscriptoBernardi },
                { 1867, LocalidadEntreRios.SauceDeLuna },
                { 1868, LocalidadEntreRios.ElCimarron },
                { 1869, LocalidadEntreRios.NuevaVizcaya },
                { 1870, LocalidadEntreRios.PasoDuarte },
                { 1871, LocalidadEntreRios.Banderas },
                { 1872, LocalidadEntreRios.SantaLucia },
                { 1873, LocalidadEntreRios.ArroyoDelMedio },
                { 1874, LocalidadEntreRios.ArroyoLasTunas },
                { 1875, LocalidadEntreRios.DistritoDiegoLopez },
                { 1876, LocalidadEntreRios.ElGatoLomaLimpia },
                { 1877, LocalidadEntreRios.ElGramiyal }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Feliciano).Key, new Dictionary<long, string>
            {
                { 1878, LocalidadEntreRios.SanJoseDeFeliciano },
                { 1879, LocalidadEntreRios.SanVictor },
                { 1880, LocalidadEntreRios.DistritoChanar },
                { 1881, LocalidadEntreRios.LaVerbena },
                { 1882, LocalidadEntreRios.LagunaBenitez },
                { 1883, LocalidadEntreRios.LaEsmeralda },
                { 1884, LocalidadEntreRios.LasMulitas },
                { 1885, LocalidadEntreRios.LasHierras },
                { 1886, LocalidadEntreRios.MulasGrandes }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Gualeguay).Key, new Dictionary<long, string>
            {
                { 1887, LocalidadEntreRios.Gualeguay },
                { 1888, LocalidadEntreRios.GeneralGalarza },
                { 1889, LocalidadEntreRios.AldeaAsuncion },
                { 1890, LocalidadEntreRios.DistritoSextoCostaDeNogoya },
                { 1891, LocalidadEntreRios.QuintoDistrito },
                { 1892, LocalidadEntreRios.IslasLasLechiguanas },
                { 1893, LocalidadEntreRios.PrimerDistritoCuchilla },
                { 1894, LocalidadEntreRios.DistritoCuarto },
                { 1895, LocalidadEntreRios.EstacionLazo },
                { 1896, LocalidadEntreRios.GonzalezCalderon },
                { 1897, LocalidadEntreRios.MonteRedondo },
                { 1898, LocalidadEntreRios.PuntaDelMonte }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Gualeguaychu).Key, new Dictionary<long, string>
            {
                { 1899, LocalidadEntreRios.Gualeguaychu },
                { 1900, LocalidadEntreRios.Larroque },
                { 1901, LocalidadEntreRios.Urdinarrain },
                { 1902, LocalidadEntreRios.Gilbert },
                { 1903, LocalidadEntreRios.PuebloGeneralBelgrano },
                { 1904, LocalidadEntreRios.EnriqueCarbo },
                { 1905, LocalidadEntreRios.AldeaSanJuan },
                { 1906, LocalidadEntreRios.Irazusta },
                { 1907, LocalidadEntreRios.CostaUruguayNorte },
                { 1908, LocalidadEntreRios.FaustinoMParera },
                { 1909, LocalidadEntreRios.GeneralAlmada },
                { 1910, LocalidadEntreRios.LasMercedes },
                { 1911, LocalidadEntreRios.CostaDeSanAntonio },
                { 1912, LocalidadEntreRios.CostaUruguaySur },
                { 1913, LocalidadEntreRios.CuchillaRedonda },
                { 1914, LocalidadEntreRios.DistritoTalitas },
                { 1915, LocalidadEntreRios.EstacionEscrina },
                { 1916, LocalidadEntreRios.PastorBritos },
                { 1917, LocalidadEntreRios.Perdices },
                { 1918, LocalidadEntreRios.RinconDelCinto },
                { 1919, LocalidadEntreRios.RinconDelGato }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.IslasDelIbicuy).Key, new Dictionary<long, string>
            {
                { 1920, LocalidadEntreRios.Ceibas },
                { 1921, LocalidadEntreRios.PuertoIbicuy },
                { 1922, LocalidadEntreRios.VillaParanacito },
                { 1923, LocalidadEntreRios.Medanos },
                { 1924, LocalidadEntreRios.Nancay }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.LaPaz).Key, new Dictionary<long, string>
            {
                { 1925, LocalidadEntreRios.Bovril },
                { 1926, LocalidadEntreRios.LaPaz },
                { 1927, LocalidadEntreRios.SantaElena },
                { 1928, LocalidadEntreRios.PiedrasBlancas },
                { 1929, LocalidadEntreRios.SanGustavo },
                { 1930, LocalidadEntreRios.VillaAlcaraz },
                { 1931, LocalidadEntreRios.ColoniaAvigdor },
                { 1932, LocalidadEntreRios.ElSolar },
                { 1933, LocalidadEntreRios.Ombu },
                { 1934, LocalidadEntreRios.AlcarazNorte },
                { 1935, LocalidadEntreRios.AlcarazSur },
                { 1936, LocalidadEntreRios.YesoOeste },
                { 1937, LocalidadEntreRios.ColoniaCarrasco },
                { 1938, LocalidadEntreRios.ColoniaOficialN3 },
                { 1939, LocalidadEntreRios.ColoniaOficialN14 },
                { 1940, LocalidadEntreRios.ElQuebracho },
                { 1941, LocalidadEntreRios.LaProvidencia },
                { 1942, LocalidadEntreRios.PuertoAlgarrobo },
                { 1943, LocalidadEntreRios.SanRamirez },
                { 1944, LocalidadEntreRios.Saucecito },
                { 1945, LocalidadEntreRios.SirLeonard },
                { 1946, LocalidadEntreRios.TacuarasYacare },
                { 1947, LocalidadEntreRios.ColoniaOficialN13 },
                { 1948, LocalidadEntreRios.ColoniaViraro },
                { 1949, LocalidadEntreRios.Estaquitas },
                { 1950, LocalidadEntreRios.LasToscas },
                { 1951, LocalidadEntreRios.PicadaBeron }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Nogoya).Key, new Dictionary<long, string>
            {
                { 1952, LocalidadEntreRios.LucasGonzalez },
                { 1953, LocalidadEntreRios.Nogoya },
                { 1954, LocalidadEntreRios.Aranguren },
                { 1955, LocalidadEntreRios.Hernandez },
                { 1956, LocalidadEntreRios.DonCristobalSegundo },
                { 1957, LocalidadEntreRios.Febre },
                { 1958, LocalidadEntreRios.XXDeSetiembre },
                { 1959, LocalidadEntreRios.CrucesitasOctava },
                { 1960, LocalidadEntreRios.DistritoSauce },
                { 1961, LocalidadEntreRios.DonCristobalPrimero },
                { 1962, LocalidadEntreRios.JustoJoseDeUrquiza },
                { 1963, LocalidadEntreRios.AldeaSanMiguel },
                { 1964, LocalidadEntreRios.CrucecitasSeptima },
                { 1965, LocalidadEntreRios.CrucecitasTercera },
                { 1966, LocalidadEntreRios.Betbeder },
                { 1967, LocalidadEntreRios.DistritoChiqueros },
                { 1968, LocalidadEntreRios.Laurencena }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Parana).Key, new Dictionary<long, string>
            {
                { 1969, LocalidadEntreRios.Crespo },
                { 1970, LocalidadEntreRios.MariaGrande },
                { 1971, LocalidadEntreRios.Parana },
                { 1972, LocalidadEntreRios.SanBenito },
                { 1973, LocalidadEntreRios.Viale },
                { 1974, LocalidadEntreRios.VillaHernandarias },
                { 1975, LocalidadEntreRios.Cerrito },
                { 1976, LocalidadEntreRios.ColoniaAvellaneda },
                { 1977, LocalidadEntreRios.Hasenkamp },
                { 1978, LocalidadEntreRios.OroVerde },
                { 1979, LocalidadEntreRios.Segui },
                { 1980, LocalidadEntreRios.Tabossi },
                { 1981, LocalidadEntreRios.VillaUrquiza },
                { 1982, LocalidadEntreRios.AldeaMariaLuisa },
                { 1983, LocalidadEntreRios.ElPingo },
                { 1984, LocalidadEntreRios.PuebloBrugo },
                { 1985, LocalidadEntreRios.AldeaSantaMaria },
                { 1986, LocalidadEntreRios.PuertoCurtiembre },
                { 1987, LocalidadEntreRios.ElPalenque },
                { 1988, LocalidadEntreRios.LaPicada },
                { 1989, LocalidadEntreRios.LasTunas },
                { 1990, LocalidadEntreRios.SauceMontrull },
                { 1991, LocalidadEntreRios.Sosa },
                { 1992, LocalidadEntreRios.ColoniaCrespo },
                { 1993, LocalidadEntreRios.PuebloBellocq },
                { 1994, LocalidadEntreRios.SaucePinto },
                { 1995, LocalidadEntreRios.TezanosPinto },
                { 1996, LocalidadEntreRios.VillaFontana },
                { 1997, LocalidadEntreRios.VillaGobernadorEtchevehere },
                { 1998, LocalidadEntreRios.ArroyoBurgos },
                { 1999, LocalidadEntreRios.ArroyoCorralito },
                { 2000, LocalidadEntreRios.AldeaEigenfeld },
                { 2001, LocalidadEntreRios.AldeaSanAntonio },
                { 2002, LocalidadEntreRios.AldeaSanRafael },
                { 2003, LocalidadEntreRios.AldeaSantaRosa },
                { 2004, LocalidadEntreRios.AntonioTomas },
                { 2005, LocalidadEntreRios.ColoniaCelina },
                { 2006, LocalidadEntreRios.EspinilloNorte },
                { 2007, LocalidadEntreRios.MariaGrandeSegunda },
                { 2008, LocalidadEntreRios.PasoDeLaArena },
                { 2009, LocalidadEntreRios.PasoDeLaPiedra },
                { 2010, LocalidadEntreRios.SantaLuisa },
                { 2011, LocalidadEntreRios.ArroyoMaturrango },
                { 2012, LocalidadEntreRios.ArroyoPaloSeco },
                { 2013, LocalidadEntreRios.ColoniaCerrito },
                { 2014, LocalidadEntreRios.ColoniaMerou },
                { 2015, LocalidadEntreRios.ColoniaReffino },
                { 2016, LocalidadEntreRios.DistritoTala },
                { 2017, LocalidadEntreRios.Quebracho }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.SanSalvador).Key, new Dictionary<long, string>
            {
                { 2018, LocalidadEntreRios.SanSalvador },
                { 2019, LocalidadEntreRios.GeneralCampos },
                { 2020, LocalidadEntreRios.ColoniaBaylina },
                { 2021, LocalidadEntreRios.SanErnesto },
                { 2022, LocalidadEntreRios.ColoniaOficialN5 },
                { 2023, LocalidadEntreRios.WalterMoss }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Tala).Key, new Dictionary<long, string>
            {
                { 2024, LocalidadEntreRios.Macia },
                { 2025, LocalidadEntreRios.RosarioDelTala },
                { 2026, LocalidadEntreRios.GobernadorMansilla },
                { 2027, LocalidadEntreRios.GobernadorSola },
                { 2028, LocalidadEntreRios.Durazno },
                { 2029, LocalidadEntreRios.GobernadorEchague },
                { 2030, LocalidadEntreRios.Guardamonte },
                { 2031, LocalidadEntreRios.AltamiranoSur },
                { 2032, LocalidadEntreRios.ArroyoCle },
                { 2033, LocalidadEntreRios.LasGuachas },
                { 2034, LocalidadEntreRios.SauceSur },
                { 2035, LocalidadEntreRios.LaOllita }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Uruguay).Key, new Dictionary<long, string>
            {
                { 2036, LocalidadEntreRios.Basavilbaso },
                { 2037, LocalidadEntreRios.ConcepcionDelUruguay },
                { 2038, LocalidadEntreRios.Caseros },
                { 2039, LocalidadEntreRios.ColoniaElia },
                { 2040, LocalidadEntreRios.Herrera },
                { 2041, LocalidadEntreRios.PrimeroDeMayo },
                { 2042, LocalidadEntreRios.Pronunciamiento },
                { 2043, LocalidadEntreRios.SanJusto },
                { 2044, LocalidadEntreRios.SantaAnita },
                { 2045, LocalidadEntreRios.VillaMantero },
                { 2046, LocalidadEntreRios.LasMoscas },
                { 2047, LocalidadEntreRios.SanCipriano },
                { 2048, LocalidadEntreRios.VillaSanMarcial },
                { 2049, LocalidadEntreRios.Tala },
                { 2050, LocalidadEntreRios.EstacionLibaros },
                { 2051, LocalidadEntreRios.Rocamora },
                { 2052, LocalidadEntreRios.ArroyoGena }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Victoria).Key, new Dictionary<long, string>
            {
                { 2053, LocalidadEntreRios.Victoria },
                { 2054, LocalidadEntreRios.RinconDeNogoya },
                { 2055, LocalidadEntreRios.RinconDelDoll },
                { 2056, LocalidadEntreRios.Antelo },
                { 2057, LocalidadEntreRios.MolinoDoll },
                { 2058, LocalidadEntreRios.Chilcas },
                { 2059, LocalidadEntreRios.DistritoPajonal },
                { 2060, LocalidadEntreRios.Hinojal },
                { 2061, LocalidadEntreRios.LagunaDelPescado },
                { 2062, LocalidadEntreRios.Montoya }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoEntreRios.Villaguay).Key, new Dictionary<long, string>
            {
                { 2063, LocalidadEntreRios.Villaguay },
                { 2064, LocalidadEntreRios.VillaClara },
                { 2065, LocalidadEntreRios.VillaDominguez },
                { 2066, LocalidadEntreRios.Jubileo },
                { 2067, LocalidadEntreRios.PasoDeLaLaguna },
                { 2068, LocalidadEntreRios.IngenieroSajaroff },
                { 2069, LocalidadEntreRios.LucasNorte },
                { 2070, LocalidadEntreRios.LucasSurSegundo },
                { 2071, LocalidadEntreRios.RaicesOeste },
                { 2072, LocalidadEntreRios.EstacionRaices },
                { 2073, LocalidadEntreRios.LucasSurPrimera },
                { 2074, LocalidadEntreRios.MojonesNorte },
                { 2075, LocalidadEntreRios.ParajeLosAlgarrobos },
                { 2076, LocalidadEntreRios.ColoniaAdivino },
                { 2077, LocalidadEntreRios.MojonesSud }
            });
        }
    }
}
