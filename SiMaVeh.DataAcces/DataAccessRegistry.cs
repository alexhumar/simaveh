using Lamar;
using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.DataAccess.Repository;

namespace SiMaVeh.DataAccess
{
    public class DataAccessRegistry : ServiceRegistry
    {
        public DataAccessRegistry()
        {
            //Registro generico abierto: resuelve IRepository<TBe, TBeId> para cualquier entidad del modelo.
            For(typeof(IRepository<,>)).Use(typeof(Repository<,>));

            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();

                //Seeders y configuradores del contexto se descubren automaticamente:
                //alcanza con crear la clase para que se aplique.
                s.AddAllTypesOf<IAplicadorSeed>();
                s.AddAllTypesOf<IConfiguradorContext>();
            });
        }
    }
}
