using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.Api.Registration.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Model.Interfaces;

namespace SiMaVeh.Api.Registration
{
    /// <summary>
    /// /// <summary>
    /// Registrador de dependencias de model
    /// </summary>
    /// </summary>
    internal class ModelDependencyRegistrator : IDependencyRegistrator
    {
        /// <summary>
        /// Registro de dependencias en la coleccion de servicios
        /// </summary>
        /// <param name="services"></param>
        public void Register(IServiceCollection services)
        {
            services.AddScoped<IModelBuilder, SiMaVehModelBuilder>();
        }
    }
}
