using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.DataAccess.DataSeed.Seeders;
using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.DataAccess.Test.Helpers;
using SiMaVeh.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.Test
{
    /// <summary>
    /// El DataAccessRegistry descubre seeders y configuradores por escaneo: si una clase nueva
    /// no queda registrada (o se registra algo de mas), estos tests lo detectan.
    /// </summary>
    public sealed class DataAccessRegistryTests : IDisposable
    {
        private readonly BaseDatosEnMemoria baseDatos = new();

        public void Dispose() => baseDatos.Dispose();

        private static IEnumerable<Type> Implementaciones<T>() => typeof(DataAccessRegistry).Assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && typeof(T).IsAssignableFrom(t));

        [Fact]
        public void Seeders_SeRegistranTodosLosDelEnsamblado()
        {
            var registrados = baseDatos.Get<IEnumerable<IAplicadorSeed>>().Select(s => s.GetType());

            Assert.Equal(Implementaciones<IAplicadorSeed>().OrderBy(t => t.Name), registrados.OrderBy(t => t.Name));
            Assert.Equal(15, registrados.Count());
            Assert.All(registrados, t => Assert.True(t.BaseType.IsGenericType && t.BaseType.GetGenericTypeDefinition() == typeof(SeederBase<>)));
        }

        [Fact]
        public void Configuradores_SeRegistranTodosLosDelEnsambladoSinIncluirAlRaiz()
        {
            var registrados = baseDatos.Get<IEnumerable<IConfiguradorContext>>().Select(c => c.GetType()).ToList();

            Assert.Equal(Implementaciones<IConfiguradorContext>().OrderBy(t => t.Name), registrados.OrderBy(t => t.Name));
            Assert.DoesNotContain(typeof(ConfiguradorSiMaVehContext), registrados);
            Assert.Contains(typeof(ConfiguradorJerarquiaTPT), registrados);
            Assert.Contains(typeof(ConfiguradorRelacionesManyToMany), registrados);
        }

        [Fact]
        public void ResuelveLosServiciosDeDataAccess()
        {
            Assert.IsType<DataSeeder>(baseDatos.Get<IDataSeeder>());
            Assert.IsType<ConfiguradorSiMaVehContext>(baseDatos.Get<IConfiguradorSiMaVehContext>());
            Assert.NotNull(baseDatos.Get<IGenericEntityGetter>());
            Assert.NotNull(baseDatos.Get<IOperadorEntidadesRelacionadas>());
            Assert.NotNull(baseDatos.Get<IRelatedEntityAdder>());
            Assert.NotNull(baseDatos.Get<IRelatedEntityChanger>());
            Assert.NotNull(baseDatos.Get<IRelatedEntityRemover>());
        }

        [Fact]
        public void Repositorio_SeResuelvePorRegistroGenericoAbierto()
        {
            Assert.IsType<Repository<Pais, long>>(baseDatos.Get<IRepository<Pais, long>>());
            Assert.IsType<Repository<Moneda, string>>(baseDatos.Get<IRepository<Moneda, string>>());
        }

        [Fact]
        public void BaseConSeed_CargaLosDatosIniciales()
        {
            using var conSeed = new BaseDatosEnMemoria(conSeed: true);

            Assert.Equal(2, conSeed.Contexto.Paises.Count());
            Assert.Equal("Argentina", conSeed.Contexto.Provincias.Find(1L).Pais.Nombre);
        }
    }
}
