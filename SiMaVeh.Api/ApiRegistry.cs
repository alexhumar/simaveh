using Lamar;

namespace SiMaVeh.Api
{
    public class ApiRegistry : ServiceRegistry
    {
        public ApiRegistry()
        {
            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });
        }
    }
}
