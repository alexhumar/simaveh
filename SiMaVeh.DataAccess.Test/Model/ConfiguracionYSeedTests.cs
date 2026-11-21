using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.DataAccess.DataSeed.Seeders;
using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.Test.Model
{
    /// <summary>
    /// Tests unitarios (con dobles) de los componentes que arman el modelo: DataSeeder, SeederBase
    /// y ConfiguradorSiMaVehContext.
    /// </summary>
    public class ConfiguracionYSeedTests
    {
        private class Registro : IAplicadorSeed, IConfiguradorContext
        {
            public List<ModelBuilder> Invocaciones { get; } = [];

            public void Aplicar(ModelBuilder builder) => Invocaciones.Add(builder);

            public void Configurar(ModelBuilder builder) => Invocaciones.Add(builder);
        }

        public class EntidadPrueba
        {
            public long Id { get; set; }

            public string Nombre { get; set; }
        }

        private class SeederPrueba : SeederBase<EntidadPrueba>
        {
            public override IEnumerable<object> GetSeeds() => [new { Id = 1L, Nombre = "Uno" }, new { Id = 2L, Nombre = "Dos" }];
        }

        [Fact]
        public void DataSeeder_AplicaTodosLosSeedersSobreElMismoBuilder()
        {
            var seeders = new[] { new Registro(), new Registro(), new Registro() };
            var builder = new ModelBuilder();

            new DataSeeder(seeders).SeedData(builder);

            Assert.All(seeders, s => Assert.Same(builder, Assert.Single(s.Invocaciones)));
        }

        [Fact]
        public void DataSeeder_SinSeeders_NoFalla()
        {
            new DataSeeder([]).SeedData(new ModelBuilder());
        }

        [Fact]
        public void ConfiguradorSiMaVehContext_AplicaTodosLosConfiguradores()
        {
            var configuradores = new[] { new Registro(), new Registro() };
            var builder = new ModelBuilder();

            new ConfiguradorSiMaVehContext(configuradores).Configurar(builder);

            Assert.All(configuradores, c => Assert.Same(builder, Assert.Single(c.Invocaciones)));
        }

        [Fact]
        public void SeederBase_Aplicar_RegistraLosSeedsEnLaEntidad()
        {
            var builder = new ModelBuilder();
            builder.Entity<EntidadPrueba>().HasKey(e => e.Id);
            builder.Entity<EntidadPrueba>().Property(e => e.Nombre);

            new SeederPrueba().Aplicar(builder);

            var seeds = builder.Model.FindEntityType(typeof(EntidadPrueba)).GetSeedData().ToList();
            Assert.Equal(2, seeds.Count);
            Assert.Equal(["Uno", "Dos"], seeds.Select(s => (string)s[nameof(EntidadPrueba.Nombre)]));
        }
    }
}
