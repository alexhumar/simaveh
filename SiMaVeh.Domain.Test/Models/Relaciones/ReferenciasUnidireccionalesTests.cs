using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Test.Models.Relaciones
{
    /// <summary>
    /// Referencias unidireccionales (IEntityChanger sin contraparte): Cambiar asigna la referencia
    /// y un null se ignora (conserva la referencia actual).
    /// </summary>
    public class ReferenciasUnidireccionalesTests
    {
        public record Caso(Func<object> CrearDestino, Func<int, object> CrearReferencia, Func<object, object, object> Cambiar, Func<object, object> Leer);

        private static Caso C<TDestino, TRef>(Func<TDestino> destino, Func<int, TRef> referencia, Func<TDestino, TRef, object> cambiar, Func<TDestino, TRef> leer)
            => new(() => destino(), i => referencia(i), (d, r) => cambiar((TDestino)d, (TRef)r), d => leer((TDestino)d));

        private static readonly Dictionary<string, Caso> casos = new()
        {
            ["Direccion.Localidad"] = C(() => Crear.Direccion(), i => Crear.Localidad(i), (d, r) => d.Cambiar(r), d => d.Localidad),
            ["EntidadReparadora.TipoEntidadReparadora"] = C(() => Crear.EntidadReparadora(), i => Crear.TipoEntidadReparadora(i), (d, r) => d.Cambiar(r), d => d.TipoEntidadReparadora),
            ["EntidadReparadora.Direccion"] = C(() => Crear.EntidadReparadora(), i => Crear.Direccion(i), (d, r) => d.Cambiar(r), d => d.Direccion),
            ["FuenteEnergia.Marca"] = C(() => Crear.FuenteEnergia(), i => Crear.Marca(i), (d, r) => d.Cambiar(r), d => d.Marca),
            ["FuenteEnergia.TipoFuenteEnergia"] = C(() => Crear.FuenteEnergia(), i => Crear.TipoFuenteEnergia(i), (d, r) => d.Cambiar(r), d => d.TipoFuenteEnergia),
            ["GrupoModelo.Marca"] = C(() => Crear.GrupoModelo(), i => Crear.Marca(i), (d, r) => d.Cambiar(r), d => d.Marca),
            ["Mantenimiento.Recambio"] = C(() => Crear.Mantenimiento(), i => (Recambio)Crear.Repuesto(i), (d, r) => d.Cambiar(r), d => d.Recambio),
            ["Mantenimiento.MonedaMontoRecambio"] = C(() => Crear.Mantenimiento(), i => Crear.Moneda($"M{i}"), (d, r) => d.Cambiar(r), d => d.MonedaMontoRecambio),
            ["Mantenimiento.Reparador"] = C(() => Crear.Mantenimiento(), i => Crear.Reparador(i), (d, r) => d.Cambiar(r), d => d.Reparador),
            ["ModeloVehiculo.GrupoModelo"] = C(() => Crear.ModeloVehiculo(), i => Crear.GrupoModelo(i), (d, r) => d.Cambiar(r), d => d.GrupoModelo),
            ["ModeloVehiculo.Airbags"] = C(() => Crear.ModeloVehiculo(), i => new EquipamientoAirbags { Conductor = i % 2 == 0 }, (d, r) => d.Cambiar(r), d => d.Airbags),
            ["ModeloVehiculo.TipoFuenteEnergia"] = C(() => Crear.ModeloVehiculo(), i => Crear.TipoFuenteEnergia(i), (d, r) => d.Cambiar(r), d => d.TipoFuenteEnergia),
            ["Neumatico.Marca"] = C(() => Crear.Neumatico(), i => Crear.Marca(i), (d, r) => d.Cambiar(r), d => d.Marca),
            ["PeriodicidadMantenimiento.ModeloVehiculo"] = C(() => Crear.PeriodicidadMantenimiento(), i => Crear.ModeloVehiculo(i), (d, r) => d.Cambiar(r), d => d.ModeloVehiculo),
            ["Persona.TipoDocumento"] = C(() => Crear.Usuario(), i => Crear.TipoDocumento(i), (d, r) => d.Cambiar(r), d => d.TipoDocumento),
            ["Pieza.UbicacionPieza"] = C(() => Crear.Pieza(), i => Crear.UbicacionPieza(izquierda: i % 2 == 0), (d, r) => d.Cambiar(r), d => d.UbicacionPieza),
            ["PresionNeumatico.Neumatico"] = C(() => Crear.PresionNeumatico(), i => Crear.Neumatico(i), (d, r) => d.Cambiar(r), d => d.Neumatico),
            ["Recambio.Marca (Kit)"] = C(() => Crear.Kit(), i => Crear.Marca(i), (d, r) => d.Cambiar(r), d => d.Marca),
            ["Recambio.Marca (Repuesto)"] = C(() => Crear.Repuesto(), i => Crear.Marca(i), (d, r) => d.Cambiar(r), d => d.Marca),
            ["Repuesto.TargetMantenimiento"] = C(() => Crear.Repuesto(), i => (TargetMantenimiento)Crear.Pieza(i), (d, r) => d.Cambiar(r), d => d.TargetMantenimiento),
            ["ServicioReparador.MonedaMontoManoObra"] = C(() => Crear.ServicioReparador(), i => Crear.Moneda($"M{i}"), (d, r) => d.Cambiar(r), d => d.MonedaMontoManoObra),
            ["Telefono.TipoTelefono"] = C(() => Crear.Telefono(), i => Crear.TipoTelefono(i), (d, r) => d.Cambiar(r), d => d.TipoTelefono),
            ["TipoCambio.MonedaOrigen"] = C(() => Crear.TipoCambio(), i => Crear.Moneda($"M{i}"), (d, r) => d.CambiarMonedaOrigen(r), d => d.MonedaOrigen),
            ["TipoCambio.MonedaDestino"] = C(() => Crear.TipoCambio(), i => Crear.Moneda($"M{i}"), (d, r) => d.CambiarMonedaDestino(r), d => d.MonedaDestino),
        };

        public static TheoryData<string> Casos => new(casos.Keys.OrderBy(k => k));

        [Theory]
        [MemberData(nameof(Casos))]
        public void Cambiar_Referencia_LaAsignaYDevuelveElDestino(string caso)
        {
            var c = casos[caso];
            var destino = c.CrearDestino();
            var referencia = c.CrearReferencia(1);

            var resultado = c.Cambiar(destino, referencia);

            Assert.Same(destino, resultado);
            Assert.Same(referencia, c.Leer(destino));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Cambiar_OtraReferencia_ReemplazaLaAnterior(string caso)
        {
            var c = casos[caso];
            var destino = c.CrearDestino();
            c.Cambiar(destino, c.CrearReferencia(1));
            var nueva = c.CrearReferencia(2);

            c.Cambiar(destino, nueva);

            Assert.Same(nueva, c.Leer(destino));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Cambiar_Null_ConservaLaReferenciaActual(string caso)
        {
            var c = casos[caso];
            var destino = c.CrearDestino();
            var referencia = c.CrearReferencia(1);
            c.Cambiar(destino, referencia);

            var resultado = c.Cambiar(destino, null);

            Assert.Same(destino, resultado);
            Assert.Same(referencia, c.Leer(destino));
        }

        [Fact]
        public void TipoCambio_CambiarMonedas_SonIndependientes()
        {
            var tipoCambio = Crear.TipoCambio();
            var dolar = Crear.Moneda("USD");
            var peso = Crear.Moneda("ARS");

            tipoCambio.CambiarMonedaOrigen(dolar).CambiarMonedaDestino(peso);

            Assert.Same(dolar, tipoCambio.MonedaOrigen);
            Assert.Same(peso, tipoCambio.MonedaDestino);
        }

        [Fact]
        public void Vehiculo_CambiarModeloVehiculo_SinModeloPrevio_LoAsigna()
        {
            var automovil = new Automovil { Id = 1, Patente = "AA000BB" };
            var modelo = Crear.ModeloVehiculo();

            automovil.Cambiar(modelo);

            Assert.Same(modelo, automovil.ModeloVehiculo);
        }

        [Fact]
        public void Vehiculo_CambiarModeloVehiculoANull_ConservaElModelo()
        {
            var modelo = Crear.ModeloVehiculo();
            var automovil = new Automovil { Id = 1, Patente = "AA000BB" }.Cambiar(modelo);

            automovil.Cambiar((ModeloVehiculo)null);

            Assert.Same(modelo, automovil.ModeloVehiculo);
        }

        [Fact]
        public void Vehiculo_CambiarModeloVehiculo_ConModeloPrevio_LoReemplaza()
        {
            var automovil = new Automovil { Id = 1, Patente = "AA000BB", ModeloVehiculo = Crear.ModeloVehiculo(1) };
            var nuevo = Crear.ModeloVehiculo(2);

            var resultado = automovil.Cambiar(nuevo);

            Assert.Same(automovil, resultado);
            Assert.Same(nuevo, automovil.ModeloVehiculo);
        }
    }
}
