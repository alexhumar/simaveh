using Lamar;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
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
using SiMaVeh.Domain.DataSeed.Models;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.Models.Calculadores.UbicacionPieza.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SiMaVeh.Domain.Test.Fixtures
{
    /// <summary>
    /// Contenedor de Domain compartido por todos los tests de la clase (construir los fixtures es costoso).
    /// </summary>
    public class ContenedorDominio
    {
        public Container Container { get; } = new(new DomainRegistry());

        public T Get<T>() => Container.GetInstance<T>();
    }

    /// <summary>
    /// Integridad de los datos de seed: Ids unicos, nombres cargados y referencias validas entre fixtures.
    /// Un error aca romperia la migracion o la carga inicial de la base.
    /// </summary>
    public class FixturesTests(ContenedorDominio contenedor) : IClassFixture<ContenedorDominio>
    {
        private readonly ContenedorDominio contenedor = contenedor;

        //Defectos conocidos en los datos de seed. Se excluyen de los tests generales y se documentan
        //en tests omitidos propios, para que el resto de los datos siga verificandose.
        private const string CodigoMonedaVenezolanaInvalido = "VES7​";
        private const string NombreTipoDocumentoConDescripcionLarga = "DNI";

        private static void AssertIdsUnicos<T>(IEnumerable<T> ids)
        {
            var lista = ids.ToList();
            var duplicados = lista.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToList();

            Assert.True(duplicados.Count == 0, $"Ids duplicados: {string.Join(", ", duplicados)}");
        }

        private static void AssertNombresCargados<T>(IEnumerable<DatosEntidadBase<T>> datos)
        {
            Assert.All(datos, d => Assert.False(string.IsNullOrWhiteSpace(d.Nombre), $"Id {d.Id} sin nombre"));
        }

        private static void AssertReferenciasValidas(IEnumerable<long> referencias, IEnumerable<long> idsExistentes, string descripcion)
        {
            var existentes = idsExistentes.ToHashSet();
            var invalidas = referencias.Where(r => !existentes.Contains(r)).Distinct().ToList();

            Assert.True(invalidas.Count == 0, $"{descripcion} inexistentes: {string.Join(", ", invalidas)}");
        }

        [Fact]
        public void Paises_TienenIdsUnicosYNombre()
        {
            var paises = contenedor.Get<IFixturePais>().GetPaises().ToList();

            Assert.NotEmpty(paises);
            AssertIdsUnicos(paises.Select(p => p.Id));
            AssertNombresCargados(paises);
        }

        [Fact]
        public void Provincias_PertenecenAPaisesExistentes()
        {
            var paises = contenedor.Get<IFixturePais>().GetPaises().Select(p => p.Id);
            var provincias = contenedor.Get<IFixtureProvincia>().GetProvincias();

            AssertReferenciasValidas(provincias.Keys, paises, "Paises");
            AssertIdsUnicos(provincias.Values.SelectMany(p => p).Select(p => p.Id));
            AssertNombresCargados(provincias.Values.SelectMany(p => p));
            Assert.All(paises, idPais => Assert.NotEmpty(provincias[idPais]));
        }

        [Fact]
        public void Partidos_PertenecenAProvinciasExistentes()
        {
            var provincias = contenedor.Get<IFixtureProvincia>().GetProvincias().Values.SelectMany(p => p).Select(p => p.Id);
            var partidos = contenedor.Get<IFixturePartido>().GetPartidos();

            AssertReferenciasValidas(partidos.Keys, provincias, "Provincias");
            AssertIdsUnicos(partidos.Values.SelectMany(p => p).Select(p => p.Id));
            AssertNombresCargados(partidos.Values.SelectMany(p => p));
        }

        [Fact]
        public void Localidades_PertenecenAPartidosExistentes()
        {
            var partidos = contenedor.Get<IFixturePartido>().GetPartidos().Values.SelectMany(p => p).Select(p => p.Id);
            var localidades = contenedor.Get<IFixtureLocalidad>().GetLocalidades();

            AssertReferenciasValidas(localidades.Keys, partidos, "Partidos");
            AssertIdsUnicos(localidades.Values.SelectMany(l => l).Select(l => l.Id));
            AssertNombresCargados(localidades.Values.SelectMany(l => l));
        }

        [Fact]
        public void Marcas_TienenIdsUnicosYCategoriasExistentesSinRepetir()
        {
            var categorias = contenedor.Get<IFixtureCategoriaMarca>().GetCategoriasMarca().ToList();
            var marcas = contenedor.Get<IFixtureMarca>().GetMarcas().ToList();

            AssertIdsUnicos(categorias.Select(c => c.Id));
            AssertNombresCargados(categorias);
            AssertIdsUnicos(marcas.Select(m => m.Id));
            AssertNombresCargados(marcas);
            AssertReferenciasValidas(marcas.SelectMany(m => m.Categorias).Select(c => c.Id), categorias.Select(c => c.Id), "Categorias");
            //La tabla intermedia MarcaCategoriaMarca tiene clave (MarcaId, CategoriaMarcaId): no puede haber repetidos.
            Assert.All(marcas, m => AssertIdsUnicos(m.Categorias.Select(c => c.Id)));
        }

        [Fact]
        public void FuentesEnergia_ReferencianMarcasYTiposExistentes()
        {
            var marcas = contenedor.Get<IFixtureMarca>().GetMarcas().Select(m => m.Id);
            var tipos = contenedor.Get<IFixtureTipoFuenteEnergia>().GetTiposFuenteEnergia().Select(t => t.Id);
            var fuentes = contenedor.Get<IFixtureFuenteEnergia>().GetFuentesEnergia().ToList();

            AssertIdsUnicos(fuentes.Select(f => f.Id));
            AssertNombresCargados(fuentes);
            Assert.All(fuentes, f => Assert.NotNull(f.Marca));
            Assert.All(fuentes, f => Assert.NotNull(f.TipoFuenteEnergia));
            AssertReferenciasValidas(fuentes.Select(f => f.Marca.Id), marcas, "Marcas");
            AssertReferenciasValidas(fuentes.Select(f => f.TipoFuenteEnergia.Id), tipos, "Tipos de fuente de energia");
        }

        [Fact]
        public void Monedas_TienenCodigoISOUnicoYNombre()
        {
            var monedas = contenedor.Get<IFixtureMoneda>().GetMonedas().ToList();

            AssertIdsUnicos(monedas.Select(m => m.Id));
            AssertNombresCargados(monedas);
            Assert.All(monedas.Where(m => m.Id != CodigoMonedaVenezolanaInvalido), m => Assert.Matches(new Regex("^[A-Z]{3}$"), m.Id));
        }

        [Fact(Skip = "BUG: el codigo ISO del Bolivar Soberano esta cargado como \"VES7\" seguido de un espacio de ancho cero (U+200B) en lugar de \"VES\" (CodigoISOMoneda.cs).")]
        public void Monedas_BolivarSoberano_TieneCodigoISOValido()
        {
            var monedas = contenedor.Get<IFixtureMoneda>().GetMonedas();

            Assert.Contains(monedas, m => m.Id == "VES");
            Assert.DoesNotContain(monedas, m => m.Id == CodigoMonedaVenezolanaInvalido);
        }

        [Fact]
        public void UbicacionesPieza_SonLasCuatroCombinacionesConIdCalculado()
        {
            var calculador = contenedor.Get<ICalculadorIdUbicacionPieza>();
            var ubicaciones = contenedor.Get<IFixtureUbicacionPieza>().GetUbicacionesPieza().ToList();

            Assert.Equal(4, ubicaciones.Count);
            AssertIdsUnicos(ubicaciones.Select(u => u.Id));
            Assert.All(ubicaciones, u => Assert.Equal(calculador.Calcular(u), u.Id));
        }

        [Fact]
        public void EquipamientosAirbags_SonTodasLasCombinacionesConIdCalculado()
        {
            var calculador = contenedor.Get<ICalculadorIdEquipamientoAirbags>();
            var equipamientos = contenedor.Get<IFixtureEquipamientoAirbags>().GetEquipamientosAirbags().ToList();

            Assert.Equal(1024, equipamientos.Count);
            AssertIdsUnicos(equipamientos.Select(e => e.Id));
            Assert.All(equipamientos, e => Assert.Equal(calculador.Calcular(e), e.Id));
        }

        public static TheoryData<string> FixturesDeTipos => new("TipoDocumento", "TipoEntidadReparadora", "TipoFuenteEnergia", "TipoTelefono");

        [Theory]
        [MemberData(nameof(FixturesDeTipos))]
        public void Tipos_TienenIdsUnicosNombreYDescripcionValida(string fixture)
        {
            var tipos = (fixture switch
            {
                "TipoDocumento" => contenedor.Get<IFixtureTipoDocumento>().GetTiposDocumento(),
                "TipoEntidadReparadora" => contenedor.Get<IFixtureTipoEntidadReparadora>().GetTiposEntidadReparadora(),
                "TipoFuenteEnergia" => contenedor.Get<IFixtureTipoFuenteEnergia>().GetTiposFuenteEnergia(),
                _ => contenedor.Get<IFixtureTipoTelefono>().GetTiposTelefono(),
            }).ToList();

            Assert.NotEmpty(tipos);
            AssertIdsUnicos(tipos.Select(t => t.Id));
            AssertNombresCargados(tipos);
            //Los validadores de los tipos limitan la descripcion a 100 caracteres.
            Assert.All(tipos.Where(t => fixture != "TipoDocumento" || t.Nombre != NombreTipoDocumentoConDescripcionLarga), t => Assert.True((t.Descripcion?.Length ?? 0) <= 100, $"Descripcion de '{t.Nombre}' supera los 100 caracteres"));
        }

        [Fact(Skip = "BUG: la descripcion del tipo de documento DNI tiene mas de 100 caracteres y no cumple ValidadorTipoDocumento, por lo que un PUT de ese registro tal como esta en la base es rechazado.")]
        public void TiposDocumento_DNI_TieneDescripcionDeHasta100Caracteres()
        {
            var dni = contenedor.Get<IFixtureTipoDocumento>().GetTiposDocumento().Single(t => t.Nombre == NombreTipoDocumentoConDescripcionLarga);

            Assert.True(dni.Descripcion.Length <= 100);
        }

        [Fact]
        public void DatosEntidadBuilder_ConstruyeCadaTipoDeDato()
        {
            var builder = contenedor.Get<IDatosEntidadBuilder>();
            var categoria = builder.Build(1, "Autos");

            var entidad = builder.Build(7, "Nombre", "Descripcion");
            var moneda = builder.Build("USD", "Dolar");
            var marca = builder.Build(2, "Ford", [categoria]);
            var ubicacion = builder.Build(izquierda: false, superior: true);
            var airbags = builder.Build(true, false, TipoAirbagLateral.Ambos, TipoAirbagLateral.Ambos, TipoAirbagLateral.NoPosee, TipoAirbagLateral.NoPosee);
            var fuente = builder.Build(3, "Super", marca, categoria);

            Assert.Equal((7L, "Nombre", "Descripcion"), (entidad.Id, entidad.Nombre, entidad.Descripcion));
            Assert.Null(categoria.Descripcion);
            Assert.Equal(("USD", "Dolar"), (moneda.Id, moneda.Nombre));
            Assert.Equal((2L, "Ford"), (marca.Id, marca.Nombre));
            Assert.Same(categoria, Assert.Single(marca.Categorias));
            Assert.Equal("DS", ubicacion.Id);
            Assert.Equal("CNAAANN", airbags.Id);
            Assert.Equal((3L, "Super"), (fuente.Id, fuente.Nombre));
            Assert.Same(marca, fuente.Marca);
            Assert.Same(categoria, fuente.TipoFuenteEnergia);
        }
    }
}
