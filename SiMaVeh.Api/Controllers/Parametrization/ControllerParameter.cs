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
    public class ControllerParameter : IControllerParameter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="relatedEntityGetter"></param>
        /// <param name="relatedEntityChanger"></param>
        /// <param name="relatedEntityAdder"></param>
        /// <param name="relatedEntityRemover"></param>
        /// <param name="entityTypeGetter"></param>
        /// <param name="errorsBuilder"></param>
        public ControllerParameter(SiMaVehContext context,
            IODataRelatedEntityChanger relatedEntityChanger,
            IODataRelatedEntityAdder relatedEntityAdder,
            IODataRelatedEntityRemover relatedEntityRemover,
            IEntityTypeGetter entityTypeGetter,
            IErrorsBuilder errorsBuilder)
        {
            Context = context;
            RelatedEntityChanger = relatedEntityChanger;
            RelatedEntityAdder = relatedEntityAdder;
            RelatedEntityRemover = relatedEntityRemover;
            EntityTypeGetter = entityTypeGetter;
            ErrorsBuilder = errorsBuilder;
        }

        /// <summary>
        /// Context
        /// </summary>
        public SiMaVehContext Context { get; set; }

        /// <summary>
        /// RelatedEntityChanger
        /// </summary>
        public IODataRelatedEntityChanger RelatedEntityChanger { get; set; }

        /// <summary>
        /// RelatedEntityAdder
        /// </summary>
        public IODataRelatedEntityAdder RelatedEntityAdder { get; set; }

        /// <summary>
        /// RelatedEntityRemover
        /// </summary>
        public IODataRelatedEntityRemover RelatedEntityRemover { get; set; }

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