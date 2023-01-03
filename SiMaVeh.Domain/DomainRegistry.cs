using FluentValidation;
using Lamar;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Enums.Parsers;
using SiMaVeh.Domain.Enums.Parsers.Interfaces;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Validators;

namespace SiMaVeh.Domain
{
    /// <summary>
    /// DomainRegistry
    /// </summary>
    public class DomainRegistry : ServiceRegistry
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DomainRegistry()
        {
            For<IEnumParser<TipoAirbagLateral>>().Use<TipoAirbagLateralParser>();

            For<IValidator<Aceite>>().Use<ValidadorAceite>().Transient();
            For<IValidator<Automovil>>().Use<ValidadorAutomovil>().Transient();
            For<IValidator<CategoriaMarca>>().Use<ValidadorCategoriaMarca>().Transient();
            For<IValidator<Direccion>>().Use<ValidadorDireccion>().Transient();
            For<IValidator<EntidadReparadora>>().Use<ValidadorEntidadReparadora>().Transient();
            For<IValidator<EquipamientoAirbags>>().Use<ValidadorEquipamientoAirbags>().Transient();
            For<IValidator<Fluido>>().Use<ValidadorFluido>().Transient();
            For<IValidator<FuenteEnergia>>().Use<ValidadorFuenteEnergia>().Transient();
            For<IValidator<GrupoModelo>>().Use<ValidadorGrupoModelo>().Transient();
            For<IValidator<Kit>>().Use<ValidadorKit>().Transient();
            For<IValidator<Localidad>>().Use<ValidadorLocalidad>().Transient();
            For<IValidator<Mantenimiento>>().Use<ValidadorMantenimiento>().Transient();
            For<IValidator<Marca>>().Use<ValidadorMarca>().Transient();
            For<IValidator<ModeloVehiculo>>().Use<ValidadorModeloVehiculo>().Transient();
            For<IValidator<Moneda>>().Use<ValidadorMoneda>().Transient();
            For<IValidator<Neumatico>>().Use<ValidadorNeumatico>().Transient();
            For<IValidator<Pais>>().Use<ValidadorPais>().Transient();
            For<IValidator<Partido>>().Use<ValidadorPartido>().Transient();
            For<IValidator<PeriodicidadMantenimiento>>().Use<ValidadorPeriodicidadMantenimiento>().Transient();
            For<IValidator<Persona>>().Use<ValidadorPersona>().Transient();
            For<IValidator<Pieza>>().Use<ValidadorPieza>().Transient();
            For<IValidator<PresionNeumatico>>().Use<ValidadorPresionNeumatico>().Transient();
            For<IValidator<Provincia>>().Use<ValidadorProvincia>().Transient();
            For<IValidator<Recambio>>().Use<ValidadorRecambio>().Transient();
            For<IValidator<Reparador>>().Use<ValidadorReparador>().Transient();
            For<IValidator<Repuesto>>().Use<ValidadorRepuesto>().Transient();
            For<IValidator<ServicioReparador>>().Use<ValidadorServicioReparador>().Transient();
            For<IValidator<TargetMantenimiento>>().Use<ValidadorTargetMantenimiento>().Transient();
            For<IValidator<Telefono>>().Use<ValidadorTelefono>().Transient();
            For<IValidator<TipoCambio>>().Use<ValidadorTipoCambio>().Transient();
            For<IValidator<TipoDocumento>>().Use<ValidadorTipoDocumento>().Transient();
            For<IValidator<TipoEntidadReparadora>>().Use<ValidadorTipoEntidadReparadora>().Transient();
            For<IValidator<TipoFuenteEnergia>>().Use<ValidadorTipoFuenteEnergia>().Transient();
            For<IValidator<TipoTelefono>>().Use<ValidadorTipoTelefono>().Transient();
            For<IValidator<UbicacionPieza>>().Use<ValidadorUbicacionPieza>().Transient();
            For<IValidator<Usuario>>().Use<ValidadorUsuario>().Transient();
            For<IValidator<Vehiculo>>().Use<ValidadorVehiculo>().Transient();

            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });
        }
    }
}
