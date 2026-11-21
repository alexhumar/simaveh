using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Extensions;
using SiMaVeh.Domain.Utils;
using System;

namespace SiMaVeh.Domain.Test.Utils
{
    public class UtilidadesTests
    {
        [Fact]
        public void EnumUtils_GetValues_DevuelveTodosLosValoresEnOrden()
        {
            Assert.Equal(
                [TipoAirbagLateral.NoPosee, TipoAirbagLateral.Lateral, TipoAirbagLateral.Cortina, TipoAirbagLateral.Ambos],
                EnumUtils.GetValues<TipoAirbagLateral>());
        }

        [Fact]
        public void GetDetalle_SinInnerException_DevuelveElMensaje()
        {
            Assert.Equal("Error", new Exception("Error").GetDetalle());
        }

        [Fact]
        public void GetDetalle_ConInnerException_AgregaElDetalle()
        {
            var excepcion = new Exception("Error", new InvalidOperationException("Causa"));

            Assert.Equal("Error. Detalle: Causa", excepcion.GetDetalle());
        }

        [Fact]
        public void GetDetalle_ConInnerExceptionSinMensaje_DevuelveSoloElMensaje()
        {
            var excepcion = new Exception("Error", new InvalidOperationException(" "));

            Assert.Equal("Error", excepcion.GetDetalle());
        }
    }
}
