namespace SiMaVeh.Api.Registration.Interfaces
{
    internal interface ISiMaVehDependencyRegistratorBuilder
    {
        /// <summary>
        /// Retorna el registrator de dependencias SiMaVeh
        /// </summary>
        /// <returns></returns>
        IDependencyRegistrator BuildRegistrator();
    }
}
