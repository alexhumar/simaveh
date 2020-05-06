using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorUbicacionPieza
    /// </summary>
    public class ValidadorUbicacionPieza : AbstractValidator<UbicacionPieza>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorUbicacionPieza()
        {
            RuleFor(x => x.Izquierda)
                .NotNull();
            RuleFor(x => x.Superior)
                .NotNull();
        }
    }
}