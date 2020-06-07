using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorMarca
    /// </summary>
    public class ValidadorMarca : AbstractValidator<Marca>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorMarca()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.Categoria)
                .NotNull();
        }
    }
}