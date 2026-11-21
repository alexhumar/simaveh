using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Repository;
using SiMaVeh.DataAccess.Test.Helpers;
using SiMaVeh.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Test.Repository
{
    public sealed class RepositoryTests : IDisposable
    {
        private readonly BaseDatosEnMemoria baseDatos = new();
        private readonly IRepository<TipoTelefono, long> repository;

        public RepositoryTests()
        {
            repository = baseDatos.Get<IRepository<TipoTelefono, long>>();
        }

        public void Dispose() => baseDatos.Dispose();

        private TipoTelefono LeerEnNuevoScope(long id) =>
            baseDatos.EnNuevoScope(sp => sp.GetRequiredService<SiMaVehContext>().TiposTelefono.Find(id));

        private static TipoTelefono Nuevo(long id, string nombre = null) => new() { Id = id, Nombre = nombre ?? $"Tipo {id}", Descripcion = "Descripcion" };

        [Fact]
        public void Contenedor_ResuelveElRepositorioGenerico()
        {
            Assert.IsType<Repository<TipoTelefono, long>>(repository);
        }

        [Fact]
        public async Task AddAsync_PersisteLaEntidad()
        {
            var afectados = await repository.AddAsync(Nuevo(1, "Celular"));

            Assert.Equal(1, afectados);
            Assert.Equal("Celular", LeerEnNuevoScope(1).Nombre);
        }

        [Fact]
        public async Task FindAsync_EntidadExistente_LaDevuelve()
        {
            await repository.AddAsync(Nuevo(1, "Celular"));

            var encontrada = await repository.FindAsync(1);

            Assert.NotNull(encontrada);
            Assert.Equal("Celular", encontrada.Nombre);
        }

        [Fact]
        public async Task FindAsync_EntidadInexistente_DevuelveNull()
        {
            Assert.Null(await repository.FindAsync(999));
        }

        [Fact]
        public async Task FindAsync_ClaveString_FuncionaConEntidadesDeClaveTexto()
        {
            var monedas = baseDatos.Get<IRepository<Moneda, string>>();
            await monedas.AddAsync(new Moneda { Id = "USD", Nombre = "Dolar" });

            Assert.Equal("Dolar", (await monedas.FindAsync("USD")).Nombre);
            Assert.Null(await monedas.FindAsync("EUR"));
        }

        [Fact]
        public async Task GetQueryable_DevuelveTodasLasEntidadesYPermiteFiltrar()
        {
            await repository.AddAsync(Nuevo(1, "Celular"));
            await repository.AddAsync(Nuevo(2, "Fijo"));

            var queryable = repository.GetQueryable();

            Assert.Equal(2, queryable.Count());
            Assert.Equal("Fijo", queryable.Single(t => t.Nombre.StartsWith("F")).Nombre);
        }

        [Fact]
        public async Task RemoveAsync_EliminaLaEntidad()
        {
            await repository.AddAsync(Nuevo(1));
            var entidad = await repository.FindAsync(1);

            var afectados = await repository.RemoveAsync(entidad);

            Assert.Equal(1, afectados);
            Assert.Null(LeerEnNuevoScope(1));
        }

        [Fact]
        public async Task UpdateAsync_EntidadExistente_ActualizaSusValores()
        {
            await repository.AddAsync(Nuevo(1, "Celular"));

            //Instancia desconectada, como la que llega en el body de un PUT.
            var afectados = await repository.UpdateAsync(new TipoTelefono { Id = 1, Nombre = "Movil", Descripcion = "Nueva" });

            Assert.Equal(1, afectados);
            var leida = LeerEnNuevoScope(1);
            Assert.Equal("Movil", leida.Nombre);
            Assert.Equal("Nueva", leida.Descripcion);
        }

        [Fact]
        public async Task UpdateAsync_EntidadInexistente_NoHaceNada()
        {
            var afectados = await repository.UpdateAsync(Nuevo(5));

            Assert.Equal(0, afectados);
            Assert.Null(LeerEnNuevoScope(5));
        }

        [Fact]
        public async Task SaveChangesAsync_PersisteLosCambiosPendientes()
        {
            await repository.AddAsync(Nuevo(1, "Celular"));
            var entidad = await repository.FindAsync(1);
            entidad.Nombre = "Modificado";

            var afectados = await repository.SaveChangesAsync();

            Assert.Equal(1, afectados);
            Assert.Equal("Modificado", LeerEnNuevoScope(1).Nombre);
        }
    }
}
