using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Test.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Test.Models.Relaciones
{
    /// <summary>
    /// Colecciones unidireccionales (ICollectionManager que no actualiza la contraparte):
    /// Agregar/Quitar modifican solo la coleccion del duenio e ignoran los null.
    /// </summary>
    public class ColeccionesUnidireccionalesTests
    {
        public record Caso(Func<object> CrearDuenio, Func<long, object> CrearElemento, Func<object, object, object> Agregar, Func<object, object, object> Quitar, Func<object, IEnumerable> Coleccion);

        private static Caso C<TDuenio, TElemento>(Func<TDuenio> duenio, Func<long, TElemento> elemento, Func<TDuenio, TElemento, object> agregar, Func<TDuenio, TElemento, object> quitar, Func<TDuenio, IEnumerable<TElemento>> coleccion)
            => new(() => duenio(), i => elemento(i), (d, e) => agregar((TDuenio)d, (TElemento)e), (d, e) => quitar((TDuenio)d, (TElemento)e), d => coleccion((TDuenio)d));

        private static readonly Dictionary<string, Caso> casos = new()
        {
            ["Aceite.RecomendacionesModeloVehiculo"] = C(() => Crear.Aceite(), Crear.ModeloVehiculo, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.RecomendacionesModeloVehiculo),
            ["CategoriaMarca.Marcas"] = C(() => Crear.CategoriaMarca(), Crear.Marca, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.Marcas),
            ["EntidadReparadora.Reparadores"] = C(() => Crear.EntidadReparadora(), Crear.Reparador, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.Reparadores),
            ["FuenteEnergia.RecomendacionesModeloVehiculo"] = C(() => Crear.FuenteEnergia(), Crear.ModeloVehiculo, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.RecomendacionesModeloVehiculo),
            ["Kit.Repuestos"] = C(() => Crear.Kit(), Crear.Repuesto, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.Repuestos),
            ["Marca.Categorias"] = C(() => Crear.Marca(), Crear.CategoriaMarca, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.Categorias),
            ["ModeloVehiculo.AceitesRecomendados"] = C(() => Crear.ModeloVehiculo(), Crear.Aceite, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.AceitesRecomendados),
            ["ModeloVehiculo.FuentesEnergiaRecomendadas"] = C(() => Crear.ModeloVehiculo(), Crear.FuenteEnergia, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.FuentesEnergiaRecomendadas),
            ["ModeloVehiculo.RepuestosRecomendados"] = C(() => Crear.ModeloVehiculo(), Crear.Repuesto, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.RepuestosRecomendados),
            ["ModeloVehiculo.PresionesNeumaticoRecomendadas"] = C(() => Crear.ModeloVehiculo(), Crear.PresionNeumatico, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.PresionesNeumaticoRecomendadas),
            ["PresionNeumatico.RecomendacionesModeloVehiculo"] = C(() => Crear.PresionNeumatico(), Crear.ModeloVehiculo, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.RecomendacionesModeloVehiculo),
            ["Reparador.EntidadesReparadoras"] = C(() => Crear.Reparador(), Crear.EntidadReparadora, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.EntidadesReparadoras),
            ["Repuesto.Kits"] = C(() => Crear.Repuesto(), Crear.Kit, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.Kits),
            ["Repuesto.RecomendacionesModeloVehiculo"] = C(() => Crear.Repuesto(), Crear.ModeloVehiculo, (d, e) => d.Agregar(e), (d, e) => d.Quitar(e), d => d.RecomendacionesModeloVehiculo),
        };

        public static TheoryData<string> Casos => new(casos.Keys.OrderBy(k => k));

        private static List<object> Elementos(Caso c, object duenio) => c.Coleccion(duenio).Cast<object>().ToList();

        //Se compara por referencia: algunos Equals del dominio lanzan NullReferenceException al comparar
        //contra entidades sin sus navegaciones cargadas (ver IgualdadTests).
        private static bool Contiene(Caso c, object duenio, object elemento) => Elementos(c, duenio).Any(e => ReferenceEquals(e, elemento));

        [Theory]
        [MemberData(nameof(Casos))]
        public void Agregar_Elemento_LoIncorporaYDevuelveElDuenio(string caso)
        {
            var c = casos[caso];
            var duenio = c.CrearDuenio();
            var elemento = c.CrearElemento(1);

            var resultado = c.Agregar(duenio, elemento);

            Assert.Same(duenio, resultado);
            Assert.True(Contiene(c, duenio, elemento));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Agregar_VariosElementos_LosIncorporaATodos(string caso)
        {
            var c = casos[caso];
            var duenio = c.CrearDuenio();

            c.Agregar(duenio, c.CrearElemento(1));
            c.Agregar(duenio, c.CrearElemento(2));

            Assert.Equal(2, Elementos(c, duenio).Count);
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Agregar_MismoElementoDosVeces_NoLoDuplica(string caso)
        {
            var c = casos[caso];
            var duenio = c.CrearDuenio();
            var elemento = c.CrearElemento(1);

            c.Agregar(duenio, elemento);
            c.Agregar(duenio, elemento);

            Assert.Single(Elementos(c, duenio));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Agregar_Null_NoModificaLaColeccion(string caso)
        {
            var c = casos[caso];
            var duenio = c.CrearDuenio();

            var resultado = c.Agregar(duenio, null);

            Assert.Same(duenio, resultado);
            Assert.Empty(Elementos(c, duenio));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Quitar_ElementoAgregado_LoRemueve(string caso)
        {
            var c = casos[caso];
            var duenio = c.CrearDuenio();
            var elemento = c.CrearElemento(1);
            var otro = c.CrearElemento(2);
            c.Agregar(duenio, elemento);
            c.Agregar(duenio, otro);

            var resultado = c.Quitar(duenio, elemento);

            Assert.Same(duenio, resultado);
            Assert.False(Contiene(c, duenio, elemento));
            Assert.True(Contiene(c, duenio, otro));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Quitar_ElementoNoAgregado_NoModificaLaColeccion(string caso)
        {
            var c = casos[caso];
            var duenio = c.CrearDuenio();
            c.Agregar(duenio, c.CrearElemento(1));

            c.Quitar(duenio, c.CrearElemento(2));

            Assert.Single(Elementos(c, duenio));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Quitar_Null_NoModificaLaColeccion(string caso)
        {
            var c = casos[caso];
            var duenio = c.CrearDuenio();
            c.Agregar(duenio, c.CrearElemento(1));

            var resultado = c.Quitar(duenio, null);

            Assert.Same(duenio, resultado);
            Assert.Single(Elementos(c, duenio));
        }
    }
}
