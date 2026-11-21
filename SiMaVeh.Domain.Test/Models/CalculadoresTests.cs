using SiMaVeh.Domain.DataSeed.Models;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Enums.Parsers;
using SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags;
using SiMaVeh.Domain.Models.Calculadores.UbicacionPieza;
using SiMaVeh.Domain.Utils;
using System.Linq;

namespace SiMaVeh.Domain.Test.Models
{
    public class CalculadoresTests
    {
        private readonly CalculadorIdEquipamientoAirbags calculadorAirbags = new(new TipoAirbagLateralParser());

        [Theory]
        [InlineData(true, true, "IS")]
        [InlineData(true, false, "II")]
        [InlineData(false, true, "DS")]
        [InlineData(false, false, "DI")]
        public void CalculadorIdUbicacionPieza_Calcular(bool izquierda, bool superior, string esperado)
        {
            var id = new CalculadorIdUbicacionPieza().Calcular(new DatosUbicacionPieza { Izquierda = izquierda, Superior = superior });

            Assert.Equal(esperado, id);
        }

        [Theory]
        [InlineData(true, true, TipoAirbagLateral.Ambos, TipoAirbagLateral.Ambos, TipoAirbagLateral.Ambos, TipoAirbagLateral.Ambos, "CAAAAA")]
        [InlineData(false, false, TipoAirbagLateral.NoPosee, TipoAirbagLateral.NoPosee, TipoAirbagLateral.NoPosee, TipoAirbagLateral.NoPosee, "NCNANNNN")]
        [InlineData(true, false, TipoAirbagLateral.Lateral, TipoAirbagLateral.Cortina, TipoAirbagLateral.NoPosee, TipoAirbagLateral.Ambos, "CNALCNA")]
        public void CalculadorIdEquipamientoAirbags_Calcular(bool conductor, bool acompanante, TipoAirbagLateral di, TipoAirbagLateral dd, TipoAirbagLateral ti, TipoAirbagLateral td, string esperado)
        {
            var datos = new DatosEquipamientoAirbags { Conductor = conductor, Acompanante = acompanante, DelanteroIzquierdo = di, DelanteroDerecho = dd, TraseroIzquierdo = ti, TraseroDerecho = td };

            Assert.Equal(esperado, calculadorAirbags.Calcular(datos));
        }

        [Fact]
        public void CalculadorIdEquipamientoAirbags_TodasLasCombinaciones_GeneranIdsUnicos()
        {
            var bools = new[] { true, false };
            var tipos = EnumUtils.GetValues<TipoAirbagLateral>().ToArray();

            var ids = (from c in bools
                       from a in bools
                       from di in tipos
                       from dd in tipos
                       from ti in tipos
                       from td in tipos
                       select calculadorAirbags.Calcular(new DatosEquipamientoAirbags { Conductor = c, Acompanante = a, DelanteroIzquierdo = di, DelanteroDerecho = dd, TraseroIzquierdo = ti, TraseroDerecho = td }))
                      .ToList();

            Assert.Equal(1024, ids.Count);
            Assert.Equal(ids.Count, ids.Distinct().Count());
        }
    }
}
