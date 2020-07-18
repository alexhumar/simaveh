using SiMaVeh.Api.Registration.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Api.Registration
{
    internal class SiMaVehDependencyRegistratorBuilder : ISiMaVehDependencyRegistratorBuilder
    {
        /// <summary>
        /// Retorna el registrator de dependencias SiMaVeh
        /// </summary>
        /// <returns></returns>
        public IDependencyRegistrator BuildRegistrator()
        {
            var innerRegistrators = new List<IDependencyRegistrator>
            {
                new ModelDependencyRegistrator(),
                new ControllerDependencyRegistrator(),
                new DataSeedDependencyRegistrator(),
                new ValidatorDependencyRegistrator()
            };

            return new SiMaVehDependencyRegistrator(innerRegistrators);
        }
    }
}
