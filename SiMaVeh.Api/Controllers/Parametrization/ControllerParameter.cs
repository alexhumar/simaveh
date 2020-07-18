using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Api.ErrorManagement.Interfaces;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Api.Controllers.Parametrization
{
    /// <summary>
    /// Singleton que encapsula los objetos necesarios para inyectar en el GenericController
    /// </summary>
    internal class ControllerParameter : IControllerParameter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="relatedEntityGetter"></param>
        /// <param name="entityTypeGetter"></param>
        /// <param name="errorsBuilder"></param>
        public ControllerParameter(SiMaVehContext context,
            IRelatedEntityGetter relatedEntityGetter,
            IEntityTypeGetter entityTypeGetter,
            IErrorsBuilder errorsBuilder)
        {
            Context = context;
            RelatedEntityGetter = relatedEntityGetter;
            EntityTypeGetter = entityTypeGetter;
            ErrorsBuilder = errorsBuilder;
        }

        /// <summary>
        /// Context
        /// </summary>
        public SiMaVehContext Context { get; set; }

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        public IRelatedEntityGetter RelatedEntityGetter { get; set; }

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        public IEntityTypeGetter EntityTypeGetter { get; set; }

        /// <summary>
        /// ErrorsBuilder
        /// </summary>
        public IErrorsBuilder ErrorsBuilder { get; set; }
    }
}