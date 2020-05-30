using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    class LocalidadJujuyFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadJujuyFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
            : base(partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.Cochinoca).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2139, LocalidadJujuy.AbraPampa),
                datosEntidadBuilder.Build(2140, LocalidadJujuy.PuestoDelMarques),
                datosEntidadBuilder.Build(2141, LocalidadJujuy.AbdonCastroTolay),
                datosEntidadBuilder.Build(2142, LocalidadJujuy.Rinconadillas),
                datosEntidadBuilder.Build(2143, LocalidadJujuy.SantuarioDeTresPozos),
                datosEntidadBuilder.Build(2144, LocalidadJujuy.Casabindo),
                datosEntidadBuilder.Build(2145, LocalidadJujuy.Tusaquillas),
                datosEntidadBuilder.Build(2146, LocalidadJujuy.Cochinoca),
                datosEntidadBuilder.Build(2147, LocalidadJujuy.SanFranciscoDeAlfarcito)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.DrManuelBelgrano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2148, LocalidadJujuy.Guerrero),
                datosEntidadBuilder.Build(2149, LocalidadJujuy.LaAlmona),
                datosEntidadBuilder.Build(2150, LocalidadJujuy.Leon),
                datosEntidadBuilder.Build(2151, LocalidadJujuy.LosNogales),
                datosEntidadBuilder.Build(2152, LocalidadJujuy.Lozano),
                datosEntidadBuilder.Build(2153, LocalidadJujuy.Ocloyas),
                datosEntidadBuilder.Build(2154, LocalidadJujuy.SanPabloDeReyes),
                datosEntidadBuilder.Build(2155, LocalidadJujuy.SanSalvadorDeJujuy),
                datosEntidadBuilder.Build(2156, LocalidadJujuy.Yala)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.ElCarmen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2157, LocalidadJujuy.Perico),
                datosEntidadBuilder.Build(2158, LocalidadJujuy.ElCarmen),
                datosEntidadBuilder.Build(2159, LocalidadJujuy.Monterrico),
                datosEntidadBuilder.Build(2160, LocalidadJujuy.PampaBlanca),
                datosEntidadBuilder.Build(2161, LocalidadJujuy.AguasCalientes),
                datosEntidadBuilder.Build(2162, LocalidadJujuy.PuestoViejo),
                datosEntidadBuilder.Build(2163, LocalidadJujuy.BarrioElMilagro),
                datosEntidadBuilder.Build(2164, LocalidadJujuy.BarrioLaUnion),
                datosEntidadBuilder.Build(2165, LocalidadJujuy.LosLapachos),
                datosEntidadBuilder.Build(2166, LocalidadJujuy.Manantiales)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.Humahuaca).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2167, LocalidadJujuy.Coctaca),
                datosEntidadBuilder.Build(2168, LocalidadJujuy.ElAguilar),
                datosEntidadBuilder.Build(2169, LocalidadJujuy.Humahuaca),
                datosEntidadBuilder.Build(2170, LocalidadJujuy.Iturbe),
                datosEntidadBuilder.Build(2171, LocalidadJujuy.TresCruces),
                datosEntidadBuilder.Build(2172, LocalidadJujuy.Uquia)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.Ledesma).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2173, LocalidadJujuy.VeintitresDeAgosto),
                datosEntidadBuilder.Build(2174, LocalidadJujuy.Bananal),
                datosEntidadBuilder.Build(2175, LocalidadJujuy.Bermejito),
                datosEntidadBuilder.Build(2176, LocalidadJujuy.Caimancito),
                datosEntidadBuilder.Build(2177, LocalidadJujuy.Calilegua),
                datosEntidadBuilder.Build(2178, LocalidadJujuy.Chalican),
                datosEntidadBuilder.Build(2179, LocalidadJujuy.FrailePintado),
                datosEntidadBuilder.Build(2180, LocalidadJujuy.Guayacan),
                datosEntidadBuilder.Build(2181, LocalidadJujuy.Jaramillo),
                datosEntidadBuilder.Build(2182, LocalidadJujuy.Libertad),
                datosEntidadBuilder.Build(2183, LocalidadJujuy.LibertadorGeneralSanMartin),
                datosEntidadBuilder.Build(2184, LocalidadJujuy.Paulina),
                datosEntidadBuilder.Build(2185, LocalidadJujuy.SanBorja),
                datosEntidadBuilder.Build(2186, LocalidadJujuy.Yuto)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.Palpala).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2187, LocalidadJujuy.Carahunco),
                datosEntidadBuilder.Build(2188, LocalidadJujuy.CentroForestal),
                datosEntidadBuilder.Build(2189, LocalidadJujuy.Palpala)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.Rinconada).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2190, LocalidadJujuy.CasaColorada),
                datosEntidadBuilder.Build(2191, LocalidadJujuy.Coyaguaima),
                datosEntidadBuilder.Build(2192, LocalidadJujuy.LagunillasDelFarallon),
                datosEntidadBuilder.Build(2193, LocalidadJujuy.Liviara),
                datosEntidadBuilder.Build(2194, LocalidadJujuy.LomaBlanca),
                datosEntidadBuilder.Build(2195, LocalidadJujuy.NuevoPirquitas),
                datosEntidadBuilder.Build(2196, LocalidadJujuy.Orosmayo),
                datosEntidadBuilder.Build(2197, LocalidadJujuy.Rinconada)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.SanAntonio).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2198, LocalidadJujuy.ElCeibal),
                datosEntidadBuilder.Build(2199, LocalidadJujuy.LoteoNavea),
                datosEntidadBuilder.Build(2200, LocalidadJujuy.SanAntonio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.SanPedro).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2201, LocalidadJujuy.Arrayanal),
                datosEntidadBuilder.Build(2202, LocalidadJujuy.ArroyoColorado),
                datosEntidadBuilder.Build(2203, LocalidadJujuy.DonEmilio),
                datosEntidadBuilder.Build(2204, LocalidadJujuy.ElAcheral),
                datosEntidadBuilder.Build(2205, LocalidadJujuy.ElPuesto),
                datosEntidadBuilder.Build(2206, LocalidadJujuy.ElQuemado),
                datosEntidadBuilder.Build(2207, LocalidadJujuy.ElSauzal),
                datosEntidadBuilder.Build(2208, LocalidadJujuy.LaEsperanza),
                datosEntidadBuilder.Build(2209, LocalidadJujuy.LaManga),
                datosEntidadBuilder.Build(2210, LocalidadJujuy.LaMendieta),
                datosEntidadBuilder.Build(2211, LocalidadJujuy.Miraflores),
                datosEntidadBuilder.Build(2212, LocalidadJujuy.PalosBlancos),
                datosEntidadBuilder.Build(2213, LocalidadJujuy.Parapeti),
                datosEntidadBuilder.Build(2214, LocalidadJujuy.Piedritas),
                datosEntidadBuilder.Build(2215, LocalidadJujuy.Rodeito),
                datosEntidadBuilder.Build(2216, LocalidadJujuy.RosarioDeRioGrande),
                datosEntidadBuilder.Build(2217, LocalidadJujuy.SanAntonio),
                datosEntidadBuilder.Build(2218, LocalidadJujuy.SanLucas),
                datosEntidadBuilder.Build(2219, LocalidadJujuy.SanPedroDeJujuy)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.SantaBarbara).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2220, LocalidadJujuy.ElPiquete),
                datosEntidadBuilder.Build(2221, LocalidadJujuy.PuenteLavayen),
                datosEntidadBuilder.Build(2222, LocalidadJujuy.ElFuerte),
                datosEntidadBuilder.Build(2223, LocalidadJujuy.ElTalar),
                datosEntidadBuilder.Build(2224, LocalidadJujuy.PalmaSola),
                datosEntidadBuilder.Build(2225, LocalidadJujuy.SantaClara),
                datosEntidadBuilder.Build(2226, LocalidadJujuy.Vinalito)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.SantaCatalina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2227, LocalidadJujuy.Casira),
                datosEntidadBuilder.Build(2228, LocalidadJujuy.CienegaDePaicone),
                datosEntidadBuilder.Build(2229, LocalidadJujuy.Cieneguillas),
                datosEntidadBuilder.Build(2230, LocalidadJujuy.CusiCusi),
                datosEntidadBuilder.Build(2231, LocalidadJujuy.SantaCatalina)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.Susques).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2232, LocalidadJujuy.Susques),
                datosEntidadBuilder.Build(2233, LocalidadJujuy.Catua),
                datosEntidadBuilder.Build(2234, LocalidadJujuy.Coranzuli),
                datosEntidadBuilder.Build(2235, LocalidadJujuy.ElToro),
                datosEntidadBuilder.Build(2236, LocalidadJujuy.Huancar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.Tilcara).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2237, LocalidadJujuy.ColoniaSanJose),
                datosEntidadBuilder.Build(2238, LocalidadJujuy.Huacalera),
                datosEntidadBuilder.Build(2239, LocalidadJujuy.Juella),
                datosEntidadBuilder.Build(2240, LocalidadJujuy.Maimara),
                datosEntidadBuilder.Build(2241, LocalidadJujuy.Tilcara)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.Tumbaya).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2242, LocalidadJujuy.Barcena),
                datosEntidadBuilder.Build(2243, LocalidadJujuy.ElMoreno),
                datosEntidadBuilder.Build(2244, LocalidadJujuy.Purmamarca),
                datosEntidadBuilder.Build(2245, LocalidadJujuy.Tumbaya),
                datosEntidadBuilder.Build(2246, LocalidadJujuy.Volcan)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.ValleGrande).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2247, LocalidadJujuy.Caspala),
                datosEntidadBuilder.Build(2248, LocalidadJujuy.Pampichuela),
                datosEntidadBuilder.Build(2249, LocalidadJujuy.SanFrancisco),
                datosEntidadBuilder.Build(2250, LocalidadJujuy.SantaAna),
                datosEntidadBuilder.Build(2251, LocalidadJujuy.ValleColorado),
                datosEntidadBuilder.Build(2252, LocalidadJujuy.ValleGrande)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoJujuy.Yavi).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2253, LocalidadJujuy.Cangrejillos),
                datosEntidadBuilder.Build(2254, LocalidadJujuy.ElCondor),
                datosEntidadBuilder.Build(2255, LocalidadJujuy.LaIntermedia),
                datosEntidadBuilder.Build(2256, LocalidadJujuy.LaQuiaca),
                datosEntidadBuilder.Build(2257, LocalidadJujuy.Pumahuasi),
                datosEntidadBuilder.Build(2258, LocalidadJujuy.Yavi),
                datosEntidadBuilder.Build(2259, LocalidadJujuy.Barrios)
            });
        }
    }
}
