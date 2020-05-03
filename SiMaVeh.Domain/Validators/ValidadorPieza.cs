using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorPieza
    /// </summary>
    public class ValidadorPieza : AbstractValidator<Pieza>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorPieza()
        {
            Include(new ValidadorTargetMantenimiento());

            // RuleFor(x => x.UbicacionPieza)
            //     .NotNull();
        }
    }
}