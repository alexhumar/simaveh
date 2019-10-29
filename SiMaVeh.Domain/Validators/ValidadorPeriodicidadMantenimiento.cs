
using FluentValidation;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorPeriodicidadMantenimiento
    /// </summary>
    public class ValidadorPeriodicidadMantenimiento : AbstractValidator<PeriodicidadMantenimiento>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorPeriodicidadMantenimiento()
        {
            RuleFor(x => x.Anios)
                .GreaterThan(0);
            RuleFor(x => x.Dias)
                .GreaterThan(0);
            RuleFor(x => x.Kilometros)
                .GreaterThan(0);
            RuleFor(x => x.Meses)
                .GreaterThan(0);
            // RuleFor(x => x.ModeloVehiculo)
            //     .NotNull();
            // RuleFor(x => x.TargetMantenimiento)
            //     .NotNull();
        }
    }
}