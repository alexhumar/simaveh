using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.Models;
using System;
using System.Linq;
using System.Reflection;

namespace SiMaVeh.Domain.Test.BusinessLogic
{
    public class EntityTypeGetterTests
    {
        private class EntidadDesconocida : DomainMember<long>
        {
        }

        private readonly EntityTypeGetter entityTypeGetter = new();

        public static TheoryData<Type> EntidadesDelModelo => new(typeof(Pais).Assembly.GetTypes()
            .Where(t => t.Namespace == typeof(Pais).Namespace && t.IsClass && EsDomainMember(t, out _))
            .OrderBy(t => t.Name));

        private static bool EsDomainMember(Type tipo, out Type tipoId)
        {
            for (var t = tipo.BaseType; t != null; t = t.BaseType)
            {
                if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(DomainMember<>))
                {
                    tipoId = t.GetGenericArguments()[0];
                    return true;
                }
            }

            tipoId = null;
            return false;
        }

        private string InvocarGenerico(string metodo, Type tipo)
        {
            EsDomainMember(tipo, out var tipoId);
            return (string)typeof(EntityTypeGetter).GetMethod(metodo, BindingFlags.Public | BindingFlags.Instance)
                .MakeGenericMethod(tipo, tipoId)
                .Invoke(entityTypeGetter, null);
        }

        [Theory]
        [MemberData(nameof(EntidadesDelModelo))]
        public void GetCollectionNameAsString_TodaEntidadDelModelo_TieneNombreDeColeccion(Type tipo)
        {
            Assert.False(string.IsNullOrWhiteSpace(InvocarGenerico(nameof(EntityTypeGetter.GetCollectionNameAsString), tipo)));
        }

        [Theory]
        [MemberData(nameof(EntidadesDelModelo))]
        public void GetTypeAsString_DevuelveElNombreDelTipo(Type tipo)
        {
            Assert.Equal(tipo.Name, InvocarGenerico(nameof(EntityTypeGetter.GetTypeAsString), tipo));
        }

        [Fact]
        public void GetCollectionNameAsString_NombresDeColeccion_SonUnicos()
        {
            var nombres = EntidadesDelModelo.Select(t => InvocarGenerico(nameof(EntityTypeGetter.GetCollectionNameAsString), (Type)t.Data)).ToList();

            Assert.Equal(nombres.Count, nombres.Distinct().Count());
        }

        [Fact]
        public void GetCollectionNameAsString_UsaLasConstantesDeEntitySet()
        {
            Assert.Equal(EntitySet.Pais, entityTypeGetter.GetCollectionNameAsString<Pais, long>());
            Assert.Equal("Paises", entityTypeGetter.GetCollectionNameAsString<Pais, long>());
            Assert.Equal("KitsRepuestos", entityTypeGetter.GetCollectionNameAsString<Kit, long>());
            Assert.Equal("Monedas", entityTypeGetter.GetCollectionNameAsString<Moneda, string>());
            Assert.Equal("EquipamientosAirbags", entityTypeGetter.GetCollectionNameAsString<EquipamientoAirbags, string>());
        }

        [Fact]
        public void GetCollectionNameAsString_EntidadNoRegistrada_DevuelveNull()
        {
            Assert.Null(entityTypeGetter.GetCollectionNameAsString<EntidadDesconocida, long>());
        }
    }
}
