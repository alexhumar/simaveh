using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model;

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
        public ControllerParameter(SiMaVehContext context, IRelatedEntityGetter relatedEntityGetter)
        {
            Context = context;
            RelatedEntityGetter = relatedEntityGetter;
        }

        /// <summary>
        /// Context
        /// </summary>
        public SiMaVehContext Context { get; set; }

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        public IRelatedEntityGetter RelatedEntityGetter { get; set; }
    }
}