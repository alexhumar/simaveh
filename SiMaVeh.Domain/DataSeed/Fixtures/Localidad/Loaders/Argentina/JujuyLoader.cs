using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class JujuyLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public JujuyLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.Cochinoca).Value.Key, new Dictionary<long, string>
            {
                { 2139, LocalidadJujuy.AbraPampa },
                { 2140, LocalidadJujuy.PuestoDelMarques },
                { 2141, LocalidadJujuy.AbdonCastroTolay },
                { 2142, LocalidadJujuy.Rinconadillas },
                { 2143, LocalidadJujuy.SantuarioDeTresPozos },
                { 2144, LocalidadJujuy.Casabindo },
                { 2145, LocalidadJujuy.Tusaquillas },
                { 2146, LocalidadJujuy.Cochinoca },
                { 2147, LocalidadJujuy.SanFranciscoDeAlfarcito }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.DrManuelBelgrano).Value.Key, new Dictionary<long, string>
            {
                { 2148, LocalidadJujuy.Guerrero },
                { 2149, LocalidadJujuy.LaAlmona },
                { 2150, LocalidadJujuy.Leon },
                { 2151, LocalidadJujuy.LosNogales },
                { 2152, LocalidadJujuy.Lozano },
                { 2153, LocalidadJujuy.Ocloyas },
                { 2154, LocalidadJujuy.SanPabloDeReyes },
                { 2155, LocalidadJujuy.SanSalvadorDeJujuy },
                { 2156, LocalidadJujuy.Yala }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.ElCarmen).Value.Key, new Dictionary<long, string>
            {
                { 2157, LocalidadJujuy.Perico },
                { 2158, LocalidadJujuy.ElCarmen },
                { 2159, LocalidadJujuy.Monterrico },
                { 2160, LocalidadJujuy.PampaBlanca },
                { 2161, LocalidadJujuy.AguasCalientes },
                { 2162, LocalidadJujuy.PuestoViejo },
                { 2163, LocalidadJujuy.BarrioElMilagro },
                { 2164, LocalidadJujuy.BarrioLaUnion },
                { 2165, LocalidadJujuy.LosLapachos },
                { 2166, LocalidadJujuy.Manantiales }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.Humahuaca).Value.Key, new Dictionary<long, string>
            {
                { 2167, LocalidadJujuy.Coctaca },
                { 2168, LocalidadJujuy.ElAguilar },
                { 2169, LocalidadJujuy.Humahuaca },
                { 2170, LocalidadJujuy.Iturbe },
                { 2171, LocalidadJujuy.TresCruces },
                { 2172, LocalidadJujuy.Uquia }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.Ledesma).Value.Key, new Dictionary<long, string>
            {
                { 2173, LocalidadJujuy.VeintitresDeAgosto },
                { 2174, LocalidadJujuy.Bananal },
                { 2175, LocalidadJujuy.Bermejito },
                { 2176, LocalidadJujuy.Caimancito },
                { 2177, LocalidadJujuy.Calilegua },
                { 2178, LocalidadJujuy.Chalican },
                { 2179, LocalidadJujuy.FrailePintado },
                { 2180, LocalidadJujuy.Guayacan },
                { 2181, LocalidadJujuy.Jaramillo },
                { 2182, LocalidadJujuy.Libertad },
                { 2183, LocalidadJujuy.LibertadorGeneralSanMartin },
                { 2184, LocalidadJujuy.Paulina },
                { 2185, LocalidadJujuy.SanBorja },
                { 2186, LocalidadJujuy.Yuto }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.Palpala).Value.Key, new Dictionary<long, string>
            {
                { 2187, LocalidadJujuy.Carahunco },
                { 2188, LocalidadJujuy.CentroForestal },
                { 2189, LocalidadJujuy.Palpala }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.Rinconada).Value.Key, new Dictionary<long, string>
            {
                { 2190, LocalidadJujuy.CasaColorada },
                { 2191, LocalidadJujuy.Coyaguaima },
                { 2192, LocalidadJujuy.LagunillasDelFarallon },
                { 2193, LocalidadJujuy.Liviara },
                { 2194, LocalidadJujuy.LomaBlanca },
                { 2195, LocalidadJujuy.NuevoPirquitas },
                { 2196, LocalidadJujuy.Orosmayo },
                { 2197, LocalidadJujuy.Rinconada }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.SanAntonio).Value.Key, new Dictionary<long, string>
            {
                { 2198, LocalidadJujuy.ElCeibal },
                { 2199, LocalidadJujuy.LoteoNavea },
                { 2200, LocalidadJujuy.SanAntonio }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.SanPedro).Value.Key, new Dictionary<long, string>
            {
                { 2201, LocalidadJujuy.Arrayanal },
                { 2202, LocalidadJujuy.ArroyoColorado },
                { 2203, LocalidadJujuy.DonEmilio },
                { 2204, LocalidadJujuy.ElAcheral },
                { 2205, LocalidadJujuy.ElPuesto },
                { 2206, LocalidadJujuy.ElQuemado },
                { 2207, LocalidadJujuy.ElSauzal },
                { 2208, LocalidadJujuy.LaEsperanza },
                { 2209, LocalidadJujuy.LaManga },
                { 2210, LocalidadJujuy.LaMendieta },
                { 2211, LocalidadJujuy.Miraflores },
                { 2212, LocalidadJujuy.PalosBlancos },
                { 2213, LocalidadJujuy.Parapeti },
                { 2214, LocalidadJujuy.Piedritas },
                { 2215, LocalidadJujuy.Rodeito },
                { 2216, LocalidadJujuy.RosarioDeRioGrande },
                { 2217, LocalidadJujuy.SanAntonio },
                { 2218, LocalidadJujuy.SanLucas },
                { 2219, LocalidadJujuy.SanPedroDeJujuy }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.SantaBarbara).Value.Key, new Dictionary<long, string>
            {
                { 2220, LocalidadJujuy.ElPiquete },
                { 2221, LocalidadJujuy.PuenteLavayen },
                { 2222, LocalidadJujuy.ElFuerte },
                { 2223, LocalidadJujuy.ElTalar },
                { 2224, LocalidadJujuy.PalmaSola },
                { 2225, LocalidadJujuy.SantaClara },
                { 2226, LocalidadJujuy.Vinalito }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.SantaCatalina).Value.Key, new Dictionary<long, string>
            {
                { 2227, LocalidadJujuy.Casira },
                { 2228, LocalidadJujuy.CienegaDePaicone },
                { 2229, LocalidadJujuy.Cieneguillas },
                { 2230, LocalidadJujuy.CusiCusi },
                { 2231, LocalidadJujuy.SantaCatalina }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.Susques).Value.Key, new Dictionary<long, string>
            {
                { 2232, LocalidadJujuy.Susques },
                { 2233, LocalidadJujuy.Catua },
                { 2234, LocalidadJujuy.Coranzuli },
                { 2235, LocalidadJujuy.ElToro },
                { 2236, LocalidadJujuy.Huancar }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.Tilcara).Value.Key, new Dictionary<long, string>
            {
                { 2237, LocalidadJujuy.ColoniaSanJose },
                { 2238, LocalidadJujuy.Huacalera },
                { 2239, LocalidadJujuy.Juella },
                { 2240, LocalidadJujuy.Maimara },
                { 2241, LocalidadJujuy.Tilcara }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.Tumbaya).Value.Key, new Dictionary<long, string>
            {
                { 2242, LocalidadJujuy.Barcena },
                { 2243, LocalidadJujuy.ElMoreno },
                { 2244, LocalidadJujuy.Purmamarca },
                { 2245, LocalidadJujuy.Tumbaya },
                { 2246, LocalidadJujuy.Volcan }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.ValleGrande).Value.Key, new Dictionary<long, string>
            {
                { 2247, LocalidadJujuy.Caspala },
                { 2248, LocalidadJujuy.Pampichuela },
                { 2249, LocalidadJujuy.SanFrancisco },
                { 2250, LocalidadJujuy.SantaAna },
                { 2251, LocalidadJujuy.ValleColorado },
                { 2252, LocalidadJujuy.ValleGrande }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoJujuy.Yavi).Value.Key, new Dictionary<long, string>
            {
                { 2253, LocalidadJujuy.Cangrejillos },
                { 2254, LocalidadJujuy.ElCondor },
                { 2255, LocalidadJujuy.LaIntermedia },
                { 2256, LocalidadJujuy.LaQuiaca },
                { 2257, LocalidadJujuy.Pumahuasi },
                { 2258, LocalidadJujuy.Yavi },
                { 2259, LocalidadJujuy.Barrios }
            });
        }
    }
}
