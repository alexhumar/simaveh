using FluentValidation.AspNetCore;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess;
using SiMaVeh.Helpers;
using SiMaVeh.Parametrization;
using Microsoft.Extensions.Hosting;

namespace SiMaVehNetCore
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
