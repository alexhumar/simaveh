using Lamar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain;

namespace SiMaVeh.DataAccess.Test.Helpers
{
    /// <summary>
    /// Modelo de EF construido con el proveedor real (Pomelo MySQL) sin conectarse a ninguna base:
    /// permite verificar tablas, claves y datos de seed tal como se generan las migraciones.
    /// Se comparte entre los tests de una clase mediante IClassFixture.
    /// </summary>
    public sealed class ModeloMySql : System.IDisposable
    {
        private readonly Container container;
        private readonly System.IServiceProvider scope;

        public ModeloMySql()
        {
            container = new Container(x =>
            {
                x.IncludeRegistry<DomainRegistry>();
                x.IncludeRegistry<DataAccessRegistry>();
                x.AddDbContext<SiMaVehContext>(o => o.UseLazyLoadingProxies()
                    .UseMySql("server=localhost;database=simaveh", ServerVersion.Parse("10.11.0-mariadb")));
            });
            scope = container.CreateScope().ServiceProvider;
            //El modelo de diseno conserva los datos de seed (el de runtime, optimizado para lectura, no).
            Model = scope.GetRequiredService<SiMaVehContext>().GetService<IDesignTimeModel>().Model;
        }

        public IModel Model { get; }

        public T Get<T>() => scope.GetRequiredService<T>();

        public void Dispose() => container.Dispose();
    }
}
