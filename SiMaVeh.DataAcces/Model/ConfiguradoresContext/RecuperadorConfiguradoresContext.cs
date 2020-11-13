using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    internal class RecuperadorConfiguradoresContext : IRecuperadorConfiguradoresContext
    {
        public IEnumerable<IConfiguradorContext> GetConfiguradoresContext()
        {
            return new List<IConfiguradorContext>
            {
                //new ConfiguradorJerarquiaTPH(),
                //new ConfiguradorPropiedadesCalculadas(),
                new ConfiguradorJerarquiaTPT(),
                new ConfiguradorIDsAutogenerados(),
                new ConfiguradorRelacionesManyToMany()
            };
        }
    }
}
