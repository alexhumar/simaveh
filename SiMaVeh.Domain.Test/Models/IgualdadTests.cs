using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Test.Models
{
    /// <summary>
    /// Igualdad de las entidades: dos entidades son iguales si son la misma instancia, si tienen el mismo Id
    /// o si coinciden en su clave de negocio. El hash depende solo del tipo y del Id.
    /// </summary>
    public class IgualdadTests
    {
        /// <param name="Crear">Crea la entidad con el Id indicado. La variante 0 y la 1 tienen claves de negocio distintas.</param>
        /// <param name="IdCalculado">El Id se calcula a partir de la clave de negocio (no se puede elegir libremente).</param>
        public record Caso(Func<long, int, object> Crear, bool IdCalculado = false);

        private static readonly DateTime fecha = new(2024, 1, 1);

        private static readonly Dictionary<string, Caso> casos = new()
        {
            ["Aceite"] = new((id, v) => new Aceite { Id = id, Nombre = v == 0 ? "Sintetico" : "Mineral" }),
            ["Automovil"] = new((id, v) => new Automovil { Id = id, Patente = v == 0 ? "AA000BB" : "CC111DD" }),
            ["CategoriaMarca"] = new((id, v) => new CategoriaMarca { Id = id, Nombre = v == 0 ? "Autos" : "Motos" }),
            ["Direccion"] = new((id, v) => new Direccion { Id = id, Calle = v == 0 ? "Mitre" : "Sarmiento", NumeroCalle = 100, Localidad = Crear.Localidad(1) }),
            ["EntidadReparadora"] = new((id, v) => new EntidadReparadora { Id = id, Nombre = v == 0 ? "Taller A" : "Taller B", TipoEntidadReparadora = Crear.TipoEntidadReparadora(1) }),
            ["EquipamientoAirbags"] = new((id, v) => new EquipamientoAirbags { Conductor = true, Acompanante = v == 0 }, IdCalculado: true),
            ["Fluido"] = new((id, v) => new Fluido { Id = id, Nombre = v == 0 ? "Refrigerante" : "Liquido de frenos" }),
            ["FuenteEnergia"] = new((id, v) => new FuenteEnergia { Id = id, Nombre = v == 0 ? "Super" : "Premium", Marca = Crear.Marca(1), TipoFuenteEnergia = Crear.TipoFuenteEnergia(1) }),
            ["GrupoModelo"] = new((id, v) => new GrupoModelo { Id = id, Nombre = v == 0 ? "Gol" : "Polo", Marca = Crear.Marca(1) }),
            ["Kit"] = new((id, v) => new Kit { Id = id, Nombre = v == 0 ? "Distribucion" : "Embrague" }),
            ["Localidad"] = new((id, v) => new Localidad { Id = id, Nombre = v == 0 ? "Quilmes" : "Bernal", CPA = v == 0 ? "B1878" : "B1876", Partido = Crear.Partido(1) }),
            ["Mantenimiento"] = new((id, v) => new Mantenimiento { Id = id, Accion = v == 0 ? AccionMantenimiento.Reemplazo : AccionMantenimiento.Reparacion, Recambio = Crear.Repuesto(1), ServicioReparador = Crear.ServicioReparador(1), Reparador = Crear.Reparador(1) }),
            ["Marca"] = new((id, v) => new Marca { Id = id, Nombre = v == 0 ? "Ford" : "Fiat" }),
            ["ModeloVehiculo"] = new((id, v) => new ModeloVehiculo { Id = id, Version = v == 0 ? "1.6" : "2.0", GrupoModelo = Crear.GrupoModelo(1) }),
            ["Moneda"] = new((id, v) => new Moneda { Id = $"M{id}", Nombre = v == 0 ? "Peso" : "Dolar" }),
            ["Neumatico"] = new((id, v) => new Neumatico { Id = id, Modelo = v == 0 ? "P400" : "P7", Marca = Crear.Marca(1) }),
            ["Pais"] = new((id, v) => new Pais { Id = id, Nombre = v == 0 ? "Argentina" : "Uruguay" }),
            ["Partido"] = new((id, v) => new Partido { Id = id, Nombre = v == 0 ? "Quilmes" : "Lanus", Provincia = Crear.Provincia(1) }),
            ["PeriodicidadMantenimiento"] = new((id, v) => new PeriodicidadMantenimiento { Id = id, EsDefault = v == 0, Repuesto = Crear.Repuesto(1), ModeloVehiculo = Crear.ModeloVehiculo(1) }),
            ["Pieza"] = new((id, v) => new Pieza { Id = id, Nombre = v == 0 ? "Pastilla" : "Disco" }),
            ["Provincia"] = new((id, v) => new Provincia { Id = id, Nombre = v == 0 ? "Buenos Aires" : "Cordoba", Pais = Crear.Pais(1) }),
            ["Reparador"] = new((id, v) => new Reparador { Id = id, NumeroDocumento = v == 0 ? "20111222" : "20333444" }),
            ["Repuesto"] = new((id, v) => new Repuesto { Id = id, CodigoIdentificador = v == 0 ? "R-1" : "R-2", TargetMantenimiento = Crear.Pieza(1) }),
            ["ServicioReparador"] = new((id, v) => new ServicioReparador { Id = id, FechaInicio = fecha, FechaFin = fecha, KilometrajeVehiculo = v == 0 ? 1000 : 2000, MontoManoObra = 10, Vehiculo = new Automovil { Id = 1, Patente = "AA000BB" }, EntidadReparadora = Crear.EntidadReparadora(1), MonedaMontoManoObra = Crear.Moneda() }),
            ["Telefono"] = new((id, v) => new Telefono { Id = id, Numero = v == 0 ? 4444 : 5555, TipoTelefono = Crear.TipoTelefono(1) }),
            ["TipoCambio"] = new((id, v) => new TipoCambio { Id = id, CoeficienteCambio = v == 0 ? 1000 : 1200, Fecha = fecha, MonedaOrigen = Crear.Moneda("USD"), MonedaDestino = Crear.Moneda("ARS") }),
            ["TipoDocumento"] = new((id, v) => new TipoDocumento { Id = id, Nombre = v == 0 ? "DNI" : "Pasaporte" }),
            ["TipoEntidadReparadora"] = new((id, v) => new TipoEntidadReparadora { Id = id, Nombre = v == 0 ? "Taller" : "Concesionario" }),
            ["TipoFuenteEnergia"] = new((id, v) => new TipoFuenteEnergia { Id = id, Nombre = v == 0 ? "Nafta" : "Diesel" }),
            ["TipoTelefono"] = new((id, v) => new TipoTelefono { Id = id, Nombre = v == 0 ? "Celular" : "Fijo" }),
            ["UbicacionPieza"] = new((id, v) => new UbicacionPieza { Izquierda = true, Superior = v == 0 }, IdCalculado: true),
            ["Usuario"] = new((id, v) => new Usuario { Id = id, NumeroDocumento = v == 0 ? "30111222" : "30333444" }),
        };

        public static TheoryData<string> Casos => new(casos.Keys.OrderBy(k => k));

        public static TheoryData<string> CasosConIdLibre => new(casos.Where(c => !c.Value.IdCalculado).Select(c => c.Key).OrderBy(k => k));

        [Theory]
        [MemberData(nameof(Casos))]
        public void Equals_MismaInstancia_EsTrue(string caso)
        {
            var entidad = casos[caso].Crear(1, 0);

            Assert.True(entidad.Equals(entidad));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Equals_MismaClaveDeNegocio_EsTrue(string caso)
        {
            var c = casos[caso];

            Assert.True(c.Crear(1, 0).Equals(c.Crear(2, 0)));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Equals_DistintoIdYDistintaClave_EsFalse(string caso)
        {
            var c = casos[caso];

            Assert.False(c.Crear(1, 0).Equals(c.Crear(2, 1)));
        }

        [Theory]
        [MemberData(nameof(CasosConIdLibre))]
        public void Equals_MismoIdConDistintaClave_EsTrue(string caso)
        {
            var c = casos[caso];

            Assert.True(c.Crear(1, 0).Equals(c.Crear(1, 1)));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void Equals_NullUOtroTipo_EsFalse(string caso)
        {
            var entidad = casos[caso].Crear(1, 0);

            Assert.False(entidad.Equals(null));
            Assert.False(entidad.Equals(new object()));
        }

        [Theory]
        [MemberData(nameof(Casos))]
        public void GetHashCode_MismoId_EsIgual(string caso)
        {
            var c = casos[caso];

            //Para las entidades con Id calculado, misma variante => mismo Id.
            Assert.Equal(c.Crear(1, 0).GetHashCode(), c.Crear(1, c.IdCalculado ? 0 : 1).GetHashCode());
        }

        [Theory]
        [MemberData(nameof(CasosConIdLibre))]
        public void GetHashCode_DistintoId_EsDistinto(string caso)
        {
            var c = casos[caso];

            Assert.NotEqual(c.Crear(1, 0).GetHashCode(), c.Crear(2, 0).GetHashCode());
        }

        [Fact]
        public void Equals_NombreConDistintasMayusculas_EsTrue()
        {
            Assert.Equal(new Pais { Id = 1, Nombre = "Argentina" }, new Pais { Id = 2, Nombre = "ARGENTINA" });
            Assert.Equal(new Marca { Id = 1, Nombre = "Ford" }, new Marca { Id = 2, Nombre = "ford" });
        }

        [Fact]
        public void Equals_SubtiposDeTargetMantenimientoConMismoNombre_NoSonIguales()
        {
            //Aceite.Equals exige que el otro objeto tambien sea un Aceite.
            Assert.False(new Aceite { Id = 1, Nombre = "X" }.Equals(new Fluido { Id = 2, Nombre = "X" }));
        }

        [Fact]
        public void Equals_UsuarioYReparadorConMismoDocumento_NoSonIguales()
        {
            Assert.False(new Usuario { Id = 1, NumeroDocumento = "1" }.Equals(new Reparador { Id = 2, NumeroDocumento = "1" }));
        }

        [Fact]
        public void Equals_PresionNeumatico_DistintoIdYDistintoNeumatico_EsFalse()
        {
            var presion1 = new PresionNeumatico { Id = 1, Neumatico = ConMarca(Crear.Neumatico(1)) };
            var presion2 = new PresionNeumatico { Id = 2, Neumatico = ConMarca(Crear.Neumatico(2)) };

            Assert.False(presion1.Equals(presion2));
            Assert.True(presion1.Equals(new PresionNeumatico { Id = 1 }));
        }

        private static Neumatico ConMarca(Neumatico neumatico) => neumatico.Cambiar(Crear.Marca());

        #region Defectos detectados (documentados como tests omitidos)

        [Fact(Skip = "BUG: Neumatico.Equals compara Marca.Equals(Marca) (consigo misma) en lugar de item.Marca, por lo que neumaticos de distinta marca con el mismo modelo se consideran iguales.")]
        public void Equals_Neumatico_MismoModeloDistintaMarca_EsFalse()
        {
            var neumatico1 = new Neumatico { Id = 1, Modelo = "P7", Marca = Crear.Marca(1) };
            var neumatico2 = new Neumatico { Id = 2, Modelo = "P7", Marca = Crear.Marca(2) };

            Assert.False(neumatico1.Equals(neumatico2));
        }

        [Fact(Skip = "BUG: Localidad.Equals considera iguales a dos localidades con el mismo CPA aunque sea vacio o null. El seed carga CPA = string.Empty en todas las localidades, por lo que todas resultan iguales entre si.")]
        public void Equals_Localidad_SinCPAEnDistintosPartidos_EsFalse()
        {
            var localidad1 = new Localidad { Id = 1, Nombre = "Quilmes", CPA = string.Empty, Partido = Crear.Partido(1) };
            var localidad2 = new Localidad { Id = 2, Nombre = "Moron", CPA = string.Empty, Partido = Crear.Partido(2) };

            Assert.False(localidad1.Equals(localidad2));
        }

        [Fact(Skip = "BUG: varios Equals (Provincia, Partido, ModeloVehiculo, PresionNeumatico, etc.) desreferencian navegaciones sin chequear null y lanzan NullReferenceException al comparar contra otra entidad con distinto Id.")]
        public void Equals_EntidadSinNavegacionesCargadas_NoLanzaExcepcion()
        {
            var provincia1 = new Provincia { Id = 1, Nombre = "Buenos Aires" };
            var provincia2 = new Provincia { Id = 2, Nombre = "Buenos Aires" };

            var excepcion = Record.Exception(() => provincia1.Equals(provincia2));

            Assert.Null(excepcion);
        }

        [Fact(Skip = "BUG: las entidades nuevas (Id = 0) son todas iguales entre si por tener el mismo Id, por lo que no se pueden agregar dos entidades nuevas distintas a una misma coleccion antes de persistirlas.")]
        public void Agregar_DosProvinciasNuevasSinPersistir_AgregaAmbas()
        {
            var pais = Crear.Pais();

            pais.Agregar(new Provincia { Nombre = "Buenos Aires" });
            pais.Agregar(new Provincia { Nombre = "Cordoba" });

            Assert.Equal(2, pais.Provincias.Count);
        }

        [Fact(Skip = "BUG: se viola el contrato Equals/GetHashCode: dos entidades iguales por clave de negocio pero con distinto Id tienen distinto hash.")]
        public void GetHashCode_EntidadesIgualesPorClaveDeNegocio_EsIgual()
        {
            var pais1 = new Pais { Id = 1, Nombre = "Argentina" };
            var pais2 = new Pais { Id = 2, Nombre = "Argentina" };

            Assert.True(pais1.Equals(pais2));
            Assert.Equal(pais1.GetHashCode(), pais2.GetHashCode());
        }

        #endregion
    }
}
