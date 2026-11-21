using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SiMaVeh.DataAccess.Model.Relations;
using SiMaVeh.DataAccess.Test.Helpers;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Moneda.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.Interfaces;
using M = SiMaVeh.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.Test.Model
{
    /// <summary>
    /// Modelo de EF tal como lo ve el proveedor real (MySQL): tablas, claves, relaciones y datos de seed.
    /// </summary>
    public class ModeloEfTests(ModeloMySql modelo) : IClassFixture<ModeloMySql>
    {
        private readonly IModel model = modelo.Model;

        private IEntityType Entidad(Type tipo) => model.FindEntityType(tipo) ?? throw new InvalidOperationException($"{tipo.Name} no esta en el modelo");

        private IReadOnlyList<IDictionary<string, object>> Seeds<T>() => Entidad(typeof(T)).GetSeedData().ToList();

        public static TheoryData<Type, string> TablasTPT => new()
        {
            { typeof(M.Vehiculo), "Vehiculos" },
            { typeof(M.Automovil), "Automoviles" },
            { typeof(M.TargetMantenimiento), "TargetsMantenimiento" },
            { typeof(M.Pieza), "Piezas" },
            { typeof(M.Fluido), "Fluidos" },
            { typeof(M.Aceite), "Aceites" },
            { typeof(M.Persona), "Personas" },
            { typeof(M.Reparador), "Reparadores" },
            { typeof(M.Usuario), "Usuarios" },
            { typeof(M.Recambio), "Recambios" },
            { typeof(M.Kit), "Kits" },
            { typeof(M.Repuesto), "Repuestos" },
        };

        [Theory]
        [MemberData(nameof(TablasTPT))]
        public void JerarquiasTPT_CadaTipoTieneSuTabla(Type tipo, string tabla)
        {
            Assert.Equal(tabla, Entidad(tipo).GetTableName());
        }

        [Fact]
        public void JerarquiasTPT_NoUsanDiscriminador()
        {
            Assert.Null(Entidad(typeof(M.Persona)).FindDiscriminatorProperty());
            Assert.Null(Entidad(typeof(M.Vehiculo)).FindDiscriminatorProperty());
        }

        [Theory]
        [InlineData(typeof(M.EquipamientoAirbags))]
        [InlineData(typeof(M.UbicacionPieza))]
        public void EntidadesConIdCalculado_NoGeneranElIdEnLaBase(Type tipo)
        {
            Assert.Equal(ValueGenerated.Never, Entidad(tipo).FindPrimaryKey().Properties.Single().ValueGenerated);
        }

        [Theory]
        [InlineData(typeof(M.Pais))]
        [InlineData(typeof(M.Mantenimiento))]
        public void EntidadesConIdNumerico_GeneranElIdEnLaBase(Type tipo)
        {
            Assert.Equal(ValueGenerated.OnAdd, Entidad(tipo).FindPrimaryKey().Properties.Single().ValueGenerated);
        }

        public static TheoryData<Type, string, string> RelacionesManyToMany => new()
        {
            { typeof(KitRepuesto), nameof(KitRepuesto.KitId), nameof(KitRepuesto.RepuestoId) },
            { typeof(MarcaCategoriaMarca), nameof(MarcaCategoriaMarca.MarcaId), nameof(MarcaCategoriaMarca.CategoriaMarcaId) },
            { typeof(ModeloVehiculoAceite), nameof(ModeloVehiculoAceite.ModeloVehiculoId), nameof(ModeloVehiculoAceite.AceiteId) },
            { typeof(ModeloVehiculoFuenteEnergia), nameof(ModeloVehiculoFuenteEnergia.ModeloVehiculoId), nameof(ModeloVehiculoFuenteEnergia.FuenteEnergiaId) },
            { typeof(ModeloVehiculoPresionNeumatico), nameof(ModeloVehiculoPresionNeumatico.ModeloVehiculoId), nameof(ModeloVehiculoPresionNeumatico.PresionNeumaticoId) },
            { typeof(ModeloVehiculoRepuesto), nameof(ModeloVehiculoRepuesto.ModeloVehiculoId), nameof(ModeloVehiculoRepuesto.RepuestoId) },
            { typeof(ReparadorEntidadReparadora), nameof(ReparadorEntidadReparadora.ReparadorId), nameof(ReparadorEntidadReparadora.EntidadReparadoraId) },
        };

        [Theory]
        [MemberData(nameof(RelacionesManyToMany))]
        public void RelacionesManyToMany_UsanSuEntidadIntermediaConClaveCompuesta(Type intermedia, string fk1, string fk2)
        {
            var entidad = Entidad(intermedia);

            Assert.Equal(new[] { fk1, fk2 }.OrderBy(p => p), entidad.FindPrimaryKey().Properties.Select(p => p.Name).OrderBy(p => p));
            Assert.Equal(2, entidad.GetForeignKeys().Count());
        }

        [Fact]
        public void Modelo_IncluyeTodasLasEntidadesDelDominio()
        {
            var entidades = typeof(M.Pais).Assembly.GetTypes()
                .Where(t => t.Namespace == typeof(M.Pais).Namespace && t.IsClass && !t.IsNested && !t.IsGenericTypeDefinition && t.GetProperty("Id") != null);

            Assert.All(entidades, t => Assert.NotNull(model.FindEntityType(t)));
        }

        #region Seed

        [Fact]
        public void Seed_CantidadDeRegistros_CoincideConLosFixtures()
        {
            Assert.Equal(modelo.Get<IFixturePais>().GetPaises().Count(), Seeds<M.Pais>().Count);
            Assert.Equal(modelo.Get<IFixtureProvincia>().GetProvincias().Values.Sum(p => p.Count), Seeds<M.Provincia>().Count);
            Assert.Equal(modelo.Get<IFixturePartido>().GetPartidos().Values.Sum(p => p.Count), Seeds<M.Partido>().Count);
            Assert.Equal(modelo.Get<IFixtureLocalidad>().GetLocalidades().Values.Sum(l => l.Count), Seeds<M.Localidad>().Count);
            Assert.Equal(modelo.Get<IFixtureCategoriaMarca>().GetCategoriasMarca().Count(), Seeds<M.CategoriaMarca>().Count);
            Assert.Equal(modelo.Get<IFixtureMarca>().GetMarcas().Count(), Seeds<M.Marca>().Count);
            Assert.Equal(modelo.Get<IFixtureMarca>().GetMarcas().Sum(m => m.Categorias.Count), Seeds<MarcaCategoriaMarca>().Count);
            Assert.Equal(modelo.Get<IFixtureFuenteEnergia>().GetFuentesEnergia().Count(), Seeds<M.FuenteEnergia>().Count);
            Assert.Equal(modelo.Get<IFixtureMoneda>().GetMonedas().Count(), Seeds<M.Moneda>().Count);
            Assert.Equal(modelo.Get<IFixtureEquipamientoAirbags>().GetEquipamientosAirbags().Count(), Seeds<M.EquipamientoAirbags>().Count);
            Assert.Equal(modelo.Get<IFixtureUbicacionPieza>().GetUbicacionesPieza().Count(), Seeds<M.UbicacionPieza>().Count);
            Assert.Equal(modelo.Get<IFixtureTipoDocumento>().GetTiposDocumento().Count(), Seeds<M.TipoDocumento>().Count);
            Assert.Equal(modelo.Get<IFixtureTipoEntidadReparadora>().GetTiposEntidadReparadora().Count(), Seeds<M.TipoEntidadReparadora>().Count);
            Assert.Equal(modelo.Get<IFixtureTipoFuenteEnergia>().GetTiposFuenteEnergia().Count(), Seeds<M.TipoFuenteEnergia>().Count);
            Assert.Equal(modelo.Get<IFixtureTipoTelefono>().GetTiposTelefono().Count(), Seeds<M.TipoTelefono>().Count);
        }

        [Fact]
        public void Seed_DivisionesTerritoriales_IncluyenLaClaveForaneaDeSuPadre()
        {
            var paises = Seeds<M.Pais>().Select(s => s["Id"]).ToHashSet();
            var provincias = Seeds<M.Provincia>();
            var partidos = Seeds<M.Partido>();
            var localidades = Seeds<M.Localidad>();

            Assert.All(provincias, p => Assert.Contains(p["PaisId"], paises));
            var idsProvincias = provincias.Select(p => p["Id"]).ToHashSet();
            Assert.All(partidos, p => Assert.Contains(p["ProvinciaId"], idsProvincias));
            var idsPartidos = partidos.Select(p => p["Id"]).ToHashSet();
            Assert.All(localidades, l => Assert.Contains(l["PartidoId"], idsPartidos));
        }

        [Fact]
        public void Seed_Localidades_SeCarganConCPAVacio()
        {
            Assert.All(Seeds<M.Localidad>(), l => Assert.Equal(string.Empty, l["CPA"]));
        }

        [Fact]
        public void Seed_FuentesEnergiaYMarcasCategorias_ReferencianRegistrosSembrados()
        {
            var marcas = Seeds<M.Marca>().Select(s => s["Id"]).ToHashSet();
            var categorias = Seeds<M.CategoriaMarca>().Select(s => s["Id"]).ToHashSet();
            var tipos = Seeds<M.TipoFuenteEnergia>().Select(s => s["Id"]).ToHashSet();

            Assert.All(Seeds<M.FuenteEnergia>(), f =>
            {
                Assert.Contains(f["MarcaId"], marcas);
                Assert.Contains(f["TipoFuenteEnergiaId"], tipos);
            });
            Assert.All(Seeds<MarcaCategoriaMarca>(), mc =>
            {
                Assert.Contains(mc["MarcaId"], marcas);
                Assert.Contains(mc["CategoriaMarcaId"], categorias);
            });
        }

        #endregion
    }
}
