using Lamar;
using SiMaVeh.Api.Model;
using SiMaVeh.Api.Model.Interfaces;

namespace SiMaVeh.Api
{
    public class ApiRegistry : ServiceRegistry
    {
        public ApiRegistry()
        {
            For<IODataModelBuilder>().Use<SiMaVehModelBuilder>();

            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });
        }
    }
}
