
using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorModeloVehiculo
    /// </summary>
    public class ValidadorModeloVehiculo : AbstractValidator<ModeloVehiculo>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorModeloVehiculo()
        {
            //El resto de las properties son nullables
            // RuleFor(x => x.GrupoModelo)
            //     .NotNull();
            // RuleFor(x => x.TipoFuenteEnergia)
            //     .NotNull();
            RuleFor(x => x.Version)
                .NotNull()
                .NotEqual(string.Empty);
        }
    }
}