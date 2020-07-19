using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Api.ErrorManagement;
using SiMaVeh.Api.ErrorManagement.Interfaces;
using SiMaVeh.Api.Model;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.Api.Registration.Interfaces;
using SiMaVeh.Api.Utils;
using SiMaVeh.Api.Utils.Interfaces;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Api.Registration
{
    /// <summary>
    /// Registrador de dependencias de controllers
    /// </summary>
    internal class ControllerDependencyRegistrator : IDependencyRegistrator
    {
        /// <summary>
        /// Registro de dependencias en la coleccion de servicios
        /// </summary>
        /// <param name="services"></param>
        public void Register(IServiceCollection services)
        {
            services.AddScoped<IUriParser, UriParser>();
            services.AddScoped<IRelatedEntityGetter, RelatedEntityGetter>();
            services.AddScoped<IRelatedEntityChanger, RelatedEntityChanger>();
            services.AddScoped<IRelatedEntityAdder, RelatedEntityAdder>();
            services.AddScoped<IEntityTypeGetter, EntityTypeGetter>();
            services.AddScoped<IErrorsBuilder, ErrorsBuilder>();
            services.AddScoped<IControllerParameter, ControllerParameter>();
        }
    }
}
