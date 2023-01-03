using Lamar;

namespace SiMaVeh.Domain
{
    /// <summary>
    /// DomainRegistry
    /// </summary>
    public class DomainRegistry : ServiceRegistry
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DomainRegistry()
        {
            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });
        }
    }
}
