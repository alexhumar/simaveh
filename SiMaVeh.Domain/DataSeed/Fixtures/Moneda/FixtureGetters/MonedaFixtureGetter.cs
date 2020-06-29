using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Moneda.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Moneda.FixtureGetters
{
    /// <summary>
    /// Fixture getter de moneda
    /// </summary>
    internal class MonedaFixtureGetter : IMonedaFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosMoneda> monedas;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public MonedaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            monedas = new List<DatosMoneda>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosMoneda> Get()
        {
            return monedas;
        }

        private void Initialize()
        {
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.AED, Constants.Monedas.Moneda.DirhamDeLosEmiratosArabesUnidos));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.AFN, Constants.Monedas.Moneda.Afgani));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ALL, Constants.Monedas.Moneda.Lek));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.AMD, Constants.Monedas.Moneda.DramArmenio));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ANG, Constants.Monedas.Moneda.FlorinAntillanoNeerlandes));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.AOA, Constants.Monedas.Moneda.Kwanza));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ARS, Constants.Monedas.Moneda.PesoArgentino));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.AUD, Constants.Monedas.Moneda.DolarAustraliano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.AWG, Constants.Monedas.Moneda.FlorinArubeno));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.AZN, Constants.Monedas.Moneda.ManatAzerbaiyano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BAM, Constants.Monedas.Moneda.MarcoConvertible));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BBD, Constants.Monedas.Moneda.DolarDeBarbados));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BDT, Constants.Monedas.Moneda.Taka));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BGN, Constants.Monedas.Moneda.LevBulgaro));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BHD, Constants.Monedas.Moneda.DinarBareini));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BIF, Constants.Monedas.Moneda.FrancoDeBurundi));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BMD, Constants.Monedas.Moneda.DolarBermudeno));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BND, Constants.Monedas.Moneda.DolarDeBrunei));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BOB, Constants.Monedas.Moneda.Boliviano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BOV, Constants.Monedas.Moneda.MVDOL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BRL, Constants.Monedas.Moneda.RealBrasileno));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BSD, Constants.Monedas.Moneda.DolarBahameno));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BTN, Constants.Monedas.Moneda.Ngultrum));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BWP, Constants.Monedas.Moneda.Pula));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BYN, Constants.Monedas.Moneda.RubloBielorruso));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.BZD, Constants.Monedas.Moneda.DolarBeliceno));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CAD, Constants.Monedas.Moneda.DolarCanadiense));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CDF, Constants.Monedas.Moneda.FrancoCongoleno));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CHE, Constants.Monedas.Moneda.EuroWIR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CHF, Constants.Monedas.Moneda.FrancoSuizo));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CHW, Constants.Monedas.Moneda.FrancoWIR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CLF, Constants.Monedas.Moneda.UnidadDeFomento));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CLP, Constants.Monedas.Moneda.PesoChileno));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CNY, Constants.Monedas.Moneda.YuanChino));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.COP, Constants.Monedas.Moneda.PesoColombiano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.COU, Constants.Monedas.Moneda.UnidadDeValorReal));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CRC, Constants.Monedas.Moneda.ColonCostarricense));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CUC, Constants.Monedas.Moneda.PesoConvertible));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CUP, Constants.Monedas.Moneda.PesoCubano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CVE, Constants.Monedas.Moneda.EscudoCaboverdiano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.CZK, Constants.Monedas.Moneda.CoronaCheca));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.DJF, Constants.Monedas.Moneda.FrancoYibutiano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.DKK, Constants.Monedas.Moneda.CoronaDanesa));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.DOP, Constants.Monedas.Moneda.PesoDominicano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.DZD, Constants.Monedas.Moneda.DinarArgelino));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.EGP, Constants.Monedas.Moneda.LibraEgipcia));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ERN, Constants.Monedas.Moneda.Nakfa));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ETB, Constants.Monedas.Moneda.BirrEtiope));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.EUR, Constants.Monedas.Moneda.Euro));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.FJD, Constants.Monedas.Moneda.DolarFiyiano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.FKP, Constants.Monedas.Moneda.LibraMalvinense));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.GBP, Constants.Monedas.Moneda.LibraEsterlina));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.GEL, Constants.Monedas.Moneda.Lari));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.GHS, Constants.Monedas.Moneda.CediGhanes));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.GIP, Constants.Monedas.Moneda.LibraDeGibraltar));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.GMD, Constants.Monedas.Moneda.Dalasi));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.GNF, Constants.Monedas.Moneda.FrancoGuineano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.GTQ, Constants.Monedas.Moneda.Quetzal));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.GYD, Constants.Monedas.Moneda.DolarGuyanes));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.HKD, Constants.Monedas.Moneda.DolarDeHongKong));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.HNL, Constants.Monedas.Moneda.Lempira));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.HRK, Constants.Monedas.Moneda.Kuna));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.HTG, Constants.Monedas.Moneda.Gourde));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.HUF, Constants.Monedas.Moneda.Forinto));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.IDR, Constants.Monedas.Moneda.RupiaIndonesia));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ILS, Constants.Monedas.Moneda.NuevoShequelIsraeli));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.INR, Constants.Monedas.Moneda.RupiaIndia));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.IQD, Constants.Monedas.Moneda.DinarIraqui));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.IRR, Constants.Monedas.Moneda.RialIrani));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ISK, Constants.Monedas.Moneda.CoronaIslandesa));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.JMD, Constants.Monedas.Moneda.DolarJamaiquino));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.JOD, Constants.Monedas.Moneda.DinarJordano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.JPY, Constants.Monedas.Moneda.Yen));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.KES, Constants.Monedas.Moneda.ChelinKeniano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.KGS, Constants.Monedas.Moneda.Som));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.KHR, Constants.Monedas.Moneda.Riel));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.KMF, Constants.Monedas.Moneda.FrancoComorense));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.KPW, Constants.Monedas.Moneda.WonNorcoreano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.KRW, Constants.Monedas.Moneda.Won));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.KWD, Constants.Monedas.Moneda.DinarKuwaiti));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.KYD, Constants.Monedas.Moneda.DolarDeLasIslasCaiman));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.KZT, Constants.Monedas.Moneda.Tenge));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.LAK, Constants.Monedas.Moneda.Kip));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.LBP, Constants.Monedas.Moneda.LibraLibanesa));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.LKR, Constants.Monedas.Moneda.RupiaDeSriLanka));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.LRD, Constants.Monedas.Moneda.DolarLiberiano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.LSL, Constants.Monedas.Moneda.Loti));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.LYD, Constants.Monedas.Moneda.DinarLibio));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MAD, Constants.Monedas.Moneda.DirhamMarroqui));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MDL, Constants.Monedas.Moneda.LeuMoldavo));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MGA, Constants.Monedas.Moneda.AriaryMalgache));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MKD, Constants.Monedas.Moneda.Denar));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MMK, Constants.Monedas.Moneda.Kyat));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MNT, Constants.Monedas.Moneda.Tugrik));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MOP, Constants.Monedas.Moneda.Pataca));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MRU, Constants.Monedas.Moneda.Uguiya));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MUR, Constants.Monedas.Moneda.RupiaDeMauricio));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MVR, Constants.Monedas.Moneda.Rufiyaa));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MWK, Constants.Monedas.Moneda.Kwacha));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MXN, Constants.Monedas.Moneda.PesoMexicano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MXV, Constants.Monedas.Moneda.UnidadDeInversionMexicana));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MYR, Constants.Monedas.Moneda.RinggitMalayo));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.MZN, Constants.Monedas.Moneda.MeticalMozambiqueno));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.NAD, Constants.Monedas.Moneda.DolarNamibio));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.NGN, Constants.Monedas.Moneda.Naira));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.NIO, Constants.Monedas.Moneda.Cordoba));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.NOK, Constants.Monedas.Moneda.CoronaNoruega));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.NPR, Constants.Monedas.Moneda.RupiaNepali));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.NZD, Constants.Monedas.Moneda.DolarNeozelandes));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.OMR, Constants.Monedas.Moneda.RialOmani));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.PAB, Constants.Monedas.Moneda.Balboa));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.PEN, Constants.Monedas.Moneda.Sol));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.PGK, Constants.Monedas.Moneda.Kina));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.PHP, Constants.Monedas.Moneda.PesoFilipino));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.PKR, Constants.Monedas.Moneda.RupiaPakistani));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.PLN, Constants.Monedas.Moneda.Złoty));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.PYG, Constants.Monedas.Moneda.Guarani));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.QAR, Constants.Monedas.Moneda.RialCatari));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.RON, Constants.Monedas.Moneda.LeuRumano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.RSD, Constants.Monedas.Moneda.DinarSerbio));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.RUB, Constants.Monedas.Moneda.RubloRuso));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.RWF, Constants.Monedas.Moneda.FrancoRuandes));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SAR, Constants.Monedas.Moneda.RialSaudi));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SBD, Constants.Monedas.Moneda.DolarDeLasIslasSalomon));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SCR, Constants.Monedas.Moneda.RupiaSeychelense));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SDG, Constants.Monedas.Moneda.LibraSudanesa));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SEK, Constants.Monedas.Moneda.CoronaSueca));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SGD, Constants.Monedas.Moneda.DolarDeSingapur));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SHP, Constants.Monedas.Moneda.LibraDeSantaElena));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SLL, Constants.Monedas.Moneda.Leone));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SOS, Constants.Monedas.Moneda.ChelinSomali));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SRD, Constants.Monedas.Moneda.DolarSurinames));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SSP, Constants.Monedas.Moneda.LibraSursudanesa));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.STN, Constants.Monedas.Moneda.Dobra));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SVC, Constants.Monedas.Moneda.ColonSalvadoreno));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SYP, Constants.Monedas.Moneda.LibraSiria));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.SZL, Constants.Monedas.Moneda.Lilangeni));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.THB, Constants.Monedas.Moneda.Baht));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.TJS, Constants.Monedas.Moneda.SomoniTayiko));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.TMT, Constants.Monedas.Moneda.ManatTurcomano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.TND, Constants.Monedas.Moneda.DinarTunecino));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.TOP, Constants.Monedas.Moneda.Paʻanga));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.TRY, Constants.Monedas.Moneda.LiraTurca));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.TTD, Constants.Monedas.Moneda.DolarDeTrinidadYTobago));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.TWD, Constants.Monedas.Moneda.NuevoDolarTaiwanes));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.TZS, Constants.Monedas.Moneda.ChelinTanzano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.UAH, Constants.Monedas.Moneda.Grivna));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.UGX, Constants.Monedas.Moneda.ChelinUgandes));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.USD, Constants.Monedas.Moneda.DolarEstadounidense));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.USN, Constants.Monedas.Moneda.DolarEstadounidenseSiguienteDia));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.UYI, Constants.Monedas.Moneda.PesoEnUnidadesIndexadasUruguay));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.UYU, Constants.Monedas.Moneda.PesoUruguayo));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.UYW, Constants.Monedas.Moneda.UnidadPrevisional));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.UZS, Constants.Monedas.Moneda.SomUzbeko));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.VES7​, Constants.Monedas.Moneda.BolivarSoberano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.VND, Constants.Monedas.Moneda.DongVietnamita));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.VUV, Constants.Monedas.Moneda.Vatu));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.WST, Constants.Monedas.Moneda.Tala));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XAF, Constants.Monedas.Moneda.FrancoCFADeAfricaCentral));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XAG, Constants.Monedas.Moneda.PlataUnaOnzaTroy));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XAU, Constants.Monedas.Moneda.OroUnaOnzaTroy));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XBA, Constants.Monedas.Moneda.UnidadCompuestaEuropeaEURCO));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XBB, Constants.Monedas.Moneda.UnidadMonetariaEuropeaEMU6));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XBC, Constants.Monedas.Moneda.UnidadEuropeaDeCuenta9EUA9));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XBD, Constants.Monedas.Moneda.UnidadEuropeaDeCuenta17EUA17));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XCD, Constants.Monedas.Moneda.DolarDelCaribeOriental));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XDR, Constants.Monedas.Moneda.DerechosEspecialesDeGiro));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XOF, Constants.Monedas.Moneda.FrancoCFADeAfricaOccidental));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XPD, Constants.Monedas.Moneda.PaladioUnaOnzaTroy));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XPF, Constants.Monedas.Moneda.FrancoCFP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XPT, Constants.Monedas.Moneda.PlatinoUnaOnzaTroy));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XSU, Constants.Monedas.Moneda.SUCRE));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XTS, Constants.Monedas.Moneda.ReservadoParaPruebas));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XUA, Constants.Monedas.Moneda.UnidadDeCuentaBAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.XXX, Constants.Monedas.Moneda.SinDivisa));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.YER, Constants.Monedas.Moneda.RialYemeni));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ZAR, Constants.Monedas.Moneda.Rand));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ZMW, Constants.Monedas.Moneda.KwachaZambiano));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.ZWL, Constants.Monedas.Moneda.DolarZimbabuense));
        }
    }
}
