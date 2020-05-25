using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class FormosaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public FormosaLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoFormosa.Bermejo).Value.Key, new Dictionary<long, string>
            {
                { 2078, LocalidadFormosa.LagunaYema },
                { 2079, LocalidadFormosa.FortinSoledad },
                { 2080, LocalidadFormosa.Guadalcazar },
                { 2081, LocalidadFormosa.Lamadrid },
                { 2082, LocalidadFormosa.LaRinconada },
                { 2083, LocalidadFormosa.LosChiriguanos },
                { 2084, LocalidadFormosa.PozoDeMaza },
                { 2085, LocalidadFormosa.PozoDelMortero },
                { 2086, LocalidadFormosa.VacaPerdida }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoFormosa.Formosa).Value.Key, new Dictionary<long, string>
            {
                { 2087, LocalidadFormosa.Formosa },
                { 2088, LocalidadFormosa.ColoniaPastoril },
                { 2089, LocalidadFormosa.GranGuardia },
                { 2090, LocalidadFormosa.SanHilario },
                { 2091, LocalidadFormosa.MarianoBoedo },
                { 2092, LocalidadFormosa.MojonDeFierro },
                { 2093, LocalidadFormosa.VillaDelCarmen },
                { 2094, LocalidadFormosa.VillaTrinidad }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoFormosa.Laishi).Value.Key, new Dictionary<long, string>
            {
                { 2095, LocalidadFormosa.SanFranciscoDeLaishi },
                { 2096, LocalidadFormosa.BancoPayagua },
                { 2097, LocalidadFormosa.GeneralLucioVMansilla },
                { 2098, LocalidadFormosa.Herradura },
                { 2099, LocalidadFormosa.Tatane },
                { 2100, LocalidadFormosa.VillaEscolar }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoFormosa.Matacos).Value.Key, new Dictionary<long, string>
            {
                { 2101, LocalidadFormosa.IngenieroJuarez }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoFormosa.Patino).Value.Key, new Dictionary<long, string>
            {
                { 2102, LocalidadFormosa.ComandanteFontana },
                { 2103, LocalidadFormosa.BartolomeDeLasCasas },
                { 2104, LocalidadFormosa.ColoniaSarmiento },
                { 2105, LocalidadFormosa.ElRecreo },
                { 2106, LocalidadFormosa.EstanislaoDelCampo },
                { 2107, LocalidadFormosa.FortinLeyes },
                { 2108, LocalidadFormosa.FortinLugones },
                { 2109, LocalidadFormosa.GeneralManuelBelgrano },
                { 2110, LocalidadFormosa.Ibarreta },
                { 2111, LocalidadFormosa.JuanGBazan },
                { 2112, LocalidadFormosa.LasLomitas },
                { 2113, LocalidadFormosa.PostaCambioZalazar },
                { 2114, LocalidadFormosa.PozoDelTigre },
                { 2115, LocalidadFormosa.SanMartin1 },
                { 2116, LocalidadFormosa.SanMartin2 },
                { 2117, LocalidadFormosa.SubtenientePerin },
                { 2118, LocalidadFormosa.VillaGeneralGuemes }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoFormosa.Pilagas).Value.Key, new Dictionary<long, string>
            {
                { 2119, LocalidadFormosa.ElEspinillo },
                { 2120, LocalidadFormosa.BuenaVista },
                { 2121, LocalidadFormosa.MisionTacaagle },
                { 2122, LocalidadFormosa.PortonNegro },
                { 2123, LocalidadFormosa.TresLagunas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoFormosa.Pilcomayo).Value.Key, new Dictionary<long, string>
            {
                { 2124, LocalidadFormosa.Clorinda },
                { 2125, LocalidadFormosa.LagunaBlanca },
                { 2126, LocalidadFormosa.LagunaNaickNeck },
                { 2127, LocalidadFormosa.PalmaSola },
                { 2128, LocalidadFormosa.PuertoPilcomayo },
                { 2129, LocalidadFormosa.RiachoHeHe },
                { 2130, LocalidadFormosa.RiachoNegro },
                { 2131, LocalidadFormosa.SietePalmas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoFormosa.Pirane).Value.Key, new Dictionary<long, string>
            {
                { 2132, LocalidadFormosa.Pirane },
                { 2133, LocalidadFormosa.ElColorado },
                { 2134, LocalidadFormosa.MayorVicenteVillafane },
                { 2135, LocalidadFormosa.PaloSanto },
                { 2136, LocalidadFormosa.VillaDosTrece }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoFormosa.RamonLista).Value.Key, new Dictionary<long, string>
            {
                { 2137, LocalidadFormosa.GeneralMosconi },
                { 2138, LocalidadFormosa.ElPotrillo }
            });
        }
    }
}
