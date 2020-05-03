using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Helpers
{
    /// <summary>
    /// EntityTypeGetter
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    public static class EntityTypeGetter<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        private static readonly IDictionary<string, string> colecciones = new Dictionary<string, string>()
        {
            { typeof(Aceite).Name, CollectionConstants.Aceite },
            { typeof(Automovil).Name, CollectionConstants.Automovil },
            { typeof(Direccion).Name, CollectionConstants.Direccion },
            { typeof(EntidadReparadora).Name, CollectionConstants.EntidadReparadora },
            { typeof(EquipamientoAirbags).Name, CollectionConstants.EquipamientoAirbag },
            { typeof(Fluido).Name, CollectionConstants.Fluido },
            { typeof(FuenteEnergia).Name, CollectionConstants.FuenteEnergia },
            { typeof(GrupoModelo).Name, CollectionConstants.GrupoModelo },
            { typeof(Kit).Name, CollectionConstants.Kit },
            { typeof(Localidad).Name, CollectionConstants.Localidad },
            { typeof(Mantenimiento).Name, CollectionConstants.Mantenimiento },
            { typeof(Marca).Name, CollectionConstants.Marca },
            { typeof(ModeloVehiculo).Name, CollectionConstants.ModeloVehiculo },
            { typeof(Moneda).Name, CollectionConstants.Moneda },
            { typeof(Neumatico).Name, CollectionConstants.Neumatico },
            { typeof(Pais).Name, CollectionConstants.Pais },
            { typeof(Partido).Name, CollectionConstants.Partido },
            { typeof(PeriodicidadMantenimiento).Name, CollectionConstants.PeriodicidadMantenimiento },
            { typeof(Persona).Name, CollectionConstants.Persona },
            { typeof(Pieza).Name, CollectionConstants.Pieza },
            { typeof(PresionNeumatico).Name, CollectionConstants.PresionNeumatico },
            { typeof(Provincia).Name, CollectionConstants.Provincia },
            { typeof(Recambio).Name, CollectionConstants.Recambio },
            { typeof(Reparador).Name, CollectionConstants.Reparador },
            { typeof(Repuesto).Name, CollectionConstants.Repuesto },
            { typeof(ServicioReparador).Name, CollectionConstants.ServicioReparador },
            { typeof(TargetMantenimiento).Name, CollectionConstants.TargetMantenimiento },
            { typeof(Telefono).Name, CollectionConstants.Telefono },
            { typeof(TipoCambio).Name, CollectionConstants.TipoCambio },
            { typeof(TipoDocumento).Name, CollectionConstants.TipoDocumento },
            { typeof(TipoEntidadReparadora).Name, CollectionConstants.TipoEntidadReparadora },
            { typeof(TipoFuenteEnergia).Name, CollectionConstants.TipoFuenteEnergia },
            { typeof(TipoTelefono).Name, CollectionConstants.TipoTelefono },
            { typeof(UbicacionPieza).Name, CollectionConstants.UbicacionPieza },
            { typeof(Usuario).Name, CollectionConstants.Usuario },
            { typeof(Vehiculo).Name, CollectionConstants.Vehiculo }
        };

        /// <summary>
        /// GetTypeAsString
        /// </summary>
        /// <returns></returns>
        public static string GetTypeAsString()
        {
            return typeof(TBe).Name;
        }

        /// <summary>
        /// GetCollectionNameAsString
        /// </summary>
        /// <returns></returns>
        public static string GetCollectionNameAsString()
        {
            colecciones.TryGetValue(typeof(TBe).Name, out string collectionName);

            return collectionName;
        }
    }
}