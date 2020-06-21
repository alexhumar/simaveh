using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorEquipamientoAirbags
    /// </summary>
    public class ValidadorEquipamientoAirbags : AbstractValidator<EquipamientoAirbags>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorEquipamientoAirbags()
        {
            RuleFor(x => x.DelanteroDerecho)
                .NotNull()
                .IsInEnum();
            RuleFor(x => x.DelanteroIzquierdo)
                .NotNull()
                .IsInEnum();
            RuleFor(x => x.Acompanante)
                .NotNull();
            RuleFor(x => x.TraseroDerecho)
                .NotNull()
                .IsInEnum();
            RuleFor(x => x.TraseroIzquierdo)
                .NotNull()
                .IsInEnum();
            RuleFor(x => x.Conductor)
                .NotNull();
        }
    }
}