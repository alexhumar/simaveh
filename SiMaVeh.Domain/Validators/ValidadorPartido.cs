
using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorPartido
    /// </summary>
    public class ValidadorPartido : AbstractValidator<Partido>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorPartido()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            // RuleFor(x => x.Provincia)
            //     .NotNull();
        }
    }
}