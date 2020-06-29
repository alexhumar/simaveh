using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.BusinessLogic.Entities
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
            { typeof(Aceite).Name, EntitySet.Aceite },
            { typeof(Automovil).Name, EntitySet.Automovil },
            { typeof(CategoriaMarca).Name, EntitySet.CategoriaMarca },
            { typeof(Direccion).Name, EntitySet.Direccion },
            { typeof(EntidadReparadora).Name, EntitySet.EntidadReparadora },
            { typeof(EquipamientoAirbags).Name, EntitySet.EquipamientoAirbag },
            { typeof(Fluido).Name, EntitySet.Fluido },
            { typeof(FuenteEnergia).Name, EntitySet.FuenteEnergia },
            { typeof(GrupoModelo).Name, EntitySet.GrupoModelo },
            { typeof(Kit).Name, EntitySet.Kit },
            { typeof(Localidad).Name, EntitySet.Localidad },
            { typeof(Mantenimiento).Name, EntitySet.Mantenimiento },
            { typeof(Marca).Name, EntitySet.Marca },
            { typeof(ModeloVehiculo).Name, EntitySet.ModeloVehiculo },
            { typeof(Moneda).Name, EntitySet.Moneda },
            { typeof(Neumatico).Name, EntitySet.Neumatico },
            { typeof(Pais).Name, EntitySet.Pais },
            { typeof(Partido).Name, EntitySet.Partido },
            { typeof(PeriodicidadMantenimiento).Name, EntitySet.PeriodicidadMantenimiento },
            { typeof(Persona).Name, EntitySet.Persona },
            { typeof(Pieza).Name, EntitySet.Pieza },
            { typeof(PresionNeumatico).Name, EntitySet.PresionNeumatico },
            { typeof(Provincia).Name, EntitySet.Provincia },
            { typeof(Recambio).Name, EntitySet.Recambio },
            { typeof(Reparador).Name, EntitySet.Reparador },
            { typeof(Repuesto).Name, EntitySet.Repuesto },
            { typeof(ServicioReparador).Name, EntitySet.ServicioReparador },
            { typeof(TargetMantenimiento).Name, EntitySet.TargetMantenimiento },
            { typeof(Telefono).Name, EntitySet.Telefono },
            { typeof(TipoCambio).Name, EntitySet.TipoCambio },
            { typeof(TipoDocumento).Name, EntitySet.TipoDocumento },
            { typeof(TipoEntidadReparadora).Name, EntitySet.TipoEntidadReparadora },
            { typeof(TipoFuenteEnergia).Name, EntitySet.TipoFuenteEnergia },
            { typeof(TipoTelefono).Name, EntitySet.TipoTelefono },
            { typeof(UbicacionPieza).Name, EntitySet.UbicacionPieza },
            { typeof(Usuario).Name, EntitySet.Usuario },
            { typeof(Vehiculo).Name, EntitySet.Vehiculo }
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