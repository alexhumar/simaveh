using FluentValidation.AspNetCore;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.DataAccess;
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
            var config = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<SiMaVehContext>(opt => opt
                .UseLazyLoadingProxies()
                .UseMySql(config));
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
        }
    }
}
