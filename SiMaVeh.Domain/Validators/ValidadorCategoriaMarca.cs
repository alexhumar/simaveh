using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorCategoriaMarca
    /// </summary>
    public class ValidadorCategoriaMarca : AbstractValidator<CategoriaMarca>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorCategoriaMarca()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            //RuleFor(x => x.Marcas)
            //    .NotNull();
        }
    }
}