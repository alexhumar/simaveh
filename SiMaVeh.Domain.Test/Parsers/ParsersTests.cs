using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Enums.Parsers;
using SiMaVeh.Domain.Utils;

namespace SiMaVeh.Domain.Test.Parsers
{
    public class ParsersTests
    {
        [Theory]
        [InlineData(AccionMantenimiento.Reemplazo, "Reemplazo")]
        [InlineData(AccionMantenimiento.Reparacion, "Reparación")]
        [InlineData((AccionMantenimiento)99, "")]
        public void AccionMantenimientoParser_ToString(AccionMantenimiento valor, string esperado)
        {
            Assert.Equal(esperado, new AccionMantenimientoParser().ToString(valor));
        }

        [Theory]
        [InlineData(ConstruccionCarcasaNeumatico.CintasOpuestas, "B")]
        [InlineData(ConstruccionCarcasaNeumatico.Diagonal, "D")]
        [InlineData(ConstruccionCarcasaNeumatico.Radial, "R")]
        [InlineData((ConstruccionCarcasaNeumatico)99, "")]
        public void ConstruccionCarcasaNeumaticoParser_ToString(ConstruccionCarcasaNeumatico valor, string esperado)
        {
            Assert.Equal(esperado, new ConstruccionCarcasaNeumaticoParser().ToString(valor));
        }

        [Theory]
        [InlineData(TipoAirbagLateral.Ambos, "A")]
        [InlineData(TipoAirbagLateral.Cortina, "C")]
        [InlineData(TipoAirbagLateral.Lateral, "L")]
        [InlineData(TipoAirbagLateral.NoPosee, "N")]
        [InlineData((TipoAirbagLateral)99, "")]
        public void TipoAirbagLateralParser_ToString(TipoAirbagLateral valor, string esperado)
        {
            Assert.Equal(esperado, new TipoAirbagLateralParser().ToString(valor));
        }

        [Theory]
        [InlineData(TipoVehiculoNeumatico.Pasajero, "P")]
        [InlineData(TipoVehiculoNeumatico.CamionLigero, "LT")]
        [InlineData(TipoVehiculoNeumatico.TrailerEspecial, "ST")]
        [InlineData(TipoVehiculoNeumatico.UsoTemporal, "T")]
        [InlineData((TipoVehiculoNeumatico)99, "")]
        public void TipoVehiculoNeumaticoParser_ToString(TipoVehiculoNeumatico valor, string esperado)
        {
            Assert.Equal(esperado, new TipoVehiculoNeumaticoParser().ToString(valor));
        }

        [Fact]
        public void Parsers_CubrenTodosLosValoresDeSusEnums()
        {
            //Si se agrega un valor a un enum y no al parser, este test lo detecta.
            Assert.All(EnumUtils.GetValues<AccionMantenimiento>(), v => Assert.NotEmpty(new AccionMantenimientoParser().ToString(v)));
            Assert.All(EnumUtils.GetValues<ConstruccionCarcasaNeumatico>(), v => Assert.NotEmpty(new ConstruccionCarcasaNeumaticoParser().ToString(v)));
            Assert.All(EnumUtils.GetValues<TipoAirbagLateral>(), v => Assert.NotEmpty(new TipoAirbagLateralParser().ToString(v)));
            Assert.All(EnumUtils.GetValues<TipoVehiculoNeumatico>(), v => Assert.NotEmpty(new TipoVehiculoNeumaticoParser().ToString(v)));
        }
    }
}
