using FluentValidation;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Enums.Parsers.Interfaces;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.Models.Calculadores.UbicacionPieza.Interfaces;
using SiMaVeh.Domain.Test.Fixtures;
using System;
using System.Linq;

namespace SiMaVeh.Domain.Test
{
    /// <summary>
    /// El DomainRegistry descubre por escaneo validadores, parsers y servicios: si una clase nueva
    /// no queda registrada, estos tests lo detectan.
    /// </summary>
    public class DomainRegistryTests(ContenedorDominio contenedor) : IClassFixture<ContenedorDominio>
    {
        private readonly ContenedorDominio contenedor = contenedor;

        public static TheoryData<Type> EntidadesDelModelo => new(typeof(Pais).Assembly.GetTypes()
            .Where(t => t.Namespace == typeof(Pais).Namespace && t.IsClass && !t.IsNested && !t.IsGenericTypeDefinition && t.GetProperty(nameof(DomainMember<long>.Id)) != null)
            .OrderBy(t => t.Name));

        [Theory]
        [MemberData(nameof(EntidadesDelModelo))]
        public void TodaEntidadDelModelo_TieneUnValidadorRegistrado(Type entidad)
        {
            var validador = contenedor.Container.TryGetInstance(typeof(IValidator<>).MakeGenericType(entidad));

            Assert.NotNull(validador);
        }

        [Fact]
        public void ResuelveLosParsersDeTodosLosEnums()
        {
            Assert.NotNull(contenedor.Get<IEnumParser<AccionMantenimiento>>());
            Assert.NotNull(contenedor.Get<IEnumParser<ConstruccionCarcasaNeumatico>>());
            Assert.NotNull(contenedor.Get<IEnumParser<TipoAirbagLateral>>());
            Assert.NotNull(contenedor.Get<IEnumParser<TipoVehiculoNeumatico>>());
        }

        [Fact]
        public void ResuelveLosServiciosDelDominio()
        {
            Assert.NotNull(contenedor.Get<IEntityTypeGetter>());
            Assert.NotNull(contenedor.Get<ICalculadorIdUbicacionPieza>());
            Assert.NotNull(contenedor.Get<ICalculadorIdEquipamientoAirbags>());
            Assert.NotNull(contenedor.Get<IDatosEntidadBuilder>());
        }
    }
}
