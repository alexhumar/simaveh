using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorUsuario
    /// </summary>
    public class ValidadorUsuario : AbstractValidator<Usuario>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorUsuario()
        {
            Include(new ValidadorPersona());
        }
    }
}