
using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorKit
    /// </summary>
    public class ValidadorKit : AbstractValidator<Kit>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorKit()
        {
            Include(new ValidadorRecambio());

            // RuleFor(x => x.Recambios)
            //     .Must(y => y.Count > 0);
        }
    }
}