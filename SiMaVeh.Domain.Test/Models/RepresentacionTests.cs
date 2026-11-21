using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Test.Models
{
    /// <summary>
    /// ToString de las entidades y propiedades calculadas.
    /// </summary>
    public class RepresentacionTests
    {
        private static Localidad Bernal(string cpa = "B1876")
        {
            var argentina = new Pais { Id = 1, Nombre = "Argentina" };
            var buenosAires = new Provincia { Id = 1, Nombre = "Buenos Aires" }.Cambiar(argentina);
            var quilmes = new Partido { Id = 1, Nombre = "Quilmes" }.Cambiar(buenosAires);
            return new Localidad { Id = 1, Nombre = "Bernal", CPA = cpa }.Cambiar(quilmes);
        }

        private static ModeloVehiculo Focus16()
        {
            var grupo = new GrupoModelo { Id = 1, Nombre = "Focus" }.Cambiar(new Marca { Id = 1, Nombre = "Ford" });
            return new ModeloVehiculo { Id = 1, Version = "1.6" }.Cambiar(grupo);
        }

        private static Repuesto RepuestoDisco() => new Repuesto { Id = 1, CodigoIdentificador = "R-1" }.Cambiar(new Pieza { Id = 1, Nombre = "Disco" });

        private static readonly Dictionary<string, (Func<object> Crear, string Esperado)> casos = new()
        {
            ["Aceite"] = (() => new Aceite { Nombre = "Sintetico" }, "(Aceite) Sintetico"),
            ["Fluido"] = (() => new Fluido { Nombre = "Refrigerante" }, "(Fluido) Refrigerante"),
            ["Pieza sin ubicacion"] = (() => new Pieza { Nombre = "Disco" }, "(Pieza) Disco"),
            ["Pieza con ubicacion"] = (() => new Pieza { Nombre = "Disco" }.Cambiar(Crear.UbicacionPieza(izquierda: true, superior: false)), "(Pieza) Disco(Inferior, Izquierda)"),
            ["Automovil"] = (() => new Automovil { Patente = "AA000BB", AnioFabricacion = 2015, ModeloVehiculo = Focus16() }, "(AA000BB) Ford Focus 1.6 2015"),
            ["CategoriaMarca"] = (() => new CategoriaMarca { Nombre = "Autos" }, "Autos"),
            ["Pais"] = (() => new Pais { Nombre = "Argentina" }, "Argentina"),
            ["Provincia"] = (() => new Provincia { Nombre = "Cordoba" }.Cambiar(new Pais { Id = 1, Nombre = "Argentina" }), "Cordoba Argentina"),
            ["Localidad con CPA"] = (() => Bernal(), "Bernal (B1876) Quilmes Buenos Aires Argentina"),
            ["Localidad sin CPA"] = (() => Bernal(cpa: " "), "Bernal Quilmes Buenos Aires Argentina"),
            ["Direccion"] = (() => new Direccion { Calle = "Mitre", NumeroCalle = 100 }.Cambiar(Bernal()), "Mitre 100, Bernal (B1876) Quilmes Buenos Aires Argentina"),
            ["EntidadReparadora"] = (() => new EntidadReparadora { Nombre = "Lo de Juan" }.Cambiar(new TipoEntidadReparadora { Id = 1, Nombre = "Taller" }), "(Taller) Lo de Juan"),
            ["FuenteEnergia"] = (() => new FuenteEnergia { Nombre = "Super" }.Cambiar(new Marca { Id = 1, Nombre = "YPF" }).Cambiar(new TipoFuenteEnergia { Id = 1, Nombre = "Nafta" }), "(Nafta) YPF Super"),
            ["GrupoModelo"] = (() => new GrupoModelo { Nombre = "Focus" }.Cambiar(new Marca { Id = 1, Nombre = "Ford" }), "Ford Focus"),
            ["ModeloVehiculo"] = (() => Focus16(), "Ford Focus 1.6"),
            ["Kit"] = (() => new Kit { Nombre = "Distribucion" }, "Distribucion"),
            ["Marca"] = (() => new Marca { Nombre = "Ford" }, "Ford"),
            ["Moneda"] = (() => new Moneda { Nombre = "Peso" }, "Peso"),
            ["Repuesto"] = (() => RepuestoDisco(), "(R-1) (Pieza) Disco"),
            ["Mantenimiento reemplazo"] = (() => new Mantenimiento { Accion = AccionMantenimiento.Reemplazo }.Cambiar((Recambio)RepuestoDisco()), "(Reemplazo) (R-1) (Pieza) Disco"),
            ["Mantenimiento reparacion"] = (() => new Mantenimiento { Accion = AccionMantenimiento.Reparacion }, "(Reparación) "),
            ["Neumatico"] = (() => new Neumatico { Modelo = "P400", Tipo = TipoVehiculoNeumatico.Pasajero, AnchuraSeccionalNominal = 195, RelacionAnchoAlto = 65, ConstruccionCarcasa = ConstruccionCarcasaNeumatico.Radial, DiametroLLanta = 15, IndiceCarga = 91, IndiceVelocidad = "H" }.Cambiar(new Marca { Id = 1, Nombre = "Pirelli" }), "PirelliP400P195/65R15 91H"),
            ["Neumatico sin relacion ancho/alto"] = (() => new Neumatico { Modelo = "T", Tipo = TipoVehiculoNeumatico.UsoTemporal, AnchuraSeccionalNominal = 125, ConstruccionCarcasa = ConstruccionCarcasaNeumatico.Diagonal, DiametroLLanta = 16, IndiceCarga = 80, IndiceVelocidad = "M" }, "TT125/D16 80M"),
            ["PeriodicidadMantenimiento"] = (() => new PeriodicidadMantenimiento().Cambiar(RepuestoDisco()).Cambiar(Focus16()), "Periodicidad (R-1) (Pieza) Disco - Ford Focus 1.6"),
            ["Usuario"] = (() => new Usuario { Nombre = "Ana", Apellido = "Gomez" }, "Gomez, Ana"),
            ["Reparador"] = (() => new Reparador { Nombre = "Juan", Apellido = "Perez" }, "Perez, Juan"),
            ["Telefono"] = (() => new Telefono { Numero = 4444 }.Cambiar(new TipoTelefono { Id = 1, Nombre = "Celular" }), "(Celular) 4444"),
            ["TipoDocumento"] = (() => new TipoDocumento { Nombre = "DNI" }, "DNI"),
            ["TipoEntidadReparadora"] = (() => new TipoEntidadReparadora { Nombre = "Taller" }, "Taller"),
            ["TipoFuenteEnergia"] = (() => new TipoFuenteEnergia { Nombre = "Nafta" }, "Nafta"),
            ["TipoTelefono"] = (() => new TipoTelefono { Nombre = "Fijo" }, "Fijo"),
            ["UbicacionPieza superior izquierda"] = (() => Crear.UbicacionPieza(true, true), "(Superior, Izquierda)"),
            ["UbicacionPieza inferior derecha"] = (() => Crear.UbicacionPieza(false, false), "(Inferior, Derecha)"),
        };

        public static TheoryData<string> Casos => new(casos.Keys.OrderBy(k => k));

        [Theory]
        [MemberData(nameof(Casos))]
        public void ToString_DevuelveLaRepresentacionEsperada(string caso)
        {
            var (crear, esperado) = casos[caso];

            Assert.Equal(esperado, crear().ToString());
        }

        [Fact]
        public void ToString_EntidadesConFechasYMontos_IncluyenSusComponentes()
        {
            var tipoCambio = Crear.TipoCambio().CambiarMonedaOrigen(new Moneda { Id = "USD", Nombre = "Dolar" }).CambiarMonedaDestino(new Moneda { Id = "ARS", Nombre = "Peso" });
            var servicio = Crear.ServicioReparador().Cambiar(new EntidadReparadora { Id = 1, Nombre = "Taller A" });

            Assert.StartsWith("MOR: Dolar MDEST: Peso 1000 ", tipoCambio.ToString());
            Assert.StartsWith("Servicio  (", servicio.ToString());
            Assert.Contains("Taller A", servicio.ToString());
        }

        [Fact]
        public void ToString_PresionNeumatico_SinModelosRecomendados_MuestraSoloLasPresiones()
        {
            Assert.Equal("(D30, T32)", Crear.PresionNeumatico().ToString());
        }

        [Fact]
        public void ToString_PresionNeumatico_ConModelosRecomendados_LosListaOrdenados()
        {
            var presion = Crear.PresionNeumatico()
                .Agregar(new ModeloVehiculo { Id = 2, Version = "2.0" }.Cambiar(new GrupoModelo { Id = 2, Nombre = "Mondeo" }.Cambiar(new Marca { Id = 1, Nombre = "Ford" })))
                .Agregar(Focus16());

            Assert.Equal("(D30, T32) Ford Focus 1.6, Ford Mondeo 2.0", presion.ToString());
        }

        [Fact]
        public void ToString_PresionNeumatico_SinColeccionInicializada_NoFalla()
        {
            var presion = new PresionNeumatico { RuedasDelanteras = 30, RuedasTraseras = 32, RecomendacionesModeloVehiculo = null };

            Assert.Equal("(D30, T32)", presion.ToString());
        }

        [Fact]
        public void ToString_EquipamientoAirbags_IncluyeLasUbicaciones()
        {
            Assert.StartsWith("(V,G,DI,DD,TI,TD) - (S,S,L,L,N,N", Crear.EquipamientoAirbags().ToString());
        }

        [Theory]
        [InlineData(true, true, "IS")]
        [InlineData(true, false, "II")]
        [InlineData(false, true, "DS")]
        [InlineData(false, false, "DI")]
        public void UbicacionPieza_Id_SeCalculaDesdeLaUbicacion(bool izquierda, bool superior, string esperado)
        {
            var ubicacion = new UbicacionPieza { Izquierda = izquierda, Superior = superior };

            Assert.Equal(esperado, ubicacion.Id);
        }

        [Fact]
        public void UbicacionPieza_SetDeId_SeIgnora()
        {
            var ubicacion = new UbicacionPieza { Izquierda = true, Superior = true, Id = "XX" };

            Assert.Equal("IS", ubicacion.Id);
        }

        [Fact]
        public void EquipamientoAirbags_Id_SeCalculaDesdeElEquipamiento()
        {
            var completo = new EquipamientoAirbags { Conductor = true, Acompanante = true, DelanteroIzquierdo = TipoAirbagLateral.Ambos, DelanteroDerecho = TipoAirbagLateral.Ambos, TraseroIzquierdo = TipoAirbagLateral.Cortina, TraseroDerecho = TipoAirbagLateral.Lateral };
            var basico = new EquipamientoAirbags { Id = "se ignora" };

            Assert.Equal("CAAACL", completo.Id);
            Assert.Equal("NCNANNNN", basico.Id);
        }

        [Fact]
        public void PresionNeumatico_EsUniversal_SoloSiNoTieneNeumatico()
        {
            var presion = Crear.PresionNeumatico();

            Assert.True(presion.EsUniversal);

            presion.Cambiar(Crear.Neumatico());

            Assert.False(presion.EsUniversal);
        }

        [Fact]
        public void Constructores_InicializanLasColeccionesVacias()
        {
            Assert.Empty(new Pais().Provincias);
            Assert.Empty(new Provincia().Partidos);
            Assert.Empty(new Partido().Localidades);
            Assert.Empty(new Marca().Categorias);
            Assert.Empty(new CategoriaMarca().Marcas);
            Assert.Empty(new Kit().Repuestos);
            Assert.Empty(new Aceite().RecomendacionesModeloVehiculo);
            Assert.Empty(new FuenteEnergia().RecomendacionesModeloVehiculo);
            Assert.Empty(new PresionNeumatico().RecomendacionesModeloVehiculo);
            Assert.Empty(new EntidadReparadora().ServiciosReparadores);
            Assert.Empty(new EntidadReparadora().Reparadores);
            Assert.Empty(new Reparador().EntidadesReparadoras);
            Assert.Empty(new Reparador().Telefonos);
            Assert.Empty(new Usuario().Vehiculos);
            Assert.Empty(new Automovil().ServiciosReparadores);
            Assert.Empty(new ServicioReparador().Mantenimientos);
            var repuesto = new Repuesto();
            Assert.Empty(repuesto.Kits);
            Assert.Empty(repuesto.PeriodicidadesMantenimiento);
            Assert.Empty(repuesto.RecomendacionesModeloVehiculo);
            var modelo = new ModeloVehiculo();
            Assert.Empty(modelo.AceitesRecomendados);
            Assert.Empty(modelo.FuentesEnergiaRecomendadas);
            Assert.Empty(modelo.RepuestosRecomendados);
            Assert.Empty(modelo.PresionesNeumaticoRecomendadas);
        }
    }
}
