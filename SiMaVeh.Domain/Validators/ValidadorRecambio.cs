
using FluentValidation;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorRecambio
    /// </summary>
    public class ValidadorRecambio : AbstractValidator<Recambio>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorRecambio()
        {
            // RuleFor(x => x.Marca)
            //     .NotNull();
        }
    }
}