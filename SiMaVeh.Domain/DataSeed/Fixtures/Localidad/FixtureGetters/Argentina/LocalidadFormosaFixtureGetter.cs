using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    internal class LocalidadFormosaFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadFormosaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoFormosa.Bermejo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2078, LocalidadFormosa.LagunaYema),
                datosEntidadBuilder.Build(2079, LocalidadFormosa.FortinSoledad),
                datosEntidadBuilder.Build(2080, LocalidadFormosa.Guadalcazar),
                datosEntidadBuilder.Build(2081, LocalidadFormosa.Lamadrid),
                datosEntidadBuilder.Build(2082, LocalidadFormosa.LaRinconada),
                datosEntidadBuilder.Build(2083, LocalidadFormosa.LosChiriguanos),
                datosEntidadBuilder.Build(2084, LocalidadFormosa.PozoDeMaza),
                datosEntidadBuilder.Build(2085, LocalidadFormosa.PozoDelMortero),
                datosEntidadBuilder.Build(2086, LocalidadFormosa.VacaPerdida)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoFormosa.Formosa).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2087, LocalidadFormosa.Formosa),
                datosEntidadBuilder.Build(2088, LocalidadFormosa.ColoniaPastoril),
                datosEntidadBuilder.Build(2089, LocalidadFormosa.GranGuardia),
                datosEntidadBuilder.Build(2090, LocalidadFormosa.SanHilario),
                datosEntidadBuilder.Build(2091, LocalidadFormosa.MarianoBoedo),
                datosEntidadBuilder.Build(2092, LocalidadFormosa.MojonDeFierro),
                datosEntidadBuilder.Build(2093, LocalidadFormosa.VillaDelCarmen),
                datosEntidadBuilder.Build(2094, LocalidadFormosa.VillaTrinidad)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoFormosa.Laishi).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2095, LocalidadFormosa.SanFranciscoDeLaishi),
                datosEntidadBuilder.Build(2096, LocalidadFormosa.BancoPayagua),
                datosEntidadBuilder.Build(2097, LocalidadFormosa.GeneralLucioVMansilla),
                datosEntidadBuilder.Build(2098, LocalidadFormosa.Herradura),
                datosEntidadBuilder.Build(2099, LocalidadFormosa.Tatane),
                datosEntidadBuilder.Build(2100, LocalidadFormosa.VillaEscolar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoFormosa.Matacos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2101, LocalidadFormosa.IngenieroJuarez)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoFormosa.Patino).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2102, LocalidadFormosa.ComandanteFontana),
                datosEntidadBuilder.Build(2103, LocalidadFormosa.BartolomeDeLasCasas),
                datosEntidadBuilder.Build(2104, LocalidadFormosa.ColoniaSarmiento),
                datosEntidadBuilder.Build(2105, LocalidadFormosa.ElRecreo),
                datosEntidadBuilder.Build(2106, LocalidadFormosa.EstanislaoDelCampo),
                datosEntidadBuilder.Build(2107, LocalidadFormosa.FortinLeyes),
                datosEntidadBuilder.Build(2108, LocalidadFormosa.FortinLugones),
                datosEntidadBuilder.Build(2109, LocalidadFormosa.GeneralManuelBelgrano),
                datosEntidadBuilder.Build(2110, LocalidadFormosa.Ibarreta),
                datosEntidadBuilder.Build(2111, LocalidadFormosa.JuanGBazan),
                datosEntidadBuilder.Build(2112, LocalidadFormosa.LasLomitas),
                datosEntidadBuilder.Build(2113, LocalidadFormosa.PostaCambioZalazar),
                datosEntidadBuilder.Build(2114, LocalidadFormosa.PozoDelTigre),
                datosEntidadBuilder.Build(2115, LocalidadFormosa.SanMartin1),
                datosEntidadBuilder.Build(2116, LocalidadFormosa.SanMartin2),
                datosEntidadBuilder.Build(2117, LocalidadFormosa.SubtenientePerin),
                datosEntidadBuilder.Build(2118, LocalidadFormosa.VillaGeneralGuemes)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoFormosa.Pilagas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2119, LocalidadFormosa.ElEspinillo),
                datosEntidadBuilder.Build(2120, LocalidadFormosa.BuenaVista),
                datosEntidadBuilder.Build(2121, LocalidadFormosa.MisionTacaagle),
                datosEntidadBuilder.Build(2122, LocalidadFormosa.PortonNegro),
                datosEntidadBuilder.Build(2123, LocalidadFormosa.TresLagunas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoFormosa.Pilcomayo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2124, LocalidadFormosa.Clorinda),
                datosEntidadBuilder.Build(2125, LocalidadFormosa.LagunaBlanca),
                datosEntidadBuilder.Build(2126, LocalidadFormosa.LagunaNaickNeck),
                datosEntidadBuilder.Build(2127, LocalidadFormosa.PalmaSola),
                datosEntidadBuilder.Build(2128, LocalidadFormosa.PuertoPilcomayo),
                datosEntidadBuilder.Build(2129, LocalidadFormosa.RiachoHeHe),
                datosEntidadBuilder.Build(2130, LocalidadFormosa.RiachoNegro),
                datosEntidadBuilder.Build(2131, LocalidadFormosa.SietePalmas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoFormosa.Pirane).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2132, LocalidadFormosa.Pirane),
                datosEntidadBuilder.Build(2133, LocalidadFormosa.ElColorado),
                datosEntidadBuilder.Build(2134, LocalidadFormosa.MayorVicenteVillafane),
                datosEntidadBuilder.Build(2135, LocalidadFormosa.PaloSanto),
                datosEntidadBuilder.Build(2136, LocalidadFormosa.VillaDosTrece)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoFormosa.RamonLista).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2137, LocalidadFormosa.GeneralMosconi),
                datosEntidadBuilder.Build(2138, LocalidadFormosa.ElPotrillo)
            });
        }
    }
}
