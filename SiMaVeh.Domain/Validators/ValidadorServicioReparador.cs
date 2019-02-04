
using FluentValidation;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorServicioReparador
    /// </summary>
    public class ValidadorServicioReparador : AbstractValidator<ServicioReparador>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorServicioReparador()
        {
            //No se valida el monto del servicio reparador
            // RuleFor(x => x.EntidadReparadora)
            //     .NotNull();
            RuleFor(x => x.FechaInicio)
                .NotNull()
                .LessThanOrEqualTo(y => y.FechaFin);
            RuleFor(x => x.FechaFin)
                .NotNull()
                .GreaterThanOrEqualTo(y => y.FechaInicio);
            RuleFor(x => x.KilometrajeVehiculo)
                .GreaterThan(0);
            // RuleFor(x => x.MonedaMontoManoObra)
            //     .NotNull();
            // RuleFor(x => x.Vehiculo)
            //     .NotNull();
        }
    }
}