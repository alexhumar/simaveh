using FluentValidation.AspNetCore;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.Api.Validators;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Helpers;

namespace SiMaVeh
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
            services.AddDbContext<SiMaVehContext>(opt => opt
                .UseLazyLoadingProxies()
                .UseMySql(connection,
                          o => { 
                              o.EnableRetryOnFailure(); //Esto es para reintentar automaticamente comandos fallidos a la BD. Lo habilite a raiz del uso de Migrations.
                              o.MigrationsAssembly(typeof(SiMaVehContext).Assembly.FullName); 
                          })); 
            services.AddScoped<IEntityGetter, EntityGetter>();
            services.AddScoped<IControllerParameter, ControllerParameter>();
            services.AddOData();
            services.AddMvc(options =>
                {
                    // add custom binder to beginning of collection
                    // options.ModelBinderProviders.Insert(0, new ProvinciaEntityBinderProvider());

                    //TODO: Esto es para habilitar el soporte legacy para IRouter. Habria que ver como reemplazarlo!
                    options.EnableEndpointRouting = false;
                })
                .AddFluentValidation();

            ValidatorRegistrator.RegisterValidators(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapODataServiceRoute("odata", "simaveh", MyModelBuilder.getEdmModel());
                //Work-around for issue #1175
                routeBuilder.EnableDependencyInjection();
            });

            //Esto es para que se actualice la BD mediante migrations cuando arranca la Api. No es lo ideal,
            //pero como no es un modelo grande, esta bien.
            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                scope.ServiceProvider.GetService<SiMaVehContext>().Database.Migrate();
            }
        }
    }
}
