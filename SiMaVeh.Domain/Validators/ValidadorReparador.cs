using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorReparador
    /// </summary>
    public class ValidadorReparador : AbstractValidator<Reparador>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorReparador()
        {
            Include(new ValidadorPersona());

            // RuleFor(x => x.EntidadesReparadoras)
            //     .Must(x => x.Count > 0);
        }
    }
}