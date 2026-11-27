using Lamar;
using SiMaVeh.Api.Contrato;
using SiMaVeh.Api.Contrato.Interfaces;

namespace SiMaVeh.Api
{
    public class ApiRegistry : ServiceRegistry
    {
        public ApiRegistry()
        {
            //Singleton: el contrato se genera una sola vez a partir del modelo EDM y de las rutas registradas.
            For<IGeneradorContratoOpenApi>().Use<GeneradorContratoOpenApi>().Singleton();

            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });
        }
    }
}
