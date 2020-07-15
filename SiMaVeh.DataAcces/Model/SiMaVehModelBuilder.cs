using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Query;
using Microsoft.OData.Edm;
using SiMaVeh.DataAccess.Constants;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model
{
    public class SiMaVehModelBuilder
    {
        public static IEdmModel GetEdmModel()
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

            builder.EntitySet<Aceite>(EntityTypeGetter<Aceite, long>.GetCollectionNameAsString());
            builder.EntityType<Aceite>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Automovil>(EntityTypeGetter<Automovil, long>.GetCollectionNameAsString());
            builder.EntityType<Automovil>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<CategoriaMarca>(EntityTypeGetter<CategoriaMarca, long>.GetCollectionNameAsString());
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

            builder.EntitySet<Direccion>(EntityTypeGetter<Direccion, long>.GetCollectionNameAsString());
            builder.EntityType<Direccion>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<EntidadReparadora>(EntityTypeGetter<EntidadReparadora, long>.GetCollectionNameAsString());
            builder.EntityType<EntidadReparadora>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<EntidadReparadora>().Ignore(e => e.ReparadorEntidadReparadora);

            builder.EntitySet<EquipamientoAirbags>(EntityTypeGetter<EquipamientoAirbags, string>.GetCollectionNameAsString());
            builder.EntityType<EquipamientoAirbags>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Fluido>(EntityTypeGetter<Fluido, long>.GetCollectionNameAsString());
            builder.EntityType<Fluido>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<FuenteEnergia>(EntityTypeGetter<FuenteEnergia, long>.GetCollectionNameAsString());
            builder.EntityType<FuenteEnergia>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<GrupoModelo>(EntityTypeGetter<GrupoModelo, long>.GetCollectionNameAsString());
            builder.EntityType<GrupoModelo>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Kit>(EntityTypeGetter<Kit, long>.GetCollectionNameAsString());
            builder.EntityType<Kit>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Localidad>(EntityTypeGetter<Localidad, long>.GetCollectionNameAsString());
            builder.EntityType<Localidad>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Mantenimiento>(EntityTypeGetter<Mantenimiento, long>.GetCollectionNameAsString());
            builder.EntityType<Mantenimiento>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Marca>(EntityTypeGetter<Marca, long>.GetCollectionNameAsString());
            builder.EntityType<Marca>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<Marca>().Ignore(m => m.MarcaCategoriaMarca);

            builder.EntitySet<ModeloVehiculo>(EntityTypeGetter<ModeloVehiculo, long>.GetCollectionNameAsString());
            builder.EntityType<ModeloVehiculo>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Moneda>(EntityTypeGetter<Moneda, string>.GetCollectionNameAsString());
            builder.EntityType<Moneda>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Neumatico>(EntityTypeGetter<Neumatico, long>.GetCollectionNameAsString());
            builder.EntityType<Neumatico>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Pais>(EntityTypeGetter<Pais, long>.GetCollectionNameAsString());
            builder.EntityType<Pais>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Partido>(EntityTypeGetter<Partido, long>.GetCollectionNameAsString());
            builder.EntityType<Partido>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<PeriodicidadMantenimiento>(EntityTypeGetter<PeriodicidadMantenimiento, long>.GetCollectionNameAsString());
            builder.EntityType<PeriodicidadMantenimiento>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Pieza>(EntityTypeGetter<Pieza, long>.GetCollectionNameAsString());
            builder.EntityType<Pieza>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<PresionNeumatico>(EntityTypeGetter<PresionNeumatico, long>.GetCollectionNameAsString());
            builder.EntityType<PresionNeumatico>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Provincia>(EntityTypeGetter<Provincia, long>.GetCollectionNameAsString());
            builder.EntityType<Provincia>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntityType<Recambio>()
                .Abstract()
                .Ignore(r => r.KitRepuesto);

            builder.EntitySet<Reparador>(EntityTypeGetter<Reparador, long>.GetCollectionNameAsString());
            builder.EntityType<Reparador>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            builder.EntityType<Reparador>().Ignore(r => r.ReparadorEntidadReparadora);

            builder.EntitySet<Repuesto>(EntityTypeGetter<Repuesto, long>.GetCollectionNameAsString());
            builder.EntityType<Repuesto>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<ServicioReparador>(EntityTypeGetter<ServicioReparador, long>.GetCollectionNameAsString());
            builder.EntityType<ServicioReparador>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Telefono>(EntityTypeGetter<Telefono, long>.GetCollectionNameAsString());
            builder.EntityType<Telefono>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoCambio>(EntityTypeGetter<TipoCambio, long>.GetCollectionNameAsString());
            builder.EntityType<TipoCambio>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoDocumento>(EntityTypeGetter<TipoDocumento, long>.GetCollectionNameAsString());
            builder.EntityType<TipoDocumento>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoEntidadReparadora>(EntityTypeGetter<TipoEntidadReparadora, long>.GetCollectionNameAsString());
            builder.EntityType<TipoEntidadReparadora>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoFuenteEnergia>(EntityTypeGetter<TipoFuenteEnergia, long>.GetCollectionNameAsString());
            builder.EntityType<TipoFuenteEnergia>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<TipoTelefono>(EntityTypeGetter<TipoTelefono, long>.GetCollectionNameAsString());
            builder.EntityType<TipoTelefono>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<UbicacionPieza>(EntityTypeGetter<UbicacionPieza, string>.GetCollectionNameAsString());
            builder.EntityType<UbicacionPieza>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            builder.EntitySet<Usuario>(EntityTypeGetter<Usuario, long>.GetCollectionNameAsString());
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
