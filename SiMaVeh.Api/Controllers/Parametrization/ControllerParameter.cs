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
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="context"></param>
    /// <param name="relatedEntityGetter"></param>
    /// <param name="relatedEntityChanger"></param>
    /// <param name="relatedEntityAdder"></param>
    /// <param name="relatedEntityRemover"></param>
    /// <param name="entityTypeGetter"></param>
    /// <param name="errorsBuilder"></param>
    public class ControllerParameter(SiMaVehContext context,
        IODataRelatedEntityChanger relatedEntityChanger,
        IODataRelatedEntityAdder relatedEntityAdder,
        IODataRelatedEntityRemover relatedEntityRemover,
        IEntityTypeGetter entityTypeGetter,
        IErrorsBuilder errorsBuilder) : IControllerParameter
    {

        /// <summary>
        /// Context
        /// </summary>
        public SiMaVehContext Context { get; set; } = context;

        /// <summary>
        /// RelatedEntityChanger
        /// </summary>
        public IODataRelatedEntityChanger RelatedEntityChanger { get; set; } = relatedEntityChanger;

        /// <summary>
        /// RelatedEntityAdder
        /// </summary>
        public IODataRelatedEntityAdder RelatedEntityAdder { get; set; } = relatedEntityAdder;

        /// <summary>
        /// RelatedEntityRemover
        /// </summary>
        public IODataRelatedEntityRemover RelatedEntityRemover { get; set; } = relatedEntityRemover;

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        public IEntityTypeGetter EntityTypeGetter { get; set; } = entityTypeGetter;

        /// <summary>
        /// ErrorsBuilder
        /// </summary>
        public IErrorsBuilder ErrorsBuilder { get; set; } = errorsBuilder;
    }
}