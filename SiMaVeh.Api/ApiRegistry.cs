using Lamar;
using SiMaVeh.Api.Model;
using SiMaVeh.Api.Model.Interfaces;

namespace SiMaVeh.Api
{
    public class ApiRegistry : ServiceRegistry
    {
        public ApiRegistry()
        {
            For<IODataModelBuilder>().Use<SiMaVehODataModelBuilder>();

            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });
        }
    }
}
