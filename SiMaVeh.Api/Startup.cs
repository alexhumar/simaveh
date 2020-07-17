using FluentValidation.AspNetCore;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Registration;
using SiMaVeh.DataAccess.Model;

namespace SiMaVeh.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("DefaultConnection");
            services
                .AddDbContext<SiMaVehContext>(options => options
                    .UseLazyLoadingProxies()
                    .UseMySql(connection,
                              mySqlOptions =>
                              {
                                  //Esto es para reintentar automaticamente comandos fallidos a la BD. Lo habilite a raiz del uso de Migrations.
                                  mySqlOptions.EnableRetryOnFailure();
                                  mySqlOptions.MigrationsAssembly(typeof(SiMaVehContext).Assembly.FullName);
                              })
                );

            services.AddControllers(mvcOptions =>
            {
                // add custom binder to beginning of collection
                // options.ModelBinderProviders.Insert(0, new ProvinciaEntityBinderProvider());

                //TODO: Esto es para habilitar el soporte legacy para IRouter. Habria que ver como reemplazarlo!
                mvcOptions.EnableEndpointRouting = false;
            }).AddFluentValidation();

            services.AddOData();

            SiMaVehDIRegistrator.RegisterDI(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapODataServiceRoute("odata", UriConstants.PrefijoRutaOData, SiMaVehModelBuilder.GetEdmModel());
                //Work-around for issue #1175
                routeBuilder.EnableDependencyInjection();
            });

            //Esto es para que se actualice la BD mediante migrations cuando arranca la Api. No es lo ideal,
            //pero como no es un modelo grande, esta bien.
            using var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var siMaVehContext = scope.ServiceProvider.GetService<SiMaVehContext>();
            siMaVehContext.Database.Migrate();
        }
    }
}
