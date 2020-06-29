using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorGrupoModelo
    /// </summary>
    public class ValidadorGrupoModelo : AbstractValidator<GrupoModelo>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorGrupoModelo()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            // RuleFor(x => x.Marca)
            //     .NotNull();
        }
    }
}