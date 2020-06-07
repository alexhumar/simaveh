using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorMantenimiento
    /// </summary>
    public class ValidadorMantenimiento : AbstractValidator<Mantenimiento>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorMantenimiento()
        {
            // RuleFor(x => x.MonedaMontoRecambio)
            //     .NotNull();
            RuleFor(x => x.Accion)
                .NotNull()
                .IsInEnum();
            RuleFor(x => x.MontoRecambio)
                .GreaterThanOrEqualTo(0);
            // RuleFor(x => x.Recambio)
            //     .NotNull();
            // RuleFor(x => x.Reparador)
            //     .NotNull();
            // RuleFor(x => x.ServicioReparador)
            //     .NotNull();
        }
    }
}