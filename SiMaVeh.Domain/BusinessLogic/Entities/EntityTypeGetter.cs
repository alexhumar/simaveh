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
            { typeof(Aceite).Name, Entity.Aceite },
            { typeof(Automovil).Name, Entity.Automovil },
            { typeof(Direccion).Name, Entity.Direccion },
            { typeof(EntidadReparadora).Name, Entity.EntidadReparadora },
            { typeof(EquipamientoAirbags).Name, Entity.EquipamientoAirbag },
            { typeof(Fluido).Name, Entity.Fluido },
            { typeof(FuenteEnergia).Name, Entity.FuenteEnergia },
            { typeof(GrupoModelo).Name, Entity.GrupoModelo },
            { typeof(Kit).Name, Entity.Kit },
            { typeof(Localidad).Name, Entity.Localidad },
            { typeof(Mantenimiento).Name, Entity.Mantenimiento },
            { typeof(Marca).Name, Entity.Marca },
            { typeof(ModeloVehiculo).Name, Entity.ModeloVehiculo },
            { typeof(Moneda).Name, Entity.Moneda },
            { typeof(Neumatico).Name, Entity.Neumatico },
            { typeof(Pais).Name, Entity.Pais },
            { typeof(Partido).Name, Entity.Partido },
            { typeof(PeriodicidadMantenimiento).Name, Entity.PeriodicidadMantenimiento },
            { typeof(Persona).Name, Entity.Persona },
            { typeof(Pieza).Name, Entity.Pieza },
            { typeof(PresionNeumatico).Name, Entity.PresionNeumatico },
            { typeof(Provincia).Name, Entity.Provincia },
            { typeof(Recambio).Name, Entity.Recambio },
            { typeof(Reparador).Name, Entity.Reparador },
            { typeof(Repuesto).Name, Entity.Repuesto },
            { typeof(ServicioReparador).Name, Entity.ServicioReparador },
            { typeof(TargetMantenimiento).Name, Entity.TargetMantenimiento },
            { typeof(Telefono).Name, Entity.Telefono },
            { typeof(TipoCambio).Name, Entity.TipoCambio },
            { typeof(TipoDocumento).Name, Entity.TipoDocumento },
            { typeof(TipoEntidadReparadora).Name, Entity.TipoEntidadReparadora },
            { typeof(TipoFuenteEnergia).Name, Entity.TipoFuenteEnergia },
            { typeof(TipoTelefono).Name, Entity.TipoTelefono },
            { typeof(UbicacionPieza).Name, Entity.UbicacionPieza },
            { typeof(Usuario).Name, Entity.Usuario },
            { typeof(Vehiculo).Name, Entity.Vehiculo }
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