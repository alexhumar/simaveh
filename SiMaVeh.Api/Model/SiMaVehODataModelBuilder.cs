using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Api.Model
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="entityTypeGetter"></param>
    public class SiMaVehODataModelBuilder(IEntityTypeGetter entityTypeGetter) : IODataModelBuilder
    {
        private readonly IEntityTypeGetter entityTypeGetter = entityTypeGetter;

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

            Registrar<Aceite, long>(builder, conExpand: false);
            Registrar<Automovil, long>(builder);

            //NOTA: para acceder a la propiedad Marcas de CategoriaMarca, la invocacion es: CategoriasMarca([Id])/Marcas,
            //y, debido al Expand, se puede acceder asi: CategoriasMarca([Id])?$expand=Marcas
            Registrar<CategoriaMarca, long>(builder);
            Registrar<Direccion, long>(builder);
            Registrar<EntidadReparadora, long>(builder);
            Registrar<EquipamientoAirbags, string>(builder, conExpand: false);
            Registrar<Fluido, long>(builder, conExpand: false);
            Registrar<FuenteEnergia, long>(builder);
            Registrar<GrupoModelo, long>(builder);
            Registrar<Kit, long>(builder);
            Registrar<Localidad, long>(builder);
            Registrar<Mantenimiento, long>(builder);
            Registrar<Marca, long>(builder);
            Registrar<ModeloVehiculo, long>(builder);
            Registrar<Moneda, string>(builder, conExpand: false);
            Registrar<Neumatico, long>(builder);
            Registrar<Pais, long>(builder);
            Registrar<Partido, long>(builder);
            Registrar<PeriodicidadMantenimiento, long>(builder);
            Registrar<Pieza, long>(builder);
            Registrar<PresionNeumatico, long>(builder);
            Registrar<Provincia, long>(builder);

            builder.EntityType<Recambio>()
                .Abstract();

            Registrar<Reparador, long>(builder);
            Registrar<Repuesto, long>(builder);
            Registrar<ServicioReparador, long>(builder);
            Registrar<Telefono, long>(builder);
            Registrar<TipoCambio, long>(builder);
            Registrar<TipoDocumento, long>(builder, conExpand: false);
            Registrar<TipoEntidadReparadora, long>(builder, conExpand: false);
            Registrar<TipoFuenteEnergia, long>(builder, conExpand: false);
            Registrar<TipoTelefono, long>(builder, conExpand: false);
            Registrar<UbicacionPieza, string>(builder, conExpand: false);
            Registrar<Usuario, long>(builder);

            builder.EntityType<Vehiculo>()
                .Abstract();

            return builder.GetEdmModel();
        }

        /// <summary>
        /// Declara el EntitySet de la entidad y habilita las opciones de consulta comunes
        /// ($count, $filter, $orderby, paginado y $select, mas $expand cuando corresponde).
        /// </summary>
        /// <typeparam name="TBe"></typeparam>
        /// <typeparam name="TBeId"></typeparam>
        /// <param name="builder"></param>
        /// <param name="conExpand">Si se habilita $expand (hasta ODataQueryConstants.MaxDepthNav niveles)</param>
        private void Registrar<TBe, TBeId>(ODataConventionModelBuilder builder, bool conExpand = true) where TBe : DomainMember<TBeId>
        {
            builder.EntitySet<TBe>(entityTypeGetter.GetCollectionNameAsString<TBe, TBeId>());

            var entityType = builder.EntityType<TBe>()
                .Count()
                .Filter()
                .OrderBy()
                .Page()
                .Select();

            if (conExpand)
            {
                entityType.Expand(ODataQueryConstants.MaxDepthNav);
            }
        }
    }
}
