
using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorTargetMantenimiento
    /// </summary>
    public class ValidadorTargetMantenimiento : AbstractValidator<TargetMantenimiento>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorTargetMantenimiento()
        {
            RuleFor(x => x.Descripcion)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
        }
    }
}