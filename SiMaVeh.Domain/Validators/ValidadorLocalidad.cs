using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorLocalidad
    /// </summary>
    public class ValidadorLocalidad : AbstractValidator<Localidad>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorLocalidad()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.CPA)
                .NotNull()
                .NotEqual(string.Empty);
            // RuleFor(x => x.Partido)
            //     .NotNull();
        }
    }
}