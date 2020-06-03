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
                .NotNull();
            RuleFor(x => x.DelanteroIzquierdo)
                .NotNull();
            RuleFor(x => x.Acompanante)
                .NotNull();
            RuleFor(x => x.TraseroDerecho)
                .NotNull();
            RuleFor(x => x.TraseroIzquierdo)
                .NotNull();
            RuleFor(x => x.Conductor)
                .NotNull();
        }
    }
}