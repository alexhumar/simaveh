using FluentValidation.AspNetCore;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Extensions;
using SiMaVeh.Api.Registration;
using SiMaVeh.Api.Registration.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.Domain.BusinessLogic.Entities;

namespace SiMaVeh.Api
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        private readonly IModelBuilder modelBuilder;
        private readonly ISiMaVehDependencyRegistratorBuilder siMaVehDependencyRegistratorBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
            modelBuilder = new SiMaVehModelBuilder(new EntityTypeGetter());
            siMaVehDependencyRegistratorBuilder = new SiMaVehDependencyRegistratorBuilder();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            siMaVehDependencyRegistratorBuilder.BuildRegistrator().Register(services);

            var connection = configuration.GetConnectionString("DefaultConnection");
            services
                .AddDbContext<SiMaVehContext>(options => options
                    .UseLazyLoadingProxies()
                    .UseMySql(connection,
                              ServerVersion.AutoDetect(connection),
                              mySqlOptions =>
                              {
                                  //Esto es para reintentar automaticamente comandos fallidos a la BD. Lo habilite a raiz del uso de Migrations.
                                  mySqlOptions.EnableRetryOnFailure().MigrationsAssembly(typeof(SiMaVehContext).Assembly.FullName);
                              })
                );

            services.AddControllers(mvcOptions =>
            {
                // add custom binder to beginning of collection
                // options.ModelBinderProviders.Insert(0, new ProvinciaEntityBinderProvider());

                //TODO: Esto es para habilitar el soporte legacy para IRouter. Habria que ver como reemplazarlo!
                mvcOptions.EnableEndpointRouting = false;
            });

            services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

            services.AddOData();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //Las excepciones se manejan mediante la clase ResponseExceptionFilter
                //app.UseDeveloperExceptionPage();
            }

            app.ConfigureCustomExceptionMiddleware();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapODataServiceRoute("odata", UriConstants.PrefijoRutaOData, modelBuilder.GetEdmModel());
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
