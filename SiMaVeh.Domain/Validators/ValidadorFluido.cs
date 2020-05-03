using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorFluido
    /// </summary>
    public class ValidadorFluido : AbstractValidator<Fluido>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorFluido()
        {
            Include(new ValidadorTargetMantenimiento());
        }
    }
}