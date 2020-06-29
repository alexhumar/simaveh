using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorMoneda
    /// </summary>
    public class ValidadorMoneda : AbstractValidator<Moneda>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorMoneda()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
        }
    }
}