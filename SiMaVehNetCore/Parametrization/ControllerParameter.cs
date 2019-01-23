using SiMaVeh.DataAccess;
using SiMaVeh.Helpers;

namespace SiMaVeh.Parametrization
{
    /// <summary>
    /// Singleton que encapsula los objetos necesarios para inyectar en el GenericController
    /// </summary>
    public class ControllerParameter : IControllerParameter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ControllerParameter(SiMaVehContext context, IEntityGetter entityGetter)
        {
            Context = context;
            EntityGetter = entityGetter;
        }

        /// <summary>
        /// Context
        /// </summary>
        public SiMaVehContext Context { get; set; }
        
        /// <summary>
        /// EntityGetter
        /// </summary>
        public IEntityGetter EntityGetter { get; set; }
    }
}