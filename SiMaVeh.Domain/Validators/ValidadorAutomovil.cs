using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorAutomovil
    /// </summary>
    public class ValidadorAutomovil : AbstractValidator<Automovil>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorAutomovil()
        {
            Include(new ValidadorVehiculo());

            //El resto de las properties son nullables
            RuleFor(x => x.NumeroChasis)
                .NotNull()
                .NotEqual(string.Empty);
            //TODO: mejorar esta validacion
            RuleFor(x => x.Patente)
                .NotNull()
                .NotEqual(string.Empty);
        }
    }
}