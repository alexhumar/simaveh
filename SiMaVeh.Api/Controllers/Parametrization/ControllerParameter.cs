using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Api.ErrorManagement.Interfaces;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Api.Controllers.Parametrization
{
    /// <summary>
    /// Singleton que encapsula los objetos necesarios para inyectar en el GenericController
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="relatedEntityChanger"></param>
    /// <param name="relatedEntityAdder"></param>
    /// <param name="relatedEntityRemover"></param>
    /// <param name="entityTypeGetter"></param>
    /// <param name="errorsBuilder"></param>
    public class ControllerParameter(IODataRelatedEntityChanger relatedEntityChanger,
        IODataRelatedEntityAdder relatedEntityAdder,
        IODataRelatedEntityRemover relatedEntityRemover,
        IEntityTypeGetter entityTypeGetter,
        IErrorsBuilder errorsBuilder) : IControllerParameter
    {
        /// <summary>
        /// RelatedEntityChanger
        /// </summary>
        public IODataRelatedEntityChanger RelatedEntityChanger { get; } = relatedEntityChanger;

        /// <summary>
        /// RelatedEntityAdder
        /// </summary>
        public IODataRelatedEntityAdder RelatedEntityAdder { get; } = relatedEntityAdder;

        /// <summary>
        /// RelatedEntityRemover
        /// </summary>
        public IODataRelatedEntityRemover RelatedEntityRemover { get; } = relatedEntityRemover;

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        public IEntityTypeGetter EntityTypeGetter { get; } = entityTypeGetter;

        /// <summary>
        /// ErrorsBuilder
        /// </summary>
        public IErrorsBuilder ErrorsBuilder { get; } = errorsBuilder;
    }
}