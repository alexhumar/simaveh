using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorRepuesto
    /// </summary>
    public class ValidadorRepuesto : AbstractValidator<Repuesto>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorRepuesto()
        {
            Include(new ValidadorRecambio());

            RuleFor(x => x.CodigoIdentificador)
                .NotNull()
                .NotEqual(string.Empty);
            // RuleFor(x => x.Marca)
            //     .NotNull();
            // RuleFor(x => x. TargetMantenimiento)
            //     .NotNull();
        }
    }
}