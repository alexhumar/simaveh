using Lamar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain;
using System;

namespace SiMaVeh.DataAccess.Test.Helpers
{
    /// <summary>
    /// Base de datos EF InMemory aislada (un nombre unico por instancia), con el contenedor real de
    /// Domain + DataAccess. Cada scope es un "request": NuevoScope() permite verificar que los cambios
    /// quedaron persistidos y no solo en el change tracker.
    /// </summary>
    public sealed class BaseDatosEnMemoria : IDisposable
    {
        private readonly Container container;
        private readonly Lamar.IContainer scopePrincipal;

        public BaseDatosEnMemoria(bool conSeed = false)
        {
            var nombre = Guid.NewGuid().ToString();
            container = new Container(x =>
            {
                x.IncludeRegistry<DomainRegistry>();
                x.IncludeRegistry<DataAccessRegistry>();
                x.AddDbContext<SiMaVehContext>(o => o.UseLazyLoadingProxies().UseInMemoryDatabase(nombre));
            });

            scopePrincipal = (Lamar.IContainer)container.CreateScope().ServiceProvider;

            if (conSeed)
            {
                Contexto.Database.EnsureCreated();
            }
        }

        public SiMaVehContext Contexto => scopePrincipal.GetInstance<SiMaVehContext>();

        public T Get<T>() => scopePrincipal.GetInstance<T>();

        /// <summary>
        /// Ejecuta la accion en un scope nuevo (contexto nuevo, sin entidades trackeadas).
        /// </summary>
        public TResult EnNuevoScope<TResult>(Func<IServiceProvider, TResult> accion)
        {
            using var scope = container.CreateScope();
            return accion(scope.ServiceProvider);
        }

        public void Dispose()
        {
            scopePrincipal.Dispose();
            container.Dispose();
        }
    }
}
