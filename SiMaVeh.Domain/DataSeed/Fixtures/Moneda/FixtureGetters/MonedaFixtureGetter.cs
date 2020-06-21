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
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DirhamDeLosEmiratosArabesUnidos, Constants.Monedas.CodigoISOMoneda.AED));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Afgani, Constants.Monedas.CodigoISOMoneda.AFN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lek, Constants.Monedas.CodigoISOMoneda.ALL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DramArmenio, Constants.Monedas.CodigoISOMoneda.AMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FlorinAntillanoNeerlandes, Constants.Monedas.CodigoISOMoneda.ANG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kwanza, Constants.Monedas.CodigoISOMoneda.AOA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoArgentino, Constants.Monedas.CodigoISOMoneda.ARS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarAustraliano, Constants.Monedas.CodigoISOMoneda.AUD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FlorinArubeno, Constants.Monedas.CodigoISOMoneda.AWG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ManatAzerbaiyano, Constants.Monedas.CodigoISOMoneda.AZN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.MarcoConvertible, Constants.Monedas.CodigoISOMoneda.BAM));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeBarbados, Constants.Monedas.CodigoISOMoneda.BBD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Taka, Constants.Monedas.CodigoISOMoneda.BDT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LevBulgaro, Constants.Monedas.CodigoISOMoneda.BGN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarBareini, Constants.Monedas.CodigoISOMoneda.BHD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoDeBurundi, Constants.Monedas.CodigoISOMoneda.BIF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarBermudeno, Constants.Monedas.CodigoISOMoneda.BMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeBrunei, Constants.Monedas.CodigoISOMoneda.BND));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Boliviano, Constants.Monedas.CodigoISOMoneda.BOB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.MVDOL, Constants.Monedas.CodigoISOMoneda.BOV));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RealBrasileno, Constants.Monedas.CodigoISOMoneda.BRL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarBahameno, Constants.Monedas.CodigoISOMoneda.BSD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Ngultrum, Constants.Monedas.CodigoISOMoneda.BTN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Pula, Constants.Monedas.CodigoISOMoneda.BWP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RubloBielorruso, Constants.Monedas.CodigoISOMoneda.BYN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarBeliceno, Constants.Monedas.CodigoISOMoneda.BZD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarCanadiense, Constants.Monedas.CodigoISOMoneda.CAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCongoleno, Constants.Monedas.CodigoISOMoneda.CDF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.EuroWIR, Constants.Monedas.CodigoISOMoneda.CHE));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoSuizo, Constants.Monedas.CodigoISOMoneda.CHF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoWIR, Constants.Monedas.CodigoISOMoneda.CHW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadDeFomento, Constants.Monedas.CodigoISOMoneda.CLF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoChileno, Constants.Monedas.CodigoISOMoneda.CLP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.YuanChino, Constants.Monedas.CodigoISOMoneda.CNY));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoColombiano, Constants.Monedas.CodigoISOMoneda.COP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadDeValorReal, Constants.Monedas.CodigoISOMoneda.COU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ColonCostarricense, Constants.Monedas.CodigoISOMoneda.CRC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoConvertible, Constants.Monedas.CodigoISOMoneda.CUC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoCubano, Constants.Monedas.CodigoISOMoneda.CUP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.EscudoCaboverdiano, Constants.Monedas.CodigoISOMoneda.CVE));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaCheca, Constants.Monedas.CodigoISOMoneda.CZK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoYibutiano, Constants.Monedas.CodigoISOMoneda.DJF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaDanesa, Constants.Monedas.CodigoISOMoneda.DKK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoDominicano, Constants.Monedas.CodigoISOMoneda.DOP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarArgelino, Constants.Monedas.CodigoISOMoneda.DZD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraEgipcia, Constants.Monedas.CodigoISOMoneda.EGP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Nakfa, Constants.Monedas.CodigoISOMoneda.ERN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.BirrEtiope, Constants.Monedas.CodigoISOMoneda.ETB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.CodigoISOMoneda.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarFiyiano, Constants.Monedas.CodigoISOMoneda.FJD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraMalvinense, Constants.Monedas.CodigoISOMoneda.FKP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraEsterlina, Constants.Monedas.CodigoISOMoneda.GBP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lari, Constants.Monedas.CodigoISOMoneda.GEL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CediGhanes, Constants.Monedas.CodigoISOMoneda.GHS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraDeGibraltar, Constants.Monedas.CodigoISOMoneda.GIP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Dalasi, Constants.Monedas.CodigoISOMoneda.GMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoGuineano, Constants.Monedas.CodigoISOMoneda.GNF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Quetzal, Constants.Monedas.CodigoISOMoneda.GTQ));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarGuyanes, Constants.Monedas.CodigoISOMoneda.GYD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeHongKong, Constants.Monedas.CodigoISOMoneda.HKD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lempira, Constants.Monedas.CodigoISOMoneda.HNL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kuna, Constants.Monedas.CodigoISOMoneda.HRK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Gourde, Constants.Monedas.CodigoISOMoneda.HTG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Forinto, Constants.Monedas.CodigoISOMoneda.HUF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaIndonesia, Constants.Monedas.CodigoISOMoneda.IDR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.NuevoShequelIsraeli, Constants.Monedas.CodigoISOMoneda.ILS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaIndia, Constants.Monedas.CodigoISOMoneda.INR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarIraqui, Constants.Monedas.CodigoISOMoneda.IQD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialIrani, Constants.Monedas.CodigoISOMoneda.IRR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaIslandesa, Constants.Monedas.CodigoISOMoneda.ISK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarJamaiquino, Constants.Monedas.CodigoISOMoneda.JMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarJordano, Constants.Monedas.CodigoISOMoneda.JOD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Yen, Constants.Monedas.CodigoISOMoneda.JPY));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinKeniano, Constants.Monedas.CodigoISOMoneda.KES));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Som, Constants.Monedas.CodigoISOMoneda.KGS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Riel, Constants.Monedas.CodigoISOMoneda.KHR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoComorense, Constants.Monedas.CodigoISOMoneda.KMF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.WonNorcoreano, Constants.Monedas.CodigoISOMoneda.KPW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Won, Constants.Monedas.CodigoISOMoneda.KRW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarKuwaiti, Constants.Monedas.CodigoISOMoneda.KWD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeLasIslasCaiman, Constants.Monedas.CodigoISOMoneda.KYD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Tenge, Constants.Monedas.CodigoISOMoneda.KZT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kip, Constants.Monedas.CodigoISOMoneda.LAK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraLibanesa, Constants.Monedas.CodigoISOMoneda.LBP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaDeSriLanka, Constants.Monedas.CodigoISOMoneda.LKR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarLiberiano, Constants.Monedas.CodigoISOMoneda.LRD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Loti, Constants.Monedas.CodigoISOMoneda.LSL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarLibio, Constants.Monedas.CodigoISOMoneda.LYD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DirhamMarroqui, Constants.Monedas.CodigoISOMoneda.MAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LeuMoldavo, Constants.Monedas.CodigoISOMoneda.MDL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.AriaryMalgache, Constants.Monedas.CodigoISOMoneda.MGA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Denar, Constants.Monedas.CodigoISOMoneda.MKD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kyat, Constants.Monedas.CodigoISOMoneda.MMK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Tugrik, Constants.Monedas.CodigoISOMoneda.MNT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Pataca, Constants.Monedas.CodigoISOMoneda.MOP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Uguiya, Constants.Monedas.CodigoISOMoneda.MRU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaDeMauricio, Constants.Monedas.CodigoISOMoneda.MUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Rufiyaa, Constants.Monedas.CodigoISOMoneda.MVR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kwacha, Constants.Monedas.CodigoISOMoneda.MWK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoMexicano, Constants.Monedas.CodigoISOMoneda.MXN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadDeInversionMexicana, Constants.Monedas.CodigoISOMoneda.MXV));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RinggitMalayo, Constants.Monedas.CodigoISOMoneda.MYR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.MeticalMozambiqueno, Constants.Monedas.CodigoISOMoneda.MZN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarNamibio, Constants.Monedas.CodigoISOMoneda.NAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Naira, Constants.Monedas.CodigoISOMoneda.NGN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Cordoba, Constants.Monedas.CodigoISOMoneda.NIO));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaNoruega, Constants.Monedas.CodigoISOMoneda.NOK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaNepali, Constants.Monedas.CodigoISOMoneda.NPR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarNeozelandes, Constants.Monedas.CodigoISOMoneda.NZD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialOmani, Constants.Monedas.CodigoISOMoneda.OMR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Balboa, Constants.Monedas.CodigoISOMoneda.PAB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Sol, Constants.Monedas.CodigoISOMoneda.PEN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kina, Constants.Monedas.CodigoISOMoneda.PGK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoFilipino, Constants.Monedas.CodigoISOMoneda.PHP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaPakistani, Constants.Monedas.CodigoISOMoneda.PKR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Złoty, Constants.Monedas.CodigoISOMoneda.PLN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Guarani, Constants.Monedas.CodigoISOMoneda.PYG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialCatari, Constants.Monedas.CodigoISOMoneda.QAR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LeuRumano, Constants.Monedas.CodigoISOMoneda.RON));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarSerbio, Constants.Monedas.CodigoISOMoneda.RSD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RubloRuso, Constants.Monedas.CodigoISOMoneda.RUB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoRuandes, Constants.Monedas.CodigoISOMoneda.RWF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialSaudi, Constants.Monedas.CodigoISOMoneda.SAR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeLasIslasSalomon, Constants.Monedas.CodigoISOMoneda.SBD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaSeychelense, Constants.Monedas.CodigoISOMoneda.SCR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraSudanesa, Constants.Monedas.CodigoISOMoneda.SDG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaSueca, Constants.Monedas.CodigoISOMoneda.SEK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeSingapur, Constants.Monedas.CodigoISOMoneda.SGD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraDeSantaElena, Constants.Monedas.CodigoISOMoneda.SHP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Leone, Constants.Monedas.CodigoISOMoneda.SLL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinSomali, Constants.Monedas.CodigoISOMoneda.SOS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarSurinames, Constants.Monedas.CodigoISOMoneda.SRD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraSursudanesa, Constants.Monedas.CodigoISOMoneda.SSP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Dobra, Constants.Monedas.CodigoISOMoneda.STN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ColonSalvadoreno, Constants.Monedas.CodigoISOMoneda.SVC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraSiria, Constants.Monedas.CodigoISOMoneda.SYP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lilangeni, Constants.Monedas.CodigoISOMoneda.SZL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Baht, Constants.Monedas.CodigoISOMoneda.THB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.SomoniTayiko, Constants.Monedas.CodigoISOMoneda.TJS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ManatTurcomano, Constants.Monedas.CodigoISOMoneda.TMT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarTunecino, Constants.Monedas.CodigoISOMoneda.TND));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Paʻanga, Constants.Monedas.CodigoISOMoneda.TOP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LiraTurca, Constants.Monedas.CodigoISOMoneda.TRY));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeTrinidadYTobago, Constants.Monedas.CodigoISOMoneda.TTD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.NuevoDolarTaiwanes, Constants.Monedas.CodigoISOMoneda.TWD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinTanzano, Constants.Monedas.CodigoISOMoneda.TZS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Grivna, Constants.Monedas.CodigoISOMoneda.UAH));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinUgandes, Constants.Monedas.CodigoISOMoneda.UGX));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarEstadounidense, Constants.Monedas.CodigoISOMoneda.USD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarEstadounidenseSiguienteDia, Constants.Monedas.CodigoISOMoneda.USN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoEnUnidadesIndexadasUruguay, Constants.Monedas.CodigoISOMoneda.UYI));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoUruguayo, Constants.Monedas.CodigoISOMoneda.UYU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadPrevisional, Constants.Monedas.CodigoISOMoneda.UYW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.SomUzbeko, Constants.Monedas.CodigoISOMoneda.UZS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.BolivarSoberano, Constants.Monedas.CodigoISOMoneda.VES7​));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DongVietnamita, Constants.Monedas.CodigoISOMoneda.VND));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Vatu, Constants.Monedas.CodigoISOMoneda.VUV));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Tala, Constants.Monedas.CodigoISOMoneda.WST));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFADeAfricaCentral, Constants.Monedas.CodigoISOMoneda.XAF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PlataUnaOnzaTroy, Constants.Monedas.CodigoISOMoneda.XAG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.OroUnaOnzaTroy, Constants.Monedas.CodigoISOMoneda.XAU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadCompuestaEuropeaEURCO, Constants.Monedas.CodigoISOMoneda.XBA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadMonetariaEuropeaEMU6, Constants.Monedas.CodigoISOMoneda.XBB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadEuropeaDeCuenta9EUA9, Constants.Monedas.CodigoISOMoneda.XBC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadEuropeaDeCuenta17EUA17, Constants.Monedas.CodigoISOMoneda.XBD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDelCaribeOriental, Constants.Monedas.CodigoISOMoneda.XCD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DerechosEspecialesDeGiro, Constants.Monedas.CodigoISOMoneda.XDR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFADeAfricaOccidental, Constants.Monedas.CodigoISOMoneda.XOF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PaladioUnaOnzaTroy, Constants.Monedas.CodigoISOMoneda.XPD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFP, Constants.Monedas.CodigoISOMoneda.XPF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PlatinoUnaOnzaTroy, Constants.Monedas.CodigoISOMoneda.XPT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.SUCRE, Constants.Monedas.CodigoISOMoneda.XSU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ReservadoParaPruebas, Constants.Monedas.CodigoISOMoneda.XTS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadDeCuentaBAD, Constants.Monedas.CodigoISOMoneda.XUA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.SinDivisa, Constants.Monedas.CodigoISOMoneda.XXX));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialYemeni, Constants.Monedas.CodigoISOMoneda.YER));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Rand, Constants.Monedas.CodigoISOMoneda.ZAR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.KwachaZambiano, Constants.Monedas.CodigoISOMoneda.ZMW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarZimbabuense, Constants.Monedas.CodigoISOMoneda.ZWL));
        }
    }
}
