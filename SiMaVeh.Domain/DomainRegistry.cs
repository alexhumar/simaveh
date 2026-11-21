using FluentValidation;
using Lamar;
using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.Domain.Enums.Parsers.Interfaces;

namespace SiMaVeh.Domain
{
    /// <summary>
    /// Registro de servicios de Lamar del proyecto Domain.
    /// </summary>
    public class DomainRegistry : ServiceRegistry
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DomainRegistry()
        {
            //Registra como IValidator<T> todos los validadores (AbstractValidator<T>) del ensamblado.
            this.AddValidatorsFromAssemblyContaining<DomainRegistry>(ServiceLifetime.Transient);

            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();

                //Registra todos los IEnumParser<T> del ensamblado.
                s.ConnectImplementationsToTypesClosing(typeof(IEnumParser<>));
            });
        }
    }
}
