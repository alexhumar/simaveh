using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Query;
using Microsoft.OData.Edm;
using SiMaVeh.Api.Constants;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess
{
    public class MyModelBuilder
    {
        public static IEdmModel getEdmModel()
        {
            var builder = new ODataConventionModelBuilder();

            // var products = builder.EntitySet<Product>("Products");
            // var categories = builder.EntitySet<Category>("Categories");

            // products.EntityType
            //         .Count()
            //         .Filter()
            //         .Expand(1, new string[] { "Category" })
            //         .Page(5, 2)
            //         .OrderBy(new string[] { "ID", "Name" });

            // categories.EntityType
            //         .Count()
            //         .Filter()
            //         .Expand(1, new string[] { "Products" })
            //         .Page(5, 2)
            //         .OrderBy(new string[] { "ID", "Name" });

            //Aceites
            builder.EntitySet<Aceite>(EntityTypeGetter<Aceite, long>.GetCollectionNameAsString());
            builder.EntityType<Aceite>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();
            //OrderBy es para que me permita ordenar incluso si estoy accediendo por navigation property
            //El Expand choca bastante con el Page. Si al Page se le pasan parametros, cuando se trata de acceder
            //a un recurso por GET y usando un $expand, da error. Hay que usar el Page sin parametros y en el Action
            //del controller asociado especificar el tamanio de pagina. Page es deseable usarlo ya que habilita a
            //$top y $skip.
            //Para que quede todo masomenos andando, tuve que sacar de los controllers el PageSize, que parece que
            //eso es lo que realmente choca con el expand. Saque eso y anda todo bien, pero no tengo paginacion
            //implicita, sino que la tengo que hacer con $skip y $top. Tampoco funciona si se parametriza a .Page().

            //Automoviles
            builder.EntitySet<Automovil>(EntityTypeGetter<Automovil, long>.GetCollectionNameAsString());
            builder.EntityType<Automovil>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Direcciones
            builder.EntitySet<Direccion>(EntityTypeGetter<Direccion, long>.GetCollectionNameAsString());
            builder.EntityType<Direccion>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Entidades Reparadoras
            builder.EntitySet<EntidadReparadora>(EntityTypeGetter<EntidadReparadora, long>.GetCollectionNameAsString());
            builder.EntityType<EntidadReparadora>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Equipamientos Airbags
            builder.EntitySet<EquipamientoAirbags>(EntityTypeGetter<EquipamientoAirbags, long>.GetCollectionNameAsString());
            builder.EntityType<EquipamientoAirbags>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Fluidos
            builder.EntitySet<Fluido>(EntityTypeGetter<Fluido, long>.GetCollectionNameAsString());
            builder.EntityType<Fluido>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Fuentes Energia
            builder.EntitySet<FuenteEnergia>(EntityTypeGetter<FuenteEnergia, long>.GetCollectionNameAsString());
            builder.EntityType<FuenteEnergia>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Grupos Modelo
            builder.EntitySet<GrupoModelo>(EntityTypeGetter<GrupoModelo, long>.GetCollectionNameAsString());
            builder.EntityType<GrupoModelo>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Kits
            builder.EntitySet<Kit>(EntityTypeGetter<Kit, long>.GetCollectionNameAsString());
            builder.EntityType<Kit>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Localidades
            builder.EntitySet<Localidad>(EntityTypeGetter<Localidad, long>.GetCollectionNameAsString());
            builder.EntityType<Localidad>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Mantenimientos
            builder.EntitySet<Mantenimiento>(EntityTypeGetter<Mantenimiento, long>.GetCollectionNameAsString());
            builder.EntityType<Mantenimiento>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Marcas
            builder.EntitySet<Marca>(EntityTypeGetter<Marca, long>.GetCollectionNameAsString());
            builder.EntityType<Marca>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Modelos Vehiculo
            builder.EntitySet<ModeloVehiculo>(EntityTypeGetter<ModeloVehiculo, long>.GetCollectionNameAsString());
            builder.EntityType<ModeloVehiculo>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Monedas
            builder.EntitySet<Moneda>(EntityTypeGetter<Moneda, long>.GetCollectionNameAsString());
            builder.EntityType<Moneda>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Neumaticos
            builder.EntitySet<Neumatico>(EntityTypeGetter<Neumatico, long>.GetCollectionNameAsString());
            builder.EntityType<Neumatico>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Paises
            builder.EntitySet<Pais>(EntityTypeGetter<Pais, long>.GetCollectionNameAsString());
            builder.EntityType<Pais>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Partidos
            builder.EntitySet<Partido>(EntityTypeGetter<Partido, long>.GetCollectionNameAsString());
            builder.EntityType<Partido>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Periodicidades Mantenimiento
            builder.EntitySet<PeriodicidadMantenimiento>(EntityTypeGetter<PeriodicidadMantenimiento, long>.GetCollectionNameAsString());
            builder.EntityType<PeriodicidadMantenimiento>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //builder.EntitySet<Persona>(EntityTypeGetter<Persona, long>.GetCollectionNameAsString());

            //Piezas
            builder.EntitySet<Pieza>(EntityTypeGetter<Pieza, long>.GetCollectionNameAsString());
            builder.EntityType<Pieza>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Presiones Neumatico
            builder.EntitySet<PresionNeumatico>(EntityTypeGetter<PresionNeumatico, long>.GetCollectionNameAsString());
            builder.EntityType<PresionNeumatico>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Provincias
            builder.EntitySet<Provincia>(EntityTypeGetter<Provincia, long>.GetCollectionNameAsString());
            builder.EntityType<Provincia>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //builder.EntitySet<Recambio>(EntityTypeGetter<Recambio, long>.GetCollectionNameAsString());

            //Reparadores
            builder.EntitySet<Reparador>(EntityTypeGetter<Reparador, long>.GetCollectionNameAsString());
            builder.EntityType<Reparador>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Repuestos
            builder.EntitySet<Repuesto>(EntityTypeGetter<Repuesto, long>.GetCollectionNameAsString());
            builder.EntityType<Repuesto>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Servicios Reparadores
            builder.EntitySet<ServicioReparador>(EntityTypeGetter<ServicioReparador, long>.GetCollectionNameAsString());
            builder.EntityType<ServicioReparador>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //builder.EntitySet<TargetMantenimiento>(EntityTypeGetter<TargetMantenimiento, long>.GetCollectionNameAsString());

            //Telefonos
            builder.EntitySet<Telefono>(EntityTypeGetter<Telefono, long>.GetCollectionNameAsString());
            builder.EntityType<Telefono>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Tipos Cambio
            builder.EntitySet<TipoCambio>(EntityTypeGetter<TipoCambio, long>.GetCollectionNameAsString());
            builder.EntityType<TipoCambio>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Tipos Documento
            builder.EntitySet<TipoDocumento>(EntityTypeGetter<TipoDocumento, long>.GetCollectionNameAsString());
            builder.EntityType<TipoDocumento>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Tipos Entidad Reparadora
            builder.EntitySet<TipoEntidadReparadora>(EntityTypeGetter<TipoEntidadReparadora, long>.GetCollectionNameAsString());
            builder.EntityType<TipoEntidadReparadora>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Tipos Fuente Energia
            builder.EntitySet<TipoFuenteEnergia>(EntityTypeGetter<TipoFuenteEnergia, long>.GetCollectionNameAsString());
            builder.EntityType<TipoFuenteEnergia>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Tipos Telefono
            builder.EntitySet<TipoTelefono>(EntityTypeGetter<TipoTelefono, long>.GetCollectionNameAsString());
            builder.EntityType<TipoTelefono>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Ubicaciones Pieza
            builder.EntitySet<UbicacionPieza>(EntityTypeGetter<UbicacionPieza, string>.GetCollectionNameAsString());
            builder.EntityType<UbicacionPieza>()
                .Count(QueryOptionSetting.Allowed)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //Usuarios
            builder.EntitySet<Usuario>(EntityTypeGetter<Usuario, long>.GetCollectionNameAsString());
            builder.EntityType<Usuario>()
                .Count(QueryOptionSetting.Allowed)
                .Expand(QueryConstants.MaxDepthNav)
                .Filter()
                .OrderBy(QueryOptionSetting.Allowed)
                .Page()
                .Select();

            //builder.EntitySet<Vehiculo>(EntityTypeGetter<Vehiculo, long>.GetCollectionNameAsString());

            builder.EntitySet<Vehiculo>("Vehiculos").EntityType.Abstract();

            var model = builder.GetEdmModel();

            return model;
        }
    }
}
