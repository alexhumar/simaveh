using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Query;
using Microsoft.OData.Edm;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model
{
    public class SiMaVehModelBuilder : IModelBuilder
    {
        private readonly IEntityTypeGetter entityTypeGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="entityTypeGetter"></param>
        public SiMaVehModelBuilder(IEntityTypeGetter entityTypeGetter)
        {
            this.entityTypeGetter = entityTypeGetter;
        }

        public IEdmModel GetEdmModel()
        {
            //OrderBy es para que me permita ordenar incluso si estoy accediendo por navigation property
            //El Expand choca bastante con el Page. Si al Page se le pasan parametros, cuando se trata de acceder
            //a un recurso por GET y usando un $expand, da error. Hay que usar el Page sin parametros y en el Action
            //del controller asociado especificar el tamanio de pagina. Page es deseable usarlo ya que habilita a
            //$top y $skip.
            //Para que quede todo masomenos andando, tuve que sacar de los controllers el PageSize, que parece que
            //eso es lo que realmente choca con el expand. Saque eso y anda todo bien, pero no tengo paginacion
            //implicita, sino que la tengo que hacer con $skip y $top. Tampoco funciona si se parametriza a .Page().

            //Las clases abstractas no las declaro mediante EntitySet. Unicamente a las clases derivadas.

            var builder = new ODataConventionModelBuilder();

            builder.EntitySet<Aceite>(entityTypeGetter.GetCollectionNameAsString<Aceite, long>());
            builder.EntityType<Aceite>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<Aceite>().Ignore(a => a.ModeloVehiculoAceite);

            builder.EntitySet<Automovil>(entityTypeGetter.GetCollectionNameAsString<Automovil, long>());
            builder.EntityType<Automovil>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<CategoriaMarca>(entityTypeGetter.GetCollectionNameAsString<CategoriaMarca, long>());
            builder.EntityType<CategoriaMarca>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            //NOTA: para acceder a la propiedad Marcas de CategoriaMarca, la invocacion es: CategoriasMarca([Id])/Marcas,
            //y, debido al Expand, se puede acceder asi: CategoriasMarca([Id])?$expand=Marcas
            builder.EntityType<CategoriaMarca>().Ignore(c => c.MarcaCategoriaMarca);

            builder.EntitySet<Direccion>(entityTypeGetter.GetCollectionNameAsString<Direccion, long>());
            builder.EntityType<Direccion>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<EntidadReparadora>(entityTypeGetter.GetCollectionNameAsString<EntidadReparadora, long>());
            builder.EntityType<EntidadReparadora>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<EntidadReparadora>().Ignore(e => e.ReparadorEntidadReparadora);

            builder.EntitySet<EquipamientoAirbags>(entityTypeGetter.GetCollectionNameAsString<EquipamientoAirbags, string>());
            builder.EntityType<EquipamientoAirbags>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Fluido>(entityTypeGetter.GetCollectionNameAsString<Fluido, long>());
            builder.EntityType<Fluido>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<FuenteEnergia>(entityTypeGetter.GetCollectionNameAsString<FuenteEnergia, long>());
            builder.EntityType<FuenteEnergia>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<FuenteEnergia>().Ignore(f => f.ModeloVehiculoFuenteEnergia);

            builder.EntitySet<GrupoModelo>(entityTypeGetter.GetCollectionNameAsString<GrupoModelo, long>());
            builder.EntityType<GrupoModelo>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Kit>(entityTypeGetter.GetCollectionNameAsString<Kit, long>());
            builder.EntityType<Kit>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Localidad>(entityTypeGetter.GetCollectionNameAsString<Localidad, long>());
            builder.EntityType<Localidad>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Mantenimiento>(entityTypeGetter.GetCollectionNameAsString<Mantenimiento, long>());
            builder.EntityType<Mantenimiento>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Marca>(entityTypeGetter.GetCollectionNameAsString<Marca, long>());
            builder.EntityType<Marca>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<Marca>().Ignore(m => m.MarcaCategoriaMarca);

            builder.EntitySet<ModeloVehiculo>(entityTypeGetter.GetCollectionNameAsString<ModeloVehiculo, long>());
            builder.EntityType<ModeloVehiculo>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<ModeloVehiculo>().Ignore(m => m.ModeloVehiculoRepuesto);
            builder.EntityType<ModeloVehiculo>().Ignore(m => m.ModeloVehiculoPresionNeumatico);
            builder.EntityType<ModeloVehiculo>().Ignore(m => m.ModeloVehiculoFuenteEnergia);
            builder.EntityType<ModeloVehiculo>().Ignore(m => m.ModeloVehiculoAceite);

            builder.EntitySet<Moneda>(entityTypeGetter.GetCollectionNameAsString<Moneda, string>());
            builder.EntityType<Moneda>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Neumatico>(entityTypeGetter.GetCollectionNameAsString<Neumatico, long>());
            builder.EntityType<Neumatico>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Pais>(entityTypeGetter.GetCollectionNameAsString<Pais, long>());
            builder.EntityType<Pais>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Partido>(entityTypeGetter.GetCollectionNameAsString<Partido, long>());
            builder.EntityType<Partido>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<PeriodicidadMantenimiento>(entityTypeGetter.GetCollectionNameAsString<PeriodicidadMantenimiento, long>());
            builder.EntityType<PeriodicidadMantenimiento>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Pieza>(entityTypeGetter.GetCollectionNameAsString<Pieza, long>());
            builder.EntityType<Pieza>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<PresionNeumatico>(entityTypeGetter.GetCollectionNameAsString<PresionNeumatico, long>());
            builder.EntityType<PresionNeumatico>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<PresionNeumatico>().Ignore(p => p.ModeloVehiculoPresionNeumatico);

            builder.EntitySet<Provincia>(entityTypeGetter.GetCollectionNameAsString<Provincia, long>());
            builder.EntityType<Provincia>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntityType<Recambio>()
                .Abstract()
                .Ignore(r => r.KitRepuesto);

            builder.EntitySet<Reparador>(entityTypeGetter.GetCollectionNameAsString<Reparador, long>());
            builder.EntityType<Reparador>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<Reparador>().Ignore(r => r.ReparadorEntidadReparadora);

            builder.EntitySet<Repuesto>(entityTypeGetter.GetCollectionNameAsString<Repuesto, long>());
            builder.EntityType<Repuesto>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<Repuesto>().Ignore(r => r.ModeloVehiculoRepuesto);

            builder.EntitySet<ServicioReparador>(entityTypeGetter.GetCollectionNameAsString<ServicioReparador, long>());
            builder.EntityType<ServicioReparador>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Telefono>(entityTypeGetter.GetCollectionNameAsString<Telefono, long>());
            builder.EntityType<Telefono>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoCambio>(entityTypeGetter.GetCollectionNameAsString<TipoCambio, long>());
            builder.EntityType<TipoCambio>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoDocumento>(entityTypeGetter.GetCollectionNameAsString<TipoDocumento, long>());
            builder.EntityType<TipoDocumento>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoEntidadReparadora>(entityTypeGetter.GetCollectionNameAsString<TipoEntidadReparadora, long>());
            builder.EntityType<TipoEntidadReparadora>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoFuenteEnergia>(entityTypeGetter.GetCollectionNameAsString<TipoFuenteEnergia, long>());
            builder.EntityType<TipoFuenteEnergia>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoTelefono>(entityTypeGetter.GetCollectionNameAsString<TipoTelefono, long>());
            builder.EntityType<TipoTelefono>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<UbicacionPieza>(entityTypeGetter.GetCollectionNameAsString<UbicacionPieza, string>());
            builder.EntityType<UbicacionPieza>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Usuario>(entityTypeGetter.GetCollectionNameAsString<Usuario, long>());
            builder.EntityType<Usuario>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntityType<Vehiculo>()
                .Abstract();

            return builder.GetEdmModel();
        }
    }
}
