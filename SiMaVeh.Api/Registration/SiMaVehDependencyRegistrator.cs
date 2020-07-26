using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.Api.Registration.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Api.Registration
{
    /// <summary>
    /// Registrador de dependencias SiMaVeh
    /// </summary>
    internal class SiMaVehDependencyRegistrator : IDependencyRegistrator
    {
        private readonly IEnumerable<IDependencyRegistrator> registrators;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="registrators"></param>
        public SiMaVehDependencyRegistrator(IEnumerable<IDependencyRegistrator> registrators)
        {
            this.registrators = registrators;
        }

        /// <summary>
        /// Registro de dependencias en la coleccion de servicios
        /// </summary>
        /// <param name="services"></param>
        public void Register(IServiceCollection services)
        {
            foreach (var registrator in registrators)
            {
                registrator.Register(services);
            }
        }
    }
}
