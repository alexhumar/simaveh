using Microsoft.Extensions.DependencyInjection;

namespace SiMaVeh.Api.Registration.Interfaces
{
    /// <summary>
    /// Interfaz de registrador de dependencias
    /// </summary>
    internal interface IDependencyRegistrator
    {
        /// <summary>
        /// Registro de dependencias en la coleccion de servicios
        /// </summary>
        /// <param name="services"></param>
        void Register(IServiceCollection services);
    }
}
