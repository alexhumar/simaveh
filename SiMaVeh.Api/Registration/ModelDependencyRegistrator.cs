using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.Api.Registration.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.DataAccess.Model.Interfaces;

namespace SiMaVeh.Api.Registration
{
    /// <summary>
    /// Registrador de dependencias de model
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
            services.AddScoped<IConfiguradorSiMaVehContext, ConfiguradorSiMaVehContext>();
            services.AddScoped<IRecuperadorConfiguradoresContext, RecuperadorConfiguradoresContext>();
        }
    }
}
