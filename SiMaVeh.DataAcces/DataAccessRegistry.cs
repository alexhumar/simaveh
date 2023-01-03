using Lamar;
using SiMaVeh.DataAccess.DataSeed.Seeders;
using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.DataAccess.Model.Relations;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess
{
    public class DataAccessRegistry : ServiceRegistry
    {
        public DataAccessRegistry()
        {
            For<IModelBuilder>().Use<SiMaVehModelBuilder>();

            For<IDomainSeeder<Pais, long>>().Use<PaisSeeder>();
            For<IDomainSeeder<Provincia, long>>().Use<ProvinciaSeeder>();
            For<IDomainSeeder<Partido, long>>().Use<PartidoSeeder>();
            For<IDomainSeeder<Localidad, long>>().Use<LocalidadSeeder>();
            For<IDomainSeeder<TipoEntidadReparadora, long>>().Use<TipoEntidadReparadoraSeeder>();
            For<IDomainSeeder<TipoFuenteEnergia, long>>().Use<TipoFuenteEnergiaSeeder>();
            For<IDomainSeeder<TipoDocumento, long>>().Use<TipoDocumentoSeeder>();
            For<IDomainSeeder<TipoTelefono, long>>().Use<TipoTelefonoSeeder>();
            For<IDomainSeeder<UbicacionPieza, string>>().Use<UbicacionPiezaSeeder>();
            For<IDomainSeeder<EquipamientoAirbags, string>>().Use<EquipamientoAirbagsSeeder>();
            For<IDomainSeeder<Moneda, string>>().Use<MonedaSeeder>();
            For<IDomainSeeder<CategoriaMarca, long>>().Use<CategoriaMarcaSeeder>();
            For<IDomainSeeder<Marca, long>>().Use<MarcaSeeder>();
            For<ISeeder<MarcaCategoriaMarca>>().Use<MarcaCategoriaMarcaSeeder>();
            For<IDomainSeeder<FuenteEnergia, long>>().Use<FuenteEnergiaSeeder>();

            //Para inyectar repositorios hay que registrar cada uno de los tipos del modelo.
            //For<IRepository<Localidad, long>>().Use<Repository<Localidad, long>>();

            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });
        }
    }
}
