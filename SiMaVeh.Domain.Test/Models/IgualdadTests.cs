using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Test.Models
{
    /// <summary>
    /// Igualdad por identidad (DomainMember): dos entidades son iguales si son del mismo tipo y tienen el mismo
    /// Id asignado; una entidad transitoria (sin Id) solo es igual a si misma. El hash es consistente con Equals
    /// y no cambia cuando una entidad transitoria recibe su Id.
    /// </summary>
    public class IgualdadTests
    {
        /// <summary>
        /// Entidades concretas del modelo cuyo Id se asigna libremente (las de Id calculado se prueban aparte).
        /// </summary>
        public static TheoryData<Type> Entidades => new(typeof(Pais).Assembly.GetTypes()
            .Where(t => t.Namespace == typeof(Pais).Namespace && t.IsClass && !t.IsAbstract && !t.IsNested && !t.IsGenericTypeDefinition)
            .Where(t => t.GetProperty(nameof(DomainMember<long>.Id)) != null)
            .Where(t => t != typeof(EquipamientoAirbags) && t != typeof(UbicacionPieza))
            .OrderBy(t => t.Name));

        private static object Crear(Type tipo, int? id)
        {
            var entidad = Activator.CreateInstance(tipo);
            if (id.HasValue)
            {
                var propiedad = tipo.GetProperty(nameof(DomainMember<long>.Id));
                propiedad.SetValue(entidad, propiedad.PropertyType == typeof(string) ? $"ID{id}" : (object)(long)id.Value);
            }

            return entidad;
        }

        private static void AsignarId(object entidad, int id)
        {
            var propiedad = entidad.GetType().GetProperty(nameof(DomainMember<long>.Id));
            propiedad.SetValue(entidad, propiedad.PropertyType == typeof(string) ? $"ID{id}" : (object)(long)id);
        }

        [Theory]
        [MemberData(nameof(Entidades))]
        public void Equals_MismaInstancia_EsTrue(Type tipo)
        {
            var persistida = Crear(tipo, 1);
            var transitoria = Crear(tipo, null);

            Assert.True(persistida.Equals(persistida));
            Assert.True(transitoria.Equals(transitoria));
        }

        [Theory]
        [MemberData(nameof(Entidades))]
        public void Equals_MismoTipoYMismoId_EsTrue(Type tipo)
        {
            Assert.True(Crear(tipo, 1).Equals(Crear(tipo, 1)));
        }

        [Theory]
        [MemberData(nameof(Entidades))]
        public void Equals_DistintoId_EsFalse(Type tipo)
        {
            Assert.False(Crear(tipo, 1).Equals(Crear(tipo, 2)));
        }

        [Theory]
        [MemberData(nameof(Entidades))]
        public void Equals_DosEntidadesTransitorias_EsFalse(Type tipo)
        {
            Assert.False(Crear(tipo, null).Equals(Crear(tipo, null)));
        }

        [Theory]
        [MemberData(nameof(Entidades))]
        public void Equals_TransitoriaContraPersistida_EsFalse(Type tipo)
        {
            Assert.False(Crear(tipo, null).Equals(Crear(tipo, 1)));
            Assert.False(Crear(tipo, 1).Equals(Crear(tipo, null)));
        }

        [Theory]
        [MemberData(nameof(Entidades))]
        public void Equals_NullUOtroTipo_EsFalse(Type tipo)
        {
            var entidad = Crear(tipo, 1);

            Assert.False(entidad.Equals(null));
            Assert.False(entidad.Equals(new object()));
        }

        [Theory]
        [MemberData(nameof(Entidades))]
        public void GetHashCode_EntidadesIguales_TienenElMismoHash(Type tipo)
        {
            Assert.Equal(Crear(tipo, 1).GetHashCode(), Crear(tipo, 1).GetHashCode());
        }

        [Theory]
        [MemberData(nameof(Entidades))]
        public void GetHashCode_DistintoId_EsDistinto(Type tipo)
        {
            Assert.NotEqual(Crear(tipo, 1).GetHashCode(), Crear(tipo, 2).GetHashCode());
        }

        [Theory]
        [MemberData(nameof(Entidades))]
        public void GetHashCode_EntidadTransitoriaQueRecibeId_ConservaSuHash(Type tipo)
        {
            var entidad = Crear(tipo, null);
            var hashInicial = entidad.GetHashCode();

            AsignarId(entidad, 1);

            Assert.Equal(hashInicial, entidad.GetHashCode());
        }

        [Fact]
        public void EsTransitoria_SegunElIdAsignado()
        {
            Assert.True(new Pais().EsTransitoria);
            Assert.False(new Pais { Id = 1 }.EsTransitoria);
            Assert.True(new Moneda().EsTransitoria);
            Assert.True(new Moneda { Id = string.Empty }.EsTransitoria);
            Assert.False(new Moneda { Id = "ARS" }.EsTransitoria);
        }

        [Fact]
        public void Equals_DistintosTiposConMismoId_EsFalse()
        {
            Assert.False(new Usuario { Id = 1 }.Equals(new Reparador { Id = 1 }));
            Assert.False(new Aceite { Id = 1 }.Equals(new Fluido { Id = 1 }));
            Assert.False(new Pais { Id = 1 }.Equals(new Provincia { Id = 1 }));
        }

        [Fact]
        public void Equals_MismoIdConDistintosDatos_EsTrue()
        {
            Assert.Equal(new Pais { Id = 1, Nombre = "Argentina" }, new Pais { Id = 1, Nombre = "Otro nombre" });
        }

        [Fact]
        public void Equals_MismosDatosConDistintoId_EsFalse()
        {
            //La igualdad por atributos no corresponde a entidades: dos paises con el mismo nombre son entidades distintas.
            Assert.NotEqual(new Pais { Id = 1, Nombre = "Argentina" }, new Pais { Id = 2, Nombre = "Argentina" });
        }

        [Fact]
        public void Equals_EntidadSinNavegacionesCargadas_NoLanzaExcepcion()
        {
            var provincia1 = new Provincia { Id = 1, Nombre = "Buenos Aires" };
            var provincia2 = new Provincia { Id = 2, Nombre = "Buenos Aires" };

            var excepcion = Record.Exception(() => provincia1.Equals(provincia2));

            Assert.Null(excepcion);
        }

        [Fact]
        public void Equals_Neumatico_MismoModeloDistintaMarca_EsFalse()
        {
            var neumatico1 = new Neumatico { Id = 1, Modelo = "P7", Marca = Helpers.Crear.Marca(1) };
            var neumatico2 = new Neumatico { Id = 2, Modelo = "P7", Marca = Helpers.Crear.Marca(2) };

            Assert.False(neumatico1.Equals(neumatico2));
        }

        [Fact]
        public void Equals_Localidad_SinCPAEnDistintosPartidos_EsFalse()
        {
            var localidad1 = new Localidad { Id = 1, Nombre = "Quilmes", CPA = string.Empty, Partido = Helpers.Crear.Partido(1) };
            var localidad2 = new Localidad { Id = 2, Nombre = "Moron", CPA = string.Empty, Partido = Helpers.Crear.Partido(2) };

            Assert.False(localidad1.Equals(localidad2));
        }

        [Fact]
        public void Agregar_DosProvinciasNuevasSinPersistir_AgregaAmbas()
        {
            var pais = Helpers.Crear.Pais();

            pais.Agregar(new Provincia { Nombre = "Buenos Aires" });
            pais.Agregar(new Provincia { Nombre = "Cordoba" });

            Assert.Equal(2, pais.Provincias.Count);
        }

        [Fact]
        public void HashSet_EntidadTransitoriaQueSePersiste_SigueSiendoEncontrada()
        {
            var pais = Helpers.Crear.Pais();
            var provincia = new Provincia { Nombre = "Buenos Aires" };
            pais.Agregar(provincia);

            //Simula la asignacion del Id al persistir (SaveChanges).
            provincia.Id = 10;

            Assert.Contains(provincia, pais.Provincias);
            pais.Quitar(provincia);
            Assert.Empty(pais.Provincias);
        }

        [Fact]
        public void EntidadesConIdCalculado_SonIgualesSiCoincideLaClave()
        {
            var ubicacion1 = new UbicacionPieza { Izquierda = true, Superior = false };
            var ubicacion2 = new UbicacionPieza { Izquierda = true, Superior = false };
            var airbags1 = new EquipamientoAirbags { Conductor = true };
            var airbags2 = new EquipamientoAirbags { Conductor = true };

            Assert.Equal(ubicacion1, ubicacion2);
            Assert.Equal(ubicacion1.GetHashCode(), ubicacion2.GetHashCode());
            Assert.NotEqual(ubicacion1, new UbicacionPieza { Izquierda = false, Superior = false });
            Assert.Equal(airbags1, airbags2);
            Assert.Equal(airbags1.GetHashCode(), airbags2.GetHashCode());
            Assert.NotEqual(airbags1, new EquipamientoAirbags { Conductor = false });
        }

        [Fact]
        public void HashSet_NoAdmiteDosInstanciasDeLaMismaEntidad()
        {
            var conjunto = new HashSet<Marca> { new() { Id = 1, Nombre = "Ford" } };

            Assert.False(conjunto.Add(new Marca { Id = 1, Nombre = "FORD" }));
            Assert.True(conjunto.Add(new Marca { Id = 2, Nombre = "Fiat" }));
        }
    }
}
