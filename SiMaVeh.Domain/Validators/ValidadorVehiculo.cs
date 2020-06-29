using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorVehiculo
    /// </summary>
    public class ValidadorVehiculo : AbstractValidator<Vehiculo>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorVehiculo()
        {
            RuleFor(x => x.AnioFabricacion)
                .GreaterThan(1890);
            RuleFor(x => x.Kilometraje)
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.ModeloVehiculo)
                .NotNull();
            RuleFor(x => x.Usuario)
                .NotNull();
        }
    }
}