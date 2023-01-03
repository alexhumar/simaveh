using Lamar;

namespace SiMaVeh.DataAccess
{
    public class DataAccessRegistry : ServiceRegistry
    {
        public DataAccessRegistry()
        {
            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });
        }
    }
}
